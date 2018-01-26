using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmStoreInfo : Form
    {
        SqlConnection con;
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
                    using (var cmd = new SqlCommand("UpdateStoreInfo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@storeNum", tboxStoreNum.Text);
                        cmd.Parameters.AddWithValue("@storeName", tboxStoreName.Text);
                        cmd.Parameters.AddWithValue("@MName", tboxMName.Text);
                        cmd.Parameters.AddWithValue("@addr", tboxAddr.Text);
                        cmd.Parameters.AddWithValue("@homephone", tboxHomePhone.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();

                    }

                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
            }

        }
    }

}
