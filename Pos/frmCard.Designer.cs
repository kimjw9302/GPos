namespace Pos
{
    partial class frmCard
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
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPay = new System.Windows.Forms.TextBox();
            this.tboxSale = new System.Windows.Forms.TextBox();
            this.tboxCardNum = new System.Windows.Forms.TextBox();
            this.tboxYear = new System.Windows.Forms.TextBox();
            this.tboxMonth = new System.Windows.Forms.TextBox();
            this.tboxIMonth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F);
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "결제금액";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F);
            this.label2.Location = new System.Drawing.Point(60, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "할인금액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F);
            this.label3.Location = new System.Drawing.Point(60, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "카드번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F);
            this.label4.Location = new System.Drawing.Point(60, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "유효기간";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F);
            this.label5.Location = new System.Drawing.Point(60, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "할부개월";
            // 
            // tboxPay
            // 
            this.tboxPay.Location = new System.Drawing.Point(172, 57);
            this.tboxPay.Multiline = true;
            this.tboxPay.Name = "tboxPay";
            this.tboxPay.Size = new System.Drawing.Size(218, 42);
            this.tboxPay.TabIndex = 5;
            // 
            // tboxSale
            // 
            this.tboxSale.Location = new System.Drawing.Point(172, 105);
            this.tboxSale.Multiline = true;
            this.tboxSale.Name = "tboxSale";
            this.tboxSale.Size = new System.Drawing.Size(218, 42);
            this.tboxSale.TabIndex = 6;
            // 
            // tboxCardNum
            // 
            this.tboxCardNum.Location = new System.Drawing.Point(172, 153);
            this.tboxCardNum.Multiline = true;
            this.tboxCardNum.Name = "tboxCardNum";
            this.tboxCardNum.Size = new System.Drawing.Size(218, 42);
            this.tboxCardNum.TabIndex = 7;
            // 
            // tboxYear
            // 
            this.tboxYear.Location = new System.Drawing.Point(172, 201);
            this.tboxYear.Multiline = true;
            this.tboxYear.Name = "tboxYear";
            this.tboxYear.Size = new System.Drawing.Size(54, 42);
            this.tboxYear.TabIndex = 8;
            // 
            // tboxMonth
            // 
            this.tboxMonth.Location = new System.Drawing.Point(266, 201);
            this.tboxMonth.Multiline = true;
            this.tboxMonth.Name = "tboxMonth";
            this.tboxMonth.Size = new System.Drawing.Size(50, 42);
            this.tboxMonth.TabIndex = 9;
            // 
            // tboxIMonth
            // 
            this.tboxIMonth.Location = new System.Drawing.Point(172, 249);
            this.tboxIMonth.Multiline = true;
            this.tboxIMonth.Name = "tboxIMonth";
            this.tboxIMonth.Size = new System.Drawing.Size(54, 42);
            this.tboxIMonth.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 18F);
            this.label6.Location = new System.Drawing.Point(322, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "월";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 18F);
            this.label7.Location = new System.Drawing.Point(232, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "년";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(661, 50);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 134);
            this.btnDel.TabIndex = 52;
            this.btnDel.Text = "<-";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(661, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 134);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(591, 251);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(70, 67);
            this.btn00.TabIndex = 48;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(451, 251);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(140, 67);
            this.btn0.TabIndex = 47;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(591, 184);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 67);
            this.btn9.TabIndex = 46;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(521, 184);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 67);
            this.btn8.TabIndex = 45;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(451, 184);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 67);
            this.btn7.TabIndex = 44;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(591, 117);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 67);
            this.btn6.TabIndex = 43;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(521, 117);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 67);
            this.btn5.TabIndex = 42;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(451, 117);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 67);
            this.btn4.TabIndex = 41;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(591, 50);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 67);
            this.btn3.TabIndex = 39;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(521, 50);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 67);
            this.btn2.TabIndex = 40;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(451, 50);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 67);
            this.btn1.TabIndex = 38;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(445, 365);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(140, 67);
            this.btnPay.TabIndex = 53;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(591, 365);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(140, 67);
            this.btnCancle.TabIndex = 54;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 444);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxIMonth);
            this.Controls.Add(this.tboxMonth);
            this.Controls.Add(this.tboxYear);
            this.Controls.Add(this.tboxCardNum);
            this.Controls.Add(this.tboxSale);
            this.Controls.Add(this.tboxPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCard";
            this.Text = "frmCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxPay;
        private System.Windows.Forms.TextBox tboxSale;
        private System.Windows.Forms.TextBox tboxCardNum;
        private System.Windows.Forms.TextBox tboxYear;
        private System.Windows.Forms.TextBox tboxMonth;
        private System.Windows.Forms.TextBox tboxIMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancle;
=======
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "frmCard";
        }

        #endregion
>>>>>>> master
    }
}