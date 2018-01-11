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
    public partial class frmMain : Form
    {
        private SqlConnection con;
        public string empName;
        public int empId;
        public DateTime sdate;
        public bool pFlag = true;
        public TextBox current;
        public DataTable sellTable;
        public int sellrowindex;
        public int proCount;
        //public List<Sell> sellList;
        //생성자
        public frmMain()
        {
            InitializeComponent();
        }
        //매개변수 2개를 받는 생성자,  [1] 로그인하는사람의 이름 [2] 로그인하는 사람의 ID를 FormMain에서 가지고있는다.
        public frmMain(string empName, string empId) : this()
        {
            this.empId = int.Parse(empId);
            this.empName = empName;
        }

        public void SellTable()
        {
            sellrowindex = 1;
            proCount = 1;
            sellTable = new DataTable();
            sellTable.Columns.Add("No");
            sellTable.Columns.Add("바코드");
            sellTable.Columns.Add("상품명");
            sellTable.Columns.Add("단가");
            sellTable.Columns.Add("수량");
            sellTable.Columns.Add("금액");
            sellTable.Columns.Add("할인");
            sellTable.Columns.Add("비고");
        }
        //로드.
        private void frmMain_Load(object sender, EventArgs e)
        {

            sdate = DateTime.Now;
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblDate2.Text = DateTime.Now.ToLongTimeString();
            SellTable();
            timer1.Start();
            timer1.Interval = 1000;
            //로드를 하는 순간 재고를 찾아봄 그러므로 상품테이블에 재고량에 들어가야함
            lblEmployee.Text = empName;
            dgvProduct.DataSource = sellTable;
            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("LoadCheckProducts", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    con.Close();
                }
                else
                {
                    this.Visible = true;
                    con.Close();
                    frmNotice fn = new frmNotice(ds.Tables[0]);
                    fn.ShowDialog();
                }

            }

        }

        //종료버튼.
        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnTotalView_Click(object sender, EventArgs e)
        {
            new frmView().ShowDialog();
        }
        private void btnManagement_Click(object sender, EventArgs e)
        {
            new frmManagement().ShowDialog();
        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            new frmCard().ShowDialog();
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            new frmCash().ShowDialog();
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            new frmPoint().ShowDialog();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            new frmOrder().ShowDialog();
        }
        private void btnEtc_Click(object sender, EventArgs e)
        {
            new frmEtc().ShowDialog();
        }
        //담당자 변경 클릭시 -> 
        private void btnEmployeeChange_Click(object sender, EventArgs e)
        {
            frmEmployeeRotaion fer = new frmEmployeeRotaion(sdate);
            fer.Owner = this;
            fer.EmpName = empName;
            fer.EmpId = empId;
            fer.ShowDialog();

        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //계산기는 싱글톤 패턴으로
            new frmCalculator().Show();
        }



        private void txtProduct_ChangeUICues(object sender, UICuesEventArgs e)
        {
            MessageBox.Show("Test");
        }



        private void txtProduct_Click(object sender, EventArgs e)
        {
            //txtProduct.Text = "";
            current = (TextBox)sender;

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            current.Text += "7";
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            //txtProduct.Text = "";
            current = (TextBox)sender;
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            //txtQuantity.Text = "";
            current = (TextBox)sender;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            current.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            current.Text += "9";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            current.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            current.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            current.Text += "6";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            current.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            current.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            current.Text += "3";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            current.Text += "0";
        }

        private void btnHundred_Click(object sender, EventArgs e)
        {
            current.Text += "00";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            current.Text = "0";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("계속");
            foreach (var item in this.Controls)
            {

                if (item.ToString().EndsWith("TableLayoutPanel"))
                {
                    TextBox tbox = item as TextBox;
                    MessageBox.Show(tbox.Name.ToString());


                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtReceived_Click(object sender, EventArgs e)
        {
            txtReceived.Text = "";
            current = (TextBox)sender;
        }

        private void txtReceive_Click(object sender, EventArgs e)
        {
            txtReceived.Focus();
            txtReceived.Text = "";
            current = txtReceived;
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con = DBcontroller.Instance();
                con.Open();
                using (var cmd = new SqlCommand("ScanBarcode", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode", txtProduct.Text);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {

                        foreach (DataRow sellrow in sellTable.Rows)
                        {
                            int rowIndex = 0;
                            string specifier;
                            for (int i = 0; i < sellrow.ItemArray.Length; i++)
                            {
                                if (sellrow.ItemArray[i].ToString() == row["barcode"].ToString())
                                {
                                    proCount++;

                                    DataRow[] updateRow = sellTable.Select("바코드='" + row["barcode"].ToString() + "'");
                                    updateRow[rowIndex]["수량"] = proCount;
                                    updateRow[rowIndex]["금액"] = decimal.Parse(row["unitPrice"].ToString()) * proCount;
                                    txtQuantity.Text = proCount.ToString();

                                    string tot = (int.Parse(Math.Round(decimal.Parse(row["unitPrice"].ToString()) * proCount).ToString()) + int.Parse(txtReceive.Text)).ToString();
                                    string pretot = Math.Round(decimal.Parse(row["unitPrice"].ToString())).ToString();
                       

                                    txtReceive.Text = (int.Parse(tot) - (int.Parse(pretot) * (proCount - 1))).ToString();


                                    con.Close();
                                    return;
                                }
                                else
                                {
                                }

                            }
                        }

                        proCount = 1;
                        DataRow addrow = sellTable.NewRow();
                        addrow[0] = sellrowindex;
                        addrow[1] = row["barcode"];
                        addrow[2] = row["stockName"];
                        addrow[3] = row["unitPrice"].ToString();
                        addrow[4] = 1;
                        addrow[5] = (decimal.Parse(row["unitPrice"].ToString()) * 1).ToString();
                        sellrowindex++;
                        sellTable.Rows.Add(addrow);
                        txtQuantity.Text = proCount.ToString();
                        txtReceive.Text = (int.Parse(Math.Round(decimal.Parse(row["unitPrice"].ToString()) * 1).ToString()) + int.Parse(txtReceive.Text)).ToString();
                    }


                    dgvProduct.DataSource = sellTable;

                }
                con.Close();
            }
        }

        private void btnOutgo_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblDate2.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
