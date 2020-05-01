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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.loginInput = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.passwordInput = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(75, 263);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 17);
            this.Warning.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartFactory.Properties.Resources.Дизайн_1__лого__общее_горизонтальное_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(175, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Email";
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(67, 176);
            this.loginInput.MaxLength = 100;
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(265, 23);
            this.loginInput.TabIndex = 10;
            this.loginInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginInput_KeyPress);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(141, 293);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(114, 23);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Вход";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(114, 231);
            this.passwordInput.MaxLength = 30;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(170, 23);
            this.passwordInput.TabIndex = 13;
            this.passwordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordInput_KeyPress);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(168, 208);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 20);
            this.Password.TabIndex = 12;
            this.Password.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите Email и пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Регистрация";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(399, 400);
            this.Name = "LoginPage";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginPage_KeyPress);
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