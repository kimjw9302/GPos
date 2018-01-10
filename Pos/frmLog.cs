using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }


        private void frmLog_Load(object sender, EventArgs e)
        {
            FileInfo s = new FileInfo(Application.StartupPath + @"\gposlog.txt");
            if (s.Exists)
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\gposlog.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string str = sr.ReadToEnd();
                tboxLog.Text = str;
                sr.Close();
            }
            else
            {
                tboxLog.Text = "로그가 존재하지 않습니다.";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
