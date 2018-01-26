using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
        DataTable AllviewTable;
        string reason = "";
        
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
            AllviewTable = ds.Tables[0];
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
            //Image img = Image.FromFile(@"C:\Users\gd3-2\Desktop\apple-icon-180x180.png");
            //labRecipt.Image = img;
            int A = 43;
            //labRecipt.ScrollBars = ScrollBars.Vertical;
            labRecipt.AutoSize = true;
            Controls.Add(labRecipt);

            
            labRecipt.Text = "";
            int totalQ = 0;
            int totalM = 0;
            string decimalTM = "";
            string tax = "";
            string Money = "";
            
            var con = DBcontroller.Instance();
            con.Close();
            using (var cmd = new SqlCommand("ReceiptSerch", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@sellNum", dgvSells.CurrentRow.Cells[0].Value.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                con.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                DataTable cate1Table = ds.Tables[0];
                //int rowcount = ds.Tables[0].Columns.Count; 
                DataRowCollection c1Row = cate1Table.Rows;
                //MessageBox.Show(c1Row[0][0].ToString());
                labRecipt.Text = "*****************************************" + "\n" + "*********** 최근영수증발행인쇄 ***********" + "\n" + "*****************************************" + "\n";
                labRecipt.Text += c1Row[0][0].ToString() + "\n";
                labRecipt.Text += "사업자등록번호:" + c1Row[0][1].ToString() + "\n";
                labRecipt.Text += c1Row[0][2].ToString() + "\n";
                labRecipt.Text += c1Row[0][3].ToString() + "     ";
                labRecipt.Text += "TEL:" + c1Row[0][4].ToString() + "\n";
                labRecipt.Text += "\n" + "정부 방침에 의해 12년 7월 1일부터 현금 결제"+"\n"+ "취소시, 영수증이 없으면 교환/환불이 불가합니" + "\n"+"다. " + "\n";
                labRecipt.Text += "\n" + " 000    " + c1Row[0][6].ToString() + "         POS-01 " + "\n" + "\n";


                foreach (DataRow item in c1Row)
                {
                    
                    int a = 0;
                    string b = "-15";
                    string c = "18";
                    string i7 = item[7].ToString();
                    string i8 = item[8].ToString();
                    string i9 = item[9].ToString();

                    
                    if (Encoding.Default.GetByteCount(item[7].ToString()) != 25)
                    {
                        a = (25 - Encoding.Default.GetByteCount(item[7].ToString())) + 1;
                    }

                    if (Encoding.Default.GetByteCount(item[8].ToString()) == 2 || Encoding.Default.GetByteCount(item[9].ToString()) == 6)
                    {
                        c = "17";
                    }
                    if (Encoding.Default.GetByteCount(item[8].ToString()) == 3)
                    {
                        c = "17"; a = +4;
                    }                   
                    totalQ += int.Parse(item[8].ToString());
                    totalM += int.Parse(item[8].ToString()) * int.Parse(item[9].ToString().Replace(",", "").ToString());
                    decimalTM = string.Format("{0:n0}", totalM);
                    labRecipt.Text += string.Format("{0," + b + "}", item[7].ToString());
                    labRecipt.Text += i8.PadLeft(a, ' ');
                    labRecipt.Text += string.Format("{0," + c + "}", item[9].ToString()) + "\n";                    
                    //labRecipt.TextAlign = left;

                }
                if (int.Parse(c1Row[0][11].ToString()) < 0)
                {
                     A = 42;// 현금 4~5자리
                }
                
                if (c1Row[0][11].ToString() != "0")
                {
                    labRecipt.Text += "\n" + "***************** 현금 *******************" + "\n";
                    labRecipt.Text += "확 인 번 호 : " + "\n";
                    //labRecipt.Text += " 승인번호 : "+ "\n";
                    Money = string.Format("{0:n0}", int.Parse(c1Row[0][11].ToString()));
                    labRecipt.Text += "금         액 :" + string.Format("{0,"+A+"}", string.Format("{0:n0}", int.Parse(c1Row[0][11].ToString()))) + "\n";
                    labRecipt.Text += "알림:소득공제신청은;(ARS)126" + "\n";
                    labRecipt.Text += "http://현금영수증.kr/" + "\n";
                    labRecipt.Text += "홈페이지에서 자진발급분 등록을" + "\n" + " 해주시기 바랍니다." + "\n";
                    labRecipt.Text += "-----------------------------------------";
                }
                
                if (c1Row[0][12].ToString() != "0")
                {
                    labRecipt.Text += "\n" + "*************** 신용 카드 ****************" + "\n";
                    labRecipt.Text += "카 드 번 호 : "+ c1Row[0][14].ToString()+ "\n";
                    //labRecipt.Text += " 승인번호 : "+ "\n";
                    labRecipt.Text += "금         액 : " + string.Format("{0,40}", c1Row[0][12].ToString()) + "\n";
                    labRecipt.Text += "-----------------------------------------";
                }
                if (c1Row[0][13].ToString() != "0")
                {
                    labRecipt.Text += "\n" + "***************** 포인트 *****************" + "\n";
                    labRecipt.Text += "확 인 번 호 : " + "\n";
                    //labRecipt.Text += " 승인번호 : "+ "\n";
                    labRecipt.Text += "금         액 : " + string.Format("{0,42}", c1Row[0][13].ToString()) + "\n";// 포인트 3자리
                    labRecipt.Text += "-----------------------------------------";
                }
                labRecipt.Text += "\n"+string.Format("{0,-13}", "총  구  매  액");
                labRecipt.Text += totalQ.ToString().PadLeft(18, ' ');
                labRecipt.Text += string.Format("{0,17}", decimalTM);
                labRecipt.Text += "\n" + "-----------------------------------------";
                tax = string.Format("{0:n0}", totalM * 0.9092);
                labRecipt.Text += "\n" + " 과세물품가액" + string.Format("{0,42}", tax) + "\n";
                tax = string.Format("{0:n0}", totalM - (totalM * 0.9092));
                labRecipt.Text += "\n" + "부    가     세" + string.Format("{0,42}", tax) + "\n";
                labRecipt.Text += "-----------------------------------------";
                labRecipt.Text += "\n" + "내    실     돈" + string.Format("{0,42}", decimalTM) + "\n";
                if (c1Row[0][11].ToString() != "0")
                {
                    labRecipt.Text += "\n" + "현            금" + string.Format("{0,42}", string.Format("{0:n0}", int.Parse(c1Row[0][11].ToString()))) + "\n";
                    labRecipt.Text += "\n" + "내    신     돈" + string.Format("{0,42}", string.Format("{0:n0}", int.Parse(c1Row[0][11].ToString()))) + "\n";
                    labRecipt.Text += "\n" + "거    스     름" + string.Format("{0,42}", string.Format("{0:n0}", (int.Parse(c1Row[0][11].ToString()) - totalM)).ToString());
                }// 42 는 5,000 41 은 500 
                if (c1Row[0][12].ToString() != "0")
                {
                    labRecipt.Text += "\n" + "신  용  카  드" + string.Format("{0,41}", c1Row[0][12].ToString()) + "\n";
                }
                labRecipt.Text += "\n" + " *표시 상품은 부가세 면세 품목 임." + "\n";
                labRecipt.Text += "\n" + " 환불:30일내 영수증/카드지참시 가능" + "\n";
                labRecipt.Text += "\n" + " 객층 : " + c1Row[0][15].ToString() + "       담당 : " + c1Row[0][16].ToString() + "       NO : " + c1Row[0][17].ToString() + "    " + DateTime.Parse(c1Row[0][6].ToString()).ToShortTimeString();

                pictureBox1.Width=labRecipt.Width;
                pictureBox2.Width=labRecipt.Width;
                int x = labRecipt.Location.X;
                int y = labRecipt.Location.Y + labRecipt.Size.Height ;
                
                pictureBox2.Location = new Point(x, y);
                
                

            }
            
            
            
            


        }


        private void btnReturn_Click(object sender, EventArgs e)
        {            
            frmReturnReason fr = new frmReturnReason();
            fr.Owner = this;
            fr.ShowDialog();
            this.reason = fr.reason;

            if (this.reason != null)
            {
                MessageBox.Show("Test");
                int count = 0;
                if (dgvSells.CurrentRow.Cells[1].Value.ToString() == "")
                {

                    DataRowCollection ARow = AllviewTable.Rows;
                    foreach (DataRow item in ARow)
                    {
                        if (item[1] != DBNull.Value)
                        {
                            if (dgvSells.CurrentRow.Cells[0].Value.ToString() == item[1].ToString().Substring(3, item[1].ToString().LastIndexOf(")") - 3))
                            {
                                MessageBox.Show("이미 반품된 영수증 입니다.");
                                count++;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        var con = DBcontroller.Instance();
                        con.Open();
                        using (var cmd = new SqlCommand("ReturnSearch", con))
                        {
                            MessageBox.Show(dgvSells.CurrentRow.Cells[0].Value.ToString());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sellNum", dgvSells.CurrentRow.Cells[0].Value.ToString());
                            con.Close();

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adapter.SelectCommand = cmd;
                            adapter.Fill(ds);
                            DataTable RTable = ds.Tables[0];
                            DataTable RDTable = ds.Tables[1];
                            DataTable MTable = ds.Tables[2];
                            DataRowCollection Row = RTable.Rows;
                            DataRowCollection RDRow = RDTable.Rows;
                            con.Open();
                            MessageBox.Show(Row[0][1].ToString());
                            MessageBox.Show(Row[0][2].ToString());
                            using (var cmd2 = new SqlCommand("InsertSell", con))
                            {
                                if (Row[0][0] == DBNull.Value)
                                {
                                    cmd2.Parameters.AddWithValue("@memberNum", DBNull.Value);
                                }
                                else
                                {
                                    cmd2.Parameters.AddWithValue("@memberNum", int.Parse(Row[0][0].ToString()));
                                }
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.AddWithValue("@sellDate", DateTime.Now);
                                cmd2.Parameters.AddWithValue("@clientNum", int.Parse(Row[0][2].ToString()));
                                cmd2.Parameters.AddWithValue("@methodNum", int.Parse(Row[0][3].ToString()));
                                cmd2.Parameters.AddWithValue("@totalMoney", -decimal.Parse(Row[0][4].ToString()));
                                cmd2.Parameters.AddWithValue("@receiveCash", -decimal.Parse(Row[0][5].ToString()));
                                cmd2.Parameters.AddWithValue("@receiveCard", -decimal.Parse(Row[0][6].ToString()));
                                cmd2.Parameters.AddWithValue("@receivePoint", -decimal.Parse(Row[0][7].ToString()));
                                cmd2.Parameters.AddWithValue("@note", int.Parse(Row[0][8].ToString()));
                                cmd2.Parameters.AddWithValue("@savePoint", -decimal.Parse(Row[0][9].ToString()));
                                if (Row[0][10] == DBNull.Value)
                                {
                                    cmd2.Parameters.AddWithValue("@card", DBNull.Value);
                                }
                                else { cmd2.Parameters.AddWithValue("@card", Row[0][10].ToString()); }
                                cmd2.Parameters.AddWithValue("@empNum", int.Parse(Row[0][11].ToString()));
                                cmd2.Parameters.AddWithValue("@preturn", "반품(" + dgvSells.CurrentRow.Cells[0].Value.ToString() + ")");
                                cmd2.Parameters.AddWithValue("@returnReason", reason);
                                cmd2.ExecuteNonQuery();
                                con.Close();
                            }
                            con.Close();
                            con.Open();
                            MessageBox.Show(RDTable.Rows.Count.ToString());

                            foreach (DataRow item in RDRow)
                            {
                                MessageBox.Show("Test");
                                using (var ccmd = new SqlCommand("InsertSellInfo", con))
                                {

                                    ccmd.CommandType = CommandType.StoredProcedure;
                                    //decimal salesquantity = 0;
                                    //decimal tot = -1 * decimal.Parse(row["할인"].ToString());
                                    //salesquantity = tot / decimal.Parse(row["단가"].ToString());                            
                                    ccmd.Parameters.AddWithValue("@barcode", item[1].ToString());
                                    ccmd.Parameters.AddWithValue("@quantity", "-" + item[2].ToString());
                                    ccmd.Parameters.AddWithValue("@salesquantity", 0);
                                    ccmd.ExecuteNonQuery();
                                }
                                using (var ccmd = new SqlCommand("UpdateProducts", con))
                                {
                                    ccmd.CommandType = CommandType.StoredProcedure;
                                    ccmd.Parameters.AddWithValue("@barcode", item[1].ToString());
                                    ccmd.Parameters.AddWithValue("@quantity", int.Parse(item[2].ToString()) * -1);
                                    if (ccmd.ExecuteNonQuery() != 1)
                                    {
                                        MessageBox.Show("상품 재고 업데이트 에러");
                                    }
                                }

                            }
                            MessageBox.Show(RDTable.Rows[0][1].ToString());

                            con.Close();
                            con.Open();

                            if (Row[0][0] != DBNull.Value)
                            {
                                using (var ccmd = new SqlCommand("UpdatePoint", con))
                                {
                                    ccmd.CommandType = CommandType.StoredProcedure;
                                    if (Row[0][7].ToString() != "0")// 포인트 결제시 포인트를 더해준다.
                                    {
                                        ccmd.Parameters.AddWithValue("@point", decimal.Parse(Row[0][7].ToString()));
                                    }
                                    else //  포인트 적립시 포인트 차감
                                    {
                                        ccmd.Parameters.AddWithValue("@point", decimal.Parse(Row[0][9].ToString()) * -1);
                                    }
                                    ccmd.Parameters.AddWithValue("@phone", MTable.Rows[0][0].ToString());
                                    ccmd.ExecuteNonQuery();
                                }

                            }
                            con.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("반품된 상품은 반품할 수 없습니다.");
                }
                frmSalesinquiry_Load(null, null);
            }



        }
        private void datetime(int a) // 날짜가 이전 날짜가 이후 날짜 보다 클때  값을 조정해줌
        {
            if (int.Parse(DateTime.Compare(dtpSellDate2.Value, dtpSellDate1.Value).ToString()) < 0 && a == 1)
            {
                dtpSellDate2.Value = dtpSellDate1.Value;                
            }
            else if(int.Parse(DateTime.Compare(dtpSellDate2.Value, dtpSellDate1.Value).ToString()) < 0 && a == 2)
            {
                dtpSellDate1.Value = dtpSellDate2.Value;
            }
        }
        private void dtpSellDate1_ValueChanged(object sender, EventArgs e)
        {
            datetime(1);            
        }

        private void dtpSellDate2_ValueChanged(object sender, EventArgs e)
        {
            datetime(2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tboxSellD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            int width = pictureBox1.Location.X + pictureBox1.Size.Width;
            int height = pictureBox1.Location.Y + labRecipt.Height + pictureBox2.Size.Height;

            PageSettings ps = new PageSettings();
            ps.Margins = new Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings = ps;
            printPreviewDialog1.ClientSize = new Size(500, 500);
            //printPreviewDialog1.UseAntiAlias = ture;

            

            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Pen p = new Pen(Color.Blue, 5);
            //p.Alignment = PenAlignment.Inset;
            //e.Graphics.DrawRectangle(p, e.MarginBounds);
            //Font F = new Font("바탕", 12);
            //e.Graphics.DrawString(txtNote.Text, F, Brushes.Black,
            //        e.MarginBounds.Left + 100, e.MarginBounds.Top + 100);
           
        }
    }
}
