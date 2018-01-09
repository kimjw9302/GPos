namespace Pos
{
    partial class frmView
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
            this.btnCustInquiry = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnStockSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustInquiry
            // 
            this.btnCustInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCustInquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCustInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustInquiry.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnCustInquiry.ForeColor = System.Drawing.Color.White;
            this.btnCustInquiry.Location = new System.Drawing.Point(230, 185);
            this.btnCustInquiry.Name = "btnCustInquiry";
            this.btnCustInquiry.Size = new System.Drawing.Size(114, 104);
            this.btnCustInquiry.TabIndex = 1;
            this.btnCustInquiry.Text = "고객 조회";
            this.btnCustInquiry.UseVisualStyleBackColor = false;
            this.btnCustInquiry.Click += new System.EventHandler(this.btnCustInquiry_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(229, 77);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(114, 104);
            this.btnSell.TabIndex = 3;
            this.btnSell.Text = "판매 조회\r\n(영수증)\r\n";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnRevenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Location = new System.Drawing.Point(110, 185);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(114, 104);
            this.btnRevenue.TabIndex = 4;
            this.btnRevenue.Text = "매출 현황\r\n조회";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnStockSelect
            // 
            this.btnStockSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnStockSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStockSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockSelect.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnStockSelect.ForeColor = System.Drawing.Color.White;
            this.btnStockSelect.Location = new System.Drawing.Point(110, 77);
            this.btnStockSelect.Name = "btnStockSelect";
            this.btnStockSelect.Size = new System.Drawing.Size(114, 104);
            this.btnStockSelect.TabIndex = 5;
            this.btnStockSelect.Text = "재고 조회";
            this.btnStockSelect.UseVisualStyleBackColor = false;
            this.btnStockSelect.Click += new System.EventHandler(this.btnStockSelect_Click);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(442, 354);
            this.Controls.Add(this.btnStockSelect);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnCustInquiry);
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gpos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCustInquiry;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnStockSelect;
    }
}