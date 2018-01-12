﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Pos
{
    public partial class frmAddrSearch : Form
    {
        string currentPage = "1";  
        string countPerPage = "1000"; 
        string confmKey = "U01TX0FVVEgyMDE4MDExMTA5NTE0NjEwNzYwNTY="; 
        string keyword = string.Empty;
        string url = string.Empty;

        DataTable addrTable;
        DataRowCollection rows;

        public frmAddrSearch(string addr)
        {
            keyword = addr;
            InitializeComponent();
        }
        private void frmAddrSearch_Load(object sender, EventArgs e)
        {
            txtAddr.Text = keyword;
            Search();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            listAddr.Items.Clear();
            url = "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage=" + currentPage + "&countPerPage=" + countPerPage + "&keyword=" + keyword + "&confmKey=" + confmKey;

            WebClient wc = new WebClient();
            XmlReader read = new XmlTextReader(wc.OpenRead(url));
            DataSet ds = new DataSet();
            ds.ReadXml(read);

            addrTable = ds.Tables[1];
            rows = addrTable.Rows;

            foreach (DataRow item in rows)
            {
                listAddr.Items.Add(item[0]);
            }
        }

        private void listAddr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmCustRegister beforForm = (frmCustRegister)Owner;
            beforForm.SearchResult = listAddr.SelectedItem.ToString();
            this.Close();
        }
    }
}