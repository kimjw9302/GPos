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
        DataTable cate1Table, cate2Table, placeTable;
        DataSet ds;
        DataRowCollection c1Row, c2Row, pRow;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //데이터그리드뷰에 cate1, cate2와 일치하는 상품 띄워주면됨,
            
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
                con = DBcontroller.Instance();

                con.Open();
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                cate1Table = ds.Tables[0];

                placeTable = ds.Tables[3];
                c1Row = cate1Table.Rows;
                
                pRow = placeTable.Rows;

                foreach (DataRow item in c1Row)
                {
                    if (item[0].ToString() == "F")
                    {
                        cbCate1.Items.Add("식품");
                        cate2Table = ds.Tables[1];
                        c2Row = cate2Table.Rows;
                        foreach (DataRow c2 in c2Row)
                        {
                            cbCate2.Items.Add(c2[0]);
                        }
                    }
                    else if (item[0].ToString() == "NF")
                    {
                        cbCate1.Items.Add("비식품");
                        cate2Table = ds.Tables[2];
                        c2Row = cate2Table.Rows;
                        foreach (DataRow c2 in pRow)
                        {
                            lbPlace.Items.Add(c2[0]);
                        }
                    }
                }
            }
            con.Close();
        }
    }
}
