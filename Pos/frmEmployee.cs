
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeepAutomation.Barcode.Bean;
namespace Pos
{
    public partial class frmEmployee : Form, ISearch, IDelete, ISubmit
    {
        private string memberNum = null;
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            var con = DBcontroller.Instance();
            try
            {
                using (var cmd = new SqlCommand("EmployeeAllview", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    dataset(cmd);
                    con.Close();
                }
                textBox();
            }
            catch (Exception msg)
            {
                con.Close();
                MessageBox.Show(msg.Message);
                this.Dispose();
            }
        }
        private void dataset(SqlCommand cmd)
        {            
            dgvEmployees.DataSource = null;
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            dgvEmployees.DataSource = ds.Tables[0];
        }
        private void dgvEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                textBox();

            }
            catch (Exception)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        public void search()
        {
            string empName = tboxName.Text;
            var con = DBcontroller.Instance();
            try
            {
                using (var cmd = new SqlCommand("EmployeeSerch", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empName", empName);
                    var sdr = cmd.ExecuteNonQuery();
                    if (sdr.ToString() != "0")
                    {
                        dataset(cmd);
                        textBox();
                    }
                    con.Close();
                    return;

                }
            }
            catch (Exception msg)
            {
                con.Close();
                MessageBox.Show(msg.Message);
            }
            
        }

        public void submit()
        {
            string Name = tboxName.Text;
            string Position = tboxPosition.Text;
            string Phone = tboxPhone.Text;
            int houlyWage = int.Parse(tboxhourlyWage.Text);

            var con = DBcontroller.Instance();
            try
            {
                using (var cmd = new SqlCommand("EmployeeUpdate", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empName", Name);
                    cmd.Parameters.AddWithValue("@empPostion", Position);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@hourlyWage", houlyWage);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("수정이 완료 되었습니다.");
                    textBox();
                    con.Close();

                }

                frmEmployee_Load(null, null);
            }
            catch (Exception msg)
            {
                con.Close();
                MessageBox.Show(msg.Message);
            }
        }

        public void delete()
        {
            string Name = tboxName.Text;
            var con = DBcontroller.Instance();
            var result = MessageBox.Show("삭제하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    using (var cmd = new SqlCommand("EmployeeDelete", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@empName", Name);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception msg)
                {
                    con.Close();
                    MessageBox.Show(msg.Message);
                    this.Dispose();                  
                }
            }
            textBox();
            frmEmployee_Load(null, null);
        }
        private void GdiOutput(string strBarData)
        {
            //바데이터를 이미지로 출력해준다.

            //프린트 가중치 : 선의 두깨를 결정한다.
            int intW = 1;

            Graphics graphics = pboxBarcode.CreateGraphics();
            graphics.Clear(Color.White);
            //팬색
            Pen BlackPen = new Pen(Color.Black, intW);
            Pen WhitePen = new Pen(Color.White, intW);

            Brush BlackBrush = new SolidBrush(Color.Black);

            //선그리기
            for (int i = 0; i < strBarData.Length; ++i)
            {
                int intTemp = Convert.ToInt32(strBarData.Substring(i, 1));

                if (intTemp == 1)
                {
                    //검정색 출력
                    graphics.DrawLine(BlackPen, 30 + (i * intW), 10, 30 + (i * intW), 60);
                }
                else
                {
                    //하얀색 출력
                    graphics.DrawLine(WhitePen, 30 + (i * intW), 10, 30 + (i * intW), 60);
                }
            }

            //시간출력
            
            graphics.DrawString(DateTime.Now + "", new Font("Arial", 8, FontStyle.Regular), BlackBrush, 70, 270);
            //더미
            graphics.DrawString("_", new Font("고딕", 1, FontStyle.Regular), BlackBrush, 40, 300);
        }


        private void textBox()
        {
            if (dgvEmployees.RowCount != 0)
            {


      
                memberNum = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
<<<<<<< HEAD
                MessageBox.Show(memberNum);

=======
>>>>>>> 3f05cb7a26ee0e6a5045dc3bf783c86600e8f223
                tboxName.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();                
                tboxPosition.Text = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
                tboxPhone.Text = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
                tboxhourlyWage.Text = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
<<<<<<< HEAD


                claBarcode bcTemp = new claBarcode();

                memberNum = bcTemp.strBarcode(memberNum, 0);
                memberNum = bcTemp.strBarcodeToBar(memberNum);
                GdiOutput(memberNum);

=======


                BarCode barcode = new BarCode();
                barcode.Symbology = KeepAutomation.Barcode.Symbology.Code128A;
                barcode.CodeToEncode = memberNum;
                barcode.ChecksumEnabled = true;
                barcode.X = 1;
                barcode.Y = 50;
                barcode.BarCodeWidth = 170;
                barcode.BarCodeHeight = 120;
                barcode.Orientation = KeepAutomation.Barcode.Orientation.Degree0;
                barcode.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel;
                barcode.DPI = 72;
                barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Gif;
                pboxBarcode.Image = barcode.generateBarcodeToBitmap();
                //claBarcode bcTemp = new claBarcode();
                // memberNum = bcTemp.strBarcode(memberNum, 0);
                //memberNum = bcTemp.strBarcodeToBar(memberNum);
                //GdiOutput(memberNum);
>>>>>>> 3f05cb7a26ee0e6a5045dc3bf783c86600e8f223
            }
            else
            {
                MessageBox.Show("선택하신 제품이 없습니다.");
                tboxName.Text = "";
                tboxPosition.Text = "";
                tboxPhone.Text = "";
                tboxhourlyWage.Text = "";
                return;
            }

        }
        public void Barcode()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
