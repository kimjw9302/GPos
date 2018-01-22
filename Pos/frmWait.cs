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
        public void WriteLog()
        {

            FileInfo s = new FileInfo(Application.StartupPath + @"\gposlog.txt");
            if (s.Exists)
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\gposlog.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string str = sr.ReadToEnd();
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(sr.ReadToEnd());
                sw.WriteLine("관리자 : " + EmpName.ToString());
                sw.WriteLine("날짜 : " + DateTime.Now);
                sw.WriteLine("내용 : 외출하기 기능 이용 ");
                sw.Flush();
                sw.Close();
                sr.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\gposlog.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine("관리자 : " + EmpName.ToString());
                sw.WriteLine("날짜 : " + DateTime.Now);
                sw.WriteLine("내용 : 외출하기 기능 이용 ");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void frmWait_Load(object sender, EventArgs e)
        {

            WriteLog();
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
