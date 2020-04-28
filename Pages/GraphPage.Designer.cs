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
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.DateTimeCategoricalAxis dateTimeCategoricalAxis2 = new Telerik.WinControls.UI.DateTimeCategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis2 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.LineSeries lineSeries2 = new Telerik.WinControls.UI.LineSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint6 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint7 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint8 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint9 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint10 = new Telerik.Charting.CategoricalDataPoint();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphPage));
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(515, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // radChartView1
            // 
            cartesianArea2.GridDesign.AlternatingHorizontalColor = false;
            cartesianArea2.GridDesign.AlternatingVerticalColor = false;
            cartesianArea2.ShowGrid = true;
            this.radChartView1.AreaDesign = cartesianArea2;
            dateTimeCategoricalAxis2.DateTimeComponent = Telerik.Charting.DateTimeComponent.Ticks;
            dateTimeCategoricalAxis2.IsPrimary = true;
            dateTimeCategoricalAxis2.LabelRotationAngle = 300D;
            dateTimeCategoricalAxis2.Title = "";
            linearAxis2.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis2.IsPrimary = true;
            linearAxis2.LabelRotationAngle = 300D;
            linearAxis2.MajorStep = 10D;
            linearAxis2.TickOrigin = null;
            linearAxis2.Title = "";
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            dateTimeCategoricalAxis2,
            linearAxis2});
            this.radChartView1.Location = new System.Drawing.Point(0, 28);
            this.radChartView1.Name = "radChartView1";
            categoricalDataPoint6.Category = "A";
            categoricalDataPoint6.Label = 94D;
            categoricalDataPoint6.Value = 94D;
            categoricalDataPoint7.Category = "B";
            categoricalDataPoint7.Label = 15D;
            categoricalDataPoint7.Value = 15D;
            categoricalDataPoint8.Category = "C";
            categoricalDataPoint8.Label = 51D;
            categoricalDataPoint8.Value = 51D;
            categoricalDataPoint9.Category = "D";
            categoricalDataPoint9.Label = 67D;
            categoricalDataPoint9.Value = 67D;
            categoricalDataPoint10.Category = "E";
            categoricalDataPoint10.Label = 20D;
            categoricalDataPoint10.Value = 20D;
            lineSeries2.DataPoints.AddRange(new Telerik.Charting.DataPoint[] {
            categoricalDataPoint6,
            categoricalDataPoint7,
            categoricalDataPoint8,
            categoricalDataPoint9,
            categoricalDataPoint10});
            lineSeries2.HorizontalAxis = dateTimeCategoricalAxis2;
            lineSeries2.LabelAngle = 90D;
            lineSeries2.LabelDistanceToPoint = 11D;
            lineSeries2.Name = "Measurement";
            lineSeries2.ShowLabels = true;
            lineSeries2.VerticalAxis = linearAxis2;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            lineSeries2});
            this.radChartView1.ShowPanZoom = true;
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.ShowTrackBall = true;
            this.radChartView1.Size = new System.Drawing.Size(515, 384);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.ThemeName = "ControlDefault";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Save";
            // 
            // GraphPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 475);
            this.Controls.Add(this.radChartView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GraphPage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "radDiagramRibbonBar1";
            this.ThemeName = "VisualStudio2012Dark";
            this.Shown += new System.EventHandler(this.GraphPage_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
    }
}
