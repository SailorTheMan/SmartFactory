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
            this.components = new System.ComponentModel.Container();
            this.radChat1 = new Telerik.WinControls.UI.RadChat();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChat1
            // 
            this.radChat1.Location = new System.Drawing.Point(23, 63);
            this.radChat1.Name = "radChat1";
            this.radChat1.Size = new System.Drawing.Size(486, 657);
            this.radChat1.TabIndex = 0;
            this.radChat1.Text = "radChat1";
            this.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00");
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 743);
            this.Controls.Add(this.radChat1);
            this.Name = "ChatPage";
            this.Text = "Чат";
            this.Load += new System.EventHandler(this.ChatPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChat radChat1;
        private System.Windows.Forms.Timer timer1;
    }
}