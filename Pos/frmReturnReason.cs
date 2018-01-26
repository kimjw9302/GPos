using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmReturnReason : Form
    {
        public string reason { get; set; }
        
        public frmReturnReason()
        {
            InitializeComponent();
        }

        private void btnTradeC_Click(object sender, EventArgs e)
        {
            reason = btnTradeC.Text;
            this.Close();
        }

        private void btnErrorC_Click(object sender, EventArgs e)
        {
            reason = btnErrorC.Text;
            this.Close();
        }

        private void btnEtcC_Click(object sender, EventArgs e)
        {
            reason = btnEtcC.Text;
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
