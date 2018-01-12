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
    public partial class frmOrderRequest : Form, ISearch, IAlter
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable cate1Table, cateF, cateNF, placeTable ,productTable;
        DataSet ds;
        DataRowCollection c1Row, cFRow, cNFRow, pRow;

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

        private void lbPlace_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //거래처 더블클릭하면 거래처 상품 띄워주면됨
        }

        public frmOrderRequest()
        {
            InitializeComponent();
        }

        private void frmOrderRequest_Load(object sender, EventArgs e)
        {
            //공통
            string orderNum;
            DateTime now;
            int placeNum;
            int empNum;

            // 상품정보       
            //   @productNum int,
            //   @quantity int,
            //   @costPrice decimal,
            //   @price decimal,
            //   @empNum int

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
    }
}
