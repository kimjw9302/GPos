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
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable emp, conditionView;
        DataRowCollection rows;
        SqlConnection con;

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

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvWorkView.Refresh();
            con = DBcontroller.Instance();
            //tab 컨트롤 눌렀을 때마다 다른거 조회
            if (tabControl1.SelectedIndex == 0)
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
                }
                con.Close();

            }
            else if(tabControl1.SelectedIndex == 1)
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
