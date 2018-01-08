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

    public partial class frmCustRegister : Form
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

        //private string PassWord(string pw)
        //{
        //    using (MD5 md5Hash = MD5.Create())
        //    {
        //        string hash = GetMd5Hash(md5Hash, pw);

        //        MessageBox.Show("비번전 " + pw + ", 후 " + hash + ".");

        //        return hash;
        //        //Console.WriteLine("Verifying the hash...");

        //        //if (VerifyMd5Hash(md5Hash, password, hash))
        //        //{
        //        //    Console.WriteLine("The hashes are the same.");
        //        //}
        //        //else
        //        //{
        //        //    Console.WriteLine("The hashes are not same.");
        //        //}
        //    }
        //}

        //static string GetMd5Hash(MD5 md5Hash, string input)
        //{

        //     byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

        //    //바이트 수집  문자열 생성
        //    StringBuilder sBuilder = new StringBuilder();


        //    // 해시 된 데이터의 각 바이트를 반복합니다.각각을 16 진수 문자열로 포맷하십시오.
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        sBuilder.Append(data[i].ToString("x2"));
        //    }
            
        //    return sBuilder.ToString();
        //}

        //static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        //{
        //    string hashOfInput = GetMd5Hash(md5Hash, input);

        //    StringComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    if (0 == comparer.Compare(hashOfInput, hash))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


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
                var sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    MessageBox.Show("중복");
                    sdr.Close();
                    con.Close();
                    return false;
                }
                else
                {
                    sdr.Close();
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
