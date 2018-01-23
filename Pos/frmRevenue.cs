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
    public partial class frmRevenue : Form,ISearch,IAlter
    {
        DataGridView dgvProducts = null;
        SqlConnection con = null;
        public frmRevenue()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex)
            {
                case 0: 
                    break;
                case 1:
                    break;
                case 2://재웅
                    ProductRevenue();
                    break;
                case 3: //지혜
                    EmployeeAnalysis();
                    break;
                case 4: 
                    break;
                case 5:
                    break;
                case 6: //지혜
                    TotalRevenue();
                    break;
                case 7://재웅
                    AllTotalRevenue();
                    break;
            }
            
        }

        //재웅 추가/
        private void ProductRevenue()
        {
            
            DataTable pTable = new DataTable();
            dgvProducts = new DataGridView();
         
            dgvProducts.Location =new Point(355, 109);
            dgvProducts.Size = new Size(600, 484);
            dgvProducts.AllowUserToAddRows = false;

            pTable.Columns.Add("순위");
            pTable.Columns.Add("바코드");
            pTable.Columns.Add("상품명");
            pTable.Columns.Add("판매된개수",typeof(int));
            pTable.Columns.Add("거래처");
            this.Controls.Add(dgvProducts);
         

            DateTime start = DateTime.Parse(dtStart.Value.ToShortDateString());
            DateTime end = DateTime.Parse(dtEnd.Value.ToShortDateString());

            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SelectAllBarcode",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (var sdr = cmd.ExecuteReader())
                {

                    while (sdr.Read())
                    {
                        DataRow newRow = pTable.NewRow();                      
                        newRow["바코드"] =sdr["barcode"].ToString();
                        newRow["상품명"] = sdr["productName"].ToString();
                        newRow["거래처"] = sdr["placeName"].ToString();
                        pTable.Rows.Add(newRow);         
                    }                  
                }                  
            }
            con.Close();
       
            foreach (DataRow row in pTable.Rows)
            {
                con.Open();
                string barcode = row["바코드"].ToString();
                using (var cmd = new SqlCommand("productRevenue",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode",barcode);
                    cmd.Parameters.AddWithValue("@sdate", start.ToShortDateString());
                    cmd.Parameters.AddWithValue("@edate", end.ToShortDateString());
                   var sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {                      
                        row["판매된개수"] = sdr[0].ToString();                   
                    }    
                }
                con.Close();
            }
            pTable = pTable.Select("","판매된개수 DESC").CopyToDataTable();
            int count = 0;
            foreach (DataRow row in pTable.Rows)
            {
                row["순위"] = count + 1;
                count++;
            }
            dgvProducts.DataSource = pTable;
        }
        private void AllTotalRevenue()
        {
            throw new NotImplementedException();
        }
        //재웅 추가/

        //총매출
        private void TotalRevenue()
        {
            throw new NotImplementedException();
        }

        //연령별 분석
        private void EmployeeAnalysis()
        {
            throw new NotImplementedException();
        }

        //재웅추가
        private void btnOk_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            this.Controls.Remove(dgvProducts);
            if (listBox1.SelectedIndex == 2)
            {
                MessageBox.Show("들어옴");
                ProductRevenue();
            }
           
        }
    }
}
