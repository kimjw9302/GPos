﻿using System;
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

                fm.T1.Text = "0";
                fm.T2.Text = "0"; //payList
                fm.T3.Text = "0";
                fm.T4.Text = "0";
                fm.T5.Text = "0";
                con = DBcontroller.Instance();
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
                    int type = 2;
                    if (s.Cardmoeny != 0 || s.Pointmoney!=0)
                    {
                        type = 3;
                    }
                    string cardNum = s.CardNumber.Substring(0, 6);
                    cardNum += "******";
                    cardNum += s.CardNumber.Substring(12,4);
                    cmd.Parameters.AddWithValue("@sellDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@clientNum", s.Ages);
                    cmd.Parameters.AddWithValue("@methodNum", type);
                    cmd.Parameters.AddWithValue("@totalMoney", s.Tot);
                    cmd.Parameters.AddWithValue("@receiveCash", s.Cashmoney);
                    cmd.Parameters.AddWithValue("@receiveCard", s.Cardmoeny);
                    cmd.Parameters.AddWithValue("@receivePoint", s.Pointmoney);
                    cmd.Parameters.AddWithValue("@note", s.Sale.ToString());
                    cmd.Parameters.AddWithValue("@card",cardNum);
                    cmd.Parameters.AddWithValue("@empNum", s.EmpId);
                    cmd.Parameters.AddWithValue("@savePoint", s.SavePoint);
                    cmd.Parameters.AddWithValue("@preturn", DBNull.Value);
                    cmd.ExecuteNonQuery();

                    this.Dispose();
                }

                fm.T2.Text = "************이전 정보 \r\n";
                fm.T2.Text += "현금 결제 : " + s.Cashmoney + "원\r\n";
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
                        ccmd.Parameters.AddWithValue("@phone", s.Phone);
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
                try
                {
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
                }
                catch (Exception)
                {
                    MessageBox.Show("DB 서버 연결 에러 발생");

                }
            }
        }
        //취소버튼 클릭
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
