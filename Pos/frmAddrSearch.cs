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
        private string currentPage = "1";  
        private string countPerPage = "1000"; 
        private string confmKey = "U01TX0FVVEgyMDE4MDExMTA5NTE0NjEwNzYwNTY="; 
        private string keyword = string.Empty;
        private string url = string.Empty;
        private int i = 0;
        private DataTable addrTable;
        private DataRowCollection rows;

        public frmAddrSearch()
        {
            InitializeComponent();
        }
        public frmAddrSearch(string addr,int i) : this()
        {
            keyword = addr;
            this.i = i;

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
            try
            {
                listAddr.Items.Clear();
                keyword = txtAddr.Text;
                url = "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage=" + currentPage +
                    "&countPerPage=" + countPerPage + "&keyword=" + keyword + "&confmKey=" + confmKey;

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
            catch (Exception)
            {
                txtAddr.Text = "";
                MessageBox.Show("없는 주소입니다. \n 재검색하세요.");
            }
        }

        private void listAddr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (i == 0)
            {
                frmCustRegister beforForm = (frmCustRegister)Owner;
                beforForm.SearchResult = listAddr.SelectedItem.ToString();
            }
            else
            {
                frmStoreInfo fsi = (frmStoreInfo)Owner;
                fsi.SearchResult = listAddr.SelectedItem.ToString();
            }
        
           
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
