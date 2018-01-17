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
            if (tboxInputPoint.Text!=""&&int.Parse(tboxUPoint.Text)>=int.Parse(tboxInputPoint.Text))
            {
                s.Pointmoney = decimal.Parse(tboxInputPoint.Text);
                frmMain fm = (frmMain)Owner;
                fm.T2.Text = "포인트 할인이 적용되었습니다.\r\n";
                fm.T2.Text += "할인전 보유 포인트 : " +tboxUPoint.Text+"\r\n";
                fm.T2.Text += "사용 포인트 : " + tboxInputPoint.Text+"\r\n";
                fm.T2.Text += "할인후 보유 포인트 : " +(int.Parse(tboxUPoint.Text)-int.Parse(tboxInputPoint.Text))+ "\r\n";
                fm.T1.Text = (int.Parse(fm.T1.Text) - int.Parse(tboxInputPoint.Text)).ToString();
                fm.T5.Text = (int.Parse(fm.T4.Text)+ int.Parse(fm.T1.Text)).ToString() ;
                this.Dispose();
            }
            else
            {
                tboxInputPoint.Focus();
                tboxInputPoint.Text = "";
                MessageBox.Show("보유 포인트 부족");
            }
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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SearchMember", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", tboxPhone.Text);
                var sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {


                    while (sdr.Read())
                    {
                        s = Sell.Load();
                        s.ClientID = sdr["memberNum"].ToString();
                        tboxUPoint.Text = sdr["point"].ToString();
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
    }
}
