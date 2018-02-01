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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData)) // 위에서 처리 안했으면
            {
                // 여기에 처리코드를 넣는다.

                if (keyData.Equals(Keys.Escape) || keyData.Equals(Keys.Q))
                {//Esc,Q 버튼 눌렀을때
                    this.Dispose();
                    return true;
                }
                else if (keyData.Equals(Keys.F1))
                {
                    btnStockSelect_Click(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F2))
                {
                    btnLog_Click(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F3))
                {
                    btnMail_Click(null, null);
                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
        public frmEtc()
        {
            InitializeComponent();
        }

        private void btnStockSelect_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmEvent().ShowDialog();
            this.Dispose();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmLog().ShowDialog();
            this.Dispose();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmMail().ShowDialog();      
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
