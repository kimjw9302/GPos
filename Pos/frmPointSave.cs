using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmPointSave : Form
    {
        SqlConnection con;
        public frmPointSave()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con = DBcontroller.Instance();
            con.Open();
            using (var cmd = new SqlCommand("SearchMember",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone",tboxPhone.Text);
                var sdr = cmd.ExecuteScalar();
                if (sdr.ToString() == null)
                {
                    MessageBox.Show("회원에 대한 정보가 없습니다");
                }
                else
                {
                    lblName.Text = sdr.ToString();
                    lblName.Visible = true;
                    lblName2.Visible = true;
                }
            }
            con.Close();

        }
    }
}
