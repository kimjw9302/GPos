﻿using System;
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
    public partial class frmPointSave : Form
    {
        SqlConnection con;
        string money;
        bool selectflage = false;
        int dis = 0;
        string tempphone = null;
        string tempID = null;
        public frmPointSave()
        {
            InitializeComponent();
        }

        public frmPointSave(string text):this()
        {
            this.money = text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SearchMember",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone",tboxPhone.Text);
                cmd.Parameters.AddWithValue("@pwd", DBNull.Value);
                var sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {


                    while (sdr.Read())
                    {
                      
                        lblName.Text = sdr["name"].ToString();
                        lblGrade.Text = sdr["gradeName"].ToString();
                        dis = int.Parse(sdr["discountRate"].ToString());
                        tempphone = sdr["phone"].ToString();
                        tempID = sdr["memberNum"].ToString();
                        lblDiscount.Text = sdr["discountRate"].ToString()+"% 적립";
                        tboxSave.Text = (int.Parse(money) * (dis * 1) / 100).ToString();
                        lblName.Visible = true;
                        lblName2.Visible = true;
                        selectflage = true;

                    }
                }
                else {

                        MessageBox.Show("회원에 대한 정보가 없습니다");
                        lblName.Visible = false;
                        lblName2.Visible = false;
                        selectflage = false;
                }
             
            }
            con.Close();

        }

        private void frmPointSave_Load(object sender, EventArgs e)
        {
            Sell s = Sell.Load();
            tboxMoney.Text = money;
         
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectflage)
            {
                Sell s = Sell.Load();
                s.SavePoint = int.Parse(tboxSave.Text);
                s.Phone = tempphone;
                s.ClientID = tempID;
                frmMain fm = (frmMain)Owner;
                fm.T2.Text = "회원 이름 : "+lblName.Text +"\r\n";
                fm.T2.Text += "적립 포인트  : "+tboxSave.Text+"점";
                this.Dispose();
            }
            else
            {
                MessageBox.Show("정보를 검색해주세요.");
            }
        }

        private void tboxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
