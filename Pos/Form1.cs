﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }
    }
}
