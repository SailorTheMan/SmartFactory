namespace SmartFactory.Pages
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.Warning = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.loginInput = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.passwordInput = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(56, 214);
            this.Warning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 13);
            this.Warning.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(120, 122);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Email";
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(71, 143);
            this.loginInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(128, 19);
            this.loginInput.TabIndex = 10;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(94, 236);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(86, 19);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Вход";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(71, 193);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(128, 19);
            this.passwordInput.TabIndex = 13;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(113, 172);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(54, 19);
            this.Password.TabIndex = 12;
            this.Password.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(85, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "Регистрация";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartFactory.Properties.Resources.Дизайн_1__лого__общее_горизонтальное_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 325);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 325);
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox loginInput;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTextBox passwordInput;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton button1;
    }
}