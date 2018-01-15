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

namespace Pos
{
    public partial class frmOrderRequest : Form, ISearch, IAlter
    {

        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable cate1Table, cateF, cateNF, placeTable ,productTable , orderTable;
        DataSet ds;
        DataRowCollection c1Row, cFRow, cNFRow, pRow;
        int noIndex = 1, qua = 1;
        static int quaTemp;
        static decimal payTemp;

        public frmOrderRequest()
        {
            InitializeComponent();
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            dgvOrder.Refresh();
        }
        


        // 상품추가  productTable ---> orderTable
        private void btnAdd_Click(object sender, EventArgs e)
        {
            quaTemp = 0;
            payTemp = 0;
            
            foreach (DataGridViewRow row in dgvProducts.SelectedRows)
            {

                DataRow orderRow = orderTable.NewRow();
                orderRow[0] = noIndex; noIndex++;//no 
                orderRow[1] = row.Cells[0].Value; // 바코드
                orderRow[2] = row.Cells[1].Value; //상품명
                orderRow[3] = row.Cells[2].Value; //단가
                orderRow[4] = row.Cells[3].Value; //원가
                orderRow[5] = qua; //수량
                orderRow[6] = decimal.Parse(row.Cells[3].Value.ToString()) * qua; //총금액
                orderRow[7] = row.Cells[4].Value; //거래처
                

                //바코드로 변경해야됨
                DataRow[] updateRow = orderTable.Select("바코드='" + row.Cells[0].Value + "'");

                if (updateRow.Length == 1)
                {
                    updateRow[0]["수량"] = int.Parse(updateRow[0]["수량"].ToString())+1; //수량
                }
                else
                {
                    orderTable.Rows.Add(orderRow);
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
            using (var cmd = new SqlCommand("OrderSearch",con))
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
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrder.Rows.Count > 0)
            {
                con = DBcontroller.Instance();
                
                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    using (var cmd = new SqlCommand("OrderProductUpdate", con))
                    {
                        con.Open();
                        string barcode = row.Cells[1].Value.ToString();
                        int Inven = int.Parse(row.Cells[5].Value.ToString());

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        cmd.Parameters.AddWithValue("@actualInven", Inven);
                        cmd.Parameters.AddWithValue("@presentInven", Inven);

                        int i = cmd.ExecuteNonQuery();

                        if (i != 1)
                        {
                            MessageBox.Show("상품등록 실패");
                        }
                    }
                    con.Close();
                }
                MessageBox.Show(" 날짜 : " + DateTime.Now.ToShortDateString() + " [ 발주 성공] ");
            }
            else
            {
                MessageBox.Show("발주할 상품을 선택해주세요.");
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
