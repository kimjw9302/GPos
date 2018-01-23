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
    public partial class frmQua : Form
    {
        private string qua;

        public string Qua
        {
            get { return qua; }
            set { qua = value; }
        }

        public frmQua()
        {
            InitializeComponent();
        }
        public frmQua(string qua) : this()
        {
            txtQua.Text = qua;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            frmOrderRequest frmOrder = (frmOrderRequest)Owner;
            frmOrder.GetQua = txtQua.Text;
            this.Close();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            txtQua.Text += sender.ToString().Substring(sender.ToString().Length-1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            txtQua.Text = txtQua.Text.Remove(txtQua.Text.Length - 1, 1);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            txtQua.Text = "";
        }
    }
}
