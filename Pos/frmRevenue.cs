using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;


namespace Pos
{
    public partial class frmRevenue : Form, ISearch, IAlter
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
        Title BarTitle = new Title();
        DataGridView dgvProducts = new DataGridView();
        DataGridView dgvTotal = new DataGridView();
        DataRow dr1 = null;
        DataTable dt1 = null;
        decimal row1_sum, row2_sum, row3_sum = 0;
        public frmRevenue()
        {
            InitializeComponent();
        }
        private void frmRevenue_Load(object sender, EventArgs e)
        {

        }
        public void VisibleReset()
        {
            txtTime.Visible = false;
            CateNFChart.Visible = false;
            chartGender.Visible = false;
            chart1.Visible = false;
            totalChart.Visible = false;
            dgvTotal.Visible = false;
            dgvProducts.Visible = false;
            MethodReturnChart.Visible = false;
            chartAge.Visible = false;
            this.btnExcel.Visible = false;
        }
        private void Method()
        {

            MethodReturnChart.Visible = true;
            MethodReturnChart.Series["method"].Points.Clear();
            MethodReturnChart.Series["return"].Points.Clear();
            MethodReturnChart.Series["categoryF"].Points.Clear();
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
            MethodReturnChart.Series["method"].Points.Clear();
            MethodReturnChart.Series["return"].Points.Clear();
            MethodReturnChart.Series["categoryF"].Points.Clear();
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

            CateNFChart.Series["categoryNF"].Points.Clear();
            MethodReturnChart.Series["categoryF"].Points.Clear();
            MethodReturnChart.Series["method"].Points.Clear();
            MethodReturnChart.Series["return"].Points.Clear();

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
                CateNFChart.Location = new Point(913, CateNFChart.Location.Y);
                CateNFChart.Size = new Size(450, 350);


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

            if (listBox1.SelectedIndex == 1)
            {
                Category();
            }

            else if (listBox1.SelectedIndex == 2)
            {
                dgvProducts.DataSource = null;
                this.Controls.Remove(dgvProducts);
                ProductRevenue();

            }
            else if (listBox1.SelectedIndex == 4)
            {
                Method();
            }

            else if (listBox1.SelectedIndex == 5)
            {
                Return();
            }
            else if (listBox1.SelectedIndex == 6)
            {
                dgvTotal.DataSource = null;
                this.Controls.Remove(dgvTotal);
                AllTotalRevenue();
                totalChart.Visible = true;
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
            switch (listBox1.SelectedIndex)
            {
                case 0:

                    chartAge.Visible = false;
                    chartGender.Visible = false;
                    TimeRevenue();
                    break;
                case 1:
                    break;
                case 2://재웅
                    ProductRevenue();
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
                case 6: //재웅
                    AllTotalRevenue();
                    break;
            }

        }

        //재웅 추가/
        private void ProductRevenue()
        {

            DataTable pTable = new DataTable();

            dgvProducts.Visible = true;
            dgvProducts.Location = new Point(355, 109);
            dgvProducts.Size = new Size(600, 484);
            dgvProducts.AllowUserToAddRows = false;

            pTable.Columns.Add("순위");
            pTable.Columns.Add("바코드");
            pTable.Columns.Add("상품명");
            pTable.Columns.Add("판매된개수", typeof(int));
            pTable.Columns.Add("거래처");
            this.Controls.Add(dgvProducts);


            DateTime start = DateTime.Parse(dtStart.Value.ToShortDateString());
            DateTime end = DateTime.Parse(dtEnd.Value.ToShortDateString());

            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SelectAllBarcode", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (var sdr = cmd.ExecuteReader())
                {

                    while (sdr.Read())
                    {
                        DataRow newRow = pTable.NewRow();
                        newRow["바코드"] = sdr["barcode"].ToString();
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
                using (var cmd = new SqlCommand("productRevenue", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    cmd.Parameters.AddWithValue("@sdate", DateTime.Parse(start.ToShortDateString() + " 00:00:00"));
                    cmd.Parameters.AddWithValue("@edate", DateTime.Parse(end.ToShortDateString() + " 23:59:59"));
                    var sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        row["판매된개수"] = sdr[0].ToString();
                    }
                }
                con.Close();
            }
            pTable = pTable.Select("", "판매된개수 DESC").CopyToDataTable();
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
            DateTime sdate = DateTime.Parse(dtStart.Value.ToShortDateString());
            DateTime edate = DateTime.Parse(dtEnd.Value.ToShortDateString());
            TimeSpan subDate = edate - sdate;
            int days = int.Parse(subDate.TotalDays.ToString()) + 1;
            row1_sum = row2_sum = row3_sum = 0;
            DataSet ds = new DataSet();
            dt1 = new DataTable();

            totalChart.Visible = true;
            dgvTotal.Visible = true;
            #region 컨트롤정의

            dgvTotal.Location = new Point(352, 109);
            dgvTotal.Size = new Size(944, 150);
            #endregion

            #region DB연결1부분

            SqlConnection con = DBcontroller.Instance();
            con.Open();
            DateTime temp = sdate;
            dt1.Columns.Add("분류");

            for (int i = 0; i < days; i++)
            {
                if (sdate.Month.ToString().Length == 1)
                {
                    dt1.Columns.Add(sdate.Year.ToString() + "년" + "0" + sdate.Month.ToString() + "월" + sdate.Day.ToString() + "일");
                }
                else
                {
                    dt1.Columns.Add(sdate.Year.ToString() + "년" + sdate.Month.ToString() + "월" + sdate.Day.ToString() + "일");
                }




                sdate = sdate.AddDays(1);
            }

            dt1.Columns.Add("합계");

            dr1 = dt1.NewRow();
            //매출액 
            dr1[0] = "매출액";

            for (int i = 1; i < days + 1; i++)
            {
                using (var cmd = new SqlCommand("TotalRevenue", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sdate", temp);
                    var sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (sdr["sum"] == DBNull.Value)
                        {
                            dr1[i] = 0.00;
                        }
                        else
                        {
                            dr1[i] = sdr["sum"].ToString();
                            row1_sum += decimal.Parse(sdr["sum"].ToString());
                        }


                    }
                    sdr.Close();

                }

                temp = temp.AddDays(1);
            }
            dr1[days + 1] = row1_sum;
            dt1.Rows.Add(dr1);

            //할인금액
            dr1 = dt1.NewRow();
            dr1[0] = "할인금";
            sdate = DateTime.Parse(dtStart.Value.ToShortDateString());
            for (int i = 1; i < days + 1; i++)
            {
                using (var cmd = new SqlCommand("NoteRevenue", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sdate", sdate);
                    var sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (sdr["sum"] == DBNull.Value)
                        {
                            dr1[i] = 0.00;
                        }
                        else
                        {
                            dr1[i] = sdr["sum"].ToString();
                            row2_sum += decimal.Parse(sdr["sum"].ToString());
                        }

                    }
                    sdr.Close();

                }
                sdate = sdate.AddDays(1);

            }
            dr1[days + 1] = row2_sum;
            dt1.Rows.Add(dr1);
            //매출단가
            dr1 = dt1.NewRow();
            dr1[0] = "매출단가";
            sdate = DateTime.Parse(dtStart.Value.ToShortDateString());
            for (int i = 1; i < days + 1; i++)
            {
                using (var cmd = new SqlCommand("ProMoneyRevenue", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sdate", sdate);
                    var sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (sdr["sum"] == DBNull.Value)
                        {
                            dr1[i] = 0.00;
                        }
                        else
                        {
                            dr1[i] = sdr["sum"].ToString();
                            row3_sum += decimal.Parse(sdr["sum"].ToString());
                        }


                    }
                    sdr.Close();

                }
                sdate = sdate.AddDays(1);

            }
            dr1[days + 1] = row3_sum;
            dt1.Rows.Add(dr1);

            //for (int i = 0; i < 3; i++)
            //{
            //    dt.Rows.Add("");
            //}

            //합계
            List<decimal> intarr = new List<decimal>();
            dr1 = dt1.NewRow();
            dr1[0] = "매출총합계";
            sdate = DateTime.Parse(dtStart.Value.ToShortDateString());
            intarr.Add(1);
            int count = 1;
            foreach (DataRow row in dt1.Rows)
            {

                for (int i = 1; i < row.ItemArray.Length - 1; i++)
                {
                    //MessageBox.Show("!! : "+row.ItemArray[i].ToString());
                    if (count == 1)
                    {
                        intarr.Add(decimal.Parse(row.ItemArray[i].ToString()));
                    }
                    else
                    {
                        intarr[i] += decimal.Parse(row.ItemArray[i].ToString());
                    }
                }
                count++;
            }
            decimal row4_sum = 0;
            for (int i = 1; i < intarr.Count; i++)
            {
                dr1[i] = intarr[i];
                row4_sum += intarr[i];
            }
            dr1[days + 1] = row4_sum;
            dt1.Rows.Add(dr1);
            con.Close();


            #endregion
            this.Controls.Add(dgvTotal);
            dgvTotal.AllowUserToAddRows = false;
            dgvTotal.DataSource = dt1;
            Draw_Chart();

        }
        public void Draw_Chart()
        {
            Series Series1 = new Series("매출금액");
            Series1.ChartType = SeriesChartType.Line;
            for (int i = 3; i < dt1.Rows.Count; i++)
            {
                for (int j = 1; j < dt1.Rows[3].ItemArray.Length - 1; j++)
                {
                    Series1.Points.AddXY(dt1.Columns[j].ToString().Substring(5, 2) + "-" + dt1.Columns[j].ToString().Substring(8, 2), dt1.Rows[i].ItemArray[j]);
                }
            }
            totalChart.Series.Clear();
            totalChart.Series.Add(Series1);
        }

        private void frmRevenue_Load_1(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string sdate = dtStart.Value.Month + "." + dtStart.Value.Day;
            string edate = dtEnd.Value.Month + "." + dtEnd.Value.Day;

            if (sdate == edate) this.saveFileDialog1.FileName = sdate + " 매출 보고서";
            else this.saveFileDialog1.FileName = sdate + "-" + edate + " 매출 보고서";
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            this.saveFileDialog1.InitialDirectory = "c:\\";

            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                int num = 0;
                object missingType = Type.Missing;
                Excel.Application objApp;
                Excel._Workbook objBook;
                Excel.Workbooks objBooks;
                Excel.Sheets objSheets;
                Excel._Worksheet objSheet;
                Excel.Range range;
                

                string[] headers = new string[dgvTotal.ColumnCount];
                string[] columns = new string[dgvTotal.ColumnCount];

                for (int c = 0; c < dgvTotal.ColumnCount; c++)
                {
                    headers[c] = dgvTotal.Rows[0].Cells[c].OwningColumn.HeaderText.ToString();
                    num = c + 65;
                    columns[c] = Convert.ToString((char)num);
                }

                objApp = new Excel.Application();
                objBooks = objApp.Workbooks;
                objBook = objBooks.Add(Missing.Value);
                objSheets = objBook.Worksheets;
                objSheet = (Excel._Worksheet)objSheets.get_Item(1);
                objSheet.Name = "기간 별 총 매출현황";
                for (int c = 0; c < dgvTotal.ColumnCount; c++)
                {
                    range = objSheet.get_Range(columns[c] + "1", Missing.Value);
                    range.set_Value(Missing.Value, headers[c]);
                }
                for (int i = 0; i < dgvTotal.RowCount - 1; i++)
                {
                    for (int j = 0; j < dgvTotal.ColumnCount; j++)
                    {
                        range = objSheet.get_Range(columns[j] + Convert.ToString(i + 2),
                                                               Missing.Value);
                        range.set_Value(Missing.Value,
                                              dgvTotal.Rows[i].Cells[j].Value.ToString());
                    }
                }
                objApp.Visible = false;
                objApp.UserControl = false;

                objBook.SaveAs(this.saveFileDialog1.FileName,
                          Excel.XlFileFormat.xlWorkbookNormal,
                          missingType, missingType, missingType, missingType,
                          Excel.XlSaveAsAccessMode.xlNoChange,
                          missingType, missingType, missingType, missingType, missingType);
                objBook.Close(false, missingType, missingType);

                //Cursor.Current = Cursors.Default;

                MessageBox.Show("Save Success!!!");



            }
            else
            {

            }

        }



        //재웅 추가/

        //총매출
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
                    if (i < 12)
                    {
                        s = "AM";
                    }

                    txtTime.Text += "  " + s + " " + i + "~" + (i + 1) + "\t" + count[i].ToString() + "건\t\t " + (int)money[i] + "원\r\n";
                    totalMoney += (int)money[i];
                }
                txtTime.Text += "==================================\r\n";
                txtTime.Text += "\t\t\t  총 금액 : " + totalMoney + "원";
            }

        }

        //listbox선택시 
        private void listBox1_Click(object sender, EventArgs e)
        {

            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            VisibleReset();
            switch (listBox1.SelectedIndex)
            {

                case 0: //시간대별

                    TimeRevenue();
                    break;
                case 1: //카테고리별
                    Category();
                    break;
                case 2://상품별
                    ProductRevenue();
                    break;
                case 3: //객층분석

                    GenderChart(); //성별
                    AgeChart(); //연령별
                    break;
                case 4:
                    Method();
                    break;
                case 5://반품현황
                    Return();
                    break;
                case 6://기간별 매출
                    this.btnExcel.Visible = true;
                    AllTotalRevenue();
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
                decimal man = 0;
                decimal woman = 0;
                foreach (var item in rows)
                {
                    if (rows.Count > 1)
                    {
                        man = decimal.Parse(ds.Tables[0].Rows[0][1].ToString());
                        woman = decimal.Parse(ds.Tables[0].Rows[1][1].ToString());
                    }
                }



                //MethodReturnChat.Series["method"].IsValueShownAsLabel = true;
                //MethodReturnChat.Series["method"].LabelFormat = "{0.0}%";
                if (man == 0 && woman == 0)
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

        //재웅추가
        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    totalChart.Visible = false;
        //    if (listBox1.SelectedIndex == 2)
        //    {
        //        dgvProducts.DataSource = null;
        //        this.Controls.Remove(dgvProducts);
        //        ProductRevenue();

        //    }
        //    else if (listBox1.SelectedIndex == 6)
        //    {
        //        dgvTotal.DataSource = null;
        //        this.Controls.Remove(dgvTotal);
        //        AllTotalRevenue();
        //        totalChart.Visible = true;
        //    }

        //}

    }
}