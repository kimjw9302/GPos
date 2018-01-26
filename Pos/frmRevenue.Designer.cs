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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint145 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint146 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title25 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend26 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint147 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint148 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint149 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint150 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint151 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint152 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint153 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint154 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint155 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint156 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title26 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtTime = new System.Windows.Forms.TextBox();
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
            "7. 총 매출"});
            this.listBox1.Location = new System.Drawing.Point(23, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 582);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
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
            this.label2.Location = new System.Drawing.Point(53, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "조회기간 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(335, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "~";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Black;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(619, 25);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 46);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "조회";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // chartGender
            // 
            chartArea25.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea25);
            legend25.Name = "Legend1";
            this.chartGender.Legends.Add(legend25);
            this.chartGender.Location = new System.Drawing.Point(760, 87);
            this.chartGender.Name = "chartGender";
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series37.Legend = "Legend1";
            series37.Name = "Gender";
            dataPoint145.AxisLabel = "남자";
            dataPoint145.IsValueShownAsLabel = true;
            dataPoint145.LabelFormat = "{0.0}%";
            dataPoint146.AxisLabel = "여자";
            dataPoint146.IsValueShownAsLabel = true;
            dataPoint146.LabelFormat = "{0.0}%";
            series37.Points.Add(dataPoint145);
            series37.Points.Add(dataPoint146);
            this.chartGender.Series.Add(series37);
            this.chartGender.Size = new System.Drawing.Size(315, 273);
            this.chartGender.TabIndex = 8;
            this.chartGender.Text = "chart1";
            title25.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title25.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title25.Name = "Title1";
            title25.Text = "<< 성별 매출현황조회 >>";
            title25.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartGender.Titles.Add(title25);
            this.chartGender.Visible = false;
            // 
            // chartAge
            // 
            chartArea26.Name = "ChartArea1";
            this.chartAge.ChartAreas.Add(chartArea26);
            legend26.Name = "Legend1";
            this.chartAge.Legends.Add(legend26);
            this.chartAge.Location = new System.Drawing.Point(301, 87);
            this.chartAge.Name = "chartAge";
            series38.ChartArea = "ChartArea1";
            series38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series38.IsValueShownAsLabel = true;
            series38.Legend = "Legend1";
            series38.Name = "남자";
            dataPoint147.LabelFormat = "{0.0}%";
            dataPoint148.LabelFormat = "{0.0}%";
            dataPoint149.LabelFormat = "{0.0}%";
            dataPoint150.LabelFormat = "{0.0}%";
            dataPoint151.IsValueShownAsLabel = false;
            dataPoint151.LabelFormat = "{0.0}%";
            series38.Points.Add(dataPoint147);
            series38.Points.Add(dataPoint148);
            series38.Points.Add(dataPoint149);
            series38.Points.Add(dataPoint150);
            series38.Points.Add(dataPoint151);
            series38.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series39.ChartArea = "ChartArea1";
            series39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series39.IsValueShownAsLabel = true;
            series39.Legend = "Legend1";
            series39.Name = "여자";
            dataPoint152.LabelFormat = "{0.0}%";
            dataPoint153.LabelFormat = "{0.0}%";
            dataPoint154.LabelFormat = "{0.0}%";
            dataPoint155.LabelFormat = "{0.0}%";
            dataPoint156.LabelFormat = "{0.0}%";
            series39.Points.Add(dataPoint152);
            series39.Points.Add(dataPoint153);
            series39.Points.Add(dataPoint154);
            series39.Points.Add(dataPoint155);
            series39.Points.Add(dataPoint156);
            series39.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartAge.Series.Add(series38);
            this.chartAge.Series.Add(series39);
            this.chartAge.Size = new System.Drawing.Size(453, 582);
            this.chartAge.TabIndex = 9;
            this.chartAge.Text = "chart1";
            title26.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            title26.Name = "Title1";
            title26.Text = "<< 연령별 매출현황 조회 >>";
            title26.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartAge.Titles.Add(title26);
            this.chartAge.Visible = false;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTime.Location = new System.Drawing.Point(309, 87);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTime.Size = new System.Drawing.Size(418, 582);
            this.txtTime.TabIndex = 10;
            this.txtTime.Visible = false;
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1087, 707);
            this.Controls.Add(this.txtTime);
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
        private System.Windows.Forms.TextBox txtTime;
    }
}