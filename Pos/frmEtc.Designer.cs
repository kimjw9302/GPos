namespace Pos
{
    partial class frmEtc
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
            this.btnStockSelect = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockSelect
            // 
            this.btnStockSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnStockSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStockSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockSelect.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockSelect.ForeColor = System.Drawing.Color.White;
            this.btnStockSelect.Location = new System.Drawing.Point(42, 37);
            this.btnStockSelect.Name = "btnStockSelect";
            this.btnStockSelect.Size = new System.Drawing.Size(165, 104);
            this.btnStockSelect.TabIndex = 15;
            this.btnStockSelect.Text = "이벤트 등록\r\n및 조회";
            this.btnStockSelect.UseVisualStyleBackColor = false;
            this.btnStockSelect.Click += new System.EventHandler(this.btnStockSelect_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(214, 37);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(165, 104);
            this.btnLog.TabIndex = 14;
            this.btnLog.Text = "로그";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnMail.ForeColor = System.Drawing.Color.White;
            this.btnMail.Location = new System.Drawing.Point(41, 145);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(165, 104);
            this.btnMail.TabIndex = 16;
            this.btnMail.Text = "관리자\r\n문의메일";
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(214, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 104);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEtc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(419, 286);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnStockSelect);
            this.Controls.Add(this.btnLog);
            this.Name = "frmEtc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOODEE24";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockSelect;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnClose;
    }
}