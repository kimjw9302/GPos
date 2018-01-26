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
            using (var cmd = new SqlCommand("MemberAllView", con))
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
            int MemberNum = int.Parse(tboxMember.Text);
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("MemberSerch", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MemberNum", MemberNum);
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

            string MemberNum = tboxMember.Text;
            string Name = tboxName.Text;
            string Phone =tboxPhone.Text;

            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("MemberUpdate", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@memberNum", int.Parse(MemberNum));
                cmd.Parameters.AddWithValue("@memberName", Name);
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
            dgvMember.DataSource = null;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvMember.DataSource = ds.Tables[0];

        }
        public void delete()
        {
            string memberNum = tboxMember.Text;
            var con = DBcontroller.Instance();
            var result = MessageBox.Show("삭제하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (var cmd = new SqlCommand("MemberDelete", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@memberNum", int.Parse(memberNum));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            textBox();
            frmCustInquiry_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void textBox()
        {
            if (dgvMember.RowCount != 0)
            {
                tboxMember.Text = dgvMember.CurrentRow.Cells[0].Value.ToString();
                tboxName.Text = dgvMember.CurrentRow.Cells[1].Value.ToString();
                tboxPhone.Text = dgvMember.CurrentRow.Cells[3].Value.ToString();

            }
            else
            {
                MessageBox.Show("선택하신 제품이 없습니다.");
                tboxMember.Text = "";
                tboxName.Text = "";
                tboxPhone.Text = "";                
                return;
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void dgvMember_Click(object sender, EventArgs e)
        {
            textBox();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
