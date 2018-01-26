namespace Pos
{
    partial class frmEmployee
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxhourlyWage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
<<<<<<< HEAD
            this.pboxBarcode = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
=======
            this.btnClose = new System.Windows.Forms.Button();
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
=======

            this.pboxBarcode = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();

            this.btnClose = new System.Windows.Forms.Button();

>>>>>>> 메인폼
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(82, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "회원목록";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxhourlyWage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tboxPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tboxPosition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSub);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tboxName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(87, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 238);
            this.panel1.TabIndex = 6;
            // 
            // tboxhourlyWage
            // 
            this.tboxhourlyWage.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxhourlyWage.Location = new System.Drawing.Point(198, 181);
            this.tboxhourlyWage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxhourlyWage.Name = "tboxhourlyWage";
            this.tboxhourlyWage.Size = new System.Drawing.Size(196, 42);
            this.tboxhourlyWage.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(94, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "시급";
            // 
            // tboxPhone
            // 
            this.tboxPhone.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxPhone.Location = new System.Drawing.Point(198, 119);
            this.tboxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(196, 42);
            this.tboxPhone.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "전화번호";
            // 
            // tboxPosition
            // 
            this.tboxPosition.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxPosition.Location = new System.Drawing.Point(198, 65);
            this.tboxPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxPosition.Name = "tboxPosition";
            this.tboxPosition.Size = new System.Drawing.Size(196, 42);
            this.tboxPosition.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(94, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "직책";
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSub.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(614, 12);
            this.btnSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(208, 100);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "수정";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnDel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(614, 125);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(208, 100);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(470, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 212);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxName.Location = new System.Drawing.Point(198, 12);
            this.tboxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(196, 42);
            this.tboxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "직원이름";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(87, 364);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.Height = 27;
            this.dgvEmployees.Size = new System.Drawing.Size(506, 358);
            this.dgvEmployees.TabIndex = 5;
            this.dgvEmployees.Click += new System.EventHandler(this.dgvEmployees_Click);
            // 
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 메인폼
            // pboxBarcode
            // 
            this.pboxBarcode.BackColor = System.Drawing.Color.White;
            this.pboxBarcode.Location = new System.Drawing.Point(756, 394);
            this.pboxBarcode.Name = "pboxBarcode";
            this.pboxBarcode.Size = new System.Drawing.Size(153, 183);
            this.pboxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxBarcode.TabIndex = 8;
            this.pboxBarcode.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(608, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "직원바코드";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnPrint.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(613, 622);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(313, 100);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "바코드 출력";
            this.btnPrint.UseVisualStyleBackColor = false;
<<<<<<< HEAD
=======
=======

>>>>>>> 메인폼
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(628, 581);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 80);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
<<<<<<< HEAD
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
=======

>>>>>>> 메인폼
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1009, 735);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pboxBarcode);
=======
            this.ClientSize = new System.Drawing.Size(883, 672);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
=======
         this.ClientSize = new System.Drawing.Size(1009, 735);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pboxBarcode);

            this.Controls.Add(this.btnClose);

>>>>>>> 메인폼
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployees);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TextBox tboxhourlyWage;
        private System.Windows.Forms.Label label5;
<<<<<<< HEAD
<<<<<<< HEAD
        private System.Windows.Forms.PictureBox pboxBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
=======
        private System.Windows.Forms.Button btnClose;
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
=======
        private System.Windows.Forms.PictureBox pboxBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;

>>>>>>> 메인폼
    }
}