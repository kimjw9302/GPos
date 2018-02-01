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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tboxEventGroupNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxEventNum = new System.Windows.Forms.TextBox();
            this.lblEventGroupNum = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.rb_twoone = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_oneone = new System.Windows.Forms.RadioButton();
            this.rb_Ten = new System.Windows.Forms.RadioButton();
            this.rb_Twenty = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tboxProductBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(17, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // tboxEventGroupNum
            // 
            this.tboxEventGroupNum.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxEventGroupNum.Location = new System.Drawing.Point(642, 126);
            this.tboxEventGroupNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxEventGroupNum.Name = "tboxEventGroupNum";
            this.tboxEventGroupNum.Size = new System.Drawing.Size(302, 33);
            this.tboxEventGroupNum.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(542, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "그룹번호";
            // 
            // tboxEventNum
            // 
            this.tboxEventNum.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxEventNum.Location = new System.Drawing.Point(642, 87);
            this.tboxEventNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxEventNum.Name = "tboxEventNum";
            this.tboxEventNum.Size = new System.Drawing.Size(302, 33);
            this.tboxEventNum.TabIndex = 2;
            // 
            // lblEventGroupNum
            // 
            this.lblEventGroupNum.AutoSize = true;
            this.lblEventGroupNum.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEventGroupNum.Location = new System.Drawing.Point(523, 90);
            this.lblEventGroupNum.Name = "lblEventGroupNum";
            this.lblEventGroupNum.Size = new System.Drawing.Size(107, 25);
            this.lblEventGroupNum.TabIndex = 0;
            this.lblEventGroupNum.Text = "이벤트번호";
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EndDate.Location = new System.Drawing.Point(642, 48);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(302, 33);
            this.EndDate.TabIndex = 23;
            this.EndDate.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartDate.Location = new System.Drawing.Point(642, 9);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(302, 33);
            this.StartDate.TabIndex = 22;
            this.StartDate.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(311, 195);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(159, 71);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEndDate.Location = new System.Drawing.Point(523, 50);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(107, 25);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "끝나는날짜";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStartDate.Location = new System.Drawing.Point(542, 14);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 25);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "시작날짜";
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.rb_Twenty);
            this.gBox.Controls.Add(this.rb_Ten);
            this.gBox.Controls.Add(this.rb_no);
            this.gBox.Controls.Add(this.rb_twoone);
            this.gBox.Controls.Add(this.rb_All);
            this.gBox.Controls.Add(this.rb_oneone);
            this.gBox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gBox.Location = new System.Drawing.Point(17, -12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(507, 50);
            this.gBox.TabIndex = 5;
            this.gBox.TabStop = false;
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_no.Location = new System.Drawing.Point(410, 15);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(60, 25);
            this.rb_no.TabIndex = 9;
            this.rb_no.Text = "없음";
            this.rb_no.UseVisualStyleBackColor = true;
            this.rb_no.CheckedChanged += new System.EventHandler(this.rb_no_CheckedChanged);
            // 
            // rb_twoone
            // 
            this.rb_twoone.AutoSize = true;
            this.rb_twoone.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_twoone.Location = new System.Drawing.Point(159, 16);
            this.rb_twoone.Name = "rb_twoone";
            this.rb_twoone.Size = new System.Drawing.Size(69, 25);
            this.rb_twoone.TabIndex = 8;
            this.rb_twoone.Text = "2 + 1";
            this.rb_twoone.UseVisualStyleBackColor = true;
            this.rb_twoone.CheckedChanged += new System.EventHandler(this.rb_twoone_CheckedChanged);
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_All.Location = new System.Drawing.Point(30, 16);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(60, 25);
            this.rb_All.TabIndex = 6;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "전체";
            this.rb_All.UseVisualStyleBackColor = true;
            this.rb_All.CheckedChanged += new System.EventHandler(this.rb_All_CheckedChanged);
            // 
            // rb_oneone
            // 
            this.rb_oneone.AutoSize = true;
            this.rb_oneone.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_oneone.Location = new System.Drawing.Point(90, 16);
            this.rb_oneone.Name = "rb_oneone";
            this.rb_oneone.Size = new System.Drawing.Size(69, 25);
            this.rb_oneone.TabIndex = 7;
            this.rb_oneone.Text = "1 + 1";
            this.rb_oneone.UseVisualStyleBackColor = true;
            this.rb_oneone.CheckedChanged += new System.EventHandler(this.rb_oneone_CheckedChanged);
            // 
            // rb_Ten
            // 
            this.rb_Ten.AutoSize = true;
            this.rb_Ten.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_Ten.Location = new System.Drawing.Point(228, 15);
            this.rb_Ten.Name = "rb_Ten";
            this.rb_Ten.Size = new System.Drawing.Size(91, 25);
            this.rb_Ten.TabIndex = 10;
            this.rb_Ten.Text = "10%할인";
            this.rb_Ten.UseVisualStyleBackColor = true;
            this.rb_Ten.CheckedChanged += new System.EventHandler(this.rb_Ten_CheckedChanged);
            // 
            // rb_Twenty
            // 
            this.rb_Twenty.AutoSize = true;
            this.rb_Twenty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_Twenty.Location = new System.Drawing.Point(319, 15);
            this.rb_Twenty.Name = "rb_Twenty";
            this.rb_Twenty.Size = new System.Drawing.Size(91, 25);
            this.rb_Twenty.TabIndex = 11;
            this.rb_Twenty.Text = "20%할인";
            this.rb_Twenty.UseVisualStyleBackColor = true;
            this.rb_Twenty.CheckedChanged += new System.EventHandler(this.rb_Twenty_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(547, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 71);
            this.button1.TabIndex = 20;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblContent.Location = new System.Drawing.Point(84, 90);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(50, 25);
            this.lblContent.TabIndex = 9;
            this.lblContent.Text = "내용";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDiscount.Location = new System.Drawing.Point(65, 128);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(69, 25);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "할인율";
            // 
            // tboxProductName
            // 
            this.tboxProductName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxProductName.Location = new System.Drawing.Point(146, 46);
            this.tboxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(302, 33);
            this.tboxProductName.TabIndex = 24;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductName.Location = new System.Drawing.Point(84, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(50, 25);
            this.lblProductName.TabIndex = 25;
            this.lblProductName.Text = "상품";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 33);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(302, 33);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tboxProductBarcode
            // 
            this.tboxProductBarcode.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxProductBarcode.Location = new System.Drawing.Point(146, 8);
            this.tboxProductBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxProductBarcode.Name = "tboxProductBarcode";
            this.tboxProductBarcode.Size = new System.Drawing.Size(302, 33);
            this.tboxProductBarcode.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(65, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "바코드";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tboxProductBarcode);
            this.panel1.Controls.Add(this.tboxEventGroupNum);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tboxProductName);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Controls.Add(this.lblContent);
            this.panel1.Controls.Add(this.tboxEventNum);
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblEventGroupNum);
            this.panel1.Location = new System.Drawing.Point(17, 386);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 280);
            this.panel1.TabIndex = 4;
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1070, 677);
            this.ControlBox = false;
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "이벤트";
            this.Load += new System.EventHandler(this.frmEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.RadioButton rb_twoone;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.RadioButton rb_oneone;
        private System.Windows.Forms.TextBox tboxEventGroupNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxEventNum;
        private System.Windows.Forms.Label lblEventGroupNum;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.RadioButton rb_Twenty;
        private System.Windows.Forms.RadioButton rb_Ten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tboxProductBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}