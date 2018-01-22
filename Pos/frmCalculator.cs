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
    public partial class frmCalculator : Form
    {
        private static frmCalculator fc = null;
        private  frmCalculator()
        {
            InitializeComponent();
           
        }
        static public frmCalculator Instance()
        {

            if (fc == null)
            {
                fc = new frmCalculator();
            }
            return fc;
        }
    }
}
