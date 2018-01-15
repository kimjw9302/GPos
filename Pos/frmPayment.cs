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
    public partial class frmPayment : Form
    {
        string sendStr;
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            MessageBox.Show(click.Text);
            this.Visible = false;
            frmCash fc = new frmCash();
            fc.ShowDialog();
            this.Dispose();
        }
    }
}
