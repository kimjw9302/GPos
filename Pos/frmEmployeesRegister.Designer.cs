namespace Pos
{
    partial class frmEmployeesRegister
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
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtWage = new System.Windows.Forms.MaskedTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone3 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.cbPhone1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRank
            // 
            this.cbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRank.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Location = new System.Drawing.Point(144, 241);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(260, 29);
            this.cbRank.TabIndex = 7;
            // 
            // group
            // 
            this.group.Controls.Add(this.btnclose);
            this.group.Controls.Add(this.txtWage);
            this.group.Controls.Add(this.btnRegister);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.label8);
            this.group.Controls.Add(this.label10);
            this.group.Controls.Add(this.label11);
            this.group.Controls.Add(this.txtPhone3);
            this.group.Controls.Add(this.txtPhone2);
            this.group.Controls.Add(this.cbPhone1);
            this.group.Controls.Add(this.label12);
            this.group.Controls.Add(this.txtEmpNum);
            this.group.Controls.Add(this.label14);
            this.group.Controls.Add(this.txtEmpName);
            this.group.Controls.Add(this.label16);
            this.group.Controls.Add(this.cbRank);
            this.group.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.group.Location = new System.Drawing.Point(25, 40);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(493, 514);
            this.group.TabIndex = 25;
            this.group.TabStop = false;
            this.group.Text = "직원 등록";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(267, 369);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(121, 90);
            this.btnclose.TabIndex = 48;
            this.btnclose.Text = "닫기";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtWage
            // 
            this.txtWage.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWage.Location = new System.Drawing.Point(144, 285);
            this.txtWage.Mask = "0000000";
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(261, 32);
            this.txtWage.TabIndex = 47;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(130, 369);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(121, 90);
            this.btnRegister.TabIndex = 46;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(96, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "시급";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(96, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "직급";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(310, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(207, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "-";
            // 
            // txtPhone3
            // 
            this.txtPhone3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPhone3.Location = new System.Drawing.Point(330, 193);
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.Size = new System.Drawing.Size(76, 32);
            this.txtPhone3.TabIndex = 39;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPhone2.Location = new System.Drawing.Point(226, 192);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(82, 32);
            this.txtPhone2.TabIndex = 38;
            // 
            // cbPhone1
            // 
            this.cbPhone1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhone1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbPhone1.FormattingEnabled = true;
            this.cbPhone1.Items.AddRange(new object[] {
            "010",
            "011",
            "019",
            "016"});
            this.cbPhone1.Location = new System.Drawing.Point(144, 193);
            this.cbPhone1.Name = "cbPhone1";
            this.cbPhone1.Size = new System.Drawing.Size(62, 29);
            this.cbPhone1.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(65, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 36;
            this.label12.Text = "휴대전화";
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmpNum.Location = new System.Drawing.Point(145, 93);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(261, 32);
            this.txtEmpNum.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(65, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 33;
            this.label14.Text = "직원번호";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmpName.Location = new System.Drawing.Point(145, 148);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(261, 32);
            this.txtEmpName.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(97, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 21);
            this.label16.TabIndex = 27;
            this.label16.Text = "이름";
            // 
            // frmEmployeesRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(544, 600);
            this.ControlBox = false;
            this.Controls.Add(this.group);
            this.Name = "frmEmployeesRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "직원등록창";
            this.Load += new System.EventHandler(this.frmEmployeesRegister_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhone3;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.ComboBox cbPhone1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.MaskedTextBox txtWage;
        private System.Windows.Forms.Button btnclose;
    }
}