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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTradeC
            // 
            this.btnTradeC.BackColor = System.Drawing.Color.Snow;
            this.btnTradeC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTradeC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTradeC.Location = new System.Drawing.Point(121, 99);
            this.btnTradeC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTradeC.Name = "btnTradeC";
            this.btnTradeC.Size = new System.Drawing.Size(170, 106);
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
            this.btnErrorC.Location = new System.Drawing.Point(121, 210);
            this.btnErrorC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnErrorC.Name = "btnErrorC";
            this.btnErrorC.Size = new System.Drawing.Size(170, 106);
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
            this.btnEtcC.Location = new System.Drawing.Point(121, 326);
            this.btnEtcC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEtcC.Name = "btnEtcC";
            this.btnEtcC.Size = new System.Drawing.Size(170, 106);
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
            this.btnCancle.Location = new System.Drawing.Point(121, 452);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(170, 106);
            this.btnCancle.TabIndex = 16;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 돋음체", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "반품사유를 골라주세요.";
            // 
            // frmReturnReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(394, 598);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnEtcC);
            this.Controls.Add(this.btnErrorC);
            this.Controls.Add(this.btnTradeC);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReturnReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "반품사유";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTradeC;
        private System.Windows.Forms.Button btnErrorC;
        private System.Windows.Forms.Button btnEtcC;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label1;
    }
}