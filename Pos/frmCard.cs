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
    public partial class frmCard : Form
    {
        string sendMoney; //결제금액 칸에 찍힐 금액
        SqlConnection con;
        DataTable ss;
        TextBox current;
        public DataTable Ss { get => ss; set => ss = value; }

        public frmCard()
        {
            InitializeComponent();
        }

        public frmCard(string sendMoney) : this()
        {
            this.sendMoney = sendMoney;
        }
        
        //frmCard 폼이 로드 되었을때.
        private void frmCard_Load(object sender, EventArgs e)
        {
            tboxPay.Text = sendMoney;
        }

        //결제 버튼을 클릭했을때
        private void btnPay_Click(object sender, EventArgs e)
        {

            Sell s = Sell.Load();
            frmPayment fm = (frmPayment)Owner;
            //1. 유효성 검사
            if (Check())
            {
                s.Cardmoeny = decimal.Parse(tboxPay.Text);
                s.CardNumber = tboxCardNum.Text;
                this.Visible = false;
                frmSign fs = new frmSign();
                Ss = fm.Ss;
                fs.Owner = this;
                fs.ShowDialog();
                fm.T1.Text = "0";
                fm.T2.Text = "0"; //payList
                fm.T3.Text = "0";
                fm.T4.Text = "0";
                fm.T5.Text = "0";
                fm.Pic.Image = Bitmap.FromFile(@"..\..\Resources\goodee24.png");
                fm.T2.Text = "************이전 정보 \r\n";
                fm.T2.Text += "현금 결제 : " + s.Cashmoney + "원\r\n";
                fm.T2.Text += "카드 결제 : " + s.Cardmoeny + "원\r\n";
                fm.T2.Text += "포인트 결제 : " + s.Pointmoney + "원\r\n";

                //try
                //{
                    con.Open();
            

                    Sell.Clear();
                    fm.Ss.Clear();
                    this.Dispose();
                //}
                //catch (Exception msg)
                //{
                //    con.Close();
                //    MessageBox.Show(msg.Message);
                    
                //}

            }
            else
            {
                MessageBox.Show("정보를 제대로 입력해주세요.");
            }

        }

        //유효성 검사 함수
        private bool Check()
        {
            if (tboxYear.Text == "" || tboxMonth.Text == ""||tboxPay.Text==""||int.Parse(tboxPay.Text)<0||int.Parse(tboxPay.Text)>int.Parse(sendMoney))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void tboxCardNum_KeyDown(object sender, KeyEventArgs e)
        {
            //카드번호를 적고 엔터를 쳤을때
            if (e.KeyCode == Keys.Enter)
            {
                //try
                //{
                     con = DBcontroller.Instance();
                    con.Open();

                    using (var cmd = new SqlCommand("SearchCard", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cardMiddle", tboxCardNum.Text);
                        var sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {

                            if (sdr.HasRows)
                            {

                                tboxYear.Text = sdr["YY"].ToString();
                                tboxMonth.Text = sdr["MM"].ToString();
                                tboxIMonth.Text = "0";
                                tboxCardNum.Text = tboxCardNum.Text;
                            }
                        }
                        con.Close();
                    }
                //}
                //catch (Exception msg)
                //{
                //    con.Close();
                //    MessageBox.Show(msg.Message);

                //}
            }
        }
        //취소버튼 클릭
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tboxCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != Convert.ToChar(Keys.Back))

            {
                e.Handled = true;
            }
        }

        private void tboxYear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnPay_Click(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            current = tboxCardNum;
            current.Text = "";
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
    }
}
