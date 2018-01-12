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
        //List<Products> Plist = new List<Products>();
        public frmProductSelect()
        {
            InitializeComponent();
        }

        private void frmProductSelect_Load(object sender, EventArgs e)
        {

            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("StockAllView", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure; // 커맨드타입을 저장프로시저로
                
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);

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
                    con.Close();
                }
                return;
            
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
            string stockName = tboxProductName.Text;
            decimal unitPrice = decimal.Parse(tboxUnitPrice.Text);
            decimal costPrice = decimal.Parse(tboxcostPrice.Text);
            int actualInven = int.Parse(tboxActualinven.Text);
            int presentInven = int.Parse(tboxPresentInven.Text);
            //string category = tboxCategory.Text;
          
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("StockUpdate", con))
            {                                
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bbarcode", bbarcode);                
                cmd.Parameters.AddWithValue("@abarcode", abarcode);                
                cmd.Parameters.AddWithValue("@stockName", stockName);                
                cmd.Parameters.AddWithValue("@unitPrice", int.Parse(unitPrice.ToString()));
                cmd.Parameters.AddWithValue("@costPrice", int.Parse(costPrice.ToString()));
                cmd.Parameters.AddWithValue("@actualInven", actualInven);                
                cmd.Parameters.AddWithValue("@presentInven", presentInven);
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정이 완료 되었습니다.");
                //dataset(cmd);
                con.Close();
            }
            textBox();
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

        }
        public void delete()
        {
            string barcode = tboxBarcode.Text;
            var con = DBcontroller.Instance();            
            var result = MessageBox.Show("삭제하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (var cmd = new SqlCommand("StockDelete", con))
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
                //var con = DBcontroller.Instance();

            }
            else
            {
                MessageBox.Show("선택하신 제품이 없습니다.");

                tboxProductName.Text = "";
                tboxUnitPrice.Text = "";
                tboxcostPrice.Text = "";
                tboxActualinven.Text = "";
                tboxPresentInven.Text = "";
                //tboxCategory.Text = "";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
