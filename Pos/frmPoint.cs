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
    public partial class frmPoint : Form
    {
        SqlConnection con;
        Sell s;
        private bool selectflage = false;
        public string phone = null;
        TextBox current;
        MaskedTextBox mcurrent;
        public frmPoint()
        {
            InitializeComponent();
        }

        private void btnPAccum_Click(object sender, EventArgs e)
        {

        }

        private void btnPUse_Click(object sender, EventArgs e)
        {
            s = Sell.Load();
            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SearchMember", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", tboxPhone.Text);
                cmd.Parameters.AddWithValue("@pwd",tboxPass.Text);
                var sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {

                        if (sdr[0].ToString() == "0")
                        {
                            MessageBox.Show("정보 불일치");
                            con.Close();
                            return;
                        }
                        else
                        {
                            s.ClientID = sdr["memberNum"].ToString();
                            selectflage = true;
                         
                        }


                    }
                }

            }
            con.Close();
            con.Open();
            if (selectflage)
            {
                using (var cmd = new SqlCommand("UpdatePoint", con))
                {
                    int s = -1*int.Parse(tboxInputPoint.Text);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@phone", tboxPhone.Text);
                    cmd.Parameters.AddWithValue("@point", s);
                    cmd.ExecuteNonQuery();

                }
            }
            con.Close();
            if (tboxInputPoint.Text != "" && int.Parse(tboxUPoint.Text) >= int.Parse(tboxInputPoint.Text))
            {
                s.Pointmoney = decimal.Parse(tboxInputPoint.Text);
                frmMain fm = (frmMain)Owner;
                fm.T2.Text = "포인트 할인이 적용되었습니다.\r\n";
                fm.T2.Text += "할인전 보유 포인트 : " + tboxUPoint.Text + "\r\n";
                fm.T2.Text += "사용 포인트 : " + tboxInputPoint.Text + "\r\n";
                fm.T2.Text += "할인후 보유 포인트 : " + (int.Parse(tboxUPoint.Text) - int.Parse(tboxInputPoint.Text)) + "\r\n";
                fm.T1.Text = (int.Parse(fm.T1.Text) - int.Parse(tboxInputPoint.Text)).ToString();
                fm.T5.Text = (int.Parse(fm.T4.Text) + int.Parse(fm.T1.Text)).ToString();
                s.Phone = tboxPhone.Text;
                this.Dispose();
            }
            else
            {
                tboxInputPoint.Focus();
                tboxInputPoint.Text = "";
                MessageBox.Show("보유 포인트 부족");
            }
            con.Close();
            MessageBox.Show(tboxInputPoint.Text);
           
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            s = Sell.Load();
            s.ClientID = null;

            this.Dispose();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {


        }

        private void frmPoint_Load(object sender, EventArgs e)
        {
            mcurrent = tboxPhone;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con = DBcontroller.Instance();
            con.Open();
  
            using (var cmd = new SqlCommand("SearchMember", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", tboxPhone.Text);
        
                cmd.Parameters.AddWithValue("@pwd", DBNull.Value);
                var sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        tboxUPoint.Text = sdr["point"].ToString();
                        phone = tboxPhone.Text;
                        selectflage = true;
                    }
                }
                else
                {

                    MessageBox.Show("회원에 대한 정보가 없습니다");
                    selectflage = false;

                }

            }
            con.Close();
        }

        private void tboxUPoint_Click(object sender, EventArgs e)
        {
            current = tboxInputPoint;
            tboxInputPoint.Focus();

        }

        private void tboxPass_Click(object sender, EventArgs e)
        {
            current = tboxPass;
        }

        private void tboxInputPoint_Click(object sender, EventArgs e)
        {
            current = tboxInputPoint;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
     
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btn00_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }
    }
}
