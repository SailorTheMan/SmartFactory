namespace SmartFactory
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.chatButton1 = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mapButton = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.MainPush = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.462219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.71001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.28591F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.chatButton1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 93);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::SmartFactory.Properties.Resources.Logo2;
            this.pictureBox1.Image = global::SmartFactory.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Location = new System.Drawing.Point(914, 20);
            this.loginButton.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(192, 53);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Вход";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // chatButton1
            // 
            this.chatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatButton1.Enabled = false;
            this.chatButton1.Location = new System.Drawing.Point(204, 20);
            this.chatButton1.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.chatButton1.Name = "chatButton1";
            this.chatButton1.Size = new System.Drawing.Size(68, 53);
            this.chatButton1.TabIndex = 2;
            this.chatButton1.Text = "Чат";
            this.chatButton1.Click += new System.EventHandler(this.chatButton1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.metroTile1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mapButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroTile2, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 165);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1125, 224);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // metroTile1
            // 
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile1.Location = new System.Drawing.Point(19, 20);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(336, 184);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "Онлайн данные со всех устройств";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.button2_Click);
            // 
            // mapButton
            // 
            this.mapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapButton.Location = new System.Drawing.Point(393, 20);
            this.mapButton.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(337, 184);
            this.mapButton.TabIndex = 10;
            this.mapButton.Text = "Данные картографии";
            this.mapButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mapButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mapButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mapButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile2.Location = new System.Drawing.Point(768, 20);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(338, 184);
            this.metroTile2.TabIndex = 11;
            this.metroTile2.Text = "Автоматизированный склад";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // MainPush
            // 
            this.MainPush.AutoSize = true;
            this.MainPush.BackColor = System.Drawing.SystemColors.Highlight;
            this.MainPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPush.ForeColor = System.Drawing.SystemColors.Control;
            this.MainPush.Location = new System.Drawing.Point(3, 0);
            this.MainPush.Name = "MainPush";
            this.MainPush.Size = new System.Drawing.Size(231, 24);
            this.MainPush.TabIndex = 2;
            this.MainPush.Text = "Место для уведомлений";
            this.MainPush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Controls.Add(this.MainPush);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 488);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1169, 81);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 585);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPage";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label MainPush;
        public MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mapButton;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton chatButton1;
    }
}

