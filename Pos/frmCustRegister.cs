using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{

    public partial class frmCustRegister : Form, ISubmit
    {
        frmAddrSearch addrSearch;
        private SqlConnection con;
        private int userRandomNum = new Random().Next(10000000, 99999999);
        private string searchResult;
        string addr;
        bool temp =false;

        public string SearchResult
        {
            get { return searchResult; }
            set { searchResult = value; }
        }

        public frmCustRegister()
        {
            InitializeComponent();
        }

        private void frmCustRegister_Load(object sender, EventArgs e)
        {
            //콤보박스 데이터 집어넣기
            rbM.Checked = true;
            txtUserNum.Text = userRandomNum.ToString();
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cbYear.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                if (i.ToString().Length == 1)
                {
                    string temp = '0' + i.ToString();
                    cbMonth.Items.Add(temp);
                }
                else
                {
                    cbMonth.Items.Add(i);
                }

            }
            for (int i = 1; i <= 31; i++)
            {
                if (i.ToString().Length == 1)
                {
                    string temp = '0' + i.ToString();
                    cbDay.Items.Add(temp);
                }
                else
                {
                    cbDay.Items.Add(i);
                }
            }

        }

        /// <summary>
        /// 회원번호, 휴대전화 중복 체크
        /// </summary>
        /// <returns></returns>
        private bool CheckPK()
        {
            string memberNum = this.txtUserNum.Text.Trim().Replace(" ", "");
            string memberPhone = this.cbPhone1.Text + txtPhone2.Text + txtPhone3.Text;

            con = DBcontroller.Instance();

            using (var cmd = new SqlCommand("MemberCheckPK", con))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@memberNum", memberNum);
                cmd.Parameters.AddWithValue("@phone", memberPhone);
                con.Open();
                var sdr = cmd.ExecuteScalar();

                if (sdr.ToString() == "0")
                {
                    MessageBox.Show("회원번호 중복");
                    userRandomNum = new Random().Next(00000000, 99999999);
                    txtUserNum.Text = userRandomNum.ToString();
                    con.Close();
                    return false;
                }
                else if (sdr.ToString() == "1")
                {
                    MessageBox.Show("전화번호 중복");
                    txtPhone2.Text = txtPhone3.Text = "";
                    con.Close();
                    return false;
                }
                else if (sdr.ToString() == "2")
                {
                    MessageBox.Show("회원번호, 전화번호 중복");
                    txtPhone2.Text = txtPhone3.Text = "";
                    userRandomNum = new Random().Next(00000000, 99999999);
                    txtUserNum.Text = userRandomNum.ToString();
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }
            }

        }

        /// <summary>
        /// 유효성 검사
        /// </summary>
        private bool ValidityCheck()
        {
            if (this.txtUserName.Text == "" || this.cbYear.Text == "" || this.cbMonth.Text == "" || this.cbDay.Text == "" || (this.rbF.Checked && this.rbM.Checked) || this.txtAddress.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (ValidityCheck() && CheckPK())
            {
                string memberNum = txtUserNum.Text;
                string memberName = txtUserName.Text.Trim().Replace(" ", "");
                string birth = cbYear.Text + "-" + cbMonth.Text + "-" + cbDay.Text;
                string phone = cbPhone1.Text + txtPhone2.Text + txtPhone3.Text;
                string address = txtAddress.Text + txtDetailAddress.Text;
                string passWord = cbMonth.Text + cbDay.Text;
                string gender = "남자";
                if (rbF.Checked == true)
                {
                    gender = "여자";
                }

                var con = DBcontroller.Instance();


                using (var cmd = new SqlCommand("MemberRegister", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@memberNum", memberNum);
                    cmd.Parameters.AddWithValue("@memberName", memberName);
                    cmd.Parameters.AddWithValue("@birth", birth);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@password", passWord);
                    cmd.Parameters.AddWithValue("@gender", gender);

                    con.Open();

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("회원 등록 완료");
                        this.Close();
                        con.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("회원 등록 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        return;
                    }
                }

            }
        }

        private void btnAddrSearch_Click(object sender, EventArgs e)
        {
            addr = this.txtAddress.Text.Trim();

            if (addr == "")
            {
                MessageBox.Show(" 주소를 입력해주세요. ", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addr.Length > 0)
            {

                if(SqlCheck(addr))
                {
                    MessageBox.Show(addr + "는 입력 할 수없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(SpecialCheck(addr))
                {

                    MessageBox.Show(addr + "는 입력 할 수없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else{

                    addrSearch = new frmAddrSearch(addr);
                    addrSearch.Owner = this;
                    addrSearch.ShowDialog();
                    txtAddress.Text = SearchResult;
                    
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
