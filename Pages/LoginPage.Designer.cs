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
            this.loginButton = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(153, 239);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(132, 42);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(195, 99);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(47, 17);
            this.Login.TabIndex = 1;
            this.Login.Text = "Логин";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(195, 174);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 17);
            this.Password.TabIndex = 2;
            this.Password.Text = "Пароль";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(205, 219);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 17);
            this.Warning.TabIndex = 3;
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(137, 131);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(172, 22);
            this.loginInput.TabIndex = 4;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(137, 194);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(172, 22);
            this.passwordInput.TabIndex = 5;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 478);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginPage";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.TextBox passwordInput;
    }
}