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
            this.lblStockInpormation = new System.Windows.Forms.Label();
            this.lblNowStock = new System.Windows.Forms.Label();
            this.tboxActualinven = new System.Windows.Forms.TextBox();
            this.lblOperatingStock = new System.Windows.Forms.Label();
            this.tboxPresentInven = new System.Windows.Forms.TextBox();
            this.lblStoredAndReleased = new System.Windows.Forms.Label();
            this.tboxCategory = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.gbNotice = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbNotice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBarcode.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBarcode.Location = new System.Drawing.Point(785, 70);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(116, 27);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "바 코 드";
            // 
            // tboxBarcode
            // 
            this.tboxBarcode.Location = new System.Drawing.Point(916, 61);
            this.tboxBarcode.Multiline = true;
            this.tboxBarcode.Name = "tboxBarcode";
            this.tboxBarcode.Size = new System.Drawing.Size(267, 44);
            this.tboxBarcode.TabIndex = 1;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Location = new System.Drawing.Point(916, 179);
            this.tboxProductName.Multiline = true;
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(493, 44);
            this.tboxProductName.TabIndex = 6;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.PeachPuff;
            this.lblProductName.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductName.Location = new System.Drawing.Point(785, 179);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(116, 27);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "상 품 명";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUnitPrice.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUnitPrice.Location = new System.Drawing.Point(783, 242);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(118, 27);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "단     가";
            // 
            // tboxUnitPrice
            // 
            this.tboxUnitPrice.Location = new System.Drawing.Point(916, 242);
            this.tboxUnitPrice.Multiline = true;
            this.tboxUnitPrice.Name = "tboxUnitPrice";
            this.tboxUnitPrice.Size = new System.Drawing.Size(213, 44);
            this.tboxUnitPrice.TabIndex = 9;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDivision.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDivision.Location = new System.Drawing.Point(783, 295);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(118, 27);
            this.lblDivision.TabIndex = 10;
            this.lblDivision.Text = "원     가";
            // 
            // tboxcostPrice
            // 
            this.tboxcostPrice.Location = new System.Drawing.Point(916, 292);
            this.tboxcostPrice.Multiline = true;
            this.tboxcostPrice.Name = "tboxcostPrice";
            this.tboxcostPrice.Size = new System.Drawing.Size(213, 44);
            this.tboxcostPrice.TabIndex = 11;
            // 
            // lblStockInpormation
            // 
            this.lblStockInpormation.AutoSize = true;
            this.lblStockInpormation.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStockInpormation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStockInpormation.Location = new System.Drawing.Point(786, 15);
            this.lblStockInpormation.Name = "lblStockInpormation";
            this.lblStockInpormation.Size = new System.Drawing.Size(156, 24);
            this.lblStockInpormation.TabIndex = 12;
            this.lblStockInpormation.Text = "- 상품정보 -";
            // 
            // lblNowStock
            // 
            this.lblNowStock.AutoSize = true;
            this.lblNowStock.BackColor = System.Drawing.Color.Pink;
            this.lblNowStock.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNowStock.Location = new System.Drawing.Point(783, 359);
            this.lblNowStock.Name = "lblNowStock";
            this.lblNowStock.Size = new System.Drawing.Size(172, 27);
            this.lblNowStock.TabIndex = 13;
            this.lblNowStock.Text = "현 재고 수량";
            // 
            // tboxActualinven
            // 
            this.tboxActualinven.Location = new System.Drawing.Point(970, 342);
            this.tboxActualinven.Multiline = true;
            this.tboxActualinven.Name = "tboxActualinven";
            this.tboxActualinven.Size = new System.Drawing.Size(159, 44);
            this.tboxActualinven.TabIndex = 14;
            // 
            // lblOperatingStock
            // 
            this.lblOperatingStock.AutoSize = true;
            this.lblOperatingStock.BackColor = System.Drawing.Color.PeachPuff;
            this.lblOperatingStock.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOperatingStock.Location = new System.Drawing.Point(785, 405);
            this.lblOperatingStock.Name = "lblOperatingStock";
            this.lblOperatingStock.Size = new System.Drawing.Size(124, 27);
            this.lblOperatingStock.TabIndex = 15;
            this.lblOperatingStock.Text = "운영재고";
            // 
            // tboxPresentInven
            // 
            this.tboxPresentInven.Location = new System.Drawing.Point(977, 392);
            this.tboxPresentInven.Multiline = true;
            this.tboxPresentInven.Name = "tboxPresentInven";
            this.tboxPresentInven.Size = new System.Drawing.Size(152, 44);
            this.tboxPresentInven.TabIndex = 16;
            // 
            // lblStoredAndReleased
            // 
            this.lblStoredAndReleased.AutoSize = true;
            this.lblStoredAndReleased.BackColor = System.Drawing.Color.PeachPuff;
            this.lblStoredAndReleased.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStoredAndReleased.Location = new System.Drawing.Point(784, 459);
            this.lblStoredAndReleased.Name = "lblStoredAndReleased";
            this.lblStoredAndReleased.Size = new System.Drawing.Size(124, 27);
            this.lblStoredAndReleased.TabIndex = 17;
            this.lblStoredAndReleased.Text = "카테고리";
            // 
            // tboxCategory
            // 
            this.tboxCategory.Location = new System.Drawing.Point(970, 442);
            this.tboxCategory.Multiline = true;
            this.tboxCategory.Name = "tboxCategory";
            this.tboxCategory.Size = new System.Drawing.Size(159, 44);
            this.tboxCategory.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(1117, 535);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 59);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSerch
            // 
            this.btnSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSerch.Location = new System.Drawing.Point(727, 535);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(121, 59);
            this.btnSerch.TabIndex = 24;
            this.btnSerch.Text = "상품조회";
            this.btnSerch.UseVisualStyleBackColor = false;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // gbNotice
            // 
            this.gbNotice.Controls.Add(this.label19);
            this.gbNotice.Controls.Add(this.label18);
            this.gbNotice.Controls.Add(this.label17);
            this.gbNotice.Controls.Add(this.label16);
            this.gbNotice.Font = new System.Drawing.Font("굴림", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbNotice.ForeColor = System.Drawing.Color.Green;
            this.gbNotice.Location = new System.Drawing.Point(12, 497);
            this.gbNotice.Name = "gbNotice";
            this.gbNotice.Size = new System.Drawing.Size(325, 100);
            this.gbNotice.TabIndex = 33;
            this.gbNotice.TabStop = false;
            this.gbNotice.Text = "알림!";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(3, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "등록됩니다.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(3, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(287, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "등록 버튼을 누르시면 조회된 상품이";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(3, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "스캔하세요.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(3, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(287, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "가격 조회를 원하는 상품의 바코드를";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 23;
            this.dgvProducts.Size = new System.Drawing.Size(743, 482);
            this.dgvProducts.TabIndex = 34;
            this.dgvProducts.Click += new System.EventHandler(this.dgvProducts_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsubmit.Location = new System.Drawing.Point(854, 535);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(121, 59);
            this.btnsubmit.TabIndex = 35;
            this.btnsubmit.Text = "상품수정";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(981, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 59);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "상품삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmProductSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 609);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gbNotice);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tboxCategory);
            this.Controls.Add(this.lblStoredAndReleased);
            this.Controls.Add(this.tboxPresentInven);
            this.Controls.Add(this.lblOperatingStock);
            this.Controls.Add(this.tboxActualinven);
            this.Controls.Add(this.lblNowStock);
            this.Controls.Add(this.lblStockInpormation);
            this.Controls.Add(this.tboxcostPrice);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.tboxUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.tboxProductName);
            this.Controls.Add(this.tboxBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Name = "frmProductSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductSelect";
            this.Load += new System.EventHandler(this.frmProductSelect_Load);
            this.gbNotice.ResumeLayout(false);
            this.gbNotice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblStockInpormation;
        private System.Windows.Forms.Label lblNowStock;
        private System.Windows.Forms.TextBox tboxActualinven;
        private System.Windows.Forms.Label lblOperatingStock;
        private System.Windows.Forms.TextBox tboxPresentInven;
        private System.Windows.Forms.Label lblStoredAndReleased;
        private System.Windows.Forms.TextBox tboxCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.GroupBox gbNotice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnDelete;
    }
}