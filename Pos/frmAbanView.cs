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
    
    public partial class frmAbanView : Form
    {
        internal DataTable abantable;
        SqlConnection con;
        public frmAbanView()
        {
            InitializeComponent();
        }

        private void frmAbanView_Load(object sender, EventArgs e)
        {
            AbanTableMaker();
            dgvAban.DataSource = abantable;

            con = DBcontroller.Instance();

            using (var cmd = new SqlCommand("AbanCheck", con))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                abantable = ds.Tables[0];
                dgvAban.DataSource = abantable;


            }
            
        }

        private void AbanTableMaker()
        {
            abantable = new DataTable();

            abantable.Columns.Add("바코드");
            abantable.Columns.Add("상품명");
            abantable.Columns.Add("원가");
            abantable.Columns.Add("단가");
            abantable.Columns.Add("누계");
            abantable.Columns.Add("실재고");
            abantable.Columns.Add("폐기시간");
                
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmAban aban = new frmAban();
            aban.Owner = this;
            aban.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
