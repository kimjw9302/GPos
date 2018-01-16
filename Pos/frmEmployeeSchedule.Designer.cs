namespace Pos
{
    partial class frmEmployeeSchedule
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
            this.dgvWorkView = new System.Windows.Forms.DataGridView();
            this.cbEmp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWorkView
            // 
            this.dgvWorkView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkView.Location = new System.Drawing.Point(16, 196);
            this.dgvWorkView.Name = "dgvWorkView";
            this.dgvWorkView.RowTemplate.Height = 23;
            this.dgvWorkView.Size = new System.Drawing.Size(778, 411);
            this.dgvWorkView.TabIndex = 3;
            // 
            // cbEmp
            // 
            this.cbEmp.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbEmp.FormattingEnabled = true;
            this.cbEmp.Location = new System.Drawing.Point(105, 24);
            this.cbEmp.Name = "cbEmp";
            this.cbEmp.Size = new System.Drawing.Size(121, 28);
            this.cbEmp.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "직원 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(60, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "기간";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(283, 23);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(151, 29);
            this.dtpEndDate.TabIndex = 26;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(105, 23);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(145, 29);
            this.dtpStartDate.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(256, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "~";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(695, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 68);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.OrangeRed;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(695, 102);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(99, 72);
            this.btnView.TabIndex = 31;
            this.btnView.Text = "조회";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 94);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpStartDate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpEndDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 68);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기간별 전직원";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbEmp);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 68);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "기간 & 직원별 ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(817, 656);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvWorkView);
            this.Name = "frmEmployeeSchedule";
            this.Load += new System.EventHandler(this.frmEmployeeSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvWorkView;
        private System.Windows.Forms.ComboBox cbEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}