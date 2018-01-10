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
    public partial class frmMain : Form
    {
        private SqlConnection con;
        public string empName;
        public int empId;
        public DateTime sdate;
        
        //생성자
        public frmMain()
        {
            InitializeComponent();
        }
        //매개변수 2개를 받는 생성자,  [1] 로그인하는사람의 이름 [2] 로그인하는 사람의 ID를 FormMain에서 가지고있는다.
        public frmMain(string empName, string empId) : this()
        {
            this.empId = int.Parse(empId);
            this.empName = empName;
        }

        //로드.
        private void frmMain_Load(object sender, EventArgs e)
        {
            sdate = DateTime.Now;
            //로드를 하는 순간 재고를 찾아봄 그러므로 상품테이블에 재고량에 들어가야함
            lblEmployee.Text = empName;
            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("LoadCheckProducts", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

  
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter();
                
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    con.Close();
                }
                else
                {
                    this.Visible = true;
                    con.Close();
                    frmNotice fn = new frmNotice(ds.Tables[0]);
                    fn.ShowDialog();
                }
             
            }
       
        }

        //종료버튼.
        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnTotalView_Click(object sender, EventArgs e)
        {
            new frmView().ShowDialog();
        }
        private void btnManagement_Click(object sender, EventArgs e)
        {
            new frmManagement().ShowDialog();
        }
        private void btnCard_Click(object sender, EventArgs e)
        {
            new frmCard().ShowDialog();
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            new frmCash().ShowDialog();
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            new frmPoint().ShowDialog();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            new frmOrder().ShowDialog();
        }
        private void btnEtc_Click(object sender, EventArgs e)
        {
            new frmEtc().ShowDialog();
        }
        //담당자 변경 클릭시 -> 
        private void btnEmployeeChange_Click(object sender, EventArgs e)
        {
            frmEmployeeRotaion fer = new frmEmployeeRotaion(sdate);
            fer.Owner = this;
            fer.EmpName = empName;
            fer.EmpId = empId;
            fer.ShowDialog();

        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //계산기는 싱글톤 패턴으로
            new frmCalculator().Show();
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {

            //바코드를 판단 -> 내가필요한 정보는 ? 
            // 1순위 바코드에 맞는 수량, 수량이 안맞다면 모든게 꽝
            // 2순위 바코드,품목명,가격 받아오기.
            if (e.KeyCode == Keys.Enter)
            {
                con = DBcontroller.Instance();
                con.Open();
                using (var cmd = new SqlCommand("", con))
                {

                }
                con.Close();
                txtQuantity.Focus();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtReceived_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
