namespace Pos
{
    partial class frmWait
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOutCancel = new System.Windows.Forms.Button();
            this.lblsc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pos.Properties.Resources.goodee24;
            this.pictureBox1.Location = new System.Drawing.Point(12, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(69, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "매장PW";
            // 
            // tboxpassword
            // 
            this.tboxpassword.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxpassword.Location = new System.Drawing.Point(175, 115);
            this.tboxpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxpassword.Name = "tboxpassword";
            this.tboxpassword.PasswordChar = '*';
            this.tboxpassword.Size = new System.Drawing.Size(240, 35);
            this.tboxpassword.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(58, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "외출 한 시간:";
            // 
            // btnOutCancel
            // 
            this.btnOutCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnOutCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOutCancel.ForeColor = System.Drawing.Color.White;
            this.btnOutCancel.Location = new System.Drawing.Point(160, 175);
            this.btnOutCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOutCancel.Name = "btnOutCancel";
            this.btnOutCancel.Size = new System.Drawing.Size(192, 74);
            this.btnOutCancel.TabIndex = 13;
            this.btnOutCancel.Text = "외출모드 정지";
            this.btnOutCancel.UseVisualStyleBackColor = false;
            this.btnOutCancel.Click += new System.EventHandler(this.btnOutCancel_Click);
            // 
            // lblsc
            // 
            this.lblsc.AutoSize = true;
            this.lblsc.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblsc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsc.Location = new System.Drawing.Point(205, 73);
            this.lblsc.Name = "lblsc";
            this.lblsc.Size = new System.Drawing.Size(0, 28);
            this.lblsc.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblsc);
            this.Controls.Add(this.btnOutCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "외출하기";
            this.Load += new System.EventHandler(this.frmWait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOutCancel;
        private System.Windows.Forms.Label lblsc;
        private System.Windows.Forms.Timer timer1;
    }
}