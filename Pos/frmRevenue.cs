﻿using System;
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

        //지혜 - 시간대별 매출
        DataTable dt;
        DataRowCollection dtRow;
        int totalMoney;
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
        

        //조회버튼클릭
        private void btnOk_Click_1(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    chartAge.Visible = false;
                    chartGender.Visible = false;
                    TimeRevenue();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3: //지혜
                    txtTime.Visible = false;
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
            txtTime.Visible = true;
            txtTime.Text = "";
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("TimeRevenue", con))
            {
                int[] count = new int[24];
                decimal[] money = new decimal[24];
                   

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
                dt = ds.Tables[0];

                dtRow = dt.Rows;

                #region 시간대별로 건수, 금액 넣는 부분
                foreach (DataRow item in dtRow)
                {
                    string time = DateTime.Parse(item[0].ToString()).ToString("HH:mm:ss");
                    switch (time.Substring(0, 2))
                    {
                        case "00":
                            count[0] = int.Parse(item[1].ToString());
                            money[0] = decimal.Parse(item[2].ToString());
                            break;
                        case "01":
                            count[1] = int.Parse(item[1].ToString());
                            money[1] = decimal.Parse(item[2].ToString());
                            break;
                        case "02":
                            count[2] = int.Parse(item[1].ToString());
                            money[2] = decimal.Parse(item[2].ToString());
                            break;
                        case "03":
                            count[3] = int.Parse(item[1].ToString());
                            money[3] = decimal.Parse(item[2].ToString());
                            break;
                        case "04":
                            count[4] = int.Parse(item[1].ToString());
                            money[4] = decimal.Parse(item[2].ToString());
                            break;
                        case "05":
                            count[5] = int.Parse(item[1].ToString());
                            money[5] = decimal.Parse(item[2].ToString());
                            break;
                        case "06":
                            count[6] = int.Parse(item[1].ToString());
                            money[6] = decimal.Parse(item[2].ToString());
                            break;
                        case "07":
                            count[7] = int.Parse(item[1].ToString());
                            money[7] = decimal.Parse(item[2].ToString());
                            break;
                        case "08":
                            count[8] = int.Parse(item[1].ToString());
                            money[8] = decimal.Parse(item[2].ToString());
                            break;
                        case "09":
                            count[9] = int.Parse(item[1].ToString());
                            money[9] = decimal.Parse(item[2].ToString());
                            break;
                        case "10":
                            count[10] = int.Parse(item[1].ToString());
                            money[10] = decimal.Parse(item[2].ToString());
                            break;
                        case "11":
                            count[11] = int.Parse(item[1].ToString());
                            money[11] = decimal.Parse(item[2].ToString());
                            break;
                        case "12":
                            count[12] = int.Parse(item[1].ToString());
                            money[12] = decimal.Parse(item[2].ToString());
                            break;
                        case "13":
                            count[13] = int.Parse(item[1].ToString());
                            money[13] = decimal.Parse(item[2].ToString());
                            break;
                        case "14":
                            count[14] = int.Parse(item[1].ToString());
                            money[14] = decimal.Parse(item[2].ToString());
                            break;
                        case "15":
                            count[15] = int.Parse(item[1].ToString());
                            money[15] = decimal.Parse(item[2].ToString());
                            break;
                        case "16":
                            count[16] = int.Parse(item[1].ToString());
                            money[16] = decimal.Parse(item[2].ToString());
                            break;
                        case "17":
                            count[17] = int.Parse(item[1].ToString());
                            money[17] = decimal.Parse(item[2].ToString());
                            break;
                        case "18":
                            count[18] = int.Parse(item[1].ToString());
                            money[18] = decimal.Parse(item[2].ToString());
                            break;
                        case "19":
                            count[19] = int.Parse(item[1].ToString());
                            money[19] = decimal.Parse(item[2].ToString());
                            break;
                        case "20":
                            count[20] = int.Parse(item[1].ToString());
                            money[20] = decimal.Parse(item[2].ToString());
                            break;
                        case "21":
                            count[21] = int.Parse(item[1].ToString());
                            money[21] = decimal.Parse(item[2].ToString());
                            break;
                        case "22":
                            count[22] = int.Parse(item[1].ToString());
                            money[22] = decimal.Parse(item[2].ToString());
                            break;
                        case "23":
                            count[23] = int.Parse(item[1].ToString());
                            money[23] = decimal.Parse(item[2].ToString());
                            break;

                    } 
                    #endregion

                }
                con.Close();

                txtTime.Text += "\t <<시간대별 매출 현황 >>\r\n";
                txtTime.Text += "==================================\r\n";
                txtTime.Text += "    시간대\t개수\t\t금액\t \r\n";
                txtTime.Text += "==================================\r\n";

                
                for (int i = 0; i < 24; i++)
                {
                    var s = "PM";
                    if(i < 12)
                    {
                        s = "AM";
                    }

                    txtTime.Text +="  "+s+" "+ i+"~"+(i+1)+"\t"+ count[i].ToString() +"건\t\t "+ (int)money[i] + "원\r\n";
                    totalMoney += (int)money[i];
                }
                txtTime.Text += "==================================\r\n";
                txtTime.Text += "\t\t\t  총 금액 : " + totalMoney +"원";
            }

        }

        //listbox선택시 
        private void listBox1_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    chartAge.Visible = false;
                    chartGender.Visible = false;
                    TimeRevenue();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3: //지혜
                    txtTime.Visible = false;
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

        //성별 차트
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

        //연령대별 차트
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
