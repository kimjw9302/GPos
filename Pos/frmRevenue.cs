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
        SqlDataAdapter adapter;
        DataSet ds;
      

        #region 막대차트디자인
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
        DataPoint m10 = new DataPoint(0, 0);
        DataPoint m20 = new DataPoint(0, 0);
        DataPoint m30 = new DataPoint(0, 0);
        DataPoint m40 = new DataPoint(0, 0);
        DataPoint m50 = new DataPoint(0, 0);
        DataPoint w10 = new DataPoint(0, 0);
        DataPoint w20 = new DataPoint(0, 0);
        DataPoint w30 = new DataPoint(0, 0);
        DataPoint w40 = new DataPoint(0, 0);
        DataPoint w50 = new DataPoint(0, 0); 
        #endregion

        //private DataPointCollection dataPointM , dataPointW;

        //버튼누르면
        private void btnOk_Click(object sender, EventArgs e)
        {
            
          
        }

        Title BarTitle = new Title();
        
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
                    GenderChart();
                    AgeChart();
                    break;
                case 4: 
                    break;
                case 5:
                    break;
                case 6: //지혜
                    break;
                case 7:
                    break;
            }
            
        }


        //조회버튼클릭
        private void btnOk_Click_1(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    TimeRevenue();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3: //지혜
                    GenderChart(); //성별
                    AgeChart(); //연령별
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6: 
                    break;
                case 7:
                    break;
            }
        }

        private void TimeRevenue()
        {
            TextBox txtTime = new TextBox();
            txtTime.Location = new Point(319, 87);
            txtTime.Multiline = true;
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(435, 582);
            this.Controls.Add(txtTime);

        }

        private void AgeChart()
        {
            chartAge.Series[0].Points.Clear();
            chartAge.Series[1].Points.Clear();
            chartAge.Visible = true;
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("AgeAnalysis", con))
            {

                string strDate = dtStart.Value.ToShortDateString() + " 00:00:00";
                string endDate = dtEnd.Value.ToShortDateString() + " 23:59:59";

                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@startDate", DateTime.Parse(strDate));
                cmd.Parameters.AddWithValue("@endDate", DateTime.Parse(endDate));

                adapter = new SqlDataAdapter();
                ds = new DataSet();
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
                switch (item[0].ToString())
                {
                    case "10대":
                        m10.SetValueY(item[1]);
                        break;
                    case "20대":
                        m20.SetValueY(item[1]);
                        break;
                    case "30대":
                        m30.SetValueY(item[1]);
                        break;
                    case "40대":
                        m40.SetValueY(item[1]);
                        break;
                    default:
                        m50.SetValueY(item[1]);
                        break;
                }
            }
            foreach (DataRow item in womenRow)
            {
                switch (item[0].ToString())
                {
                    case "10대":
                        w10.SetValueY(item[1]);
                        break;
                    case "20대":
                        w20.SetValueY(item[1]);
                        break;
                    case "30대":
                        w30.SetValueY(item[1]);
                        break;
                    case "40대":
                        w40.SetValueY(item[1]);
                        break;
                    default:
                        w50.SetValueY(item[1]);
                        break;
                }
            }

            chartAge.Series["남자"].Points.Add(m10);
            chartAge.Series["남자"].Points.Add(m20);
            chartAge.Series["남자"].Points.Add(m30);
            chartAge.Series["남자"].Points.Add(m40);
            chartAge.Series["남자"].Points.Add(m50);
            chartAge.Series["여자"].Points.Add(w10);
            chartAge.Series["여자"].Points.Add(w20);
            chartAge.Series["여자"].Points.Add(w30);
            chartAge.Series["여자"].Points.Add(w40);
            chartAge.Series["여자"].Points.Add(w50);
            chartAge.Series["남자"].Points[0].AxisLabel = "10대";
            chartAge.Series["남자"].Points[1].AxisLabel = "20대";
            chartAge.Series["남자"].Points[2].AxisLabel = "30대";
            chartAge.Series["남자"].Points[3].AxisLabel = "40대";
            chartAge.Series["남자"].Points[4].AxisLabel = "50대 이상";
            

            chartAge.Series["남자"].Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            chartAge.Series["여자"].Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            chartAge.Series["남자"].IsValueShownAsLabel = true;
            chartAge.Series["여자"].IsValueShownAsLabel = true;

            chartAge.Series["남자"].Color = Color.SkyBlue;
            chartAge.Series["여자"].Color = Color.LightPink;
        }

        private void GenderChart()
        {

            chartGender.Series["Gender"].Points.Clear();
            chartGender.Visible = true;
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("MemberAgeSales", con))
            {
                string strDate = dtStart.Value.ToShortDateString() + " 00:00:00";
                string endDate = dtEnd.Value.ToShortDateString() + " 23:59:59";

                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@startDate", DateTime.Parse(strDate));
                cmd.Parameters.AddWithValue("@endDate", DateTime.Parse(endDate));

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                DataRowCollection rows = ds.Tables[0].Rows;
                decimal man =0;
                decimal woman =0;
                foreach (var item in rows)
                {
                    if(rows.Count>1)
                    {
                         man = decimal.Parse(ds.Tables[0].Rows[0][1].ToString());
                        woman = decimal.Parse(ds.Tables[0].Rows[1][1].ToString());
                    }
                }
                
                

                //MethodReturnChat.Series["method"].IsValueShownAsLabel = true;
                //MethodReturnChat.Series["method"].LabelFormat = "{0.0}%";
                if (man == 0 && woman == 0 )
                {
                    chartGender.Series["Gender"].Points.AddXY("데이터값 없음", 100);
                    chartGender.Series["Gender"].Points[0].Color = Color.Coral;
                }
                if (man != 0)
                {
                    chartGender.Series["Gender"].Points.AddXY("남자", man);
                    chartGender.Series["Gender"].Points[0].IsValueShownAsLabel = true;
                    chartGender.Series["Gender"].Points[0].LabelFormat = "{0.0}%";
                    chartGender.Series["Gender"].Points[0].Color = Color.SkyBlue;
                 

                }
                if (woman != 0)
                {
                    chartGender.Series["Gender"].Points.AddXY("여자", woman);
                    chartGender.Series["Gender"].Points[1].IsValueShownAsLabel = true;
                    chartGender.Series["Gender"].Points[1].LabelFormat = "{0.0}%";
                    chartGender.Series["Gender"].Points[1].Color = Color.LightPink;
                }

                chartGender.Series["Gender"].Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                con.Close();


            }
        }
        
     
    }
}
