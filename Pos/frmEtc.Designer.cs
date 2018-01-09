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
            this.SuspendLayout();
            // 
            // btnStockSelect
            // 
            this.btnStockSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnStockSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStockSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockSelect.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockSelect.ForeColor = System.Drawing.Color.White;
            this.btnStockSelect.Location = new System.Drawing.Point(105, 128);
            this.btnStockSelect.Name = "btnStockSelect";
            this.btnStockSelect.Size = new System.Drawing.Size(114, 104);
            this.btnStockSelect.TabIndex = 15;
            this.btnStockSelect.Text = "이벤트 등록/조회";
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
            this.btnLog.Location = new System.Drawing.Point(225, 128);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(114, 104);
            this.btnLog.TabIndex = 14;
            this.btnLog.Text = "로그";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // frmEtc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(433, 337);
            this.Controls.Add(this.btnStockSelect);
            this.Controls.Add(this.btnLog);
            this.Name = "frmEtc";
            this.Text = "frmEtc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockSelect;
        private System.Windows.Forms.Button btnLog;
    }
}