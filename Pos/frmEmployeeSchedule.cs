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
        DataTable emp, joinTable;
        DataRowCollection rows, viewRows;

        public frmEmployeeSchedule()
        {
            InitializeComponent();
        }

        private void frmEmployeeSchedule_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now;
            var con = DBcontroller.Instance();

            con.Open();
            using (var cmd = new SqlCommand("GetEmployeeName", con))
            {
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                emp = ds.Tables[0];

                rows = emp.Rows;


                foreach (DataRow item in rows)
                {
                    cbEmp.Items.Add(item[1].ToString());
                }
                dgvWorkView.DataSource = ds.Tables[1];

                joinTable = ds.Tables[1];
                viewRows = joinTable.Rows;
                DataTable real = ds.Tables[1];

                List<double> sub = new List<double>();
                List<double> wage = new List<double>();
                
                //IEnumerable<DateTime> query = from 
                
                //foreach (DataRow item in viewRows)
                //{
                //    real.Rows[item].;
                //    DateTime time = (DateTime)item[3](DateTime)item[2]
                //}
                

            }


            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
