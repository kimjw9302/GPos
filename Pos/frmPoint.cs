﻿using System;
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
    public partial class frmPoint : Form
    {
        SqlConnection con;

        public frmPoint()
        {
            InitializeComponent();
        }

        private void btnPAccum_Click(object sender, EventArgs e)
        {

        }

        private void btnPUse_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            con = DBcontroller.Instance();
         
        }

        private void frmPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
