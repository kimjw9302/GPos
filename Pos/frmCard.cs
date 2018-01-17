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
    public partial class frmCard : Form
    {
        string sendMoney;
        public frmCard()
        {
            InitializeComponent();
        }
        public frmCard(string sendMoney) : this()
        {
            this.sendMoney = sendMoney;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void frmCard_Load(object sender, EventArgs e)
        {
            tboxPay.Text = sendMoney;
        }
    }
}
