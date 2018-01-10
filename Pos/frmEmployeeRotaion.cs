using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmEmployeeRotaion : Form
    {
        private SqlConnection con;
        private string empName;
        private DateTime sdate;
        private DateTime edate;
        private int empId;

        public frmEmployeeRotaion()
        {
            InitializeComponent();
        }

        public frmEmployeeRotaion(DateTime sdate) : this()
        {
            this.sdate = sdate;
        }

        //부모에게서 정보를 받기 위한 속성
        public string EmpName { get => empName; set => empName = value; }
        public int EmpId { get => empId; set => empId = value; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //변경 클릭시.
        private void btnChange_Click(object sender, EventArgs e)
        {
            con = DBcontroller.Instance();
            con.Open();
            int CurrentIID = 0;
            string CurrentName = "";
            int exId = 0;
            string exName = "";

            using (var cmd = new SqlCommand("RotationEmpSelect", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpNum", tboxEmpNum.Text);
                var sdr = cmd.ExecuteReader();
                empName = "";
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        frmMain fm = (frmMain)Owner; //오너 설정
                        //전번초 정보를 저장하는 변수
                        exName = fm.empName;
                        exId = fm.empId;                       
                        CurrentName = sdr["empName"].ToString(); //교대될 사람의 이름                      
                        CurrentIID = int.Parse(sdr["empNum"].ToString()); // 교대될 사람의 번호
                        fm.empId =CurrentIID;//fm에있는 현재번호를 교대될 번호로 바꿔줌
                        fm.empName = CurrentName;
                        EmpName = CurrentName;
                        edate = DateTime.Now;
                        fm.sdate = edate;
                        fm.lblEmployee.Text = CurrentName; //fm에있는 현재이름을 교대될 이름으로 바꿔줌
                    }
                    if (CurrentIID != exId)
                    {
                        sdr.Close();
                        using (var ccmd = new SqlCommand("InsertRotation", con))
                        {

                            ccmd.CommandType = CommandType.StoredProcedure;
                            ccmd.Parameters.AddWithValue("@bNum", exId);
                            ccmd.Parameters.AddWithValue("@aNum", CurrentIID);
                            ccmd.Parameters.AddWithValue("@sdate", sdate.Date);
                            ccmd.Parameters.AddWithValue("@stime", sdate.TimeOfDay);
                            ccmd.Parameters.AddWithValue("@edate", edate.Date);
                            ccmd.Parameters.AddWithValue("@etime", edate.TimeOfDay);
                            ccmd.ExecuteNonQuery();                        
                            MessageBox.Show(CurrentName + " 씨 안녕하세요!");
                            WriteLog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("현 근무자는 교대 근무자가 될 수 없습니다.");
                        tboxEmpNum.Text = "";
                        sdr.Close();
                        con.Close();                    
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("정보를 다시입력해주세요");
                    tboxEmpNum.Text = "";
                }
            }
            con.Close();
        }
        //로그 남기기 위한 메소드
        public void WriteLog()
        {

            FileInfo s = new FileInfo(Application.StartupPath+@"\gposlog.txt");
            if (s.Exists)
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\gposlog.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string str = sr.ReadToEnd();
                StreamWriter sw = new StreamWriter(fs,Encoding.Default);
                sw.Write(sr.ReadToEnd());
                sw.WriteLine("관리자 : " + EmpName.ToString());
                sw.WriteLine("날짜 : " + DateTime.Now);
                sw.WriteLine("내용 : 근무교대를 위한 로그인 " );
                sw.Close();
                sr.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\gposlog.txt",FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine("관리자 : " + EmpName.ToString());
                sw.WriteLine("날짜 : " + DateTime.Now);
                sw.WriteLine("내용 : 근무교대를 위한 로그인 ");
                sw.Close();
                fs.Close();
            }
        }
    }
}
