namespace AOGPlanterV2.OldFarmer
{
	partial class FormSingulationChart
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            timer3 = new System.Windows.Forms.Timer(components);
            singchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnExitSing = new Button();
            lblGraphSing = new Label();
            btnSingChart = new Button();
            ((System.ComponentModel.ISupportInitialize)singchart).BeginInit();
            SuspendLayout();
            // 
            // timer2
            // 
            timer3.Enabled = true;
            timer3.Interval = 200;
            timer3.Tick += timer3_Tick;
            // 
            // popchart
            // 
            singchart.BackColor = Color.LightGray;
            chartArea1.AxisX.Maximum = 17D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Row";
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisY.MajorGrid.Interval = 5D;
            chartArea1.AxisY.Maximum = 15D;
            chartArea1.AxisY.Minimum = -15D;
            chartArea1.BackColor = Color.LightGray;
            chartArea1.BackSecondaryColor = Color.Gray;
            chartArea1.Name = "ChartArea1";
            singchart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.ItemColumnSpacing = 75;
            legend1.Name = "Legend1";
            singchart.Legends.Add(legend1);
            singchart.Location = new Point(31, 0);
            singchart.Margin = new Padding(3, 4, 3, 4);
            singchart.Name = "singchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Row        ";
            series1.Name = "Singulation";
            series1.Points.Add(dataPoint1);
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            singchart.Series.Add(series1);
            singchart.Series.Add(series2);
            singchart.Size = new Size(410, 172);
            singchart.TabIndex = 0;
            singchart.Text = "chart1";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Singulation % ";
            singchart.Titles.Add(title1);
            singchart.Click += singchart_Click;
            // 
            // btnExitPop
            // 
            btnExitSing.BackColor = Color.Maroon;
            btnExitSing.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitSing.ForeColor = Color.White;
            btnExitSing.Location = new Point(0, 0);
            btnExitSing.Margin = new Padding(3, 4, 3, 4);
            btnExitSing.Name = "btnExitPop";
            btnExitSing.Size = new Size(36, 172);
            btnExitSing.TabIndex = 1;
            btnExitSing.Text = "EXI T";
            btnExitSing.UseVisualStyleBackColor = false;
            btnExitSing.Click += btnExitSing_Click;
            // 
            // lblGraphPop
            // 
            lblGraphSing.AutoSize = true;
            lblGraphSing.BackColor = Color.LightGray;
            lblGraphSing.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGraphSing.Location = new Point(311, 0);
            lblGraphSing.Name = "lblGraphSing";
            lblGraphSing.Size = new Size(97, 25);
            lblGraphSing.TabIndex = 2;
            lblGraphSing.Text = "100%";
            // 
            // btnPopChart
            // 
            btnSingChart.BackColor = Color.Maroon;
            btnSingChart.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSingChart.ForeColor = SystemColors.ButtonFace;
            btnSingChart.Location = new Point(283, 135);
            btnSingChart.Margin = new Padding(3, 4, 3, 4);
            btnSingChart.Name = "btnSingChart";
            btnSingChart.Size = new Size(158, 37);
            btnSingChart.TabIndex = 3;
            btnSingChart.Text = "Pop Graph 2";
            btnSingChart.UseVisualStyleBackColor = false;
            btnSingChart.Click += btnSingChart_Click;
            // 
            // FormPopChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 176);
            Controls.Add(btnSingChart);
            Controls.Add(lblGraphSing);
            Controls.Add(btnExitSing);
            Controls.Add(singchart);
            Location = new Point(40, 160);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPopChart";
            StartPosition = FormStartPosition.Manual;
            Text = "Form Pop Chart";
            Load += FormSingChart_Load;
            ((System.ComponentModel.ISupportInitialize)singchart).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart singchart;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Button btnExitSing;
		private System.Windows.Forms.Label lblGraphSing;
		private System.Windows.Forms.Button btnSingChart;
	}
}
