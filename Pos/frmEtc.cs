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
    public partial class frmEtc : Form
    {
        public frmEtc()
        {
            InitializeComponent();
        }

        private void btnStockSelect_Click(object sender, EventArgs e)
        {
            new frmEvent().ShowDialog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            new frmLog().ShowDialog();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            new frmMail().ShowDialog();
        }
    }
}
