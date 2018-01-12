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
    public partial class frmProductRegister : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable cate1Table, cateF, cateNF, placeTable;
        DataSet ds;
        DataRowCollection c1Row, cFRow, cNFRow, pRow;
       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidityCheck() && checkPK())
            {
                string proName = txtProductName.Text.Trim().Replace(" ", "");
                string barCode = txtBarcode.Text.Trim().Replace(" ", "");
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text.Trim().Replace(" ", ""));
                decimal costPrice = decimal.Parse(txtCostPrice.Text.Trim().Replace(" ", ""));
                string cate1 = "F";
                if (cbCate1.SelectedIndex == 1)
                {
                    cate1 = "NF";
                }

                //MessageBox.Show(cbCate2Temp.Items[cbCate2.SelectedIndex].ToString());
                int cate2 = int.Parse(cbCate2Temp.Items[cbCate2.SelectedIndex].ToString());

                int placeNum = cbPlace.SelectedIndex + 1;

                con = DBcontroller.Instance();

                using (var cmd = new SqlCommand("ProductsRegister ", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode", barCode);
                    cmd.Parameters.AddWithValue("@productName", proName);
                    cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@costPrice", costPrice);
                    cmd.Parameters.AddWithValue("@cate1", cate1);
                    cmd.Parameters.AddWithValue("@cate2", cate2);
                    cmd.Parameters.AddWithValue("@placeNum", placeNum);

                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("상품 저장");
                        con.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("상품 저장 실패");
                        con.Close();
                        return;
                    }
                } 
            }

        }

        private void cbCate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCate2.Items.Clear();
            if(cbCate1.SelectedIndex == 0 )
            {
                foreach (DataRow item in cFRow)
                {
                    cbCate2.Items.Add(item[0]);
                    cbCate2Temp.Items.Add(item[1]);
                }

            }
            else if(cbCate1.SelectedIndex == 1)
            {
                foreach (DataRow item in cNFRow)
                {
                    cbCate2.Items.Add(item[0]);
                    cbCate2Temp.Items.Add(item[1]);
                }
            }
        }

        private bool checkPK()
        {
            string barcode = txtBarcode.Text.Trim();
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("BarcodeCheckPK", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                con.Open();

                var sdr = cmd.ExecuteScalar();
              
                if(sdr.ToString() == "1")
                {
                    MessageBox.Show("바코드 번호가 중복됩니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning );
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

        private bool ValidityCheck()
        {
            if (txtBarcode.Text == "" || txtProductName.Text == "" || txtUnitPrice.Text == "" || txtCostPrice.Text == "" || cbCate1.Text == "" || cbPlace.Text == "")
            {
                MessageBox.Show("입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public frmProductRegister()
        {
            InitializeComponent();
        }

        private void frmProductRegister_Load(object sender, EventArgs e)
        {
            con = DBcontroller.Instance();

            using (var cmd = new SqlCommand("GetProRegInfo", con))
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                cate1Table = ds.Tables[0];
                
                placeTable = ds.Tables[3];
                c1Row = cate1Table.Rows;
                
                pRow = placeTable.Rows;
                foreach (DataRow item in pRow)
                {
                    cbPlace.Items.Add(item[0]);
                }

                foreach (DataRow item in c1Row)
                {
                    switch ((string)item[0])
                    {
                        case "F":
                            cbCate1.Items.Add("식품");
                            cateF = ds.Tables[1];
                            cFRow = cateF.Rows;
                            break;
                        case "NF":
                            cbCate1.Items.Add("비식품");
                            cateNF = ds.Tables[2];
                            cNFRow = cateNF.Rows;
                            break;

                    }
                }
            }
            con.Close();
        }

    }
}
