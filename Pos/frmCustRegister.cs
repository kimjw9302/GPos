using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{

    public partial class frmCustRegister : Form ,ISubmit
    {
        private SqlConnection con;
        private int userRandomNum = new Random().Next(00000000, 99999999);
        public frmCustRegister()
        {
            InitializeComponent();
        }

        private void frmCustRegister_Load(object sender, EventArgs e)
        {
            rbM.Checked = true;
            txtUserNum.Text = userRandomNum.ToString();
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cbYear.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                if(i.ToString().Length == 1)
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
            string userNum = this.txtUserNum.Text.Trim().Replace(" ", "");
            string userPhone = this.cbPhone1.Text + txtPhone2.Text + txtPhone3.Text;

            con = DBcontroller.Instance();

            using (var cmd = new SqlCommand("UserCheckPK", con))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userNum", userNum);
                cmd.Parameters.AddWithValue("@phone", userPhone);
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
                else {
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
                string userNum = txtUserNum.Text;
                string userName = txtUserName.Text.Trim().Replace(" ", "");
                string birth = cbYear.Text + "-" + cbMonth.Text + "-" + cbDay.Text;
                string phone = cbPhone1.Text + txtPhone2.Text + txtPhone3.Text;
                string address = txtAddress.Text + txtDetailAddress.Text;
                string passWord = cbMonth.Text + cbDay.Text;
                int point = 0;
                MessageBox.Show(passWord);
                string gender = "남자";
                if (rbF.Checked == true)
                {
                    gender = "여자";
                }

                //주소검색 api 이용  // key : U01TX0FVVEgyMDE4MDEwODE2MDgzNTEwNzU5OTY=

                var con = DBcontroller.Instance();
                

                    using (var cmd = new SqlCommand("UserRegister", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userNum", userNum);
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@birth", birth);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@password", passWord);
                        cmd.Parameters.AddWithValue("@point", point);
                        cmd.Parameters.AddWithValue("@gender", gender);

                        con.Open();

                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("회원 등록이 완료 되었습니다.");
                            this.Close();
                        con.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("회원 등록이 실패하였습니다.");
                        con.Close();
                        return;
                        }
                    }
                
            }
        }
    }
}
