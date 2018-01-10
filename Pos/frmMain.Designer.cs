﻿namespace Pos
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOutgo = new System.Windows.Forms.Button();
            this.btnTotalView = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnHundred = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.button35 = new System.Windows.Forms.Button();
            this.txtPaymentList = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnTotalCancel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmployeeChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPosNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSeven = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEtc = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProduct
            // 
            this.gridProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.gridProduct.Location = new System.Drawing.Point(10, 78);
            this.gridProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.RowTemplate.Height = 23;
            this.gridProduct.Size = new System.Drawing.Size(1006, 347);
            this.gridProduct.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "상품명";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "단가";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "수량";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "금액";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "할인";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "비고";
            this.Column7.Name = "Column7";
            // 
            // btnOutgo
            // 
            this.btnOutgo.BackColor = System.Drawing.Color.Snow;
            this.btnOutgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutgo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOutgo.Location = new System.Drawing.Point(1023, 253);
            this.btnOutgo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOutgo.Name = "btnOutgo";
            this.btnOutgo.Size = new System.Drawing.Size(149, 85);
            this.btnOutgo.TabIndex = 11;
            this.btnOutgo.Text = "외출";
            this.btnOutgo.UseVisualStyleBackColor = false;
            // 
            // btnTotalView
            // 
            this.btnTotalView.BackColor = System.Drawing.Color.Snow;
            this.btnTotalView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalView.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTotalView.Location = new System.Drawing.Point(1023, 79);
            this.btnTotalView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotalView.Name = "btnTotalView";
            this.btnTotalView.Size = new System.Drawing.Size(149, 85);
            this.btnTotalView.TabIndex = 12;
            this.btnTotalView.Text = "통합 조회";
            this.btnTotalView.UseVisualStyleBackColor = false;
            this.btnTotalView.Click += new System.EventHandler(this.btnTotalView_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.Snow;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCard.Location = new System.Drawing.Point(10, 429);
            this.btnCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(149, 83);
            this.btnCard.TabIndex = 13;
            this.btnCard.Text = "신용카드 결제";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEight.Location = new System.Drawing.Point(936, 516);
            this.btnEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(80, 79);
            this.btnEight.TabIndex = 17;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNine.Location = new System.Drawing.Point(1016, 516);
            this.btnNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(80, 79);
            this.btnNine.TabIndex = 17;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSix.Location = new System.Drawing.Point(1016, 594);
            this.btnSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(80, 79);
            this.btnSix.TabIndex = 20;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFive.Location = new System.Drawing.Point(936, 594);
            this.btnFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(80, 79);
            this.btnFive.TabIndex = 19;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFour.Location = new System.Drawing.Point(856, 594);
            this.btnFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(80, 79);
            this.btnFour.TabIndex = 18;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThree.Location = new System.Drawing.Point(1016, 673);
            this.btnThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(80, 79);
            this.btnThree.TabIndex = 23;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTwo.Location = new System.Drawing.Point(936, 673);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(80, 79);
            this.btnTwo.TabIndex = 22;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOne.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOne.Location = new System.Drawing.Point(856, 673);
            this.btnOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(80, 79);
            this.btnOne.TabIndex = 21;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(137)))), ((int)(((byte)(2)))));
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUp.Location = new System.Drawing.Point(1096, 594);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(80, 79);
            this.btnUp.TabIndex = 26;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // btnHundred
            // 
            this.btnHundred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnHundred.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHundred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHundred.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHundred.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHundred.Location = new System.Drawing.Point(936, 752);
            this.btnHundred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHundred.Name = "btnHundred";
            this.btnHundred.Size = new System.Drawing.Size(80, 79);
            this.btnHundred.TabIndex = 25;
            this.btnHundred.Text = "00";
            this.btnHundred.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.Control;
            this.btnZero.Location = new System.Drawing.Point(856, 752);
            this.btnZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(80, 79);
            this.btnZero.TabIndex = 24;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Snow;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCash.Location = new System.Drawing.Point(167, 429);
            this.btnCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(149, 83);
            this.btnCash.TabIndex = 27;
            this.btnCash.Text = "현금 결제";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Snow;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPoint.Location = new System.Drawing.Point(324, 429);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(149, 83);
            this.btnPoint.TabIndex = 29;
            this.btnPoint.Text = "포인트 적립/사용";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button35);
            this.panel1.Controls.Add(this.txtPaymentList);
            this.panel1.Location = new System.Drawing.Point(12, 516);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 300);
            this.panel1.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61035F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38965F));
            this.tableLayoutPanel1.Controls.Add(this.button34, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button33, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button32, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button31, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button30, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReceive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtReceived, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtChange, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProduct, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(377, -1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 303);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(87)))));
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(0, 240);
            this.button34.Margin = new System.Windows.Forms.Padding(0);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(127, 61);
            this.button34.TabIndex = 48;
            this.button34.Text = "거스름돈";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(87)))));
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button33.ForeColor = System.Drawing.Color.White;
            this.button33.Location = new System.Drawing.Point(0, 180);
            this.button33.Margin = new System.Windows.Forms.Padding(0);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(127, 60);
            this.button33.TabIndex = 47;
            this.button33.Text = "받은금액";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(87)))));
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(0, 120);
            this.button32.Margin = new System.Windows.Forms.Padding(0);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(127, 60);
            this.button32.TabIndex = 46;
            this.button32.Text = "받을금액";
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(87)))));
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(0, 60);
            this.button31.Margin = new System.Windows.Forms.Padding(0);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(127, 60);
            this.button31.TabIndex = 45;
            this.button31.Text = "수량";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.Location = new System.Drawing.Point(0, 0);
            this.button30.Margin = new System.Windows.Forms.Padding(0);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(127, 60);
            this.button30.TabIndex = 44;
            this.button30.Text = "상품등록";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReceive.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReceive.Location = new System.Drawing.Point(127, 120);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(0);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(317, 61);
            this.txtReceive.TabIndex = 3;
            this.txtReceive.Text = "0";
            this.txtReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtReceived
            // 
            this.txtReceived.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReceived.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReceived.Location = new System.Drawing.Point(127, 180);
            this.txtReceived.Margin = new System.Windows.Forms.Padding(0);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(317, 61);
            this.txtReceived.TabIndex = 4;
            this.txtReceived.Text = "0";
            this.txtReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReceived.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceived_KeyDown);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChange.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtChange.ForeColor = System.Drawing.Color.Red;
            this.txtChange.Location = new System.Drawing.Point(127, 240);
            this.txtChange.Margin = new System.Windows.Forms.Padding(0);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(317, 61);
            this.txtChange.TabIndex = 5;
            this.txtChange.Text = "0";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuantity.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQuantity.Location = new System.Drawing.Point(127, 60);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(317, 61);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtProduct.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProduct.Location = new System.Drawing.Point(127, 0);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(0);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(317, 61);
            this.txtProduct.TabIndex = 1;
            this.txtProduct.Text = "0";
            this.txtProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(87)))));
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button35.ForeColor = System.Drawing.Color.White;
            this.button35.Location = new System.Drawing.Point(-1, -5);
            this.button35.Margin = new System.Windows.Forms.Padding(0);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(51, 314);
            this.button35.TabIndex = 46;
            this.button35.Text = "결제내역";
            this.button35.UseVisualStyleBackColor = false;
            // 
            // txtPaymentList
            // 
            this.txtPaymentList.Location = new System.Drawing.Point(-1, -1);
            this.txtPaymentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentList.Multiline = true;
            this.txtPaymentList.Name = "txtPaymentList";
            this.txtPaymentList.Size = new System.Drawing.Size(382, 311);
            this.txtPaymentList.TabIndex = 0;
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(67)))), ((int)(((byte)(22)))));
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefund.Location = new System.Drawing.Point(479, 429);
            this.btnRefund.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(149, 83);
            this.btnRefund.TabIndex = 32;
            this.btnRefund.Text = "환불";
            this.btnRefund.UseVisualStyleBackColor = false;
            // 
            // btnTotalCancel
            // 
            this.btnTotalCancel.BackColor = System.Drawing.Color.Snow;
            this.btnTotalCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTotalCancel.Location = new System.Drawing.Point(634, 429);
            this.btnTotalCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotalCancel.Name = "btnTotalCancel";
            this.btnTotalCancel.Size = new System.Drawing.Size(149, 83);
            this.btnTotalCancel.TabIndex = 33;
            this.btnTotalCancel.Text = "상품 전체 취소";
            this.btnTotalCancel.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(1096, 516);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 79);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "<-";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInit.Location = new System.Drawing.Point(1016, 752);
            this.btnInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(160, 79);
            this.btnInit.TabIndex = 35;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(137)))), ((int)(((byte)(2)))));
            this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDown.Location = new System.Drawing.Point(1096, 673);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(80, 79);
            this.btnDown.TabIndex = 37;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Snow;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.Location = new System.Drawing.Point(1023, 340);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(149, 85);
            this.btnOrder.TabIndex = 40;
            this.btnOrder.Text = "발주";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetting.Location = new System.Drawing.Point(950, -2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(122, 63);
            this.btnSetting.TabIndex = 44;
            this.btnSetting.Text = "매장정보변경";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEmployeeChange);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCalc);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblEmployee);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblPosNum);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 62);
            this.panel2.TabIndex = 9;
            // 
            // btnEmployeeChange
            // 
            this.btnEmployeeChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployeeChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeChange.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEmployeeChange.Location = new System.Drawing.Point(732, -1);
            this.btnEmployeeChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeeChange.Name = "btnEmployeeChange";
            this.btnEmployeeChange.Size = new System.Drawing.Size(109, 62);
            this.btnEmployeeChange.TabIndex = 54;
            this.btnEmployeeChange.Text = "담당자교대";
            this.btnEmployeeChange.UseVisualStyleBackColor = true;
            this.btnEmployeeChange.Click += new System.EventHandler(this.btnEmployeeChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "포스 번호 :";
            // 
            // btnCalc
            // 
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCalc.Location = new System.Drawing.Point(841, -1);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(109, 62);
            this.btnCalc.TabIndex = 52;
            this.btnCalc.Text = "계산기";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1072, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 62);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "종료";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(498, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(198, 21);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "2018-01-05 17:28:33 (금)";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblEmployee.Location = new System.Drawing.Point(402, 20);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(58, 21);
            this.lblEmployee.TabIndex = 48;
            this.lblEmployee.Text = "홍길동";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(340, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "담당자 : ";
            // 
            // lblPosNum
            // 
            this.lblPosNum.AutoSize = true;
            this.lblPosNum.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPosNum.ForeColor = System.Drawing.Color.Black;
            this.lblPosNum.Location = new System.Drawing.Point(270, 22);
            this.lblPosNum.Name = "lblPosNum";
            this.lblPosNum.Size = new System.Drawing.Size(28, 21);
            this.lblPosNum.TabIndex = 46;
            this.lblPosNum.Text = "01";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(106, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "합계 수량 / 금액 / 할인";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 45);
            this.label6.TabIndex = 43;
            this.label6.Text = "판매 등록";
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeven.Location = new System.Drawing.Point(856, 516);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(80, 79);
            this.btnSeven.TabIndex = 43;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnEtc
            // 
            this.btnEtc.BackColor = System.Drawing.Color.Snow;
            this.btnEtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtc.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEtc.Location = new System.Drawing.Point(1023, 427);
            this.btnEtc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(149, 85);
            this.btnEtc.TabIndex = 47;
            this.btnEtc.Text = "기타";
            this.btnEtc.UseVisualStyleBackColor = false;
            this.btnEtc.Click += new System.EventHandler(this.btnEtc_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.Snow;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnManagement.Location = new System.Drawing.Point(1023, 166);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(149, 85);
            this.btnManagement.TabIndex = 30;
            this.btnManagement.Text = "관리";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 838);
            this.ControlBox = false;
            this.Controls.Add(this.btnEtc);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnTotalCancel);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnManagement);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnHundred);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnTotalView);
            this.Controls.Add(this.btnOutgo);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "포스";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.Button btnOutgo;
        private System.Windows.Forms.Button btnTotalView;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnHundred;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnTotalCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnOrder;

        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPosNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPaymentList;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnEmployeeChange;
        public System.Windows.Forms.Label lblEmployee;
    }
}