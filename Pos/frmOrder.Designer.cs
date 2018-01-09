namespace Pos
{
    partial class frmOrder
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
            this.btnOrderView = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrderView
            // 
            this.btnOrderView.Location = new System.Drawing.Point(95, 111);
            this.btnOrderView.Name = "btnOrderView";
            this.btnOrderView.Size = new System.Drawing.Size(114, 104);
            this.btnOrderView.TabIndex = 0;
            this.btnOrderView.Text = "발주 조회";
            this.btnOrderView.UseVisualStyleBackColor = true;
            this.btnOrderView.Click += new System.EventHandler(this.btnOrderView_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(215, 111);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(114, 104);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "발주 신청";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 315);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnOrderView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrderView;
        private System.Windows.Forms.Button btnOrder;
    }
}