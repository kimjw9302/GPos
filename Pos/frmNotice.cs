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
    public partial class frmNotice : Form
    {
        private DataTable dataTable;

        public frmNotice()
        {
            InitializeComponent();
        }

        //DataTable을 받는 생성자
        public frmNotice(DataTable dataTable) :this()
        {
            this.dataTable = dataTable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmNotice_Load(object sender, EventArgs e)
        {
            ColumnsNaming();
            dgvItem.DataSource = dataTable;
            dgvItem.Columns[0].Width = 130;
            dgvItem.Columns[1].Width = 130;
            dgvItem.Columns[2].Width = 100;

            dgvItem.Columns[3].Width = 100;
        }
        public void ColumnsNaming()
        {
            dataTable.Columns[0].ColumnName = "바코드번호";
            
            dataTable.Columns[1].ColumnName = "상품명";
       
            dataTable.Columns[2].ColumnName = "실재고";
      
            dataTable.Columns[3].ColumnName = "현재고";
            



        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            frmOrderRequest for1 =new frmOrderRequest();
            this.Visible = false;
            for1.ShowDialog();
            this.Dispose();
        }
    }
}
