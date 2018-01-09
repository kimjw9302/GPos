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

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new frmOrder().ShowDialog();
        }

        private void btnEtc_Click(object sender, EventArgs e)
        {
            new frmEtc().ShowDialog();
        }

        private void btnEmployeeChange_Click(object sender, EventArgs e)
        {
            //바코드 폼
        }
    }
}
