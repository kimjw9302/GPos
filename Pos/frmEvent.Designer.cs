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
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.btnModify = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxDiscount = new System.Windows.Forms.TextBox();
            this.tboxContent = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tboxBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(734, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tboxDiscount);
            this.panel1.Controls.Add(this.tboxContent);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblContent);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tboxBarcode);
            this.panel1.Controls.Add(this.lblBarcode);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 220);
            this.panel1.TabIndex = 4;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EndDate.Location = new System.Drawing.Point(148, 170);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(302, 35);
            this.EndDate.TabIndex = 23;
            this.EndDate.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(592, 6);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(130, 100);
            this.btnModify.TabIndex = 21;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartDate.Location = new System.Drawing.Point(148, 129);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(302, 35);
            this.StartDate.TabIndex = 22;
            this.StartDate.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(592, 110);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 100);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(458, 110);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 100);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxDiscount
            // 
            this.tboxDiscount.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxDiscount.Location = new System.Drawing.Point(148, 90);
            this.tboxDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxDiscount.Name = "tboxDiscount";
            this.tboxDiscount.Size = new System.Drawing.Size(302, 35);
            this.tboxDiscount.TabIndex = 16;
            // 
            // tboxContent
            // 
            this.tboxContent.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxContent.Location = new System.Drawing.Point(148, 51);
            this.tboxContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxContent.Name = "tboxContent";
            this.tboxContent.Size = new System.Drawing.Size(302, 35);
            this.tboxContent.TabIndex = 15;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEndDate.Location = new System.Drawing.Point(7, 175);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(135, 24);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "끝나는날짜";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStartDate.Location = new System.Drawing.Point(32, 134);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(110, 24);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "시작날짜";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDiscount.Location = new System.Drawing.Point(57, 93);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(85, 24);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "할인율";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblContent.Location = new System.Drawing.Point(82, 54);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(60, 24);
            this.lblContent.TabIndex = 9;
            this.lblContent.Text = "내용";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(458, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 100);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tboxBarcode
            // 
            this.tboxBarcode.Font = new System.Drawing.Font("굴림", 18F);
            this.tboxBarcode.Location = new System.Drawing.Point(148, 12);
            this.tboxBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxBarcode.Name = "tboxBarcode";
            this.tboxBarcode.Size = new System.Drawing.Size(302, 35);
            this.tboxBarcode.TabIndex = 2;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBarcode.Location = new System.Drawing.Point(57, 17);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(85, 24);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "바코드";
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEvent";
            this.Load += new System.EventHandler(this.frmEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tboxBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxDiscount;
        private System.Windows.Forms.TextBox tboxContent;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}