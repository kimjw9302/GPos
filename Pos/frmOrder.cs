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
    public partial class frmOrder : Form
    {
        private int empIdSend;

        public int EmpIdSend
        {
            get { return empIdSend; }
            set { empIdSend = value; }
        }

        public frmOrder()
        {
            InitializeComponent();
        }

        public frmOrder(int empid) : this()
        {
            this.empIdSend = empid;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            new frmOrderRequest(EmpIdSend).ShowDialog();
           
        }

        private void btnOrderView_Click(object sender, EventArgs e)
        {
            
        }
    }
}
