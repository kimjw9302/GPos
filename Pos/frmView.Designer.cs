﻿namespace Pos
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
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnStockSelect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 104);
            this.button2.TabIndex = 1;
            this.button2.Text = "고객 조회";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 104);
            this.button4.TabIndex = 3;
            this.button4.Text = "판매 조회(영수증)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 104);
            this.button5.TabIndex = 4;
            this.button5.Text = "매출현황 조회";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnStockSelect
            // 
            this.btnStockSelect.Location = new System.Drawing.Point(159, 181);
            this.btnStockSelect.Name = "btnStockSelect";
            this.btnStockSelect.Size = new System.Drawing.Size(114, 104);
            this.btnStockSelect.TabIndex = 5;
            this.btnStockSelect.Text = "재고 조회";
            this.btnStockSelect.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "상품 조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 104);
            this.button3.TabIndex = 6;
            this.button3.Text = "로그 조회";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 454);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStockSelect);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmView";
            this.Text = "frmView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnStockSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}