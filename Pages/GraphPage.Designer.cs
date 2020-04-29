namespace SmartFactory.Pages
{
    partial class GraphPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphPage));
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.DateTimeCategoricalAxis dateTimeCategoricalAxis1 = new Telerik.WinControls.UI.DateTimeCategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.LineSeries lineSeries1 = new Telerik.WinControls.UI.LineSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint1 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint2 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint3 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint4 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint5 = new Telerik.Charting.CategoricalDataPoint();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(516, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Save";
            // 
            // radChartView1
            // 
            cartesianArea1.GridDesign.AlternatingHorizontalColor = false;
            cartesianArea1.GridDesign.AlternatingVerticalColor = false;
            cartesianArea1.ShowGrid = true;
            this.radChartView1.AreaDesign = cartesianArea1;
            dateTimeCategoricalAxis1.DateTimeComponent = Telerik.Charting.DateTimeComponent.Ticks;
            dateTimeCategoricalAxis1.IsPrimary = true;
            dateTimeCategoricalAxis1.LabelRotationAngle = 300D;
            dateTimeCategoricalAxis1.Title = "";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.LabelRotationAngle = 300D;
            linearAxis1.MajorStep = 10D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "";
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            dateTimeCategoricalAxis1,
            linearAxis1});
            this.radChartView1.Location = new System.Drawing.Point(0, 28);
            this.radChartView1.Name = "radChartView1";
            categoricalDataPoint1.Category = "A";
            categoricalDataPoint1.Label = 94D;
            categoricalDataPoint1.Value = 94D;
            categoricalDataPoint2.Category = "B";
            categoricalDataPoint2.Label = 15D;
            categoricalDataPoint2.Value = 15D;
            categoricalDataPoint3.Category = "C";
            categoricalDataPoint3.Label = 51D;
            categoricalDataPoint3.Value = 51D;
            categoricalDataPoint4.Category = "D";
            categoricalDataPoint4.Label = 67D;
            categoricalDataPoint4.Value = 67D;
            categoricalDataPoint5.Category = "E";
            categoricalDataPoint5.Label = 20D;
            categoricalDataPoint5.Value = 20D;
            lineSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint1,
            categoricalDataPoint2,
            categoricalDataPoint3,
            categoricalDataPoint4,
            categoricalDataPoint5});
            lineSeries1.HorizontalAxis = dateTimeCategoricalAxis1;
            lineSeries1.LabelAngle = 90D;
            lineSeries1.LabelDistanceToPoint = 11D;
            lineSeries1.Name = "Measurement";
            lineSeries1.ShowLabels = true;
            lineSeries1.VerticalAxis = linearAxis1;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            lineSeries1});
            this.radChartView1.ShowPanZoom = true;
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.ShowTrackBall = true;
            this.radChartView1.Size = new System.Drawing.Size(515, 384);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.ThemeName = "ControlDefault";
            this.radChartView1.Click += new System.EventHandler(this.radChartView1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 418);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(492, 213);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // GraphPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 643);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.radChartView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GraphPage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "radDiagramRibbonBar1";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.GraphPage_Load);
            this.Shown += new System.EventHandler(this.GraphPage_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
