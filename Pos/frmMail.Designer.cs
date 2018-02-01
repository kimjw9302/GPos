namespace Pos
{
    partial class frmMail
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
            this.tboxContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxTitle = new System.Windows.Forms.TextBox();
            this.tboxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxEmail = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tboxContent
            // 
            this.tboxContent.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxContent.Location = new System.Drawing.Point(45, 197);
            this.tboxContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxContent.Multiline = true;
            this.tboxContent.Name = "tboxContent";
            this.tboxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxContent.Size = new System.Drawing.Size(494, 245);
            this.tboxContent.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(117, 496);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(145, 87);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(295, 496);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(145, 87);
            this.btnCancle.TabIndex = 16;
            this.btnCancle.Text = "닫기";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(41, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "제목 :";
            // 
            // tboxTitle
            // 
            this.tboxTitle.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxTitle.Location = new System.Drawing.Point(117, 139);
            this.tboxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.Size = new System.Drawing.Size(422, 32);
            this.tboxTitle.TabIndex = 3;
            // 
            // tboxInput
            // 
            this.tboxInput.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxInput.Location = new System.Drawing.Point(343, 88);
            this.tboxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(196, 32);
            this.tboxInput.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "이메일 :";
            // 
            // tboxID
            // 
            this.tboxID.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxID.Location = new System.Drawing.Point(117, 90);
            this.tboxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(185, 32);
            this.tboxID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(304, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "@";
            // 
            // cboxEmail
            // 
            this.cboxEmail.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxEmail.FormattingEnabled = true;
            this.cboxEmail.Items.AddRange(new object[] {
            "직접 입력하기",
            "naver.com",
            "google.com",
            "hanmail.net"});
            this.cboxEmail.Location = new System.Drawing.Point(343, 88);
            this.cboxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxEmail.Name = "cboxEmail";
            this.cboxEmail.Size = new System.Drawing.Size(196, 38);
            this.cboxEmail.TabIndex = 2;
            this.cboxEmail.Text = "이메일 선택";
            this.cboxEmail.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(567, 635);
            this.Controls.Add(this.cboxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tboxContent);
            this.Controls.Add(this.tboxInput);
            this.Name = "frmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "문의메일";
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxContent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxTitle;
        private System.Windows.Forms.TextBox tboxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxEmail;
    }
}