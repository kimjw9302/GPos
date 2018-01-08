using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //종료버튼 클릭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //로그인버튼 클릭
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string employeeID = tboxID.Text;
            string storePw = tboxPw.Text;
            //유효성 검사
            if (Check(employeeID, storePw))
            {
                //우선쿼리로 제작(직원 아이디로 접근 )
                using (var con = DBcontroller.Instance())
                {
                    
                    //Employees 테이블 
                    string query = "select count(empNum) from dbo.Employees where empNum =123 ";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        var sdr = cmd.ExecuteScalar();
                        MessageBox.Show("1");
                        if (sdr.ToString().Contains("1"))
                        {
                            MessageBox.Show("커몬");
                        }
                        else
                        {
                            MessageBox.Show("다시입력");
                            con.Close();
                            return;
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("다시 입력해주세요.");
            }

        }
        public bool Check(string a, string b)
        {
            if (a.Length > 5 || a == "")
            {
                return false;
            }
            if (b.Length > 5 || b == "")
            {
                return false;
            }
            return true;
            
        }
        
    }
}
