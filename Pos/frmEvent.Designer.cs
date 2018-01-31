namespace Pos
{
    partial class frmEvent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxProductBarcode = new System.Windows.Forms.TextBox();
            this.tboxEventGroupNum = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tboxEventNum = new System.Windows.Forms.TextBox();
            this.lblEventGroupNum = new System.Windows.Forms.Label();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.rb_twoone = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_oneone = new System.Windows.Forms.RadioButton();
            this.rb_no = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(734, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tboxProductBarcode);
            this.panel1.Controls.Add(this.tboxEventGroupNum);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.tboxEventNum);
            this.panel1.Controls.Add(this.lblEventGroupNum);
            this.panel1.Controls.Add(this.tboxProductName);
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblContent);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 337);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(50, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "바코드";
            // 
            // tboxProductBarcode
            // 
            this.tboxProductBarcode.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxProductBarcode.Location = new System.Drawing.Point(146, 2);
            this.tboxProductBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxProductBarcode.Name = "tboxProductBarcode";
            this.tboxProductBarcode.Size = new System.Drawing.Size(302, 35);
            this.tboxProductBarcode.TabIndex = 30;
            // 
            // tboxEventGroupNum
            // 
            this.tboxEventGroupNum.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxEventGroupNum.Location = new System.Drawing.Point(146, 290);
            this.tboxEventGroupNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxEventGroupNum.Name = "tboxEventGroupNum";
            this.tboxEventGroupNum.Size = new System.Drawing.Size(302, 35);
            this.tboxEventGroupNum.TabIndex = 29;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("굴림", 20.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 130);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(302, 35);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "그룹번호";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 35);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductName.Location = new System.Drawing.Point(80, 56);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(60, 24);
            this.lblProductName.TabIndex = 25;
            this.lblProductName.Text = "상품";
            // 
            // tboxEventNum
            // 
            this.tboxEventNum.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxEventNum.Location = new System.Drawing.Point(146, 248);
            this.tboxEventNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxEventNum.Name = "tboxEventNum";
            this.tboxEventNum.Size = new System.Drawing.Size(302, 35);
            this.tboxEventNum.TabIndex = 2;
            // 
            // lblEventGroupNum
            // 
            this.lblEventGroupNum.AutoSize = true;
            this.lblEventGroupNum.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEventGroupNum.Location = new System.Drawing.Point(5, 253);
            this.lblEventGroupNum.Name = "lblEventGroupNum";
            this.lblEventGroupNum.Size = new System.Drawing.Size(135, 24);
            this.lblEventGroupNum.TabIndex = 0;
            this.lblEventGroupNum.Text = "이벤트번호";
            // 
            // tboxProductName
            // 
            this.tboxProductName.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxProductName.Location = new System.Drawing.Point(146, 52);
            this.tboxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(302, 35);
            this.tboxProductName.TabIndex = 24;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EndDate.Location = new System.Drawing.Point(146, 208);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(302, 35);
            this.EndDate.TabIndex = 23;
            this.EndDate.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartDate.Location = new System.Drawing.Point(146, 169);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(302, 35);
            this.StartDate.TabIndex = 22;
            this.StartDate.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(454, 127);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(266, 71);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEndDate.Location = new System.Drawing.Point(5, 212);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(135, 24);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "끝나는날짜";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStartDate.Location = new System.Drawing.Point(30, 174);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(110, 24);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "시작날짜";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDiscount.Location = new System.Drawing.Point(55, 134);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(85, 24);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "할인율";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblContent.Location = new System.Drawing.Point(80, 96);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(60, 24);
            this.lblContent.TabIndex = 9;
            this.lblContent.Text = "내용";
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.rb_no);
            this.gBox.Controls.Add(this.rb_twoone);
            this.gBox.Controls.Add(this.rb_All);
            this.gBox.Controls.Add(this.rb_oneone);
            this.gBox.Location = new System.Drawing.Point(11, 353);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(268, 38);
            this.gBox.TabIndex = 5;
            this.gBox.TabStop = false;
            // 
            // rb_twoone
            // 
            this.rb_twoone.AutoSize = true;
            this.rb_twoone.Location = new System.Drawing.Point(146, 16);
            this.rb_twoone.Name = "rb_twoone";
            this.rb_twoone.Size = new System.Drawing.Size(49, 16);
            this.rb_twoone.TabIndex = 8;
            this.rb_twoone.Text = "2 + 1";
            this.rb_twoone.UseVisualStyleBackColor = true;
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(11, 16);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(47, 16);
            this.rb_All.TabIndex = 6;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "전체";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // rb_oneone
            // 
            this.rb_oneone.AutoSize = true;
            this.rb_oneone.Location = new System.Drawing.Point(77, 16);
            this.rb_oneone.Name = "rb_oneone";
            this.rb_oneone.Size = new System.Drawing.Size(49, 16);
            this.rb_oneone.TabIndex = 7;
            this.rb_oneone.Text = "1 + 1";
            this.rb_oneone.UseVisualStyleBackColor = true;
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(214, 16);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(47, 16);
            this.rb_no.TabIndex = 9;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "없음";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 685);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEvent";
            this.Load += new System.EventHandler(this.frmEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.RadioButton rb_twoone;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.RadioButton rb_oneone;
        private System.Windows.Forms.TextBox tboxEventGroupNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxEventNum;
        private System.Windows.Forms.Label lblEventGroupNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxProductBarcode;
        private System.Windows.Forms.RadioButton rb_no;
    }
}