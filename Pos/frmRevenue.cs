using System;
using System.Collections;
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
        DataGridView dgvProducts = null;
        DataGridView dgvTotal = null;
        SqlConnection con = null;
        DataRow dr1 = null;
        DataTable dt =null;
        decimal row1_sum, row2_sum, row3_sum = 0;
        public frmRevenue()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
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
                case 6: //재웅

                    AllTotalRevenue();
                    break;
            }

        }

        //재웅 추가/
        private void ProductRevenue()
        {

            DataTable pTable = new DataTable();
            dgvProducts = new DataGridView();

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

            DataSet ds = new DataSet();
             dt = new DataTable();

            chart1.Visible = true;

            #region 컨트롤정의
            //Label label1 = new Label();
            //label1.Location = new Point(396, 145);
            //label1.Text = "매출액      :";
            //label1.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            //Label label2 = new Label();
            //label2.Location = new Point(396, 204);
            //label2.Text = "매출원가   :";
            //label2.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            //Label label3 = new Label();
            //label3.Location = new Point(396, 262);
            //label3.Text = "매출총이익:";
            //label3.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            //Label label4 = new Label();
            //label4.Location = new Point(750, 109);
            //label4.Text = "이달의 카드 이월 금액";
            //label4.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            //Label lblRevenue = new Label(); //매출
            //lblRevenue.Location = new Point(573, 145);
            //Label lblUnitRevenue = new Label(); //매출 원가
            //lblUnitRevenue.Location = new Point(572, 204);
            //Label lblTotReenue = new Label(); //총 매출
            //lblTotReenue.Location = new Point(157, 38);
            //Label lblCard = new Label(); //카드 이월 금액
            //lblCard.Location = new Point(168, 38);

            dgvTotal = new DataGridView();
            dgvTotal.Location = new Point(352, 109);
            dgvTotal.Size = new Size(944, 150);
            #endregion

            #region DB연결부분

            SqlConnection con = DBcontroller.Instance();
            con.Open();
            DateTime temp = sdate;
            dt.Columns.Add("분류");
            
            for (int i = 0; i < days; i++)
            {
                if (sdate.Month.ToString().Length == 1)
                {
                    dt.Columns.Add(sdate.Year.ToString() + "년" +"0"+ sdate.Month.ToString() + "월" + sdate.Day.ToString() + "일");
                }
                else
                {
                    dt.Columns.Add(sdate.Year.ToString() + "년" + sdate.Month.ToString() + "월" + sdate.Day.ToString() + "일");
                }
           



                sdate = sdate.AddDays(1);
            }

            dt.Columns.Add("합계");

            dr1 = dt.NewRow();
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
            dr1[days+1] = row1_sum;
            dt.Rows.Add(dr1);

            //할인금액
            dr1 = dt.NewRow();
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
            dt.Rows.Add(dr1);
            //매출단가
            dr1 = dt.NewRow();
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
            dt.Rows.Add(dr1);
  
            //for (int i = 0; i < 3; i++)
            //{
            //    dt.Rows.Add("");
            //}

            //합계
            List<decimal> intarr = new List<decimal>();
            dr1 = dt.NewRow();
            dr1[0] = "매출총합계";
            sdate = DateTime.Parse(dtStart.Value.ToShortDateString());
            intarr.Add(1);
            int count = 1;
            foreach (DataRow row in dt.Rows)
            {
               
                for (int i = 1; i < row.ItemArray.Length-1; i++)
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
            dt.Rows.Add(dr1);
            con.Close();


            #endregion
            this.Controls.Add(dgvTotal);
            //this.Controls.Add(label1);
            //this.Controls.Add(label2);
            //this.Controls.Add(label3);
            //this.Controls.Add(label4);
            //this.Controls.Add(lblRevenue);
            //this.Controls.Add(lblUnitRevenue);
            //this.Controls.Add(lblTotReenue);
            //this.Controls.Add(lblCard);
            dgvTotal.AllowUserToAddRows = false;

            dgvTotal.DataSource = dt;
            Draw_Chart();

        }
        public void Draw_Chart()
        {
            Series Series1 = new Series("매출금액");
            Series1.ChartType = SeriesChartType.Line;
            for (int i = 3; i < dt.Rows.Count; i++)
            {       
                for (int j = 1; j < dt.Rows[3].ItemArray.Length-1; j++)
                {
                    Series1.Points.AddXY(dt.Columns[j].ToString().Substring(5, 2) + "-"+dt.Columns[j].ToString().Substring(8,2), dt.Rows[i].ItemArray[j]);
                }     
            }
            chart1.Series.Clear();
            chart1.Series.Add(Series1);
        }
        //재웅 추가/

        //총매출
        private void TotalRevenue()
        {
            throw new NotImplementedException();
        }

        private void frmRevenue_Load(object sender, EventArgs e)
        {
            chart1.Visible = false;
        }

        //연령별 분석
        private void EmployeeAnalysis()
        {
            throw new NotImplementedException();
        }

        //재웅추가
        private void btnOk_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            if (listBox1.SelectedIndex == 2)
            {
                dgvProducts.DataSource = null;
                this.Controls.Remove(dgvProducts);
                ProductRevenue();
               
            }
            else if (listBox1.SelectedIndex == 6)
            {
                dgvTotal.DataSource = null;
                this.Controls.Remove(dgvTotal);
                AllTotalRevenue();
                chart1.Visible = true;
            }

        }
    }
}
