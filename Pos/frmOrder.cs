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
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //if()
            //{
                new frmOrderRequest().ShowDialog();
            //}
            //else 
            //{
            //    MessageBox.Show("접근 불가", "알림");
            //}
           
        }

        private void btnOrderView_Click(object sender, EventArgs e)
        {
            new frmOrderSelect().ShowDialog();
        }
    }
}
