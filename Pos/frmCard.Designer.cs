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



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPay = new System.Windows.Forms.TextBox();
            this.tboxCardNum = new System.Windows.Forms.TextBox();
            this.tboxYear = new System.Windows.Forms.TextBox();
            this.tboxMonth = new System.Windows.Forms.TextBox();
            this.tboxIMonth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "결제금액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(66, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "카드번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(66, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "유효기간";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(66, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "할부개월";
            // 
            // tboxPay
            // 
            this.tboxPay.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxPay.Location = new System.Drawing.Point(200, 42);
            this.tboxPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxPay.Multiline = true;
            this.tboxPay.Name = "tboxPay";
            this.tboxPay.Size = new System.Drawing.Size(249, 52);
            this.tboxPay.TabIndex = 5;
            this.tboxPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxCardNum
            // 
            this.tboxCardNum.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxCardNum.Location = new System.Drawing.Point(200, 107);
            this.tboxCardNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxCardNum.Multiline = true;
            this.tboxCardNum.Name = "tboxCardNum";
            this.tboxCardNum.Size = new System.Drawing.Size(249, 52);
            this.tboxCardNum.TabIndex = 1;
            this.tboxCardNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxCardNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxCardNum_KeyDown);
            // 
            // tboxYear
            // 
            this.tboxYear.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxYear.Location = new System.Drawing.Point(200, 171);
            this.tboxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxYear.Multiline = true;
            this.tboxYear.Name = "tboxYear";
            this.tboxYear.Size = new System.Drawing.Size(61, 52);
            this.tboxYear.TabIndex = 8;
            // 
            // tboxMonth
            // 
            this.tboxMonth.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxMonth.Location = new System.Drawing.Point(315, 172);
            this.tboxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMonth.Multiline = true;
            this.tboxMonth.Name = "tboxMonth";
            this.tboxMonth.Size = new System.Drawing.Size(57, 52);
            this.tboxMonth.TabIndex = 9;
            // 
            // tboxIMonth
            // 
            this.tboxIMonth.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxIMonth.Location = new System.Drawing.Point(200, 236);
            this.tboxIMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxIMonth.Multiline = true;
            this.tboxIMonth.Name = "tboxIMonth";
            this.tboxIMonth.Size = new System.Drawing.Size(61, 52);
            this.tboxIMonth.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(378, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 41);
            this.label6.TabIndex = 11;
            this.label6.Text = "월";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(267, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "년";
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.ForeColor = System.Drawing.SystemColors.Control;
            this.btn7.Location = new System.Drawing.Point(505, 42);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(79, 78);
            this.btn7.TabIndex = 147;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.Location = new System.Drawing.Point(746, 42);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 227);
            this.btnBack.TabIndex = 146;
            this.btnBack.Text = "E\r\nn\r\nt\r\ne\r\nr";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(663, 273);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 78);
            this.btnClear.TabIndex = 145;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn00.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn00.ForeColor = System.Drawing.SystemColors.Control;
            this.btn00.Location = new System.Drawing.Point(584, 273);
            this.btn00.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(79, 78);
            this.btn00.TabIndex = 144;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn0.ForeColor = System.Drawing.SystemColors.Control;
            this.btn0.Location = new System.Drawing.Point(505, 273);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(79, 78);
            this.btn0.TabIndex = 143;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(663, 195);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(79, 78);
            this.btn3.TabIndex = 142;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(584, 195);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 78);
            this.btn2.TabIndex = 141;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(505, 195);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 78);
            this.btn1.TabIndex = 140;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.ForeColor = System.Drawing.SystemColors.Control;
            this.btn6.Location = new System.Drawing.Point(663, 119);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(79, 78);
            this.btn6.TabIndex = 139;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.ForeColor = System.Drawing.SystemColors.Control;
            this.btn5.Location = new System.Drawing.Point(584, 119);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(79, 78);
            this.btn5.TabIndex = 138;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.ForeColor = System.Drawing.SystemColors.Control;
            this.btn4.Location = new System.Drawing.Point(505, 119);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(79, 78);
            this.btn4.TabIndex = 137;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.ForeColor = System.Drawing.SystemColors.Control;
            this.btn9.Location = new System.Drawing.Point(663, 42);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(79, 78);
            this.btn9.TabIndex = 135;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.ForeColor = System.Drawing.SystemColors.Control;
            this.btn8.Location = new System.Drawing.Point(584, 42);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 78);
            this.btn8.TabIndex = 136;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Snow;
            this.btnCancle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancle.Location = new System.Drawing.Point(280, 319);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(205, 84);
            this.btnCancle.TabIndex = 149;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Snow;
            this.btnPay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.Location = new System.Drawing.Point(28, 319);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(211, 84);
            this.btnPay.TabIndex = 148;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 433);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxIMonth);
            this.Controls.Add(this.tboxMonth);
            this.Controls.Add(this.tboxYear);
            this.Controls.Add(this.tboxCardNum);
            this.Controls.Add(this.tboxPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "카드결제";
            this.Load += new System.EventHandler(this.frmCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxPay;
        private System.Windows.Forms.TextBox tboxCardNum;
        private System.Windows.Forms.TextBox tboxYear;
        private System.Windows.Forms.TextBox tboxMonth;
        private System.Windows.Forms.TextBox tboxIMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnPay;
    }
}