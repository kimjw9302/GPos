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
        Title CirTitle = new Title();
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

        DataPoint m10, m20, m30, m40, m50, w10, w20, w30, w40, w50;
        Title BarTitle = new Title();
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

        /*
         *  0열 (x) - 연령대 /  1열 (y) - 비율 
         * 10대, 20대, 30대, 40대, 50대이상  datapoint 5개 * 2 (성별)
         * 
         */
        // 나이별 분석- 막대그래프
        private void AgeAnalysis()
        {
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("AgeAnalysis", con))
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
            //남자 datapoint 추가
            m10 = new DataPoint(0, (Double)yValueMan[0]);
            m20 = new DataPoint(0, (Double)yValueMan[1]);
            m30 = new DataPoint(0, (Double)yValueMan[2]);
            m40 = new DataPoint(0, (Double)yValueMan[3]);
            m50 = new DataPoint(0, (Double)yValueMan[4]);


            foreach (DataRow item in womenRow)
            {
                xValue.Add(item[0].ToString());
                yValueWom.Add((decimal)item[1]);
            }
            //여자 datapoint 추가
            w10 = new DataPoint(0, (Double)yValueWom[0]);
            w20 = new DataPoint(0, (Double)yValueWom[1]);
            w30 = new DataPoint(0, (Double)yValueWom[2]);
            w40 = new DataPoint(0, (Double)yValueWom[3]);
            w50 = new DataPoint(0, (Double)yValueWom[4]);


            serMan.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            serWom.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
          
            serMan.IsValueShownAsLabel = true;
            serWom.IsValueShownAsLabel = true;
            chart2 = new Chart();
            this.Controls.Add(this.chart2);


            chartArea2.Name = "ChartArea2";
            this.chart2.ChartAreas.Add(chartArea2);
            
           
            legend1.Name = "Legend2";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new Point(314, 87);
            this.chart2.Name = "chart2";
            
            serMan.Points.Add(m10);
            serMan.Points.Add(m20);
            serMan.Points.Add(m30);
            serMan.Points.Add(m40);
            serMan.Points.Add(m50);

            serWom.Points.Add(w10);
            serWom.Points.Add(w20);
            serWom.Points.Add(w30);
            serWom.Points.Add(w40);
            serWom.Points.Add(w50);

            serMan.LegendText = "남자";
            serWom.LegendText = "여자";
            serMan.Color = Color.SkyBlue;
            serWom.Color = Color.LightPink;

            serMan.ChartArea = "ChartArea2";
            serWom.ChartArea = "ChartArea2";



            BarTitle.Alignment = ContentAlignment.TopLeft;
            BarTitle.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
            BarTitle.TextStyle = TextStyle.Shadow;
            BarTitle.Text = "<< 연령별, 성별 매출현황 조회 >>";
            chart2.Titles.Add(BarTitle);
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //추가
            this.chart2.Series.Add(serMan);
            this.chart2.Series.Add(serWom);
            
          this.chart2.Size = new Size(478, 582);
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
            dpMan.Color = Color.SkyBlue;
            dpWomen.Color = Color.LightPink;
            

            this.chart1 = new Chart();
            this.Controls.Add(this.chart1);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new Point(798, 436);
            this.chart1.Name = "chart1";


            gender.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gender.Points.Add(dpMan);
            gender.Points.Add(dpWomen);

            gender.ChartArea = "ChartArea1";
            gender.Legend = "Legend1";
            gender.Name = "man";
            gender.ChartType = SeriesChartType.Pie;

            CirTitle.Alignment = ContentAlignment.TopLeft;
            CirTitle.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
            CirTitle.TextStyle = TextStyle.Shadow;
            CirTitle.Text = "<< 성별 매출현황 조회 >>";
            chart1.Titles.Add(CirTitle);
            //차트에 추가
            this.chart1.Series.Add(gender);
            
            this.chart1.Size = new Size(267, 233);
            this.chart1.Text = "chart1";
           

        }
        //총매출
        private void TotalRevenue()
        {
            throw new NotImplementedException();
        }
    }
}
