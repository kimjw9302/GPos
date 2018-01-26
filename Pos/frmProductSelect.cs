using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmProductSelect : Form ,ISearch,IDelete,ISubmit
    {
        SqlDataAdapter adapter;
        DataTable cate1Table;
        DataSet ds;
        DataRowCollection c1Row, c2Row;
        bool check = true;
        public frmProductSelect()
        {
            InitializeComponent();
        }

        private void frmProductSelect_Load(object sender, EventArgs e)
        {

            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("ProductAllView", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure; // 커맨드타입을 저장프로시저로
                dataset(cmd);
                textBox();
                con.Close();
                if (check) { category(); }                
                }
            return;
            
        }
        public void category()
        {
            
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("GetProRegInfo", con))
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                cate1Table = ds.Tables[0];
                c1Row = cate1Table.Rows;
                foreach (DataRow item in c1Row)
                {
                    if (item[0].ToString() == "F")
                    {
                        cbCate1.Items.Add("식품");
                    }
                    else if (item[0].ToString() == "NF")
                    {
                        cbCate1.Items.Add("비식품");
                    }
                }
                cbCate1_SelectedIndexChanged(null, null);
                con.Close();
            }
            check = false;
            
        }
        public void search()
        {
            string barcode = tboxBarcode.Text;
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("ScanBarcode_Cat",con))
            {   
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                var sdr = cmd.ExecuteNonQuery();
                if (sdr.ToString() != "0")
                {                   
                    dataset(cmd);                                   
                    textBox();
                }
                               
            }
            con.Close();
            return;
        }
        
        public void submit()
        {
            string bbarcode = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            string abarcode = tboxBarcode.Text;
            string productName = tboxProductName.Text;
            decimal unitPrice = decimal.Parse(tboxUnitPrice.Text);
            decimal costPrice = decimal.Parse(tboxcostPrice.Text);
            int actualInven = int.Parse(tboxActualinven.Text);
            int presentInven = int.Parse(tboxPresentInven.Text);
            string cate1="";
            if (cbCate1.Text == "식품")
            {
                cate1 = "F";
            }
            else
            {
                cate1 = "NF";
            }
            string cateName = cbCate2.Text;
            //string category = tboxCategory.Text;
          
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("ProductUpdate", con))
            {                                
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bbarcode", bbarcode);                
                cmd.Parameters.AddWithValue("@abarcode", abarcode);                
                cmd.Parameters.AddWithValue("@productName", productName);                
                cmd.Parameters.AddWithValue("@unitPrice", int.Parse(unitPrice.ToString()));
                cmd.Parameters.AddWithValue("@costPrice", int.Parse(costPrice.ToString()));
                cmd.Parameters.AddWithValue("@actualInven", actualInven);                
                cmd.Parameters.AddWithValue("@presentInven", presentInven);
                cmd.Parameters.AddWithValue("@cate1", cate1);
                cmd.Parameters.AddWithValue("@categoryName", cateName);

                cmd.ExecuteNonQuery();
                MessageBox.Show("수정이 완료 되었습니다.");
                //dataset(cmd);
                con.Close();
            }            
            frmProductSelect_Load(null, null);
        }
        public void dataset(SqlCommand cmd)
        {
            dgvProducts.DataSource = null;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvProducts.DataSource = ds.Tables[0];
            

            DataRow[] updateRow = ds.Tables[0].Select("대분류='F'");
            DataRow[] updateRow2 = ds.Tables[0].Select("대분류='NF'");
            for (int i = 0; i < updateRow.Length; i++)
            {
                if ("F" == updateRow[i]["대분류"].ToString())
                {
                    updateRow[i]["대분류"] = "식품";
                }

            }
            for (int i = 0; i < updateRow2.Length; i++)
            {
                if ("NF" == updateRow2[i]["대분류"].ToString())
                {
                    updateRow2[i]["대분류"] = "비식품";
                }

            }
            dgvProducts.DataSource = ds.Tables[0];
            

        }
        public void delete()
        {
            string barcode = tboxBarcode.Text;
            var con = DBcontroller.Instance();            
            var result = MessageBox.Show("삭제하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (var cmd = new SqlCommand("ProductDelete", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            textBox();
            frmProductSelect_Load(null, null);
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            submit();
            
        }

        private void cbCate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbCate2.Text = "";
            cbCate2.Items.Clear();
            if (cbCate1.Text == "식품")
            {
                c2Row = ds.Tables[1].Rows;
                cbCate2.Text = c2Row[0][0].ToString();
                foreach (DataRow c2 in c2Row)
                {
                    cbCate2.Items.Add(c2[0]);
                }
            }
            else if (cbCate1.Text == "비식품")
            {
                c2Row = ds.Tables[2].Rows;
                cbCate2.Text = c2Row[0][0].ToString();
                foreach (DataRow c2 in c2Row)
                {                    
                    cbCate2.Items.Add(c2[0]);
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }
        
        private void textBox()
        {
            if (dgvProducts.RowCount != 0 )
            {
                tboxBarcode.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                tboxProductName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                tboxUnitPrice.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                tboxcostPrice.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                tboxActualinven.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                tboxPresentInven.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();                
                cbCate1.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
                cbCate2.Text = dgvProducts.CurrentRow.Cells[7].Value.ToString();

            }
            else
            {
                MessageBox.Show("선택하신 제품이 없습니다.");
                tboxBarcode.Text = "";
                tboxProductName.Text = "";
                tboxUnitPrice.Text = "";
                tboxcostPrice.Text = "";
                tboxActualinven.Text = "";
                tboxPresentInven.Text = "";
                cbCate2.Text = "";
                return;
            }            
            
        }

        private void dgvProducts_Click(object sender, EventArgs e)
        {

            try
            {
                textBox();

            }
            catch (Exception)
            {

            }
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmProductSelect_Load(null, null);
            tboxBarcode.Text = "";
            tboxProductName.Text = "";
            tboxUnitPrice.Text = "";
            tboxcostPrice.Text = "";
            tboxActualinven.Text = "";
            tboxPresentInven.Text = "";
            cbCate2.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
