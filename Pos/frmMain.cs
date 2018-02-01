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

namespace Pos
{
    public partial class frmMain : Form
    {

        private SqlConnection con;
        public string empName;
        public int empId;
        public DateTime sdate;
        public TextBox current;
        private DataTable sellTable;
        public ArrayList eventList = new ArrayList();
        DataGridView dataGridView;
        TextBox t1, t2, t3, t4, t5;


        public DataGridView DataGridView { get => dataGridView; set => dataGridView = value; }
        public TextBox T1 { get => t1; set => t1 = value; }
        public TextBox T2 { get => t2; set => t2 = value; }
        public TextBox T3 { get => t3; set => t3 = value; }
        public TextBox T4 { get => t4; set => t4 = value; }
        public TextBox T5 { get => t5; set => t5 = value; }
        public DataTable SellTable1 { get => sellTable; set => sellTable = value; }

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
            sellTable = new DataTable();
            sellTable.Columns.Add("No");
            sellTable.Columns.Add("바코드");
            sellTable.Columns.Add("상품명");
            sellTable.Columns.Add("단가");
            sellTable.Columns.Add("수량");
            sellTable.Columns.Add("할인");
            sellTable.Columns.Add("비고");
            sellTable.Columns.Add("이벤트번호");
            sellTable.Columns.Add("이벤트내용");
            sellTable.Columns.Add("이벤트그룹");
        }
        //로드.
        private void frmMain_Load(object sender, EventArgs e)
        {
            dataGridView = dgvProduct;

            t1 = txtDiscount;
            t2 = txtPaymentList;
            t3 = txtChange;
            t4 = txtTotal;
            t5 = txtReceived;
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
            dgvProduct.Columns[0].Width = 80;
            dgvProduct.Columns[1].Width = 170;
            dgvProduct.Columns[2].Width = 280;
            dgvProduct.Columns[3].Width = 100;
            dgvProduct.Columns[4].Width = 100;
            dgvProduct.Columns[5].Width = 100;
            dgvProduct.Columns[6].Width = 100;
            dgvProduct.Columns[7].Visible = false;
            dgvProduct.Columns[8].Visible = false;
            dgvProduct.Columns[9].Visible = false;
            dgvProduct.DefaultCellStyle.BackColor = Color.FromArgb(128, Color.White);

            try
            {
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
                        frmNotice fn = new frmNotice(ds.Tables[0], empId);
                        fn.Owner = this;
                        fn.ShowDialog();
                    }
                }
            }
            catch (Exception msg)
            {
                con.Close();
                MessageBox.Show(msg.Message);
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
            if (sellTable.Rows.Count > 0)
            {
                Sell s = Sell.Load();
                s.Tot = int.Parse(txtTotal.Text);
                s.Sale = int.Parse(txtDiscount.Text);
                s.Changemoney = (s.Tot - decimal.Parse(s.Sale.ToString()));
                frmPayment fp = new frmPayment(txtReceived.Text, 0);
                fp.Owner = this;
                s.EmpId = empId;
                fp.ShowDialog();

            }
            else
            {
                MessageBox.Show("바코드를 찍어주세요");

            }
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            if (sellTable.Rows.Count > 0)
            {
                Sell s = Sell.Load();
                s.Tot = int.Parse(txtTotal.Text);
                s.Sale = int.Parse(txtDiscount.Text);
                s.EmpId = empId;
                s.Changemoney = (s.Tot - decimal.Parse(s.Sale.ToString()));
                frmPayment fp = new frmPayment(txtReceived.Text, 1);
                fp.Owner = this;
                fp.ShowDialog();
            }
            else
            {
                MessageBox.Show("바코드를 찍어주세요");

            }

        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            Sell s = Sell.Load();
            if (sellTable.Rows.Count > 0)
            {
                if (s.SavePoint == 0)
                {
                    frmPoint fpp = new frmPoint();
                    fpp.Owner = this;
                    fpp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("적립 후 사용 불가");
                }
            }
            else
            {
                MessageBox.Show("바코드를 찍어주세요");
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            con = DBcontroller.Instance();
            con.Open();

            using (var cmd = new SqlCommand("SelectEmployees", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empNum", empId);

                var sdr = cmd.ExecuteScalar();
                if (sdr.ToString() == "1")
                {
                    con.Close();
                    new frmOrderRequest(empId).ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("접근이 불가능합니다.");
                    con.Close();
                }
            }
        }
        private void btnEtc_Click(object sender, EventArgs e)
        {
            new frmEtc().ShowDialog();
        }
        //담당자 변경 클릭시 -> 

        private void btnEmployeeChange_Click(object sender, EventArgs e)
        {
            if (sellTable.Rows.Count >= 1)
            {
                MessageBox.Show("판매도중에는 교대를 하실 수 없습니다.");
            }
            else
            {
                frmEmployeeRotaion fer = new frmEmployeeRotaion(sdate);
                fer.Owner = this;
                fer.EmpName = empName;
                fer.EmpId = empId;
                fer.ShowDialog();
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //계산기는 싱글톤 패턴으로
            frmCalculator fc = frmCalculator.Instance();
            fc.Show();
            fc.Focus();
        }
        private void txtProduct_Click(object sender, EventArgs e)
        {
            txtProduct.Text = "";
            current = (TextBox)sender;

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
        private void txtTotal_Click(object sender, EventArgs e)
        {
            txtProduct.Focus();
            current = txtProduct;
        }
        private void txtDiscount_Click(object sender, EventArgs e)
        {
            txtProduct.Focus();
            current = txtProduct;
        }
        private void txtChange_Click(object sender, EventArgs e)
        {
            txtProduct.Focus();
            current = txtProduct;
        }


        #region 숫자패드버튼클릭
        private void btnSeven_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "7";
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "9";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "6";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            current = txtProduct;
            current.Text += "3";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text.Length == 0 || txtProduct.Text[0] == '0')
            {
                current.Text += "";
            }
            else
            {
                current.Text += "0";
            }
        }

        private void btnHundred_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text.Length == 0 || txtProduct.Text[0] == '0')
            {
                current.Text += "";
            }
            else
            {
                current.Text += "00";
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            current.Text = "";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (sellTable.Rows.Count <= 0)
            {

            }
            else
            {
                int index = dataGridView.CurrentCell.RowIndex;
                string localbarcode = dgvProduct[1, index].Value.ToString();
                string localeventNum = dgvProduct[9, index].Value.ToString();
                string price = dgvProduct[3, index].Value.ToString();
                string eventcon = dgvProduct[8, index].Value.ToString();
                int quan = int.Parse(dgvProduct[4, index].Value.ToString());
                DataRow[] update1 = sellTable.Select("바코드='" + localbarcode + "'");
                DataRow[] update2 = sellTable.Select("이벤트그룹='" + localeventNum + "'");

                if (quan == 1)
                {

                    sellTable.Rows[index].Delete();
                    int count = 1;
                    foreach (DataRow row in sellTable.Rows)
                    {
                        row[0] = count;
                        count++;
                    }
                    txtTotal.Text = (int.Parse(txtTotal.Text) - decimal.Parse(price)).ToString();
                    txtReceived.Text = (int.Parse(txtTotal.Text) + int.Parse(txtDiscount.Text)).ToString();
                }
                else
                {
                    if (update1.Length != 0 && update2.Length != 0)
                    {
                        int totCount = 0;
                        for (int i = 0; i < update2.Length; i++)
                        {
                            totCount += int.Parse(update2[i]["수량"].ToString());
                        }
                        DataRow[] update3 = sellTable.Select("바코드 ='" + localbarcode + "' AND 이벤트그룹='" + localeventNum + "'");

                        update3[0]["수량"] = decimal.Parse(update3[0]["수량"].ToString()) - 1;

                        txtTotal.Text = (decimal.Parse(txtTotal.Text) - decimal.Parse(price)).ToString();
                        totCount -= 1;
                        if (eventcon == "없음")
                        {
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        }
                        //1+1인경우
                        else if (eventcon == "1+1")
                        {
                            // 몫 - 나머지 : 
                            int mok = totCount / 2;
                            int namege = totCount % 2;
                            if (namege == 1)
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse(price);
                                txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("+" + price.ToString())).ToString();
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }
                            else
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }


                        }
                        //2+1인경우
                        else if (eventcon == "2+1")
                        {
                            int mok = totCount / 3;
                            int namege = totCount % 3;
                            if (namege == 1)
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }
                            else if (namege == 2)
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse(update3[0]["단가"].ToString());
                                txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse(price)).ToString();
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + int.Parse(txtDiscount.Text)).ToString();
                            }
                            else if (namege == 0)
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }
                        }
                        //%할인
                        else
                        {
                            MessageBox.Show("처음");
                            txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                            txtPaymentList.Text += "상품명 : " + update3[0]["상품명"] + "\r\n";
                            txtPaymentList.Text += "이벤트 내용 : " + eventcon + "\r\n";
                            string dis = eventcon.Substring(0, eventcon.IndexOf('%'));
                            dis = (int.Parse(dis) * 0.01).ToString();

                            txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("+" + update3[0]["단가"].ToString()) * decimal.Parse(dis)).ToString();
                            update3[0]["할인"] = (decimal.Parse("-" + update3[0]["단가"].ToString()) * decimal.Parse(dis));
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            txtTotal.Text = (decimal.Parse(txtTotal.Text)).ToString();
                        }
                    }
                    else if (update1.Length != 0 && update2.Length == 0)
                    {
                        //바코드가 selltable에 있고, 이벤트 번호가 존재할때!
                        //우선 이벤트 번호가있는 상품의 수량을 알아야함!그리고 나눠!서 가격을바꿔줭~
                        int totCount = 0;
                        //바코드가 없고, 이벤트번호 있고

                        for (int i = 0; i < update2.Length; i++)
                        {
                            totCount += int.Parse(update2[i]["수량"].ToString());
                        }
                        
                        DataRow[] update3 = sellTable.Select("바코드 ='" + localbarcode + "' AND 이벤트그룹='" + localeventNum + "'");
                        if (update3.Length == 0)
                        {
                            update3 = sellTable.Select("바코드 ='" + localbarcode + "'");
                        }
                        update3[0]["수량"] = decimal.Parse(update3[0]["수량"].ToString()) - 1;

                        txtTotal.Text = (decimal.Parse(txtTotal.Text) - decimal.Parse(price)).ToString();
                        totCount -= 1;
                        if (eventcon == "없음")
                        {
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        }
                        //1+1인경우
                        else if (eventcon == "1+1")
                        {
                            // 몫 - 나머지 : 
                            int mok = totCount / 2;
                            int namege = totCount % 2;
                            if (namege == 1)
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse(price);
                                txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("+" + price.ToString())).ToString();
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }
                            else
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }


                        }
                        //2+1인경우
                        else if (eventcon == "2+1")
                        {
                            int mok = totCount / 3;
                            int namege = totCount % 3;
                            if (namege == 1)
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }
                            else if (namege == 2)
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse(update3[0]["단가"].ToString());
                                txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse(price)).ToString();
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + int.Parse(txtDiscount.Text)).ToString();
                            }
                            else if (namege == 0)
                            {
                                update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }
                        }
                        //%할인
                        else
                        {
                            MessageBox.Show("처음");
                            txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                            txtPaymentList.Text += "상품명 : " + update3[0]["상품명"] + "\r\n";
                            txtPaymentList.Text += "이벤트 내용 : " + eventcon + "\r\n";
                            string dis = eventcon.Substring(0, eventcon.IndexOf('%'));
                            dis = (int.Parse(dis) * 0.01).ToString();

                            txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("+" + update3[0]["단가"].ToString()) * decimal.Parse(dis)).ToString();
                            update3[0]["할인"] = (decimal.Parse("-" + update3[0]["단가"].ToString()) * decimal.Parse(dis));
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            txtTotal.Text = (decimal.Parse(txtTotal.Text)).ToString();
                        }
                    }
                }
            }
        }


        private void btnUp_Click(object sender, EventArgs e)
        {
            if (sellTable.Rows.Count <= 0)
            {

            }
            else
            {
                int index = dataGridView.CurrentCell.RowIndex;
                string localbarcode = dgvProduct[1, index].Value.ToString();
                string localeventNum = dgvProduct[9, index].Value.ToString();
                string price = dgvProduct[3, index].Value.ToString();
                string eventcon = dgvProduct[8, index].Value.ToString(); 
                DataRow[] update1 = sellTable.Select("바코드='" + localbarcode + "'");//selltable에 바코드가 존재하는지
                DataRow[] update2 = sellTable.Select("이벤트그룹='" + localeventNum + "'");//selltable에 이벤트번호가 있는지
                if (update1.Length != 0 && update2.Length != 0)
                {
                    //바코드가 selltable에 있고, 이벤트 번호가 존재할때!
                    //우선 이벤트 번호가있는 상품의 수량을 알아야함!그리고 나눠!서 가격을바꿔줭~
                    int totCount = 0;
                    //바코드가 없고, 이벤트번호 있고
                    MessageBox.Show("처음1");
                    for (int i = 0; i < update2.Length; i++)
                    {
                        totCount += int.Parse(update2[i]["수량"].ToString());
                    }
                    DataRow[] update3 = sellTable.Select("바코드 ='" + localbarcode + "' AND 이벤트그룹='" + localeventNum + "'");
                    update3[0]["수량"] = int.Parse(update3[0]["수량"].ToString()) + 1;

                    txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(price)).ToString();
                    totCount += 1;
                    if (eventcon == "없음")
                    {
                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                    }
                    //1+1인경우
                    else if (eventcon == "1+1")
                    {


                        // 몫 - 나머지 : 
                        int mok = totCount / 2;
                        int namege = totCount % 2;
                        if (namege == 1)
                        {

                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        }
                        else
                        {

                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse("-" + update3[0]["단가"].ToString());
                            txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + price.ToString())).ToString();
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();

                        }


                    }
                    //2+1인경우
                    else if (eventcon == "2+1")
                    {

                        int mok = totCount / 3;
                        int namege = totCount % 3;
                        if (namege == 1)
                        {

                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        }
                        else if (namege == 2)
                        {

                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();

                        }
                        else if (namege == 0)
                        {

                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse("-" + update3[0]["단가"].ToString());
                            txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + price)).ToString();
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();

                        }

                    }
                    else
                    {
                        MessageBox.Show("처음");
                        txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                        txtPaymentList.Text += "상품명 : " + update3[0]["상품명"] + "\r\n";
                        txtPaymentList.Text += "이벤트 내용 : " + eventcon + "\r\n";
                        string dis = eventcon.Substring(0, eventcon.IndexOf('%'));
                        dis = (int.Parse(dis) * 0.01).ToString();
                        txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + update3[0]["단가"].ToString()) * decimal.Parse(dis)).ToString();
                        update3[0]["할인"] = (decimal.Parse("-" + update3[0]["단가"].ToString()) * decimal.Parse(dis));
                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        txtTotal.Text = (decimal.Parse(txtTotal.Text)).ToString();
                    }
                }
                            else if (update1.Length != 0 && update2.Length == 0)
                {
                    MessageBox.Show("처음2");

                    //바코드가 selltable에 있고, 이벤트 번호가 존재할때!
                    //우선 이벤트 번호가있는 상품의 수량을 알아야함!그리고 나눠!서 가격을바꿔줭~
                    int totCount = 0;
                    //바코드가 없고, 이벤트번호 있고

                    for (int i = 0; i < update2.Length; i++)
                    {
                        totCount += int.Parse(update2[i]["수량"].ToString());
                    }
                    DataRow[] update3 = sellTable.Select("바코드 ='" + localbarcode + "' AND 이벤트그룹='" + localeventNum + "'");
                    if (update3.Length == 0)
                    {
                        update3 = sellTable.Select("바코드 ='" + localbarcode + "'");
                    }

                    MessageBox.Show(totCount+"");
                    update3[0]["수량"] = int.Parse(update3[0]["수량"].ToString()) + 1;
                    txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(price)).ToString();
                    totCount += 1;
                    MessageBox.Show(totCount + "");

                    if (eventcon == "없음")
                    {

                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                    }
                    //1+1인경우
                    else if (eventcon == "1+1")
                    {
                        // 몫 - 나머지 : 
                        int mok = totCount / 2;
                        int namege = totCount % 2;
                        
                        if (namege == 1)
                        {
                            MessageBox.Show("1-1");
                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("1-2");
                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse("-" + update3[0]["단가"].ToString());
                            txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + price.ToString())).ToString();
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();

                        }
                    }
                    //2+1인경우
                    else if (eventcon == "2+1")
                    {

                        int mok = totCount / 3;
                        int namege = totCount % 3;
                        if (namege == 1)
                        {
                            MessageBox.Show("1-3");
                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        }
                        else if (namege == 2)
                        {
                            MessageBox.Show("1-4");
                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();

                        }
                        else if (namege == 0)
                        {
                            MessageBox.Show("1-5");
                            update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse("-" + update3[0]["단가"].ToString());
                            txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + price)).ToString();
                            txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        }
                    }
                    else
                    {


                        MessageBox.Show("1-6");
                        string dis = eventcon.Substring(0, eventcon.IndexOf('%'));
                        MessageBox.Show(dis);
                        dis = (int.Parse(dis) * 0.01).ToString();
                        txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + update3[0]["단가"].ToString()) * decimal.Parse(dis)).ToString();
                        update3[0]["할인"] = int.Parse(update3[0]["수랑"].ToString())*(decimal.Parse("-" + update3[0]["단가"].ToString()) * decimal.Parse(dis));
                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                        txtTotal.Text = (decimal.Parse(txtTotal.Text)).ToString();
                    }

                }
             

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                txtProduct.Text = txtProduct.Text.Substring(0, txtProduct.Text.Length - 1);
            }
            catch (Exception)
            {
            }
        }

        #endregion

        private void txtReceived_Click(object sender, EventArgs e)
        {
            txtProduct.Focus();
            txtProduct.Text = "";
            current = txtProduct;
        }
        private void txtReceive_Click(object sender, EventArgs e)
        {
            txtProduct.Focus();
            txtProduct.Text = "";
            current = txtProduct;
        }
        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPaymentList.Text = "";
                string scanbarcode = txtProduct.Text;
                con = DBcontroller.Instance();
                try
                {
                    con.Open();


                    if (txtProduct.Text.Length == 18)
                    {
                        scanbarcode = txtProduct.Text.Substring(0, 13);
                    }

                    using (var cmd = new SqlCommand("EventListProduct", con))
                    {
                        eventList.Clear();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@barcode", scanbarcode);
                        var sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            if (sdr["eventNum"].ToString() != "0")
                            {

                                eventList.Add(sdr["productName"].ToString());
                            }

                        }
                        sdr.Close();
                        con.Close();
                    }
                }
                catch (Exception msg)
                {
                    con.Close();
                    MessageBox.Show(msg.Message);

                }


                //try
                //{
                    con.Open();
                using (var cmd = new SqlCommand("ScanBarcode", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@barcode", scanbarcode);
                    var sdr = cmd.ExecuteReader();
                    if (!sdr.HasRows)
                    {
                        //로우가 없다는것 -> 바코드가 존재하지않음 
                        MessageBox.Show("입력하신 바코드가 존재하지 않습니다.");
                        txtProduct.Text = "";
                        con.Close();
                        sdr.Close();
                        return;
                    }
                    while (sdr.Read())
                    {
                        if (sdr.HasRows)
                        {
                            string localbarcode = sdr["barcode"].ToString();
                            string localeventNum = sdr["eventgroup"].ToString();
                            string imgurl = barcode_search.image(txtProduct.Text);
                            if (imgurl.Contains("noimage"))
                            {
                                string path = Application.StartupPath;
                                pboxProducts.Load(@"..\..\Resources\goodee24.png");
                            }
                            else { 
                            pboxProducts.ImageLocation = barcode_search.image(txtProduct.Text);
                            }
                            if (txtProduct.Text.Length == 18)
                            {
                                string barcode = txtProduct.Text;
                                string cut = barcode.Substring(13, 1);
                                string datestr = barcode.Substring(14, barcode.Length - 14);
                                if (cut == "2")
                                {
                                    DateTime expirateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, int.Parse(datestr.Substring(2, datestr.Length - 2)), int.Parse(datestr.Substring(0, 2)), 0, 0);
                                    int comparedate = DateTime.Compare(expirateTime, DateTime.Now);
                                    if (comparedate >= 0)
                                    {

                                    }
                                    else if (comparedate < 0)
                                    {
                                        con.Close();
                                        MessageBox.Show("유통기한이 지났습니다");
                                        return;
                                    }

                                }
                                else if (cut == "4")
                                {
                                    DateTime expirateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, int.Parse(datestr.Substring(0, 2)), int.Parse(datestr.Substring(2, datestr.Length - 2)), 0, 0);

                                    int comparedate = DateTime.Compare(expirateTime, DateTime.Now);
                                    if (comparedate >= 0)
                                    {
                                    }
                                    else if (comparedate < 0)
                                    {
                                        con.Close();
                                        MessageBox.Show("유통기한이 지났습니다");
                                        return;
                                    }
                                }
                            }
                            //로우가 있다 -> 일치하는 바코드가 존재한다
                            DataRow[] update1 = sellTable.Select("바코드='" + txtProduct.Text + "'");//selltable에 바코드가 존재하는지
                            DataRow[] update2 = sellTable.Select("이벤트그룹='" + localeventNum + "'");//selltable에 이벤트번호가 있는지
                                                                                                  //1.바코드 있고, 이벤트 그룹이 같을경우
                                                                                                  //2.바코드 있고, 이벤트 그룹 없을 경우
                                                                                                  //3 바코드 없으면 , 이벤트 그룹 같음
                                                                                                  //4. 바코드 없고, 이벤트 번호 그룹 없을경우
                            MessageBox.Show("update1 : "+update1.Length +" , update2 : "+update2.Length);
                            
                            if (update1.Length == 0 && update2.Length == 0)
                            {
                                //바코드가 없고, 이벤트번호 없고
                                DataRow newRow = sellTable.NewRow();
                                newRow["No"] = sellTable.Rows.Count + 1; //No.
                                newRow["바코드"] = txtProduct.Text; //바코드
                                newRow["상품명"] = sdr["productName"];
                                newRow["단가"] = sdr["unitPrice"];
                                newRow["수량"] = 1;
                                newRow["할인"] = 0;
                                newRow["이벤트번호"] = sdr["eventNum"];
                                newRow["이벤트내용"] = sdr["content"];
                                newRow["이벤트그룹"] = sdr["eventgroup"];
                                sellTable.Rows.Add(newRow);
                                txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(sdr["unitPrice"].ToString())).ToString();
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();

                                if (sdr["content"].ToString() == "없음")
                                {
                                    MessageBox.Show("1-1");
                                    newRow["할인"] = 0;
                                    txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                }
                                else if (sdr["content"].ToString() == "1+1")
                                {

                                    MessageBox.Show("1-2");

                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";

                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";

                                    txtPaymentList.Text += "이벤트 상품 : ";
                                    for (int i = 0; i < eventList.Count - 1; i++)
                                    {
                                        txtPaymentList.Text += eventList[i].ToString();
                                    }


                                }
                                else if (sdr["content"].ToString() == "2+1")
                                {
                                    MessageBox.Show("1-3");

                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 상품 : ";
                                    for (int i = 0; i < eventList.Count - 1; i++)
                                    {
                                        txtPaymentList.Text += eventList[i].ToString();
                                    }
                                }
                                //%할인
                                else
                                {
                                    MessageBox.Show("1-4");
                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";
                                    string dis = sdr["discount"].ToString().Substring(0, sdr["discount"].ToString().IndexOf('%'));
                                    dis = (int.Parse(dis) * 0.01).ToString();
                                    txtDiscount.Text = (decimal.Parse("-" + sdr["unitPrice"]) * decimal.Parse(dis)).ToString();
                                    newRow["할인"] = (decimal.Parse("-" + sdr["unitPrice"]) * decimal.Parse(dis));
                                    txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                    txtTotal.Text = (decimal.Parse(txtTotal.Text) ).ToString();
                                }
                                for (int i = 0; i < eventList.Count; i++)
                                {
                                    txtPaymentList.Text += eventList[i].ToString();
                                }
                            }
                            else if (update1.Length == 0 && update2.Length != 0)
                            {
                                int totCount = 1;
                                //바코드가 없고, 이벤트번호 있고
                                DataRow[] update4 = sellTable.Select("이벤트그룹='" + localeventNum + "'");
                                for (int i = 0; i < update4.Length; i++)
                                {
                                    totCount = int.Parse(update4[i]["수량"].ToString());
                                }
                                DataRow newRow = sellTable.NewRow();
                                newRow["No"] = sellTable.Rows.Count + 1; //No.
                                newRow["바코드"] = txtProduct.Text; //바코드
                                newRow["상품명"] = sdr["productName"];
                                newRow["단가"] = sdr["unitPrice"];
                                newRow["수량"] = 1;
                                newRow["이벤트내용"] = sdr["content"];
                                newRow["이벤트그룹"] = sdr["eventgroup"];
                                //1+1인경우
                                if (sdr["content"].ToString() == "없음")
                                {
                                    MessageBox.Show("2-1");

                                    newRow["할인"] = 0;
                                    txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                }
                                else if (sdr["content"].ToString() == "1+1")
                                {
                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 상품 : ";
                                    for (int i = 0; i < eventList.Count; i++)
                                    {
                                        txtPaymentList.Text += eventList[i].ToString();
                                    }
                                    if (totCount % 2 == 0)
                                    {
                                        MessageBox.Show("2-2");
                                        newRow["할인"] = 0;
                                        txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(sdr["unitPrice"].ToString())).ToString();
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                    }
                                    else if (totCount % 2 != 0)
                                    {
                                        MessageBox.Show("2-3");

                                        newRow["할인"] = decimal.Parse("-" + sdr["unitPrice"]);
                                        txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(sdr["unitPrice"].ToString())).ToString();
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse("-" + sdr["unitPrice"].ToString())).ToString();
                                        txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + sdr["unitPrice"].ToString())).ToString();
                                    }
                                }
                                //2+1인경우
                                else if (sdr["content"].ToString() == "2+1")
                                {

                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 상품 : ";

                                    for (int i = 0; i < eventList.Count; i++)
                                    {
                                        txtPaymentList.Text += eventList[i].ToString();
                                    }
                                    if (totCount % 3 == 1)
                                    {
                                        MessageBox.Show("2-4");

                                        newRow["할인"] = 0;
                                        txtDiscount.Text = "0";
                                        txtReceived.Text = (decimal.Parse(txtReceived.Text) + (decimal.Parse(txtTotal.Text))).ToString();
                                        txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(sdr["unitPrice"].ToString())).ToString();

                                    }
                                    else if (totCount % 3 == 2)
                                    {
                                        MessageBox.Show("2-5");

                                        newRow["할인"] = decimal.Parse("-" + sdr["unitPrice"]);
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                        txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + sdr["unitPrice"].ToString())).ToString();

                                    }
                                    else if (totCount % 3 == 0)
                                    {
                                        MessageBox.Show("2-6");

                                        newRow["할인"] = 0;
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                        txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(sdr["unitPrice"].ToString())).ToString();
                                    }
                                }
                                //%할인
                                else
                                {
                                        MessageBox.Show("2-7");

                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";
                                    string dis = sdr["discount"].ToString().Substring(0, sdr["discount"].ToString().IndexOf('%'));
                                    dis = (int.Parse(dis) * 0.01).ToString();
                                    MessageBox.Show(dis);
                                    newRow["할인"] = (decimal.Parse("-" + sdr["unitPrice"]) * decimal.Parse(dis));
                                    txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                    txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse("-" + sdr["unitPrice"])).ToString();
                                }

                                newRow["이벤트번호"] = sdr["eventNum"];
                                sellTable.Rows.Add(newRow);
                            }
                            else if (update1.Length != 0 && update2.Length != 0)
                            {
                                //바코드가 selltable에 있고, 이벤트 번호가 존재할때!
                                //우선 이벤트 번호가있는 상품의 수량을 알아야함!그리고 나눠!서 가격을바꿔줭~
                                int totCount = 0;
                                //바코드가 없고, 이벤트번호 있고

                                for (int i = 0; i < update2.Length; i++)
                                {
                                    totCount += int.Parse(update2[i]["수량"].ToString());
                                }
                                DataRow[] update3 = sellTable.Select("바코드 ='" + txtProduct.Text + "' AND 이벤트그룹='" + localeventNum + "'");
                                update3[0]["수량"] = decimal.Parse(update3[0]["수량"].ToString()) + 1;

                                txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(sdr["unitPrice"].ToString())).ToString();
                                totCount += 1;
                                if (sdr["content"].ToString() == "없음")
                                {
                                    MessageBox.Show("3-1");

                                    txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                }
                                //1+1인경우
                                else if (sdr["content"].ToString() == "1+1")
                                {
                              

                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 상품 : ";

                                    for (int i = 0; i < eventList.Count; i++)
                                    {

                                        txtPaymentList.Text += eventList[i].ToString();
                                    }
                                    // 몫 - 나머지 : 
                                    int mok = totCount / 2;
                                    int namege = totCount % 2;
                                    if (namege == 1)
                                    {
                                        MessageBox.Show("3-2");
                                        update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("3-3");
                                        update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse("-" + update3[0]["단가"].ToString());
                                        txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + sdr["unitPrice"].ToString())).ToString();
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                    }
                                }
                                //2+1인경우
                                else if (sdr["content"].ToString() == "2+1")
                                {
                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 상품 : ";
                                    for (int i = 0; i < eventList.Count; i++)
                                    {
                                        txtPaymentList.Text += eventList[i].ToString();
                                    }
                                    int mok = totCount / 3;
                                    int namege = totCount % 3;
                                    if (namege == 1)
                                    {
                                        MessageBox.Show("3-4");
                                        update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                    }
                                    else if (namege == 2)
                                    {
                                        MessageBox.Show("3-5");
                                        update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString());
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();

                                    }
                                    else if (namege == 0)
                                    {
                                        MessageBox.Show("3-6");
                                        update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + decimal.Parse("-" + update3[0]["단가"].ToString());
                                        txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + sdr["unitPrice"].ToString())).ToString();
                                        txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                    }
                                }
                                //%할인
                                else
                                {
                                    MessageBox.Show("3-7");
                                    txtPaymentList.Text = "★★★★★★이벤트정보★★★★★\r\n";
                                    txtPaymentList.Text += "상품명 : " + sdr["productName"].ToString() + "\r\n";
                                    txtPaymentList.Text += "이벤트 내용 : " + sdr["content"].ToString() + "\r\n";
                                    string dis = sdr["discount"].ToString().Substring(0, sdr["discount"].ToString().IndexOf('%'));
                                    dis = (int.Parse(dis) * 0.01).ToString();
                                    txtDiscount.Text = (decimal.Parse(txtDiscount.Text) + decimal.Parse("-" + sdr["unitPrice"]) * decimal.Parse(dis)).ToString();
                                    update3[0]["할인"] = decimal.Parse(update3[0]["할인"].ToString()) + (decimal.Parse("-" + sdr["unitPrice"]) * decimal.Parse(dis));
                                    txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                                    txtTotal.Text = (decimal.Parse(txtTotal.Text)).ToString();
                                }
                            }

                            else if (update1.Length != 0 && update2.Length == 0)
                            {
                                MessageBox.Show("4-1");
                                update1[0]["수량"] = decimal.Parse(update1[0]["수량"].ToString()) + 1;
                                txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(sdr["unitPrice"].ToString())).ToString();
                                txtReceived.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(txtDiscount.Text)).ToString();
                            }
                        }
                    }
                    dgvProduct.DataSource = sellTable;
                    txtProduct.Text = "";
                }
                con.Close();
                //}
                //catch (Exception msg)
                //{
                //    con.Close();
                //    MessageBox.Show(msg.Message);
                //}
            }
        }
        private void btnOutgo_Click(object sender, EventArgs e)
        {
            if (sellTable.Rows.Count <= 0)
            {
                frmWait fw = new frmWait(empName);
                fw.ShowDialog();
            }
            else
            {
                MessageBox.Show("현재 상태에서 불가능");
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate2.Text = DateTime.Now.ToLongTimeString();
        }
        private void btnPointSave_Click(object sender, EventArgs e)
        {
            Sell s = Sell.Load();
            if (sellTable.Rows.Count > 0)
            {
                if (s.SavePoint != 0)
                {
                    MessageBox.Show("포인트 중복 적립 불가");
                    return;
                }
                if (s.Pointmoney == 0)
                {
                    frmPointSave fp = new frmPointSave(txtReceived.Text);
                    fp.Owner = this;
                    fp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("사용 후 적립 불가");
                }
            }
            else
            {
                MessageBox.Show("바코드를 찍어주세요");
            }
        }

        private void btnTotalCancel_Click(object sender, EventArgs e)
        {
            sellTable.Rows.Clear();
            txtPaymentList.Text = "";
            Sell.Clear();
            Init();
            pboxProducts.Load(@"..\..\Resources\goodee24.png");
        }
        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (sellTable.Rows.Count <= 0)
            {
                frmSalesinquiry fsq = new frmSalesinquiry();
                fsq.ShowDialog();
            }
        }
        //매장정보변경 버튼 클릭 
        private void btnSetting_Click(object sender, EventArgs e)
        {
            //1. 현재 포스 담당자의 번호가 사장이상 일 시 버튼이 작동하게 만든다. 
            //2. DB와 연결 후 현재 담당자의 번호가 점장인지 확인.
            try
            {
                con = DBcontroller.Instance();
                con.Open();

                using (var cmd = new SqlCommand("SelectEmployees", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empNum", empId);

                    var sdr = cmd.ExecuteScalar();
                    if (sdr.ToString() == "1")
                    {
                        con.Close();
                        new frmStoreInfo().ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("접근이 불가능합니다.");
                        con.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }


        }

        public void Init()
        {
            sellTable.Rows.Clear();
            txtTotal.Text = "0";
            txtProduct.Text = "";
            txtReceived.Text = "0";
            txtChange.Text = "0";
            txtDiscount.Text = "0";
        }
    }
}
