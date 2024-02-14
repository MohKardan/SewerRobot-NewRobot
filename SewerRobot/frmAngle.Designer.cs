namespace SewerRobot
{
    partial class frmAngle
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAngle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusAvgAngle = new System.Windows.Forms.StatusStrip();
            this.tssLblAvgAngle = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartAngle)).BeginInit();
            this.statusAvgAngle.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartAngle
            // 
            this.chartAngle.BorderlineWidth = 2;
            this.chartAngle.BorderSkin.BorderWidth = 2;
            chartArea1.AxisX.LabelStyle.Format = "#.##";
            chartArea1.AxisX.MinorGrid.Interval = double.NaN;
            chartArea1.AxisX.MinorTickMark.Interval = double.NaN;
            chartArea1.AxisY.LabelStyle.Format = "#.##";
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartAngle.ChartAreas.Add(chartArea1);
            this.chartAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.MaximumAutoSize = 1F;
            legend1.Name = "Legend1";
            this.chartAngle.Legends.Add(legend1);
            this.chartAngle.Location = new System.Drawing.Point(0, 0);
            this.chartAngle.Name = "chartAngle";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 2;
            series1.MarkerSize = 10;
            series1.MarkerStep = 2;
            series1.Name = "Angle";
            this.chartAngle.Series.Add(series1);
            this.chartAngle.Size = new System.Drawing.Size(679, 429);
            this.chartAngle.TabIndex = 0;
            this.chartAngle.Text = "chart1";
            // 
            // statusAvgAngle
            // 
            this.statusAvgAngle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblAvgAngle});
            this.statusAvgAngle.Location = new System.Drawing.Point(0, 407);
            this.statusAvgAngle.Name = "statusAvgAngle";
            this.statusAvgAngle.Size = new System.Drawing.Size(679, 22);
            this.statusAvgAngle.TabIndex = 1;
            // 
            // tssLblAvgAngle
            // 
            this.tssLblAvgAngle.Name = "tssLblAvgAngle";
            this.tssLblAvgAngle.Size = new System.Drawing.Size(0, 17);
            // 
            // frmAngle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 429);
            this.Controls.Add(this.statusAvgAngle);
            this.Controls.Add(this.chartAngle);
            this.Name = "frmAngle";
            this.Text = "Angle Plot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAngle_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartAngle)).EndInit();
            this.statusAvgAngle.ResumeLayout(false);
            this.statusAvgAngle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAngle;
        private System.Windows.Forms.StatusStrip statusAvgAngle;
        private System.Windows.Forms.ToolStripStatusLabel tssLblAvgAngle;

    }
}