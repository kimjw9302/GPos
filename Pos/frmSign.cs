using System;
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
    public partial class frmSign : Form
    {
        public frmSign()
        {
            InitializeComponent();
        }

        private void frmSign_Load(object sender, EventArgs e)
        {
            Sell s = Sell.Load();
            if (s.Cardmoeny > 50000)
            {

            }
            else
            {
                this.Visible=false;
            }
         
            signPad1.PenWidth = 8;
            btnOk_Click(null, null);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Sell s = Sell.Load();
            frmCard fm = (frmCard)Owner;
            signPad1.Save();

           SqlConnection con = DBcontroller.Instance();
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
                if (s.Cardmoeny != 0 || s.Pointmoney != 0)
                {
                    type = 3;
                }
                string cardNum = s.CardNumber.Substring(0, 6);
                cardNum += "******";
                cardNum += s.CardNumber.Substring(12, 4);
                cmd.Parameters.AddWithValue("@sellDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@clientNum", s.Ages);
                cmd.Parameters.AddWithValue("@methodNum", type);
                cmd.Parameters.AddWithValue("@totalMoney", s.Tot);
                cmd.Parameters.AddWithValue("@receiveCash", s.Cashmoney);
                cmd.Parameters.AddWithValue("@receiveCard", s.Cardmoeny);
                cmd.Parameters.AddWithValue("@receivePoint", s.Pointmoney);
                cmd.Parameters.AddWithValue("@note", s.Sale.ToString());
                cmd.Parameters.AddWithValue("@card", cardNum);
                cmd.Parameters.AddWithValue("@empNum", s.EmpId);
                cmd.Parameters.AddWithValue("@savePoint", s.SavePoint);
                cmd.Parameters.AddWithValue("@preturn", DBNull.Value);
                cmd.Parameters.AddWithValue("@returnReason", DBNull.Value);
                cmd.ExecuteNonQuery();

            }


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

                using (var ccmd = new SqlCommand("SelectMemberGrade", con))
                {
                    MessageBox.Show("Test");
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

      
          
            con.Close();


            this.Dispose();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            signPad1.Clear();
        }
       
    }
}
