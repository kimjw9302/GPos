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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel);
        }
        private void btnTotalView_Click(object sender, EventArgs e)
        {
            new frmView().ShowDialog();
        }
        private void btnManagement_Click(object sender, EventArgs e)
        {
            new frmManagement().ShowDialog();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            new frmCard().ShowDialog();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            new frmCash().ShowDialog();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            new frmPoint().ShowDialog();
        }
    }
}
