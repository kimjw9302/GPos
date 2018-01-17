﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmOrderRequest : Form, ISearch, IAlter
    {

        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable cate1Table, cateF, cateNF, placeTable, productTable, orderTable;
        DataSet ds;
        DataRowCollection c1Row, cFRow, cNFRow, pRow;
        int noIndex = 1, qua = 1;
        static int quaTemp;
        static decimal payTemp;
        private int empID;

        int orderNum;
        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public frmOrderRequest()
        {
            InitializeComponent();
        }
        public frmOrderRequest(int empID) : this()
        {
            this.EmpID = empID;
        }
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            dgvOrder.Refresh();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                con = DBcontroller.Instance();
                using (var cmd = new SqlCommand("OrderNum",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CommitDate", date.Value.ToShortDateString());

                    con.Open();

                    SqlDataReader sqd = cmd.ExecuteReader();

                    while (sqd.Read())
                    {
                        cbOrderNum.Items.Add(sqd.GetString);
                    }
                }

            }
        }



        // 상품추가  productTable ---> orderTable
        private void btnAdd_Click(object sender, EventArgs e)
        {
            quaTemp = 0;
            payTemp = 0;


            for (int i = 0; i < dgvProducts.RowCount; i++)
            {
                //선택된거
                if ((string)dgvProducts.Rows[i].Cells[0].Value == "1")
                {
                    DataRow orderRow = orderTable.NewRow();
                    orderRow[0] = noIndex; noIndex++;//no 
                    orderRow[1] = dgvProducts.Rows[i].Cells[1].Value; // 바코드
                    orderRow[2] = dgvProducts.Rows[i].Cells[2].Value; //상품명
                    orderRow[3] = dgvProducts.Rows[i].Cells[3].Value; //단가
                    orderRow[4] = dgvProducts.Rows[i].Cells[4].Value; //원가
                    orderRow[5] = qua; //수량
                    orderRow[6] = decimal.Parse(dgvProducts.Rows[i].Cells[4].Value.ToString()) * qua; //총금액
                    orderRow[7] = dgvProducts.Rows[i].Cells[5].Value; //거래처


                    DataRow[] updateRow = orderTable.Select("바코드='" + dgvProducts.Rows[i].Cells[1].Value + "'");

                    if (updateRow.Length == 1)
                    {
                        updateRow[0]["수량"] = int.Parse(updateRow[0]["수량"].ToString()) + 1; //수량
                    }
                    else
                    {
                        orderTable.Rows.Add(orderRow);
                    }

                }
            }

            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                quaTemp += int.Parse(row.Cells[5].Value.ToString());
                payTemp += decimal.Parse(row.Cells[6].Value.ToString()) * int.Parse(row.Cells[5].Value.ToString());
            }

            txtTotalQua.Text = quaTemp.ToString();
            txtTotalPay.Text = payTemp.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dgvOrder.SelectedRows)
            {
                quaTemp -= int.Parse(item.Cells[5].Value.ToString());
                payTemp -= decimal.Parse(item.Cells[6].Value.ToString()) * int.Parse(item.Cells[5].Value.ToString());

                this.dgvOrder.Rows.Remove(item);
            }


            txtTotalQua.Text = quaTemp.ToString();
            txtTotalPay.Text = payTemp.ToString();

        }


        private void btnPSearch_Click(object sender, EventArgs e)
        {
            dgvProducts.Refresh();
            string place = cbPlace.SelectedItem.ToString();
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("OrderPlaceSearch", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@place", place);
                con.Open();

                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                productTable = ds.Tables[0];

                dgvProducts.DataSource = productTable;

            }
            con.Close();
        }

        private void cbCate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCate2.Items.Clear();
            if (cbCate1.SelectedIndex == 0)
            {
                foreach (DataRow item in cFRow)
                {
                    cbCate2.Items.Add(item[0]);
                    cbCate2Temp.Items.Add(item[1]);
                }

            }
            else if (cbCate1.SelectedIndex == 1)
            {
                foreach (DataRow item in cNFRow)
                {
                    cbCate2.Items.Add(item[0]);
                    cbCate2Temp.Items.Add(item[1]);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvProducts.Refresh();
            //데이터그리드뷰에 cate1, cate2와 일치하는 상품 띄워주면됨,

            int cate2 = int.Parse(cbCate2Temp.Items[cbCate2.SelectedIndex].ToString());
            //MessageBox.Show(cate2.ToString()); 
            con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("OrderSearch", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cate2", cate2);
                con.Open();

                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                productTable = ds.Tables[0];

                dgvProducts.DataSource = productTable;

            }
            con.Close();
        }

        //dgvOrder 다돌려서 있는값 수량 가져와서 값 넘겨주기
        //발주신청 누르는 버튼
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrder.Rows.Count > 0)
            {
                orderNum = int.Parse(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + new Random().Next(100, 900));

                con = DBcontroller.Instance();
                con.Open();
                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    string barcode = row.Cells[1].Value.ToString();
                    int Inven = int.Parse(row.Cells[5].Value.ToString());

                    using (var cmd = new SqlCommand("OrderProductUpdate", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        cmd.Parameters.AddWithValue("@actualInven", Inven);
                        cmd.Parameters.AddWithValue("@presentInven", Inven);

                        int i = cmd.ExecuteNonQuery();

                        if (i != 1)
                        {
                            MessageBox.Show("수량증가 실패");
                            con.Close();
                        }
                    }

                    //con.Close();
                }

                using (var cmd = new SqlCommand("OrdersInsert", con))
                {
                    decimal totalPrcie = decimal.Parse(txtTotalPay.Text);
                    DateTime date = DateTime.Now;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orderNum", orderNum);
                    cmd.Parameters.AddWithValue("@price", totalPrcie);
                    cmd.Parameters.AddWithValue("@commitDate", date);
                    cmd.Parameters.AddWithValue("@empNum", EmpID);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show(" 날짜 : " + DateTime.Now.ToShortDateString() + " [ 발주 성공] ");
                    }
                    else
                    {
                        MessageBox.Show("발주 실패");
                        con.Close();
                    }
                }




                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    string barcode = row.Cells[1].Value.ToString();
                    int Inven = int.Parse(row.Cells[5].Value.ToString());
                    string placeName = row.Cells[7].Value.ToString();
                    decimal costPrice = decimal.Parse(row.Cells[4].Value.ToString());

                    using (var cmd = new SqlCommand("OrderDetailInsert", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        cmd.Parameters.AddWithValue("@orderNum", orderNum);
                        cmd.Parameters.AddWithValue("@quantity", Inven);
                        cmd.Parameters.AddWithValue("@costPrice", costPrice);
                        cmd.Parameters.AddWithValue("@placeName", placeName);

                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                        }
                        else
                        {
                            MessageBox.Show("발주 상세 실패");
                            con.Close();
                        }

                    }
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("발주할 상품을 선택해주세요.");
                con.Close();
            }


        }


        private void frmOrderRequest_Load(object sender, EventArgs e)
        {
            OrderTableMake();
            ProductTableMake();
            dgvProducts.DataSource = productTable;
            dgvOrder.DataSource = orderTable;
            con = DBcontroller.Instance();

            using (var cmd = new SqlCommand("GetProRegInfo", con))
            {
                con.Open();

                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                cate1Table = ds.Tables[0];

                placeTable = ds.Tables[3];
                c1Row = cate1Table.Rows;

                pRow = placeTable.Rows;
                foreach (DataRow item in pRow)
                {
                    cbPlace.Items.Add(item[0]);
                }

                foreach (DataRow item in c1Row)
                {
                    switch ((string)item[0])
                    {
                        case "F":
                            cbCate1.Items.Add("식품");
                            cateF = ds.Tables[1];
                            cFRow = cateF.Rows;
                            break;
                        case "NF":
                            cbCate1.Items.Add("비식품");
                            cateNF = ds.Tables[2];
                            cNFRow = cateNF.Rows;
                            break;

                    }
                }
            }

            con.Close();
        }

        private void OrderTableMake()
        {
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.HeaderText = "선택";
            check.FalseValue = "0";
            check.TrueValue = "1";
            dgvProducts.Columns.Insert(0, check);

            orderTable = new DataTable();

            orderTable.Columns.Add("No");
            orderTable.Columns.Add("바코드");
            orderTable.Columns.Add("상품명");
            orderTable.Columns.Add("단가");
            orderTable.Columns.Add("원가");
            orderTable.Columns.Add("수량");
            orderTable.Columns.Add("총금액");
            orderTable.Columns.Add("거래처");

        }
        private void ProductTableMake()
        {
            productTable = new DataTable();

            productTable.Columns.Add("상품명");
            productTable.Columns.Add("바코드");
            productTable.Columns.Add("단가");
            productTable.Columns.Add("원가");
            productTable.Columns.Add("거래처");

        }
    }
}
