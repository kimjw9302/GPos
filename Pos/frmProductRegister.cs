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
        DataTable cate1Table, cate2Table, placeTable;
        DataSet ds;
        DataRowCollection c1Row, c2Row, pRow;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidityCheck() && checkPK())
            {
                string proName = txtProductName.Text.Trim().Replace(" ", "");
                int barCode = int.Parse(txtBarcode.Text.Trim().Replace(" ", ""));
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text.Trim().Replace(" ", ""));
                decimal costPrice = decimal.Parse(txtCostPrice.Text.Trim().Replace(" ", ""));

                int categoryNum = cbCate1.SelectedIndex + 1;
                int placeNum = cbPlace.SelectedIndex + 1;

                con = DBcontroller.Instance();

                using (var cmd = new SqlCommand("ProductsRegister ", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode", barCode);
                    cmd.Parameters.AddWithValue("@productName", proName);
                    cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@costPrice", costPrice);
                    cmd.Parameters.AddWithValue("@categoryNum", categoryNum);
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
                cate2Table = ds.Tables[1];
                placeTable = ds.Tables[2];
                c1Row = cate1Table.Rows;
                c2Row = cate2Table.Rows;
                pRow = placeTable.Rows;

                foreach (DataRow item in c1Row)
                {
                    if(item[0].ToString() == "F")
                    {
                        cbCate1.Items.Add("식품");
                    }
                    else if(item[0].ToString() == "NF")
                    {
                        cbCate1.Items.Add("비식품");
                    }
                    
                }
                foreach (DataRow item in c2Row)
                {
                    cbCate2.Items.Add(item[0]);
                }
               
                foreach (DataRow item in pRow)
                {
                    cbPlace.Items.Add(item[0]);
                }
            }
            con.Close();
        }

    }
}
