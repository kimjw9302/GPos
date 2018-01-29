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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustInquiry
            // 
            this.btnCustInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCustInquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCustInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustInquiry.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnCustInquiry.ForeColor = System.Drawing.Color.White;
            this.btnCustInquiry.Location = new System.Drawing.Point(146, 144);
            this.btnCustInquiry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustInquiry.Name = "btnCustInquiry";
            this.btnCustInquiry.Size = new System.Drawing.Size(130, 130);
            this.btnCustInquiry.TabIndex = 1;
            this.btnCustInquiry.Text = "고객 조회";
            this.btnCustInquiry.UseVisualStyleBackColor = false;
            this.btnCustInquiry.Click += new System.EventHandler(this.btnCustInquiry_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(145, 9);
            this.btnSell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(130, 130);
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
            this.btnRevenue.Location = new System.Drawing.Point(9, 144);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(130, 130);
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
            this.btnStockSelect.Location = new System.Drawing.Point(9, 9);
            this.btnStockSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStockSelect.Name = "btnStockSelect";
            this.btnStockSelect.Size = new System.Drawing.Size(130, 130);
            this.btnStockSelect.TabIndex = 5;
            this.btnStockSelect.Text = "재고 조회";
            this.btnStockSelect.UseVisualStyleBackColor = false;
            this.btnStockSelect.Click += new System.EventHandler(this.btnStockSelect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(282, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 130);
            this.button1.TabIndex = 6;
            this.button1.Text = "직원 조회";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Red;
            this.btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(282, 144);
            this.btnOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(130, 130);
            this.btnOut.TabIndex = 7;
            this.btnOut.Text = "닫기";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(422, 283);
            this.ControlBox = false;
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStockSelect);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnCustInquiry);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "통합 조회";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCustInquiry;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnStockSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOut;
    }
}