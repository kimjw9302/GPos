using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
        }
        
        private void btnCustRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            new frmCustRegister().ShowDialog();
            
        }

        private void btnCustRegister_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmCustRegister().ShowDialog();
        }

        private void btnProductRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmProductRegister().ShowDialog();
        }

        private void btnEmployeeRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmEmployeesRegister().ShowDialog();
        }

        private void btnEmpWork_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmEmployeeSchedule().ShowDialog();
        }
        private void btnAban_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmAbanView().ShowDialog();
        }

   
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
