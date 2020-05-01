namespace SmartFactory.Pages
{
    partial class MapPage
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.сheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.сheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.сheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(20, 60);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1263, 592);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // сheckBox1
            // 
            this.сheckBox1.AutoSize = true;
            this.сheckBox1.Location = new System.Drawing.Point(1092, 161);
            this.сheckBox1.Name = "сheckBox1";
            this.сheckBox1.Size = new System.Drawing.Size(77, 17);
            this.сheckBox1.TabIndex = 5;
            this.сheckBox1.Text = "Филиалы";
            this.сheckBox1.UseVisualStyleBackColor = true;
            this.сheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // сheckBox2
            // 
            this.сheckBox2.AutoSize = true;
            this.сheckBox2.Location = new System.Drawing.Point(1092, 184);
            this.сheckBox2.Name = "сheckBox2";
            this.сheckBox2.Size = new System.Drawing.Size(90, 17);
            this.сheckBox2.TabIndex = 6;
            this.сheckBox2.Text = "Маршруты";
            this.сheckBox2.UseVisualStyleBackColor = true;
            this.сheckBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // сheckBox3
            // 
            this.сheckBox3.AutoSize = true;
            this.сheckBox3.Location = new System.Drawing.Point(1092, 207);
            this.сheckBox3.Name = "сheckBox3";
            this.сheckBox3.Size = new System.Drawing.Size(86, 17);
            this.сheckBox3.TabIndex = 7;
            this.сheckBox3.Text = "Работники";
            this.сheckBox3.UseVisualStyleBackColor = true;
            this.сheckBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1092, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Загрузить маршрут";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.сheckBox3);
            this.Controls.Add(this.сheckBox2);
            this.Controls.Add(this.сheckBox1);
            this.Controls.Add(this.gMapControl1);
            this.MaximumSize = new System.Drawing.Size(1303, 672);
            this.MinimumSize = new System.Drawing.Size(1303, 672);
            this.Name = "MapPage";
            this.Text = "Карта";
            this.Load += new System.EventHandler(this.MapPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroCheckBox сheckBox1;
        private MetroFramework.Controls.MetroCheckBox сheckBox2;
        private MetroFramework.Controls.MetroCheckBox сheckBox3;
        private MetroFramework.Controls.MetroButton button1;
    }
}