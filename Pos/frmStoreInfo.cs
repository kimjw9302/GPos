using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmStoreInfo : Form
    {
        SqlConnection con;
        private string searchResult;
        string addr;
        bool temp = false;
        public string SearchResult
        {
            get { return searchResult; }
            set { searchResult = value; }
        }

        public frmStoreInfo()
        {
            InitializeComponent();
        }

        private void frmStoreInfo_Load(object sender, EventArgs e)
        {
            //로드가 되면 스토어정보를 다 띄어주고 변경 할 수 있게 만든다.
            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("StoreInfo", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        tboxStoreNum.Text = sdr["storeNum"].ToString();
                        tboxStoreName.Text = sdr["storeName"].ToString();
                        tboxMName.Text = sdr["masterName"].ToString();
                        tboxAddr.Text = sdr["address"].ToString();
                        tboxHomePhone.Text = sdr["homephone"].ToString();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("정보가 없습니다");
                    con.Close();
                    this.Dispose();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 변경하시겠습니까?", "경고", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    con = DBcontroller.Instance();
                    con.Open();
                    using (var cmd = new SqlCommand("UpdateSotreInfo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@storeNum", tboxStoreNum.Text);
                        cmd.Parameters.AddWithValue("@storeName", tboxStoreName.Text);
                        cmd.Parameters.AddWithValue("@MName", tboxMName.Text);
                        cmd.Parameters.AddWithValue("@addr", tboxAddr.Text);
                        cmd.Parameters.AddWithValue("@homephone", tboxHomePhone.Text);                      
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("정보가 변경되었습니다");
                        this.Dispose();
                    }

                }
                catch (Exception z)
                {
                    con.Close();
                    MessageBox.Show(z.Message);
                }
            }

        }
        private bool SqlCheck(string addr)
        {
            //걸러야할 문자
            string[] sPattern =  {
            "OR", "SELECT", "INSERT", "DELETE", "UPDATE", "CREATE", "DROP", "EXEC",
                    "UNION",  "FETCH", "DECLARE", "TRUNCATE"
            };

            foreach (string s in sPattern)
            {
                if (Regex.IsMatch(addr, s, RegexOptions.IgnoreCase))
                {
                    temp = true;
                    break;
                }
            }
            return temp;

        }

        //특수문자 제거
        private bool SpecialCheck(string addr)
        {
            string str = @"[~!@\#$%^&*\()\=+|\\/:;?""<>']";
            Regex rex = new Regex(str);
            //MessageBox.Show(" 특스문자 " +rex.IsMatch(addr).ToString());
            return rex.IsMatch(addr);

        }
        private void btnAddrSearch_Click(object sender, EventArgs e)
        {
            string addr = this.tboxAddr.Text.Trim();

            if (addr == "")
            {
                MessageBox.Show(" 주소를 입력해주세요. ", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addr.Length > 0)
            {

                if (SqlCheck(addr))
                {
                    MessageBox.Show(addr + "는 입력 할 수없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SpecialCheck(addr))
                {

                    MessageBox.Show(addr + "는 입력 할 수없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    frmAddrSearch addrSearch = new frmAddrSearch(addr,1);
                    addrSearch.Owner = this;
                    addrSearch.ShowDialog();
                    tboxAddr.Text = SearchResult;

                }

            }
        }
    }

}
