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
            new frmCustRegister().ShowDialog();
        }

        private void btnCustRegister_Click_1(object sender, EventArgs e)
        {
            new frmCustRegister().ShowDialog();
        }

        private void btnProductRegister_Click(object sender, EventArgs e)
        {
            new frmProductRegister().ShowDialog();
        }

        private void btnEmployeeRegister_Click(object sender, EventArgs e)
        {
            new frmEmployeesRegister().ShowDialog();
        }

        private void btnEmpWork_Click(object sender, EventArgs e)
        {
            new frmEmployeeSchedule().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
