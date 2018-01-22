namespace Pos
{
    partial class frmProductRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.MaskedTextBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.MaskedTextBox();
            this.cbPlaceTemp = new System.Windows.Forms.ComboBox();
            this.cbCate2Temp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCate1 = new System.Windows.Forms.ComboBox();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.cbCate2 = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(48, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품명";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProductName.Location = new System.Drawing.Point(123, 121);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PromptChar = ' ';
            this.txtProductName.Size = new System.Drawing.Size(300, 33);
            this.txtProductName.TabIndex = 2;
            // 
            // group
            // 
            this.group.Controls.Add(this.txtBarcode);
            this.group.Controls.Add(this.cbPlaceTemp);
            this.group.Controls.Add(this.cbCate2Temp);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.cbCate1);
            this.group.Controls.Add(this.cbPlace);
            this.group.Controls.Add(this.cbCate2);
            this.group.Controls.Add(this.btnRegister);
            this.group.Controls.Add(this.label7);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.txtCostPrice);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.txtUnitPrice);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.txtProductName);
            this.group.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.group.Location = new System.Drawing.Point(22, 92);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(483, 524);
            this.group.TabIndex = 2;
            this.group.TabStop = false;
            this.group.Text = "상품 등록";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(123, 75);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PromptChar = ' ';
            this.txtBarcode.Size = new System.Drawing.Size(300, 33);
            this.txtBarcode.TabIndex = 1;
            // 
            // cbPlaceTemp
            // 
            this.cbPlaceTemp.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbPlaceTemp.FormattingEnabled = true;
            this.cbPlaceTemp.Location = new System.Drawing.Point(123, 317);
            this.cbPlaceTemp.Name = "cbPlaceTemp";
            this.cbPlaceTemp.Size = new System.Drawing.Size(300, 33);
            this.cbPlaceTemp.TabIndex = 7;
            this.cbPlaceTemp.Visible = false;
            // 
            // cbCate2Temp
            // 
            this.cbCate2Temp.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCate2Temp.FormattingEnabled = true;
            this.cbCate2Temp.Location = new System.Drawing.Point(294, 268);
            this.cbCate2Temp.Name = "cbCate2Temp";
            this.cbCate2Temp.Size = new System.Drawing.Size(129, 33);
            this.cbCate2Temp.TabIndex = 6;
            this.cbCate2Temp.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(48, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "대분류";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(219, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "소분류";
            // 
            // cbCate1
            // 
            this.cbCate1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCate1.FormattingEnabled = true;
            this.cbCate1.Location = new System.Drawing.Point(123, 268);
            this.cbCate1.Name = "cbCate1";
            this.cbCate1.Size = new System.Drawing.Size(90, 33);
            this.cbCate1.TabIndex = 5;
            this.cbCate1.SelectedIndexChanged += new System.EventHandler(this.cbCate1_SelectedIndexChanged);
            // 
            // cbPlace
            // 
            this.cbPlace.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(123, 317);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(300, 33);
            this.cbPlace.TabIndex = 16;
            // 
            // cbCate2
            // 
            this.cbCate2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCate2.FormattingEnabled = true;
            this.cbCate2.Location = new System.Drawing.Point(306, 268);
            this.cbCate2.Name = "cbCate2";
            this.cbCate2.Size = new System.Drawing.Size(117, 33);
            this.cbCate2.TabIndex = 17;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(162, 408);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(153, 60);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "상품 등록";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(48, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "거래처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(67, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "원가";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCostPrice.Location = new System.Drawing.Point(123, 219);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(300, 33);
            this.txtCostPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(67, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "단가";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUnitPrice.Location = new System.Drawing.Point(123, 170);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PromptChar = ' ';
            this.txtUnitPrice.Size = new System.Drawing.Size(300, 33);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "바코드";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(379, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 60);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProductRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(533, 638);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.group);
            this.Name = "frmProductRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProductRegister_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtProductName;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.ComboBox cbCate1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCostPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.ComboBox cbCate2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCate2Temp;
        private System.Windows.Forms.ComboBox cbPlaceTemp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MaskedTextBox txtBarcode;
    }
}