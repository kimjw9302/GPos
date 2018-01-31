using System;
using System.Data;
using System.Data.SqlClient;
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
                dataGridView1.Columns[1].HeaderText = "상품";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].HeaderText = "내용";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].HeaderText = "할인율";
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].HeaderText = "시작날짜";
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[5].HeaderText = "끝나는날짜";
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[6].HeaderText = "이벤트번호";
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[7].HeaderText = "그룹번호";
                dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void ComponentInit()
        {
            tboxProductName.Text = comboBox1.Text = comboBox2.Text = StartDate.Text = EndDate.Text = tboxEventNum.Text = tboxEventGroupNum.Text = "";
        }

        // 수정
        private void btnModify_Click(object sender, EventArgs e)
        {
            string ubarcode = this.tboxProductBarcode.Text.Trim();
            string productName = this.tboxProductName.Text.Trim();
            string uEventContent = this.comboBox1.Text.Trim();
            string uDiscount = this.comboBox2.Text.Trim();
            string uStartDate = this.StartDate.Value.ToLongDateString();
            string uEndDate = this.EndDate.Value.ToLongDateString();
            int uEventNum = int.Parse(this.tboxEventNum.Text.Trim());
            int uEventGroup = int.Parse(this.tboxEventGroupNum.Text.Trim());


            var con = DBcontroller.Instance();
            if (uEventNum == 0)
            {
                using (var cmd = new SqlCommand("EventModiDelete", con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@eventContent", uEventContent);
                    cmd.Parameters.AddWithValue("@discount", uDiscount);
                    cmd.Parameters.AddWithValue("@startdate", DateTime.Parse(uStartDate));
                    cmd.Parameters.AddWithValue("@enddate", DateTime.Parse(uEndDate));
                    cmd.Parameters.AddWithValue("@eventNum", uEventNum);
                    cmd.Parameters.AddWithValue("@eventGroup", uEventGroup);
                    adapter.UpdateCommand = cmd;

                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    Rests();
                    ComponentInit();
                    return;
                }
            }
            else if(uEventNum != 0 )
            {

                using (var cmd = new SqlCommand("EventModi", con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ubarcode", ubarcode);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@eventContent", uEventContent);
                    cmd.Parameters.AddWithValue("@discount", uDiscount);
                    cmd.Parameters.AddWithValue("@startdate", DateTime.Parse(uStartDate));
                    cmd.Parameters.AddWithValue("@enddate", DateTime.Parse(uEndDate));
                    cmd.Parameters.AddWithValue("@eventNum", uEventNum);
                    cmd.Parameters.AddWithValue("@eventGroup", uEventGroup);
                    adapter.UpdateCommand = cmd;

                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    Rests();
                    ComponentInit();
                    return;
                }
                
            }

        }
        
    
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            tboxProductBarcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tboxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            StartDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EndDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tboxEventNum.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tboxEventGroupNum.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
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