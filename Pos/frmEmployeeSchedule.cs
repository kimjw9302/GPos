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
        DataTable emp, joinTable, conditionView;
        DataRowCollection rows, viewRows;
        SqlConnection con;

        public frmEmployeeSchedule()
        {
            InitializeComponent();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Inquiry();
        }

        private void frmEmployeeSchedule_Load(object sender, EventArgs e)
        {
            Inquiry();
        }

        private void Inquiry()
        {
            dtpStartDate.Value = DateTime.Now;

            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("GetEmployeeName", con))
            {
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                emp = ds.Tables[0];
                joinTable = ds.Tables[1];

                rows = emp.Rows;
                viewRows = joinTable.Rows;

                //combobox에 직원이름 추가
                foreach (DataRow item in rows)
                {
                    cbEmp.Items.Add(item[1].ToString());
                }
                
            }
            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //tab 컨트롤 눌렀을 때마다 다른거 조회
            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("EmployeeSchedule", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@empName", cbEmp.SelectedItem);

                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                
                conditionView = ds.Tables[0];

                dgvWorkView.Refresh();
                dgvWorkView.DataSource = conditionView;
            }

            con.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
