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
    public partial class frmManagement : Form
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
                    //카드결제
                    btnCustRegister_Click_1(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F2))
                {
                    //현금결제
                    btnProductRegister_Click(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F3))
                {
                    //포인트결제
                    btnAban_Click(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F4))
                {
                    //포인트적립
                    btnEmployeeRegister_Click(null, null);
                    return true;
                }
                else if (keyData.Equals(Keys.F5))
                {
                    //포인트적립
                    btnEmpWork_Click(null, null);
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
        public frmManagement()
        {
            InitializeComponent();
        }
        
        private void btnCustRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmCustRegister().ShowDialog();
            
        }

        private void btnCustRegister_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmCustRegister().ShowDialog();
        }

        private void btnProductRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmProductRegister().ShowDialog();
        }

        private void btnEmployeeRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmEmployeesRegister().ShowDialog();
        }

        private void btnEmpWork_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmEmployeeSchedule().ShowDialog();
        }
        private void btnAban_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmAbanView().ShowDialog();
        }

   
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
