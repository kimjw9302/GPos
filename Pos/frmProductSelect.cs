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
                    //DataTable dataTable = new DataTable();                
                    dgvProducts.DataSource = ds.Tables[0]; 
                    con.Close();
                }
                return;
            
        }      

        public void search()
        {
            int barcode = int.Parse(tboxBarcode.Text);
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("ScanBarcode_Cat",con))
            {
                dgvProducts.DataSource = null;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds);
                dgvProducts.DataSource = ds.Tables[0];
                con.Close();
            }
            
            return;
        }
        
        public void submit()
        {
            int bbarcode = int.Parse(dgvProducts.CurrentRow.Cells[0].Value.ToString());
            int abarcode = int.Parse(tboxBarcode.Text);
            string stockName = tboxProductName.Text;
            decimal unitPrice = decimal.Parse(tboxUnitPrice.Text);
            decimal costPrice = decimal.Parse(tboxcostPrice.Text);
            int actualInven = int.Parse(tboxActualinven.Text);
            int presentInven = int.Parse(tboxPresentInven.Text);
            string category = tboxCategory.Text;
            MessageBox.Show( bbarcode.ToString());
            MessageBox.Show(abarcode.ToString());
            MessageBox.Show(stockName.ToString());
            MessageBox.Show(unitPrice.ToString());
            MessageBox.Show(costPrice.ToString());
            MessageBox.Show(actualInven.ToString());
            MessageBox.Show(presentInven.ToString());
            MessageBox.Show(category.ToString());



            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("StockUpdate", con))
            {
                //dgvProducts.DataSource = null;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", bbarcode);
                cmd.Parameters.AddWithValue("@abarcode", abarcode);
                cmd.Parameters.AddWithValue("@stockName", stockName);
                cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@costPrice", costPrice);
                cmd.Parameters.AddWithValue("@actualInven", actualInven);
                cmd.Parameters.AddWithValue("@presentInven", presentInven);
                //cmd.Parameters.AddWithValue("@category", category);
                //DataSet ds = new DataSet();
                //SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd;
                //sda.Fill(ds);
                //dgvProducts.DataSource = ds.Tables[0];
                //con.Close();
            }
            //textBox();
            return;
        }
        public void delete()
        {
            throw new NotImplementedException();
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

        }
        
        private void textBox()
        {
            tboxBarcode.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            tboxProductName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            tboxUnitPrice.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            tboxcostPrice.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            tboxActualinven.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            tboxPresentInven.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            tboxCategory.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvProducts_Click(object sender, EventArgs e)
        {
            textBox();
        }
    }
}
