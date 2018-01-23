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
    public partial class frmRevenue : Form,ISearch,IAlter
    {
        SqlConnection con;
        //지혜 - 남녀 비율 차트 생성시 필요
        ChartArea chartArea1 = new ChartArea();
        Legend legend1 = new Legend();
        Series gender = new Series();
        DataPoint dpMan;
        DataPoint dpWomen;
        private Chart chart1;
        private List<decimal> value = new List<decimal>();
        //~ 지혜 - 막대차트
        DataTable manTable, womenTable;
        DataRowCollection manRow, womenRow;
        Series serMan = new Series();
        Series serWom = new Series();
        List<string> xValue = new List<string>();
        List<decimal> yValueMan = new List<decimal>();
        List<decimal> yValueWom = new List<decimal>();
        ChartArea chartArea2 = new ChartArea();
        Legend legend2 = new Legend();
        private Chart chart2;
        //


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
                case 2:
                    break;
                case 3: //지혜
                    GenderAnalysis();
                    AgeAnalysis();
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
        // 나이별 분석- 막대그래프
        private void AgeAnalysis()
        {
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("AgeAnalysis",con))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                manTable = ds.Tables[0];
                womenTable = ds.Tables[1];

                manRow = manTable.Rows;
                womenRow = womenTable.Rows;
            }
            con.Close();

            foreach (DataRow item in manRow)
            {
                //첫번째 : 나이, 두번째 : 비율
                xValue.Add(item[0].ToString());
                yValueMan.Add((decimal)item[1]);
            }
            foreach (DataRow item in womenRow)
            {
                xValue.Add(item[0].ToString());
                yValueWom.Add((decimal)item[1]);
            }
            
            chartArea2.Name = "ChartArea2";
            this.chart2.ChartAreas.Add(chartArea2);
            
            legend1.Name = "Legend2";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(513, 252);
            this.chart2.Name = "chart2";
            
            this.chart2.Series.Add(serMan);
            this.chart2.Series.Add(serWom);
            serMan.ChartArea = "ChartArea2";
            serWom.ChartArea = "ChartArea2";
            this.chart2.Size = new System.Drawing.Size(500, 300);
            this.chart2.Text = "chart2";



        }

        //연령별 분석 - 원형
        private void GenderAnalysis()
        {
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("MemberAgeSales",con))
            {
                con.Open();
                SqlDataReader read = cmd.ExecuteReader();
                
                while (read.Read())
                {
                    //datapoint 값 담기
                    value.Add(read.GetDecimal(1));
                }
                
            }
            con.Close();

            dpMan = new DataPoint(0, (double)value[0]);
            dpWomen = new DataPoint(0, (double)value[1]);
            dpMan.LegendText = "남자";
            dpWomen.LegendText = "여자";
            dpMan.IsValueShownAsLabel = true;
            dpWomen.IsValueShownAsLabel = true;
            dpMan.LabelFormat = "{0.0}%";
            dpWomen.LabelFormat = "{0.0}%";

            this.chart1 = new Chart();
            this.Controls.Add(this.chart1);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(339, 125);
            this.chart1.Name = "chart1";

            gender.Points.Add(dpMan);
            gender.Points.Add(dpWomen);

            gender.ChartArea = "ChartArea1";
            gender.Legend = "Legend1";
            gender.Name = "man";
            gender.ChartType = SeriesChartType.Pie;
            
            //차트에 추가
            this.chart1.Series.Add(gender);
            
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.Text = "chart1";
           

        }
        //총매출
        private void TotalRevenue()
        {
            throw new NotImplementedException();
        }
    }
}
