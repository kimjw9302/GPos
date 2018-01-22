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
    public partial class frmAban : Form
    {
        SqlConnection con;
        DateTime date;
        public frmAban()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string barcodeShort = txtBarcode.Text.Substring(0, 13);
            string barcode = txtBarcode.Text;
            // db
            frmAbanView abanView = (frmAbanView)Owner;
           
            if (abanView.abantable.Rows.Count > 0)
            {
                foreach (DataRow item in abanView.abantable.Rows)
                {
                    if (item[0].ToString() == barcodeShort && item[6].ToString().Substring(0,10) == DateTime.Now.ToShortDateString())
                    {
                        MessageBox.Show("Test");
                        int qua = int.Parse(item[4].ToString());
                        qua++;
                        // 재고 수량 증가 AbandonsUpdate
                        con = DBcontroller.Instance();
                        using (var cmd = new SqlCommand("AbandonsUpdate", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@barcode", barcodeShort);
                            cmd.Parameters.AddWithValue("@date", DateTime.Parse(DateTime.Now.ToShortDateString()));
                            cmd.Parameters.AddWithValue("@qua", qua);
                            con.Open();
                            int i = cmd.ExecuteNonQuery();
                            MessageBox.Show(i.ToString());
                            if (i != 0)
                            {
                                MessageBox.Show("성공");
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("실패");
                                con.Close();
                            }
                        }
                    }
                    else
                    {
                        //테이블에 추가
                        con = DBcontroller.Instance();
                        using (var cmd = new SqlCommand("AbandonsAdd", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@barcode", barcode);
                            cmd.Parameters.AddWithValue("@date", DateTime.Parse(DateTime.Now.ToShortDateString()));
                            cmd.Parameters.AddWithValue("@qua", 1);
                            con.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i != 1)
                            {
                                MessageBox.Show("성공");
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("실패");
                                con.Close();
                            }
                        }
                    }
                }
            }
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
