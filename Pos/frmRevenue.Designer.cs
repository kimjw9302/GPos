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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 13F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "1. 시간대별 매출현황",
            "2. 카테고리별 매출현황",
            "3. 상품별 매출현황",
            "4. 객층분석",
            "5. 결제수단별 매출현황",
            "6. 반품현황",
            "7. 총 매출",
            "8. 실 매출"});
            this.listBox1.Location = new System.Drawing.Point(23, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 582);
            this.listBox1.TabIndex = 0;
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(146, 30);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(177, 30);
            this.dtStart.TabIndex = 3;
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(368, 30);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 30);
            this.dtEnd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(53, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "조회기간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(335, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "~";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(608, 25);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 51);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "조회";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // chartGender
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGender.Legends.Add(legend3);
            this.chartGender.Location = new System.Drawing.Point(760, 87);
            this.chartGender.Name = "chartGender";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Gender";
            dataPoint13.AxisLabel = "남자";
            dataPoint13.IsValueShownAsLabel = true;
            dataPoint13.LabelFormat = "{0.0}%";
            dataPoint14.AxisLabel = "여자";
            dataPoint14.IsValueShownAsLabel = true;
            dataPoint14.LabelFormat = "{0.0}%";
            series4.Points.Add(dataPoint13);
            series4.Points.Add(dataPoint14);
            this.chartGender.Series.Add(series4);
            this.chartGender.Size = new System.Drawing.Size(315, 273);
            this.chartGender.TabIndex = 8;
            this.chartGender.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "<< 성별 매출현황조회 >>";
            title3.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartGender.Titles.Add(title3);
            this.chartGender.Visible = false;
            // 
            // chartAge
            // 
            chartArea4.Name = "ChartArea1";
            this.chartAge.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartAge.Legends.Add(legend4);
            this.chartAge.Location = new System.Drawing.Point(301, 87);
            this.chartAge.Name = "chartAge";
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "남자";
            dataPoint15.LabelFormat = "{0.0}%";
            dataPoint16.LabelFormat = "{0.0}%";
            dataPoint17.LabelFormat = "{0.0}%";
            dataPoint18.LabelFormat = "{0.0}%";
            dataPoint19.IsValueShownAsLabel = false;
            dataPoint19.LabelFormat = "{0.0}%";
            series5.Points.Add(dataPoint15);
            series5.Points.Add(dataPoint16);
            series5.Points.Add(dataPoint17);
            series5.Points.Add(dataPoint18);
            series5.Points.Add(dataPoint19);
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "여자";
            dataPoint20.LabelFormat = "{0.0}%";
            dataPoint21.LabelFormat = "{0.0}%";
            dataPoint22.LabelFormat = "{0.0}%";
            dataPoint23.LabelFormat = "{0.0}%";
            dataPoint24.LabelFormat = "{0.0}%";
            series6.Points.Add(dataPoint20);
            series6.Points.Add(dataPoint21);
            series6.Points.Add(dataPoint22);
            series6.Points.Add(dataPoint23);
            series6.Points.Add(dataPoint24);
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartAge.Series.Add(series5);
            this.chartAge.Series.Add(series6);
            this.chartAge.Size = new System.Drawing.Size(453, 582);
            this.chartAge.TabIndex = 9;
            this.chartAge.Text = "chart1";
            title4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            title4.Name = "Title1";
            title4.Text = "<< 연령별 매출현황 조회 >>";
            title4.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartAge.Titles.Add(title4);
            this.chartAge.Visible = false;
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1087, 707);
            this.Controls.Add(this.chartAge);
            this.Controls.Add(this.chartGender);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.listBox1);
            this.Name = "frmRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRevenue";
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAge;
    }
}