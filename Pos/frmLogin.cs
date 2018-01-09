using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //종료버튼 클릭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //로그인버튼 클릭
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MakeBarcode mb = new MakeBarcode();
            //Bitmap b = mb.Barcode(tboxID.Text);
            //pictureBox2.Image = b;
            //pictureBox2.Height = b.Height;
            //pictureBox2.Width = b.Width;

            string employeeID = tboxID.Text;
            string storePw = tboxPw.Text;
            //유효성 검사
            if (Check(employeeID, storePw))
            {
                //우선쿼리로 제작(직원 아이디로 접근 )
                var con = DBcontroller.Instance();

                //Employees 테이블 
                //

                using (var cmd = new SqlCommand("FirstLoginSelect", con))
                {
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(employeeID));
                    cmd.Parameters.AddWithValue("@StorePW", int.Parse(storePw));
                    var sdr = cmd.ExecuteScalar();

                    if (sdr.ToString() == "1")
                    {
                        con.Close();
                        this.Visible = false;
                        new frmMain().ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("다시입력해주세요");
                        tboxID.Text = "";
                        tboxPw.Text = "";
                        tboxID.Focus();
                        con.Close();
                        return;
                    }

                }

            }

            else
            {
                MessageBox.Show("다시 입력해주세요.");
            }

        }
        /// <summary>
        /// 입력한값이 유효성에 맞는지 부터 검사를 시작함.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Check(string a, string b)
        {
            if (a.Length > 5 || a == "")
            {
                return false;
            }
            if (b.Length > 5 || b == "")
            {
                return false;
            }
            return true;

        }

        private void tboxPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }


        }
    }
}
