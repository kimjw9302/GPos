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
    public partial class frmRevenue : Form,ISearch,IAlter
    {
        public frmRevenue()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex)
            {
                case 0: 
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3: //지혜
                    EmployeeAnalysis();
                    break;
                case 4: 
                    break;
                case 5:
                    break;
                case 6: //지혜
                    TotalRevenue();
                    break;
                case 7:
                    break;
            }
            
        }

        //총매출
        private void TotalRevenue()
        {
            throw new NotImplementedException();
        }

        //연령별 분석
        private void EmployeeAnalysis()
        {
            throw new NotImplementedException();
        }
    }
}
