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
    public partial class frmCustInquiry : Form,ISearch,IDelete,IAlter
    {
        public frmCustInquiry()
        {
            InitializeComponent();
        }

        private void frmCustInquiry_Load(object sender, EventArgs e)
        {
            
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("UserAllView", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;               
                var sdr = cmd.ExecuteNonQuery();
                dataset(cmd);
                textBox();

            }
            con.Close();
            return;
        }
        public void search()
        {
            int UserNum = int.Parse(tboxUser.Text);
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("UserSerch", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userNum", UserNum);
                var sdr = cmd.ExecuteNonQuery();
                if (sdr.ToString() != "0")
                {
                    dataset(cmd);
                    //textBox();
                }

            }
            con.Close();
            return;
        }

        public void submit()
        {

            string userNum = tboxUser.Text;
            string Name = tboxName.Text;
            string Phone =tboxPhone.Text;

            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("UserUpdate", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userNum", userNum);
                cmd.Parameters.AddWithValue("@userName", Name);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정이 완료 되었습니다.");
                textBox();
                con.Close();
            }
            
            frmCustInquiry_Load(null, null);
        }
        public void dataset(SqlCommand cmd)
        {
            dgvUser.DataSource = null;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvUser.DataSource = ds.Tables[0];

        }
        public void delete()
        {
            //string barcode = tboxBarcode.Text;
            //var con = DBcontroller.Instance();
            //var result = MessageBox.Show("삭제하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //if (result == DialogResult.OK)
            //{
            //    using (var cmd = new SqlCommand("StockDelete", con))
            //    {
            //        con.Open();
            //        cmd.Parameters.AddWithValue("@barcode", barcode);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}
            //textBox();
            //frmProductSelect_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void textBox()
        {
            if (dgvUser.RowCount != 0)
            {
                tboxUser.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
                tboxName.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
                tboxPhone.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();

            }
            else
            {
                MessageBox.Show("선택하신 제품이 없습니다.");
                tboxUser.Text = "";
                tboxName.Text = "";
                tboxPhone.Text = "";                
                return;
            }

        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            textBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            submit();
        }
    }
}
