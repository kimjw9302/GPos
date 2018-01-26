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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        private void btnStockSelect_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmProductSelect().ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmSalesinquiry().ShowDialog();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmRevenue().ShowDialog();
        }

        private void btnCustInquiry_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmCustInquiry().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmEmployee().ShowDialog();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
