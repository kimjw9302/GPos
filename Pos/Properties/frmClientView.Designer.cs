﻿namespace Pos.Properties
{
    partial class frmClientView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(839, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(614, 94);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(208, 65);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(32, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 178);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객번호";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 25);
            this.textBox1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(465, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 152);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(29, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "회원목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "성별";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "전체";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(146, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 19);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "남";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(195, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 19);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "여";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(74, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 69);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(614, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(94, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "이름";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 25);
            this.textBox2.TabIndex = 10;
            // 
            // frmClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 694);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmClientView";
            this.Text = "frmClientView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}