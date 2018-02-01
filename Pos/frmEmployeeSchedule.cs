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
    public partial class frmEmployeeSchedule : Form, ISearch
    {
        private SqlDataAdapter adapter;
        private DataSet ds;
        private DataTable emp, conditionView;
        private DataRowCollection rows;
        private SqlConnection con;

        public frmEmployeeSchedule()
        {
            InitializeComponent();
        }

        private void frmEmployeeSchedule_Load(object sender, EventArgs e)
        {
            TableMake();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;

            con = DBcontroller.Instance();

            try
            {
                using (var cmd = new SqlCommand("GetEmployeeName", con))
                {
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);

                    emp = ds.Tables[0];
                    rows = emp.Rows;

                    foreach (DataRow item in rows)
                    {
                        cbEmp.Items.Add(item[0]);
                    }

                }
                con.Close();
            }
            catch (Exception msg)
            {
                con.Close();
                MessageBox.Show(msg.Message);

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvWorkView.Refresh();
            con = DBcontroller.Instance();
            //tab 컨트롤 눌렀을 때마다 다른거 조회

            if (tabControl1.SelectedIndex == 0)
            {
                try
                {
                    using (var cmd = new SqlCommand("EmployeeSchedule", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value.ToShortDateString());
                        con.Open();
                        adapter = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds);

                        conditionView = ds.Tables[0];
                        dgvWorkView.DataSource = conditionView;
                        dgvColor();

                    }
                    con.Close();
                }
                catch (Exception msg)
                {
                    con.Close();
                    MessageBox.Show(msg.Message);
                }
                
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                try
                {
                    using (var cmd = new SqlCommand("EmpNameSchedule", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@empName", cbEmp.SelectedItem);

                        adapter = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds);

                        conditionView = ds.Tables[0];

                        dgvWorkView.DataSource = conditionView;

                    }
                    con.Close();
                }
                catch (Exception msg)
                {
                    con.Close();
                    MessageBox.Show(msg.Message);
                }
            }
          
        }

        private void TableMake()
        {
            conditionView = new DataTable();

            conditionView.Columns.Add("직원명");
            conditionView.Columns.Add("출근날짜");
            conditionView.Columns.Add("출근시간");
            conditionView.Columns.Add("퇴근날짜");
            conditionView.Columns.Add("퇴근시간");
            conditionView.Columns.Add("총근무시간");
            conditionView.Columns.Add("일급");

            dgvWorkView.DataSource = conditionView;

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.MaxDate = DateTime.Now;
            dtpEndDate.MaxDate = DateTime.Now;
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conditionView.Clear();
            dgvWorkView.Refresh();
        }

        private void dgvWorkView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvColor();
        }

        private void dgvColor()
        {
            foreach (DataGridViewRow row in dgvWorkView.Rows)
            {
                switch (row.Cells[0].Value)
                {
                    case "고지혜":
                        row.DefaultCellStyle.BackColor = Color.Gold;
                        break;
                    case "안치훈":
                        row.DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        break;
                    case "김재웅":
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                        break;
                    case "김덕준":
                        row.DefaultCellStyle.BackColor = Color.DarkOrchid;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        break;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
