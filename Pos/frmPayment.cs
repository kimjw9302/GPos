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
    public partial class frmPayment : Form
    {
        string sendStr;
        string sendMoney;
        DataGridView dataGridView;
        DataTable ss;
        int type;
        public string SendStr { get => sendStr; set => sendStr = value; }
        TextBox t1, t2, t3, t4, t5;
        public DataGridView DataGridView { get => dataGridView; set => dataGridView = value; }
        public TextBox T1 { get => t1; set => t1 = value; }
        public TextBox T2 { get => t2; set => t2 = value; }
        public TextBox T3 { get => t3; set => t3 = value; }
        public TextBox T4 { get => t4; set => t4 = value; }
        public TextBox T5 { get => t5; set => t5 = value; }
        public DataTable Ss { get => ss; set => ss = value; }

        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(string text, int a) : this()
        {
            sendMoney = text;
            type = a;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            Sell s = Sell.Load();
 
            if (type == 1&& s.Ages != 0)
            {
                this.Visible = false;
                frmCash fc = new frmCash(sendMoney);
                frmMain fm = (frmMain)Owner;
                dataGridView = fm.DataGridView;
                t1 = fm.T1;
                t2 = fm.T2;
                t3 = fm.T3;
                t4 = fm.T4;
                t5 = fm.T5;
                ss = fm.SellTable1;

                fc.Owner = this;
                fc.ShowDialog();
                this.Dispose();
            }
           else if (type == 0 && s.Ages != 0)
            {
  
                this.Visible = false;
                frmCard fc = new frmCard(sendMoney);
                frmMain fm = (frmMain)Owner;
                dataGridView = fm.DataGridView;
                t1 = fm.T1;
                t2 = fm.T2;
                t3 = fm.T3;
                t4 = fm.T4;
                t5 = fm.T5;
                ss = fm.SellTable1;
                fc.Owner = this;
                fc.ShowDialog();
                this.Dispose();
            }

        }

        private void btn_click(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            Sell s = Sell.Load();
            if (type == 1)
            {
                s.Ages = int.Parse(click.Name.Substring(3, click.Name.Length - 3));
                this.Visible = false;
                frmCash fc = new frmCash(sendMoney);
                frmMain fm = (frmMain)Owner;
                dataGridView = fm.DataGridView;
                t1 = fm.T1;
                t2 = fm.T2;
                t3 = fm.T3;
                t4 = fm.T4;
                t5 = fm.T5;
                ss = fm.SellTable1;

                fc.Owner = this;
                fc.ShowDialog();
                this.Dispose();
            }
            else
            {
                s.Ages = int.Parse(click.Name.Substring(3, click.Name.Length - 3));
                this.Visible = false;
                frmCard fc = new frmCard(sendMoney);
                frmMain fm = (frmMain)Owner;
                dataGridView = fm.DataGridView;
                t1 = fm.T1;
                t2 = fm.T2;
                t3 = fm.T3;
                t4 = fm.T4;
                t5 = fm.T5;
                ss = fm.SellTable1;
                fc.Owner = this;
                fc.ShowDialog();
                this.Dispose();
            }
        }
    }
}
