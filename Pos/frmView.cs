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
    public partial class frmView : Form
    {
        SqlConnection con;
        int empId = 0;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData)) // 위에서 처리 안했으면
            {
                // 여기에 처리코드를 넣는다.

                if (keyData.Equals(Keys.Escape) || keyData.Equals(Keys.Q))
                {//Esc,Q 버튼 눌렀을때
                    this.Dispose();
                    return true;
                }
                else if (keyData.Equals(Keys.F1))
                {
                    //카드결제
                    btnStockSelect_Click(null, null);

                    return true;
                }
                else if (keyData.Equals(Keys.F2))
                {
                    //현금결제
                    btnSell_Click(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F3))
                {
                    //포인트결제
                    button1_Click(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F4))
                {
                    //포인트적립
                    btnRevenue_Click(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F5))
                {
                    btnCustInquiry_Click(null, null);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
        public frmView(int empId)
        {
            this.empId = empId;
            InitializeComponent();
        }

        private void btnStockSelect_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmProductSelect().ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmSalesinquiry().ShowDialog();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
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
                        this.Visible = false;
                        new frmRevenue().ShowDialog();


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

        private void btnCustInquiry_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmCustInquiry().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                        this.Visible = false;
                        new frmEmployee().ShowDialog();


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

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
