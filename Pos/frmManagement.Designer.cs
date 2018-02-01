namespace Pos
{
    partial class frmManagement
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
            this.btnProductRegister = new System.Windows.Forms.Button();
            this.btnCustRegister = new System.Windows.Forms.Button();
            this.btnEmployeeRegister = new System.Windows.Forms.Button();
            this.btnEmpWork = new System.Windows.Forms.Button();
            this.btnAban = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductRegister
            // 
            this.btnProductRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnProductRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnProductRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductRegister.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductRegister.ForeColor = System.Drawing.Color.White;
            this.btnProductRegister.Location = new System.Drawing.Point(158, 39);
            this.btnProductRegister.Name = "btnProductRegister";
            this.btnProductRegister.Size = new System.Drawing.Size(114, 104);
            this.btnProductRegister.TabIndex = 12;
            this.btnProductRegister.Text = "상품 등록\r\n[F2]";
            this.btnProductRegister.UseVisualStyleBackColor = false;
            this.btnProductRegister.Click += new System.EventHandler(this.btnProductRegister_Click);
            // 
            // btnCustRegister
            // 
            this.btnCustRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCustRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCustRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustRegister.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnCustRegister.ForeColor = System.Drawing.Color.White;
            this.btnCustRegister.Location = new System.Drawing.Point(39, 39);
            this.btnCustRegister.Name = "btnCustRegister";
            this.btnCustRegister.Size = new System.Drawing.Size(114, 104);
            this.btnCustRegister.TabIndex = 13;
            this.btnCustRegister.Text = "회원 등록\r\n[F1]";
            this.btnCustRegister.UseVisualStyleBackColor = false;
            this.btnCustRegister.Click += new System.EventHandler(this.btnCustRegister_Click_1);
            // 
            // btnEmployeeRegister
            // 
            this.btnEmployeeRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnEmployeeRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEmployeeRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeRegister.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeRegister.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeRegister.Location = new System.Drawing.Point(39, 148);
            this.btnEmployeeRegister.Name = "btnEmployeeRegister";
            this.btnEmployeeRegister.Size = new System.Drawing.Size(114, 104);
            this.btnEmployeeRegister.TabIndex = 14;
            this.btnEmployeeRegister.Text = "직원 등록\r\n[F4]";
            this.btnEmployeeRegister.UseVisualStyleBackColor = false;
            this.btnEmployeeRegister.Click += new System.EventHandler(this.btnEmployeeRegister_Click);
            // 
            // btnEmpWork
            // 
            this.btnEmpWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnEmpWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEmpWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpWork.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmpWork.ForeColor = System.Drawing.Color.White;
            this.btnEmpWork.Location = new System.Drawing.Point(159, 148);
            this.btnEmpWork.Name = "btnEmpWork";
            this.btnEmpWork.Size = new System.Drawing.Size(114, 104);
            this.btnEmpWork.TabIndex = 15;
            this.btnEmpWork.Text = "직원 근태\r\n[F5]";
            this.btnEmpWork.UseVisualStyleBackColor = false;
            this.btnEmpWork.Click += new System.EventHandler(this.btnEmpWork_Click);
            // 
            // btnAban
            // 
            this.btnAban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAban.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAban.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnAban.ForeColor = System.Drawing.Color.White;
            this.btnAban.Location = new System.Drawing.Point(277, 39);
            this.btnAban.Name = "btnAban";
            this.btnAban.Size = new System.Drawing.Size(114, 104);
            this.btnAban.TabIndex = 17;
            this.btnAban.Text = "폐기 등록\r\n[F3]";
            this.btnAban.UseVisualStyleBackColor = false;
            this.btnAban.Click += new System.EventHandler(this.btnAban_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(278, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 104);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "닫기\r\n[Q]";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(430, 296);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAban);
            this.Controls.Add(this.btnEmpWork);
            this.Controls.Add(this.btnEmployeeRegister);
            this.Controls.Add(this.btnCustRegister);
            this.Controls.Add(this.btnProductRegister);
            this.Name = "frmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductRegister;
        private System.Windows.Forms.Button btnCustRegister;
        private System.Windows.Forms.Button btnEmployeeRegister;
        private System.Windows.Forms.Button btnEmpWork;
        private System.Windows.Forms.Button btnAban;
        private System.Windows.Forms.Button btnClose;
    }
}