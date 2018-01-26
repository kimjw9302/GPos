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
using System.Windows.Forms.DataVisualization.Charting;

namespace Pos
{
    public partial class frmRevenue : Form, ISearch, IAlter
    {
        
        public frmRevenue()
        {
            InitializeComponent();
        }


        private void frmRevenue_Load(object sender, EventArgs e)
        {

        }
        private void Method()
        {
            MethodReturnChart.Visible = true;
            var con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SalesMethod", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sdate", DateTime.Parse(dtStart.Value.ToShortDateString() + " 00:00:00"));
                cmd.Parameters.AddWithValue("@edate", DateTime.Parse(dtEnd.Value.ToShortDateString() + " 23:59:59"));
                con.Close();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                MethodReturnChart.Size = new Size(703, 527);
                int cash = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                int card = int.Parse(ds.Tables[1].Rows[0][0].ToString());
                int point = int.Parse(ds.Tables[2].Rows[0][0].ToString());

                //MethodReturnChat.Series["method"].IsValueShownAsLabel = true;
                //MethodReturnChat.Series["method"].LabelFormat = "{0.0}%";
                if (cash == 0 && card == 0 && point == 0)
                {
                    MethodReturnChart.Series["method"].Points.AddXY("없음", 100);
                }
                if (cash != 0)
                {
                    MethodReturnChart.Series["method"].Points.AddXY("현금", cash);
                }
                if (card != 0)
                {
                    MethodReturnChart.Series["method"].Points.AddXY("카드", card);
                }
                if (point != 0)
                {
                    MethodReturnChart.Series["method"].Points.AddXY("포인트", point);
                }
            }


        }
        private void Return()
        {
            MethodReturnChart.Visible = true;
            var con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SalesReturn", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sdate", DateTime.Parse(dtStart.Value.ToShortDateString() + " 00:00:00"));
                cmd.Parameters.AddWithValue("@edate", DateTime.Parse(dtEnd.Value.ToShortDateString() + " 23:59:59"));
                con.Close();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                MethodReturnChart.Size = new Size(703, 527);
                int trade = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                int error = int.Parse(ds.Tables[1].Rows[0][0].ToString());
                int etc = int.Parse(ds.Tables[2].Rows[0][0].ToString());

                
                MethodReturnChart.Series["return"].LabelFormat = "{0.0}%";
                if (trade == 0 && error == 0 && etc == 0)
                {
                    MethodReturnChart.Series["return"].Points.AddXY("없음", 100);
                }
                if (trade != 0)
                {
                    MethodReturnChart.Series["return"].Points.AddXY("거래 취소", trade);
                    MethodReturnChart.Series["return"].Points[0].IsValueShownAsLabel = true;
                    MethodReturnChart.Series["return"].Points[0].LabelFormat = "{0.0}%";
                    MethodReturnChart.Series["return"].Points[0].Color = Color.SkyBlue;
                }
                if (error != 0)
                {
                    MethodReturnChart.Series["return"].Points.AddXY("오류 발급 취소", error);
                }
                if (etc != 0)
                {
                    MethodReturnChart.Series["return"].Points.AddXY("기타", etc);
                }
            }
        }
        private void Category()
        {
            MethodReturnChart.Visible = true;
            CateNFChart.Visible = true;
            var con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SalesCate", con))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sdate", DateTime.Parse(dtStart.Value.ToShortDateString() + " 00:00:00"));
                cmd.Parameters.AddWithValue("@edate", DateTime.Parse(dtEnd.Value.ToShortDateString() + " 23:59:59"));
                
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                DataTable food = ds.Tables[0];
                DataTable notfood = ds.Tables[1];
                MethodReturnChart.Size = new Size(450, 350);
                MethodReturnChart.Location = new Point(0, 0);
                CateNFChart.Size = new Size(450, 350);
                CateNFChart.Location = new Point(450, 0);                             

                if (food.Rows.Count == 0)
                {                    
                    MethodReturnChart.Series["categoryF"].Points.AddXY("없음", 100);
                }
                foreach (DataRow item in food.Rows)
                {
                    MethodReturnChart.Series["categoryF"].Points.AddXY(item[0].ToString(), item[1].ToString());
                }
                if (notfood.Rows.Count == 0)
                {                    
                    CateNFChart.Series["categoryNF"].Points.AddXY("없음", 100);
                }
                foreach (DataRow item in notfood.Rows)
                { 
                    CateNFChart.Series["categoryNF"].Points.AddXY(item[0].ToString(), item[1].ToString());
                   
                }
                con.Close();
               
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {            
            MethodReturnChart.Series["method"].Points.Clear();
            MethodReturnChart.Series["return"].Points.Clear();
            MethodReturnChart.Series["categoryF"].Points.Clear();
            CateNFChart.Series["categoryNF"].Points.Clear();
            if (listBox1.SelectedIndex.ToString() == "4")
            {
                Method();
            }
            else if (listBox1.SelectedIndex.ToString() == "5")
            {
                Return();
            }
            else if (listBox1.SelectedIndex.ToString() == "1")
            {
                Category();
            }            
          
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void datetime(int a)
        {
            if (int.Parse(DateTime.Compare(dtEnd.Value, dtStart.Value).ToString()) < 0 && a == 1)
            {
                dtEnd.Value = dtStart.Value;
            }
            else if (int.Parse(DateTime.Compare(dtEnd.Value, dtStart.Value).ToString()) < 0 && a == 2)
            {
                dtStart.Value = dtEnd.Value;
            }
        }
       

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            datetime(1);
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            datetime(2);
        }

        private void MethodReturnChat_Click(object sender, EventArgs e)
        {
            if (!MethodReturnChart.Series.IsUniqueName("categoryF"))
            {
                MessageBox.Show("Test");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex)
            {
                case 0: 
                    break;
                case 1:
                    break;
                case 2:
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
                case 7:
                    break;
            }
            
        }

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
    }
}