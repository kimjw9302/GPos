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
            this.gbNotice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.Color.White;
            this.lblBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBarcode.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(783, 70);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(116, 37);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "바 코 드";
            // 
            // tboxBarcode
            // 
            this.tboxBarcode.Font = new System.Drawing.Font("맑은 고딕", 25F, System.Drawing.FontStyle.Bold);
            this.tboxBarcode.Location = new System.Drawing.Point(986, 70);
            this.tboxBarcode.Multiline = true;
            this.tboxBarcode.Name = "tboxBarcode";
            this.tboxBarcode.Size = new System.Drawing.Size(269, 44);
            this.tboxBarcode.TabIndex = 1;
            this.tboxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.tboxProductName.Location = new System.Drawing.Point(986, 139);
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
            this.lblProductName.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(783, 146);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(116, 37);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "상 품 명";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.White;
            this.lblUnitPrice.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblUnitPrice.Location = new System.Drawing.Point(783, 211);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(116, 37);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "단     가";
            // 
            // tboxUnitPrice
            // 
            this.tboxUnitPrice.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.tboxUnitPrice.Location = new System.Drawing.Point(986, 211);
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
            this.lblDivision.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblDivision.Location = new System.Drawing.Point(783, 282);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(116, 37);
            this.lblDivision.TabIndex = 10;
            this.lblDivision.Text = "원     가";
            // 
            // tboxcostPrice
            // 
            this.tboxcostPrice.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.tboxcostPrice.Location = new System.Drawing.Point(986, 282);
            this.tboxcostPrice.Multiline = true;
            this.tboxcostPrice.Name = "tboxcostPrice";
            this.tboxcostPrice.Size = new System.Drawing.Size(269, 44);
            this.tboxcostPrice.TabIndex = 11;
            this.tboxcostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStockInpormation
            // 
            this.lblStockInpormation.AutoSize = true;
            this.lblStockInpormation.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStockInpormation.ForeColor = System.Drawing.Color.Black;
            this.lblStockInpormation.Location = new System.Drawing.Point(1027, 12);
            this.lblStockInpormation.Name = "lblStockInpormation";
            this.lblStockInpormation.Size = new System.Drawing.Size(147, 32);
            this.lblStockInpormation.TabIndex = 12;
            this.lblStockInpormation.Text = "- 상품정보 -";
            // 
            // lblNowStock
            // 
            this.lblNowStock.AutoSize = true;
            this.lblNowStock.BackColor = System.Drawing.Color.White;
            this.lblNowStock.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblNowStock.Location = new System.Drawing.Point(783, 342);
            this.lblNowStock.Name = "lblNowStock";
            this.lblNowStock.Size = new System.Drawing.Size(170, 37);
            this.lblNowStock.TabIndex = 13;
            this.lblNowStock.Text = "현 재고 수량";
            // 
            // tboxActualinven
            // 
            this.tboxActualinven.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.tboxActualinven.Location = new System.Drawing.Point(986, 342);
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
            this.lblOperatingStock.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblOperatingStock.Location = new System.Drawing.Point(783, 398);
            this.lblOperatingStock.Name = "lblOperatingStock";
            this.lblOperatingStock.Size = new System.Drawing.Size(197, 37);
            this.lblOperatingStock.TabIndex = 15;
            this.lblOperatingStock.Text = "실제 재고 수량";
            // 
            // tboxPresentInven
            // 
            this.tboxPresentInven.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.tboxPresentInven.Location = new System.Drawing.Point(986, 398);
            this.tboxPresentInven.Multiline = true;
            this.tboxPresentInven.Name = "tboxPresentInven";
            this.tboxPresentInven.Size = new System.Drawing.Size(269, 44);
            this.tboxPresentInven.TabIndex = 16;
            this.tboxPresentInven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1206, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 59);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.BackColor = System.Drawing.Color.Snow;
            this.btnSerch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnSerch.Location = new System.Drawing.Point(790, 519);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(121, 59);
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
            this.gbNotice.Location = new System.Drawing.Point(12, 497);
            this.gbNotice.Name = "gbNotice";
            this.gbNotice.Size = new System.Drawing.Size(325, 70);
            this.gbNotice.TabIndex = 33;
            this.gbNotice.TabStop = false;
            this.gbNotice.Text = "알림!";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(3, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 21);
            this.label17.TabIndex = 1;
            this.label17.Text = "스캔하세요.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(3, 25);
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
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 23;
            this.dgvProducts.Size = new System.Drawing.Size(743, 482);
            this.dgvProducts.TabIndex = 34;
            this.dgvProducts.Click += new System.EventHandler(this.dgvProducts_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Snow;
            this.btnsubmit.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnsubmit.Location = new System.Drawing.Point(931, 519);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(121, 59);
            this.btnsubmit.TabIndex = 35;
            this.btnsubmit.Text = "상품수정";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Snow;
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(1070, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 59);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "상품삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(786, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 66;
            this.label7.Text = "대분류 :";
            // 
            // cbCate1
            // 
            this.cbCate1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.cbCate1.FormattingEnabled = true;
            this.cbCate1.Location = new System.Drawing.Point(865, 461);
            this.cbCate1.Name = "cbCate1";
            this.cbCate1.Size = new System.Drawing.Size(99, 29);
            this.cbCate1.TabIndex = 63;
            this.cbCate1.SelectedIndexChanged += new System.EventHandler(this.cbCate1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(969, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 65;
            this.label8.Text = "소분류 :";
            // 
            // cbCate2
            // 
            this.cbCate2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.cbCate2.FormattingEnabled = true;
            this.cbCate2.Location = new System.Drawing.Point(1043, 461);
            this.cbCate2.Name = "cbCate2";
            this.cbCate2.Size = new System.Drawing.Size(164, 29);
            this.cbCate2.TabIndex = 64;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Snow;
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(1213, 457);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 33);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "상품정보 초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmProductSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1390, 609);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCate1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCate2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gbNotice);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.btnCancel);
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
    }
}