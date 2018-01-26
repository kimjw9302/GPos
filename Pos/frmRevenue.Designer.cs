namespace Pos
{
    partial class frmRevenue
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
<<<<<<< HEAD
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
=======
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
=======
            this.panel = new System.Windows.Forms.Panel();
            this.MethodReturnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new System.Windows.Forms.Button();
            this.CateNFChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MethodReturnChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CateNFChart)).BeginInit();
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 13F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "1. 시간대별 매출현황",
            "2. 카테고리별 매출현황",
            "3. 상품별 매출현황",
            "4. 객층분석",
            "5. 결제수단별 매출현황",
            "6. 반품현황",
            "7. 기간별 매출"});
            this.listBox1.Location = new System.Drawing.Point(26, 109);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 708);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(167, 38);
            this.dtStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(202, 36);
            this.dtStart.TabIndex = 3;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(421, 38);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(228, 36);
            this.dtEnd.TabIndex = 4;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(61, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "조회기간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(383, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "~";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(695, 31);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(123, 64);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "조회";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
<<<<<<< HEAD
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(352, 517);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(937, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
=======
            // panel
            // 
            this.panel.Controls.Add(this.MethodReturnChart);
            this.panel.Controls.Add(this.CateNFChart);
            this.panel.Location = new System.Drawing.Point(301, 87);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 580);
            this.panel.TabIndex = 8;
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
            // 
            // MethodReturnChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MethodReturnChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MethodReturnChart.Legends.Add(legend1);
            this.MethodReturnChart.Location = new System.Drawing.Point(67, 38);
            this.MethodReturnChart.Name = "MethodReturnChart";
            this.MethodReturnChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            series1.Legend = "Legend1";
            series1.Name = "method";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "return";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "categoryF";
            this.MethodReturnChart.Series.Add(series1);
            this.MethodReturnChart.Series.Add(series2);
            this.MethodReturnChart.Series.Add(series3);
            this.MethodReturnChart.Size = new System.Drawing.Size(703, 527);
            this.MethodReturnChart.TabIndex = 0;
            this.MethodReturnChart.Text = "chart1";
            this.MethodReturnChart.Visible = false;
            this.MethodReturnChart.Click += new System.EventHandler(this.MethodReturnChat_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1093, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 51);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CateNFChart
            // 
            chartArea2.Name = "ChartArea1";
            this.CateNFChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CateNFChart.Legends.Add(legend2);
            this.CateNFChart.Location = new System.Drawing.Point(218, 91);
            this.CateNFChart.Name = "CateNFChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "categoryNF";
            this.CateNFChart.Series.Add(series4);
            this.CateNFChart.Size = new System.Drawing.Size(400, 350);
            this.CateNFChart.TabIndex = 1;
            this.CateNFChart.Text = "chart1";
            this.CateNFChart.Visible = false;
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1360, 884);
            this.Controls.Add(this.chart1);
=======
            this.ClientSize = new System.Drawing.Size(1217, 707);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRevenue";
            this.Load += new System.EventHandler(this.frmRevenue_Load);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
=======
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MethodReturnChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CateNFChart)).EndInit();
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
<<<<<<< HEAD
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
=======
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MethodReturnChart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart CateNFChart;
>>>>>>> f312230371ce44b9a8a3cc2d68715b6c2d1dd804
    }
}