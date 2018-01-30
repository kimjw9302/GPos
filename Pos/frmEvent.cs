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
        DataTable dt;
        public frmEvent()
        {
            InitializeComponent();
        }
        
        private void Rests()
        {
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("EventLoad", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[0].HeaderText = "바코드";
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].HeaderText = "상품이름";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].HeaderText = "내용";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].HeaderText = "이벤트 번호";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dataGridView1.Columns[3].HeaderText = "시작날짜";
                //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dataGridView1.Columns[4].HeaderText = "끝나는날짜";
                //dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dataGridView1.Columns[5].HeaderText = "이벤트 번호";
                //dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dataGridView1.Columns[6].HeaderText = "그룹 번호";
                //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                con.Close();
            }
        }


        private void frmEvent_Load(object sender, EventArgs e)
        {
            if (rb_All.Checked == true)
            {
                Rests();
            }
            else if (rb_oneone.Checked)
            {

            }
            else if (rb_twoone.Checked)
            {

            }
            EventCate();
        }

        // 저장
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int uEventGroup = int.Parse(this.tboxEventGroupNum.Text.Trim());
            string productName = this.tboxProductName.Text.Trim();
            string uEventContent = this.comboBox1.Text.Trim();
            string uDiscount = this.comboBox2.Text.Trim();
            string uStartDate = this.StartDate.Value.ToLongDateString();
            string uEndDate = this.EndDate.Value.ToLongDateString();

            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("EventSave", con))
            {
                cmd.Parameters.AddWithValue("@uEventGroup", uEventGroup);
                cmd.Parameters.AddWithValue("@productName", productName);
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

        private void ComponentInit()
        {
            tboxEventGroupNum.Text = tboxProductName.Text = comboBox1.Text = comboBox2.Text = StartDate.Text = EndDate.Text = "";
        }

        // 수정
        private void btnModify_Click(object sender, EventArgs e)
        {
            int uEventGroup = int.Parse(this.tboxEventGroupNum.Text.Trim());
            string productName = this.tboxProductName.Text.Trim();
            string uEventContent = this.comboBox1.Text.Trim();
            string uDiscount = this.comboBox2.Text.Trim();
            string uStartDate = this.StartDate.Value.ToLongDateString();
            string uEndDate = this.EndDate.Value.ToLongDateString();


            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("EventDetailUpdate", con))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eventGroup", uEventGroup);
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@eventContent", uEventContent);
                cmd.Parameters.AddWithValue("@discount", uDiscount);
                cmd.Parameters.AddWithValue("@startdate", DateTime.Parse(uStartDate));
                cmd.Parameters.AddWithValue("@enddate", DateTime.Parse(uEndDate));
                adapter.UpdateCommand = cmd;
                

                

                int i = cmd.ExecuteNonQuery();
                con.Close();
                Rests();
                ComponentInit();
                return;                
            }            

        }
        
    

        // 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productName = this.tboxProductName.Text.Trim();
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("EventDelete", con))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                cmd.Parameters.AddWithValue("@productName", productName);

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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            tboxEventGroupNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tboxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            StartDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EndDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void EventCate()
        {
            var con = DBcontroller.Instance();
            using (var cmd = new SqlCommand("EventCate", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;               

                cmd.ExecuteNonQuery();

               
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                sda.Fill(ds);
                 dt = ds.Tables[0];
                
                MessageBox.Show(dt.Rows.Count.ToString());
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][1]);
                    comboBox2.Items.Add(dt.Rows[i][2]);
                }
                con.Close();
                
            }
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (comboBox1.Text == dt.Rows[i][1].ToString())
                {
                    comboBox2.Text = dt.Rows[i][2].ToString();
                    break;
                }
                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (comboBox2.Text == dt.Rows[i][2].ToString())
                {
                    comboBox1.Text = dt.Rows[i][1].ToString();
                }

            }
        }
    }
}