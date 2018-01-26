namespace Pos
{
    partial class frmReturnReason
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
            this.btnTradeC = new System.Windows.Forms.Button();
            this.btnErrorC = new System.Windows.Forms.Button();
            this.btnEtcC = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTradeC
            // 
            this.btnTradeC.BackColor = System.Drawing.Color.Snow;
            this.btnTradeC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTradeC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTradeC.Location = new System.Drawing.Point(99, 55);
            this.btnTradeC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTradeC.Name = "btnTradeC";
            this.btnTradeC.Size = new System.Drawing.Size(149, 85);
            this.btnTradeC.TabIndex = 13;
            this.btnTradeC.Text = "거래 취소";
            this.btnTradeC.UseVisualStyleBackColor = false;
            this.btnTradeC.Click += new System.EventHandler(this.btnTradeC_Click);
            // 
            // btnErrorC
            // 
            this.btnErrorC.BackColor = System.Drawing.Color.Snow;
            this.btnErrorC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnErrorC.Location = new System.Drawing.Point(99, 144);
            this.btnErrorC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnErrorC.Name = "btnErrorC";
            this.btnErrorC.Size = new System.Drawing.Size(149, 85);
            this.btnErrorC.TabIndex = 14;
            this.btnErrorC.Text = "오류 발급 취소";
            this.btnErrorC.UseVisualStyleBackColor = false;
            this.btnErrorC.Click += new System.EventHandler(this.btnErrorC_Click);
            // 
            // btnEtcC
            // 
            this.btnEtcC.BackColor = System.Drawing.Color.Snow;
            this.btnEtcC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtcC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEtcC.Location = new System.Drawing.Point(99, 237);
            this.btnEtcC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEtcC.Name = "btnEtcC";
            this.btnEtcC.Size = new System.Drawing.Size(149, 85);
            this.btnEtcC.TabIndex = 15;
            this.btnEtcC.Text = "기타";
            this.btnEtcC.UseVisualStyleBackColor = false;
            this.btnEtcC.Click += new System.EventHandler(this.btnEtcC_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(99, 338);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(149, 85);
            this.btnCancle.TabIndex = 16;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmReturnReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(346, 478);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnEtcC);
            this.Controls.Add(this.btnErrorC);
            this.Controls.Add(this.btnTradeC);
            this.Name = "frmReturnReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReturnReason";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTradeC;
        private System.Windows.Forms.Button btnErrorC;
        private System.Windows.Forms.Button btnEtcC;
        private System.Windows.Forms.Button btnCancle;
    }
}