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
    public partial class frmEmployeesRegister : Form,ISubmit
    {
        SqlConnection con;
        private int empRandomNum = new Random().Next(10000000, 99999999);
        public frmEmployeesRegister()
        {
            InitializeComponent();
        }

        private void frmEmployeesRegister_Load(object sender, EventArgs e)
        {
            txtEmpNum.Text = empRandomNum.ToString();
            string[] rank = { "사장", "점장", "파트타이머" };
            cbRank.Items.AddRange(rank);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckPK() && ValidityCheck())
            {
                con = DBcontroller.Instance();
                using (var cmd = new SqlCommand("EmployeeRegister", con))
                {
                    int empNum = int.Parse(txtEmpNum.Text);
                    string empName = txtEmpName.Text.Trim().Replace(" ", "");
                    string empPosition = cbRank.Text;
                    string phone = cbPhone1.Text + txtPhone2.Text + txtPhone3.Text;
                    int hourlyWage = int.Parse(txtWage.Text);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empNum", empNum);
                    cmd.Parameters.AddWithValue("@empName", empName);
                    cmd.Parameters.AddWithValue("@empPosition", empPosition);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@hourlyWage", hourlyWage);
                    con.Open();

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("직원 등록 완료");
                        this.Close();
                        con.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("직원 등록 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        con.Close();
                        return;
                    }
                } 
            }
        }
        //유효성 검사
        private bool ValidityCheck()
        {
            if (this.txtEmpNum.Text == "" || this.txtEmpName.Text =="" || this.txtPhone2.Text =="" || this.txtPhone3.Text == "" || this.txtEmpName.Text == "" || this.txtWage.Text == "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CheckPK()
        {
            string empNum = this.txtEmpNum.Text.Trim().Replace(" ", "");
            string phone = cbPhone1.Text + txtPhone2.Text + txtPhone3.Text;

            con = DBcontroller.Instance();

            using (var cmd = new SqlCommand("EmployeeCheckPK", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empNum", empNum);
                cmd.Parameters.AddWithValue("@phone", phone);

                con.Open();
                var sdr = cmd.ExecuteScalar();

                if (sdr.ToString() == "0")
                {
                    MessageBox.Show("직원번호 중복");
                    empRandomNum = new Random().Next(00000000, 99999999);
                    txtEmpNum.Text = empRandomNum.ToString();
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
                    MessageBox.Show("직원번호, 전화번호 중복");
                    txtPhone2.Text = txtPhone3.Text = "";
                    empRandomNum = new Random().Next(00000000, 99999999);
                    txtEmpNum.Text = empRandomNum.ToString();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
