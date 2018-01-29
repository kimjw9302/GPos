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
                    //바코드 13자리랑, 날짜 같으면 수량 증가 
                    if (item[0].ToString() == barcode && item[6].ToString().Substring(0,10) == DateTime.Now.ToShortDateString() )
                    {
                        int qua = int.Parse(item[4].ToString());
                        qua++;

                        con = DBcontroller.Instance();
                        using (var cmd = new SqlCommand("AbandonsUpdate", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@barcode", barcodeShort);
                            cmd.Parameters.AddWithValue("@date", DateTime.Parse(DateTime.Now.ToShortDateString()));
                            cmd.Parameters.AddWithValue("@qua", qua);
                            con.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i == 2)
                            {
                                MessageBox.Show("등록 성공");
                                con.Close();
                                this.Close();
                                Owner.Close();

                            }
                            else
                            {
                                MessageBox.Show("등록 실패");
                                con.Close();
                                this.Close();
                                Owner.Close();
                            }
                        }
                    }
                    //다르면 추가
                    else
                    {
                        AbanTableAdd(barcodeShort, barcode);
                        return;
                    }
                }
            }
            else
            {
                AbanTableAdd(barcodeShort, barcode); 
            }
        }

        private void AbanTableAdd(string barcodeShort, string barcode)
        {
            if(barcode.Length > 17)
            {
                barcode=barcode.Substring(13, 5);
            }
            else
            {
                barcode = "";
            }

            //첫등록 상품 테이블에 추가
            try
            {
                con = DBcontroller.Instance();
                using (var cmd = new SqlCommand("AbandonsAdd", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode", barcodeShort); //바코드 13자리
                    cmd.Parameters.AddWithValue("@date", DateTime.Parse(DateTime.Now.ToShortDateString()));
                    cmd.Parameters.AddWithValue("@qua", 1);
                    cmd.Parameters.AddWithValue("@barcodeSub", barcode); //바코드 5자리
                    con.Open();
                    int i = cmd.ExecuteNonQuery(); //
                    if (i != 1)
                    {
                        MessageBox.Show("등록 성공");
                        con.Close();
                        this.Close();
                        Owner.Close();
                    }
                    else
                    {
                        MessageBox.Show("등록 실패");
                        con.Close();
                        this.Close();
                        Owner.Close();
                    }
                }
            }
            catch (SqlException)
            {
                con.Close();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
