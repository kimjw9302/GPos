namespace Pos
{
    partial class frmProductSelect
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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.tboxBarcode = new System.Windows.Forms.TextBox();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tboxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.tboxcostPrice = new System.Windows.Forms.TextBox();
            this.lblNowStock = new System.Windows.Forms.Label();
            this.tboxActualinven = new System.Windows.Forms.TextBox();
            this.lblOperatingStock = new System.Windows.Forms.Label();
            this.tboxPresentInven = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.gbNotice = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCate1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCate2 = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbNotice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.Color.White;
            this.lblBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBarcode.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBarcode.Location = new System.Drawing.Point(59, 50);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(102, 30);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "바 코 드 :";
            // 
            // tboxBarcode
            // 
            this.tboxBarcode.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxBarcode.Location = new System.Drawing.Point(169, 46);
            this.tboxBarcode.Multiline = true;
            this.tboxBarcode.Name = "tboxBarcode";
            this.tboxBarcode.Size = new System.Drawing.Size(269, 44);
            this.tboxBarcode.TabIndex = 1;
            this.tboxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxProductName.Location = new System.Drawing.Point(169, 106);
            this.tboxProductName.Multiline = true;
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(269, 44);
            this.tboxProductName.TabIndex = 6;
            this.tboxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.White;
            this.lblProductName.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductName.Location = new System.Drawing.Point(61, 110);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(102, 30);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "상 품 명 :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.White;
            this.lblUnitPrice.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUnitPrice.Location = new System.Drawing.Point(61, 170);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(102, 30);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "단     가 :";
            // 
            // tboxUnitPrice
            // 
            this.tboxUnitPrice.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxUnitPrice.Location = new System.Drawing.Point(169, 166);
            this.tboxUnitPrice.Multiline = true;
            this.tboxUnitPrice.Name = "tboxUnitPrice";
            this.tboxUnitPrice.Size = new System.Drawing.Size(269, 44);
            this.tboxUnitPrice.TabIndex = 9;
            this.tboxUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.BackColor = System.Drawing.Color.White;
            this.lblDivision.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDivision.Location = new System.Drawing.Point(61, 226);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(102, 30);
            this.lblDivision.TabIndex = 10;
            this.lblDivision.Text = "원     가 :";
            // 
            // tboxcostPrice
            // 
            this.tboxcostPrice.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxcostPrice.Location = new System.Drawing.Point(169, 226);
            this.tboxcostPrice.Multiline = true;
            this.tboxcostPrice.Name = "tboxcostPrice";
            this.tboxcostPrice.Size = new System.Drawing.Size(269, 44);
            this.tboxcostPrice.TabIndex = 11;
            this.tboxcostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNowStock
            // 
            this.lblNowStock.AutoSize = true;
            this.lblNowStock.BackColor = System.Drawing.Color.White;
            this.lblNowStock.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNowStock.Location = new System.Drawing.Point(68, 286);
            this.lblNowStock.Name = "lblNowStock";
            this.lblNowStock.Size = new System.Drawing.Size(95, 30);
            this.lblNowStock.TabIndex = 13;
            this.lblNowStock.Text = "현 재고 :";
            // 
            // tboxActualinven
            // 
            this.tboxActualinven.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxActualinven.Location = new System.Drawing.Point(169, 286);
            this.tboxActualinven.Multiline = true;
            this.tboxActualinven.Name = "tboxActualinven";
            this.tboxActualinven.Size = new System.Drawing.Size(269, 44);
            this.tboxActualinven.TabIndex = 14;
            this.tboxActualinven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOperatingStock
            // 
            this.lblOperatingStock.AutoSize = true;
            this.lblOperatingStock.BackColor = System.Drawing.Color.White;
            this.lblOperatingStock.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOperatingStock.Location = new System.Drawing.Point(47, 346);
            this.lblOperatingStock.Name = "lblOperatingStock";
            this.lblOperatingStock.Size = new System.Drawing.Size(116, 30);
            this.lblOperatingStock.TabIndex = 15;
            this.lblOperatingStock.Text = "실제 재고 :";
            // 
            // tboxPresentInven
            // 
            this.tboxPresentInven.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxPresentInven.Location = new System.Drawing.Point(169, 346);
            this.tboxPresentInven.Multiline = true;
            this.tboxPresentInven.Name = "tboxPresentInven";
            this.tboxPresentInven.Size = new System.Drawing.Size(269, 44);
            this.tboxPresentInven.TabIndex = 16;
            this.tboxPresentInven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1142, 574);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 69);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.BackColor = System.Drawing.Color.Snow;
            this.btnSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSerch.Location = new System.Drawing.Point(692, 574);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(142, 69);
            this.btnSerch.TabIndex = 24;
            this.btnSerch.Text = "상품조회";
            this.btnSerch.UseVisualStyleBackColor = false;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // gbNotice
            // 
            this.gbNotice.Controls.Add(this.label17);
            this.gbNotice.Controls.Add(this.label16);
            this.gbNotice.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.gbNotice.ForeColor = System.Drawing.Color.Black;
            this.gbNotice.Location = new System.Drawing.Point(28, 562);
            this.gbNotice.Name = "gbNotice";
            this.gbNotice.Size = new System.Drawing.Size(355, 81);
            this.gbNotice.TabIndex = 33;
            this.gbNotice.TabStop = false;
            this.gbNotice.Text = "알림!";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(16, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 21);
            this.label17.TabIndex = 1;
            this.label17.Text = "스캔하세요.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(16, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(274, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "가격 조회를 원하는 상품의 바코드를";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(28, 60);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 23;
            this.dgvProducts.Size = new System.Drawing.Size(743, 482);
            this.dgvProducts.TabIndex = 34;
            this.dgvProducts.Click += new System.EventHandler(this.dgvProducts_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Snow;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnsubmit.Location = new System.Drawing.Point(842, 574);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(142, 69);
            this.btnsubmit.TabIndex = 35;
            this.btnsubmit.Text = "상품수정";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Snow;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(992, 574);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 69);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "상품삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(30, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "대분류 :";
            // 
            // cbCate1
            // 
            this.cbCate1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.cbCate1.FormattingEnabled = true;
            this.cbCate1.Location = new System.Drawing.Point(114, 418);
            this.cbCate1.Name = "cbCate1";
            this.cbCate1.Size = new System.Drawing.Size(99, 29);
            this.cbCate1.TabIndex = 63;
            this.cbCate1.SelectedIndexChanged += new System.EventHandler(this.cbCate1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(219, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 65;
            this.label8.Text = "소분류 :";
            // 
            // cbCate2
            // 
            this.cbCate2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.cbCate2.FormattingEnabled = true;
            this.cbCate2.Location = new System.Drawing.Point(306, 416);
            this.cbCate2.Name = "cbCate2";
            this.cbCate2.Size = new System.Drawing.Size(132, 29);
            this.cbCate2.TabIndex = 64;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Snow;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(542, 574);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 69);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "상품정보 초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBarcode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tboxBarcode);
            this.groupBox1.Controls.Add(this.cbCate1);
            this.groupBox1.Controls.Add(this.tboxProductName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.cbCate2);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Controls.Add(this.tboxUnitPrice);
            this.groupBox1.Controls.Add(this.lblDivision);
            this.groupBox1.Controls.Add(this.tboxcostPrice);
            this.groupBox1.Controls.Add(this.lblNowStock);
            this.groupBox1.Controls.Add(this.tboxActualinven);
            this.groupBox1.Controls.Add(this.lblOperatingStock);
            this.groupBox1.Controls.Add(this.tboxPresentInven);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(777, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 493);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상품 정보";
            // 
            // frmProductSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1304, 719);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gbNotice);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmProductSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품 조회";
            this.Load += new System.EventHandler(this.frmProductSelect_Load);
            this.gbNotice.ResumeLayout(false);
            this.gbNotice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox tboxBarcode;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tboxUnitPrice;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.TextBox tboxcostPrice;
        private System.Windows.Forms.Label lblNowStock;
        private System.Windows.Forms.TextBox tboxActualinven;
        private System.Windows.Forms.Label lblOperatingStock;
        private System.Windows.Forms.TextBox tboxPresentInven;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.GroupBox gbNotice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCate1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCate2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}