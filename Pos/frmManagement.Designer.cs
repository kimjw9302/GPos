namespace Pos
{
    partial class frmManagement
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
            this.btnCustRegister = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustRegister
            // 
            this.btnCustRegister.Location = new System.Drawing.Point(12, 30);
            this.btnCustRegister.Name = "btnCustRegister";
            this.btnCustRegister.Size = new System.Drawing.Size(113, 104);
            this.btnCustRegister.TabIndex = 0;
            this.btnCustRegister.Text = "회원 등록";
            this.btnCustRegister.UseVisualStyleBackColor = true;
            this.btnCustRegister.Click += new System.EventHandler(this.btnCustRegister_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(251, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 104);
            this.button7.TabIndex = 8;
            this.button7.Text = "직원 조회/등록";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 104);
            this.button3.TabIndex = 7;
            this.button3.Text = "직원업무 스케줄   (근태현황)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 104);
            this.button2.TabIndex = 9;
            this.button2.Text = "직원 교대";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 104);
            this.button4.TabIndex = 10;
            this.button4.Text = "이벤트 관리";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(131, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 104);
            this.button5.TabIndex = 11;
            this.button5.Text = "상품 관리";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(530, 413);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCustRegister);
            this.Name = "frmManagement";
            this.Text = "관리";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustRegister;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}