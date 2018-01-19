using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 그리드 뷰에 필요한것들 http://m.blog.daum.net/jabapos/16819171?tp_nil_a=2 여기서보기
/// </summary>
namespace Pos
{
    public partial class frmSalesinquiry : Form,ISearch,IDelete,IAlter
    {
        public frmSalesinquiry()
        {
            InitializeComponent();
        }

        private void frmSalesinquiry_Load(object sender, EventArgs e)
        {
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("SellAllView", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                dataset(cmd);                
                con.Close();
                tboxSellD.AutoScrollOffset =new Point(100,100);

            }
            return;
        }
        public void dataset(SqlCommand cmd)
        {
            dgvSells.DataSource = null;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvSells.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tabControl1.SelectedTab.Text);
            var con = DBcontroller.Instance();
            if (tabControl1.SelectedTab.Text == "기간조회")
            {
                using (var cmd = new SqlCommand("SellDateSerch", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@ADate", DateTime.Parse(dtpSellDate1.Value.ToShortDateString()+" 00:00:00"));
                    cmd.Parameters.AddWithValue("@BDate", DateTime.Parse(dtpSellDate2.Value.ToShortDateString() + " 23:59:59"));
                    cmd.CommandType = CommandType.StoredProcedure; 
                    dataset(cmd);
                    con.Close();
                }
                return;
            }
            if (tabControl1.SelectedTab.Text == "영수증조회")
            {
                using (var cmd = new SqlCommand("SellReceiptNumView", con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@sellNum",tboxReceipt.Text);                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    dataset(cmd);
                    con.Close();
                }

            }
            

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                int Row = dgvSells.CurrentRow.Index;
                Row--;
                DataGridViewCell _dgvCell = dgvSells.Rows[Row].Cells[0];
                dgvSells.FirstDisplayedCell = _dgvCell;
                dgvSells.CurrentCell = _dgvCell;
            }
            catch (ArgumentOutOfRangeException)
            {
                
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                int Row = dgvSells.CurrentRow.Index;
                Row++;
                DataGridViewCell _dgvCell = dgvSells.Rows[Row].Cells[0];
                dgvSells.FirstDisplayedCell = _dgvCell;
                dgvSells.CurrentCell = _dgvCell;
            }
            catch (ArgumentOutOfRangeException)
            {
                
            }
        }

        private void dgvSells_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tboxSellD.ScrollBars = ScrollBars.Vertical;
            int totalQ = 0;
            int totalM = 0;
            string decimalTM ="";
            string tax = "";
            string Money = "";
            try
            {
                var con = DBcontroller.Instance();
                using (var cmd = new SqlCommand("ReceiptSerch", con))
                {
                    con.Open();                    
                    cmd.Parameters.AddWithValue("@sellNum", dgvSells.CurrentRow.Cells[0].Value.ToString());
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                   
                    DataTable cate1Table = ds.Tables[0];
                    int rowcount = ds.Tables[0].Columns.Count; 
                    DataRowCollection c1Row = cate1Table.Rows;

                    tboxSellD.Text = "*****************************************" + Environment.NewLine+ "*********** 최근영수증발행인쇄 ***********" + Environment.NewLine + "*****************************************";
                    tboxSellD.Text += c1Row[0][0].ToString() + Environment.NewLine;
                    tboxSellD.Text += "사업자등록번호:" + c1Row[0][1].ToString() + Environment.NewLine;
                    tboxSellD.Text += c1Row[0][2].ToString() + Environment.NewLine;
                    tboxSellD.Text += c1Row[0][3].ToString() + "     ";
                    tboxSellD.Text += "TEL:" + c1Row[0][4].ToString() + Environment.NewLine;
                    tboxSellD.Text += Environment.NewLine +"정부 방침에 의해 12년 7월 1일부터 현금 결제 취소시, 영수증이 없으면 교환/환불이 불가합니다. "+ Environment.NewLine;
                    tboxSellD.Text += Environment.NewLine + " 000    " + c1Row[0][6].ToString() + "    POS-01 "+ Environment.NewLine+ Environment.NewLine;

                    
                    foreach (DataRow item in c1Row)
                    {
                        int a = 0;
                        string b = "-15";
                        string c = "18";                        
                        string i7 = item[7].ToString();
                        string i8 = item[8].ToString();
                        string i9 = item[9].ToString();
                                           
                        if ( Encoding.Default.GetByteCount(item[7].ToString()) != 25)
                        {
                            a = (25 - Encoding.Default.GetByteCount(item[7].ToString())) + 1; 
                        }

                        if (Encoding.Default.GetByteCount(item[8].ToString()) == 2 || Encoding.Default.GetByteCount(item[9].ToString()) == 6)
                        {
                             c = "17";
                        }                        
                        if (Encoding.Default.GetByteCount(item[8].ToString()) == 3 )
                        {
                            c = "17"; a = +4;
                        }
                        totalQ += int.Parse(item[8].ToString());                        
                        totalM += int.Parse(item[8].ToString()) * int.Parse(item[9].ToString().Replace(",", "").ToString());
                        decimalTM = string.Format("{0:n0}", totalM);
                        tboxSellD.Text +=  string.Format("{0,"+b+"}", item[7].ToString());
                        tboxSellD.Text += i8.PadLeft(a,' ');                        
                        tboxSellD.Text += string.Format("{0,"+c+"}",item[9].ToString())+Environment.NewLine;                        
                    }
                    
                    if (c1Row[0][11] != DBNull.Value)
                    {
                        tboxSellD.Text += Environment.NewLine+" ***************** 현금 ******************" + Environment.NewLine;
                        tboxSellD.Text += " 확인번호 : "+ Environment.NewLine;
                        //tboxSellD.Text += " 승인번호 : "+ Environment.NewLine;
                        Money = string.Format("{0:n0}", int.Parse(c1Row[0][11].ToString()));
                        tboxSellD.Text += " 금      액 :" + string.Format("{0,44}", "1,100,000") + Environment.NewLine;
                        tboxSellD.Text += " 알림:소득공제신청은;(ARS)126"+ Environment.NewLine;
                        tboxSellD.Text += " http://현금영수증.kr/"+ Environment.NewLine;
                        tboxSellD.Text += " 홈페이지에서 자진발급분 등록을" + Environment.NewLine + " 해주시기 바랍니다." + Environment.NewLine;
                        tboxSellD.Text += "-----------------------------------------";
                    }
                    if (c1Row[0][12] != DBNull.Value)
                    {
                        tboxSellD.Text += Environment.NewLine+" *************** 카드 *****************" + Environment.NewLine;
                        tboxSellD.Text += " 확인번호 : "+ Environment.NewLine;
                        //tboxSellD.Text += " 승인번호 : "+ Environment.NewLine;
                        tboxSellD.Text += " 금    액 : " + string.Format("{0,45}", c1Row[0][12].ToString()) + Environment.NewLine;
                        tboxSellD.Text += "-----------------------------------------";
                    }
                    if (c1Row[0][13] != DBNull.Value)
                    {
                        tboxSellD.Text += Environment.NewLine+" *************** 포인트 *****************" + Environment.NewLine;
                        tboxSellD.Text += " 확인번호 : "+ Environment.NewLine;
                        //tboxSellD.Text += " 승인번호 : "+ Environment.NewLine;
                        tboxSellD.Text += " 금    액 : " + string.Format("{0,45}", c1Row[0][13].ToString()) + Environment.NewLine;
                        tboxSellD.Text += "---------------------------------------- - ";
                    }
                        tboxSellD.Text += string.Format("{0,-15}", "총구매액");
                        tboxSellD.Text += totalQ.ToString().PadLeft(18, ' ');                        
                        tboxSellD.Text += string.Format("{0,16}", decimalTM);
                        tboxSellD.Text += "-----------------------------------------";
                        tax = string.Format("{0:n0}", totalM * 0.9092);
                        tboxSellD.Text += " 과세물품가액" + string.Format("{0,41}", tax) + Environment.NewLine;
                        tax = string.Format("{0:n0}", totalM - (totalM * 0.9092));
                        tboxSellD.Text += "부    가     세" + string.Format("{0,41}", tax) + Environment.NewLine;  
                        tboxSellD.Text += "-----------------------------------------";
                        tboxSellD.Text += "내    실     돈" + string.Format("{0,41}", decimalTM) + Environment.NewLine;                    
                    if (c1Row[0][11] != DBNull.Value)
                    {
                        tboxSellD.Text += "현            금" + string.Format("{0,41}", string.Format("{0:n0}", int.Parse(c1Row[0][11].ToString()))) + Environment.NewLine;
                        tboxSellD.Text += "내    신     돈" + string.Format("{0,41}", string.Format("{0:n0}",int.Parse(c1Row[0][11].ToString()))) + Environment.NewLine;
                        tboxSellD.Text += "거    스     름" + string.Format("{0,41}", string.Format("{0:n0}", (int.Parse(c1Row[0][11].ToString()) - totalM)).ToString());
                    }
                    if (c1Row[0][12] != DBNull.Value)
                    {
                        tboxSellD.Text += "신  용   카  드" + string.Format("{0,41}", decimalTM) + Environment.NewLine; 
                    }
                    tboxSellD.Text += " *표시 상품은 부가세 면세 품목 임." + Environment.NewLine;
                    tboxSellD.Text += " 환불:30일내 영수증/카드지참시 가능" + Environment.NewLine;
                    tboxSellD.Text += " 객층 : " + c1Row[0][15].ToString()+ "       담당 : " + c1Row[0][16].ToString() + "       NO : " + c1Row[0][17].ToString() + "    " + DateTime.Parse(c1Row[0][6].ToString()).ToShortTimeString();

                }
                con.Close();
            }
            catch (Exception)
            {
                
            }
            

        }
    }
}
