using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmEvent : Form
    {
        DBcontroller con;
        DataSet ds;
        public frmEvent()
        {
            InitializeComponent();
        }

        private void Rests()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["gposStr"].ConnectionString))
            {
                using (var cmd = new SqlCommand("EventLoad", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    con.Close();

                    ds = new DataSet();
                    adapter.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[0].HeaderText = "바코드";
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[1].HeaderText = "내용";
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[2].HeaderText = "할인율";
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[3].HeaderText = "시작날짜";
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[4].HeaderText = "끝나는날짜";
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }


        private void frmEvent_Load(object sender, EventArgs e)
        {
            Rests();
        }

        // 저장
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string uBarcode = this.tboxBarcode.Text.Trim();
            string uEventContent = this.tboxContent.Text.Trim();
            string uDiscount = this.tboxDiscount.Text.Trim();
            string uStartDate = this.StartDate.Value.ToLongDateString();
            string uEndDate = this.EndDate.Value.ToLongDateString();

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["gposStr"].ConnectionString))
            {
                using (var cmd = new SqlCommand("EventSave", con))
                {
                    cmd.Parameters.AddWithValue("@uBarcode", uBarcode);
                    cmd.Parameters.AddWithValue("@uEventContent", uEventContent);
                    cmd.Parameters.AddWithValue("@uDiscount", uDiscount);
                    cmd.Parameters.AddWithValue("@uStartDate", uStartDate);
                    cmd.Parameters.AddWithValue("@uEndDate", uEndDate);



                    con.Open();

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("저장 되었습니다.");
                        Rests();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("저장 실패");
                        return;
                    }
                }
            }
        }

        private void ComponentInit()
        {
            tboxBarcode.Text = tboxContent.Text = tboxDiscount.Text = StartDate.Text = EndDate.Text = "";
        }

        // 수정
        private void btnModify_Click(object sender, EventArgs e)
        {
            string uBarcode = this.tboxBarcode.Text.Trim();
            string uEventContent = this.tboxContent.Text.Trim();
            string uDiscount = this.tboxDiscount.Text.Trim();
            string uStartDate = this.StartDate.Value.ToLongDateString();
            string uEndDate = this.EndDate.Value.ToLongDateString();


            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["gposStr"].ConnectionString))
            {
                using (var cmd = new SqlCommand("EventsModify", con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    cmd.Parameters.AddWithValue("@uBarcode", uBarcode);
                    cmd.Parameters.AddWithValue("@uEventContent", uEventContent);
                    cmd.Parameters.AddWithValue("@uDiscount", uDiscount);
                    cmd.Parameters.AddWithValue("@uStartDate", uStartDate);
                    cmd.Parameters.AddWithValue("@uEndDate", uEndDate);

                    adapter.UpdateCommand = cmd;

                    int i;
                    i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("저장 되었습니다.");
                        Rests();
                        ComponentInit();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("저장 실패");
                        return;
                    }
                }
            }
        }
    

        // 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uBarcode = this.tboxBarcode.Text.Trim();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["gposStr"].ConnectionString))
            {
                using (var cmd = new SqlCommand("EventDelete", con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    cmd.Parameters.AddWithValue("@uBarcode", uBarcode);

                    adapter.DeleteCommand = cmd;

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("삭제 되었습니다.");
                        Rests();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패");

                        return;
                    }
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            tboxBarcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tboxContent.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tboxDiscount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            StartDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EndDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}