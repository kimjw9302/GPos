using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmWait : Form
    {
        DateTime stime;
        string EmpName;
        public frmWait()
        {
            InitializeComponent();
        }

        public frmWait(string EmpName):this()
        {
            this.EmpName = EmpName;
        }

        private void btnOutCancel_Click(object sender, EventArgs e)
        {
            if (tboxpassword.Text == "")
            {
                MessageBox.Show("비밀번호가 틀립니다");
                tboxpassword.Text = "";
                tboxpassword.Focus();
                return;
            }

            SqlConnection con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SelectStorePw",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@password",tboxpassword.Text);
                var flag =cmd.ExecuteScalar();
                if (flag.ToString() == "1")
                {


                    WriteLog.Start(EmpName, lblsc.Text+"동안 외출하기 기능을 이용하였습니다");
                    con.Close();
                    this.Dispose();
                }
                else{
                    MessageBox.Show("비밀번호가 틀립니다");
                    tboxpassword.Text = "";
                    tboxpassword.Focus();
                    con.Close();
                }

            }

        }
     

        private void frmWait_Load(object sender, EventArgs e)
        {

            stime = DateTime.Now;

            timer1.Start();

         
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan span = new TimeSpan(DateTime.Now.Ticks-stime.Ticks);
            lblsc.Text = span.ToString("hh\\시mm\\분ss\\초");

        }

    }
}
