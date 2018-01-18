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
    public partial class frmCash : Form
    {
        private string sendMoney;
        public TextBox current;
        SqlConnection con;
        public frmCash()
        {
            InitializeComponent();
        }

        public frmCash(string sendMoney) : this()
        {
            this.sendMoney = sendMoney;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //결제끝
            Sell s = Sell.Load();
            frmPayment fm = (frmPayment)Owner;
            if (decimal.Parse(tboxBit.Text) == 0)
            {

                con = DBcontroller.Instance();
                MessageBox.Show("1" + s.Cashmoney);
                s.Cashmoney = s.Cashmoney + int.Parse(tboxReceive.Text);
                MessageBox.Show("2" + s.Cashmoney);
                fm.T1.Text = "0";
                fm.T2.Text = "0"; //payList
                fm.T3.Text = "0";
                fm.T4.Text = "0";
                fm.T5.Text = "0";


                con.Open();
                using (var cmd = new SqlCommand("InsertSell", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (s.ClientID == null)
                    {
                        cmd.Parameters.AddWithValue("@memberNum", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@memberNum", s.ClientID);
                    }

                    cmd.Parameters.AddWithValue("@sellDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@clientNum", s.Ages);
                    cmd.Parameters.AddWithValue("@methodNum", 1);
                    cmd.Parameters.AddWithValue("@totalMoney", s.Tot);
                    cmd.Parameters.AddWithValue("@receiveCash", s.Cashmoney);
                    cmd.Parameters.AddWithValue("@receiveCard", s.Cardmoeny);
                    cmd.Parameters.AddWithValue("@receivePoint", s.Pointmoney);
                    cmd.Parameters.AddWithValue("@note", s.Sale.ToString());
                    cmd.Parameters.AddWithValue("@card", DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
                fm.T2.Text = "************이전 정보 \r\n";
                fm.T2.Text += "현금 결제 : " + tboxTotal.Text + "원\r\n";
                fm.T2.Text += "카드 결제 : " + s.Cardmoeny + "원\r\n";
                fm.T2.Text += "포인트 결제 : " + s.Pointmoney + "원\r\n";
                con.Close();
                con.Open();
                foreach (DataRow row in fm.Ss.Rows)
                {
                    using (var ccmd = new SqlCommand("InsertSellInfo", con))
                    {

                        ccmd.CommandType = CommandType.StoredProcedure;


                        decimal salesquantity = 0;
                        decimal tot = -1 * decimal.Parse(row["할인"].ToString());
                        salesquantity = tot / decimal.Parse(row["단가"].ToString());
                        ccmd.Parameters.AddWithValue("@barcode", row["바코드"].ToString());
                        ccmd.Parameters.AddWithValue("@quantity", row["수량"].ToString());
                        ccmd.Parameters.AddWithValue("@salesquantity", tot);
                        ccmd.ExecuteNonQuery();

                    }
                }
                if (s.ClientID != null)
                {
                    using (var ccmd = new SqlCommand("UpdatePoint", con))
                    {


                        ccmd.CommandType = CommandType.StoredProcedure;
                        ccmd.Parameters.AddWithValue("@phone", s.ClientID);
                        ccmd.ExecuteNonQuery();
                    }
                }

                foreach (DataRow row in fm.Ss.Rows)
                {
                    using (var ccmd = new SqlCommand("UpdateProducts", con))
                    {
                        ccmd.CommandType = CommandType.StoredProcedure;
                        ccmd.Parameters.AddWithValue("@barcode", row["바코드"].ToString());
                        ccmd.Parameters.AddWithValue("@quantity", row["수량"].ToString());
                        if (ccmd.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("상품 재고 업데이트 에러");
                        }
                    }
                }
             
               
                Sell.Clear();
                fm.Ss.Clear();
                con.Close();
                this.Dispose();
            }
            //복합결제
            else
            {
                s.Cashmoney = int.Parse(tboxReceive.Text);

                fm.T5.Text = (int.Parse(fm.T5.Text) - int.Parse(tboxReceive.Text)).ToString();
                fm.T2.Text = "************이전 정보 \r\n";
                fm.T2.Text += "현금 결제 : " + s.Cashmoney + "원\r\n";
                fm.T2.Text += "카드 결제 : " + s.Cardmoeny + "원\r\n";
                fm.T2.Text += "포인트 결제 : " + s.Pointmoney + "원\r\n";
                this.Dispose();

            }
        }

        private void frmCash_Load(object sender, EventArgs e)
        {
            tboxTotal.Text = sendMoney;
            tboxReceive.Focus();
            current = tboxReceive;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            current.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            current.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            current.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            current.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            current.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            current.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            current.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            current.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            current.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            current.Text += "0";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            current.Text += "00";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            current.Text = "";
            tboxChange.Text = "";
            tboxBit.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                int m = (int.Parse(tboxReceive.Text) - int.Parse(tboxTotal.Text));
                if (m < 0)
                {
                    tboxBit.Text = (-m).ToString();
                    tboxChange.Text = "0";
                }
                else
                {
                    tboxBit.Text = "0";
                    tboxChange.Text = m.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("입력해주세요");
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void tboxTotal_Click(object sender, EventArgs e)
        {
            tboxReceive.Focus();
            current = tboxReceive;
        }

        private void tboxReceive_Click(object sender, EventArgs e)
        {
            current = (TextBox)sender;
        }

        private void tboxChange_Click(object sender, EventArgs e)
        {
            tboxReceive.Focus();
            current = tboxReceive;
        }

        private void tboxReceive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int m = (int.Parse(tboxReceive.Text) - int.Parse(tboxTotal.Text));
                if (m < 0)
                {
                    tboxBit.Text = (-m).ToString();
                    tboxChange.Text = "0";
                }
                else
                {
                    tboxBit.Text = "0";
                    tboxChange.Text = m.ToString();
                }

            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tboxBit_Click(object sender, EventArgs e)
        {
            tboxReceive.Focus();
            current = tboxReceive;
        }

    }
}
