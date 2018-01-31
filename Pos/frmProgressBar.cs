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
    public partial class frmProgressBar : Form
    {
        private int timerCount = 0;
        public frmProgressBar()
        {
            InitializeComponent();
            Init();
            timer1.Interval = 1000;
            timer1.Start();
        }
        public void Init()
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
        }
            
        private void timer1_Tick(object sender, EventArgs e)
        {
           progressBar1.Value += 11;
            if (++timerCount == 10)
            {

                timer1.Stop();

                progressBar1.Enabled = false;

                this.Close();

            }

        }
    }
}
