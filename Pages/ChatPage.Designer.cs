namespace SmartFactory.Pages
{
    partial class ChatPage
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
            this.radChat1 = new Telerik.WinControls.UI.RadChat();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChat1
            // 
            this.radChat1.Location = new System.Drawing.Point(23, 63);
            this.radChat1.Name = "radChat1";
            this.radChat1.Size = new System.Drawing.Size(1127, 657);
            this.radChat1.TabIndex = 0;
            this.radChat1.Text = "radChat1";
            this.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00");
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1200, 210);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 743);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.radChat1);
            this.Name = "ChatPage";
            this.Text = "Чат";
            this.Load += new System.EventHandler(this.ChatPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChat radChat1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}