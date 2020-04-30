namespace SmartFactory.Pages
{
    partial class UserReg
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.sexInput = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.positionInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwodLbl = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.levelInput = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(16, 34);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(331, 22);
            this.nameInput.TabIndex = 0;
            this.nameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Возраст";
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(395, 94);
            this.ageInput.Margin = new System.Windows.Forms.Padding(4);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(53, 22);
            this.ageInput.TabIndex = 2;
            this.ageInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageInput_KeyPress);
            // 
            // sexInput
            // 
            this.sexInput.Items.Add("М");
            this.sexInput.Items.Add("Ж");
            this.sexInput.Location = new System.Drawing.Point(371, 34);
            this.sexInput.Margin = new System.Windows.Forms.Padding(4);
            this.sexInput.Name = "sexInput";
            this.sexInput.Size = new System.Drawing.Size(68, 22);
            this.sexInput.TabIndex = 5;
            this.sexInput.Text = "ПОЛ";
            this.sexInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sexInput_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Должность";
            // 
            // positionInput
            // 
            this.positionInput.Location = new System.Drawing.Point(16, 94);
            this.positionInput.Margin = new System.Windows.Forms.Padding(4);
            this.positionInput.Name = "positionInput";
            this.positionInput.Size = new System.Drawing.Size(331, 22);
            this.positionInput.TabIndex = 7;
            this.positionInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionInput_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Почта";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(16, 154);
            this.emailInput.Margin = new System.Windows.Forms.Padding(4);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(331, 22);
            this.emailInput.TabIndex = 9;
            this.emailInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailInput_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Стаж";
            // 
            // expInput
            // 
            this.expInput.Location = new System.Drawing.Point(493, 94);
            this.expInput.Margin = new System.Windows.Forms.Padding(4);
            this.expInput.Name = "expInput";
            this.expInput.Size = new System.Drawing.Size(53, 22);
            this.expInput.TabIndex = 11;
            this.expInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expInput_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwodLbl
            // 
            this.passwodLbl.AutoSize = true;
            this.passwodLbl.Location = new System.Drawing.Point(16, 190);
            this.passwodLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwodLbl.Name = "passwodLbl";
            this.passwodLbl.Size = new System.Drawing.Size(395, 17);
            this.passwodLbl.TabIndex = 15;
            this.passwodLbl.Text = "Пароль (Пароль должен состоять минимум из 8 символов)";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(16, 216);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(331, 22);
            this.passwordInput.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Уровень доступа";
            // 
            // levelInput
            // 
            this.levelInput.Items.Add("сотрудник");
            this.levelInput.Items.Add("руководитель отдела");
            this.levelInput.Items.Add("руководитель предприятия");
            this.levelInput.Items.Add("админ");
            this.levelInput.Location = new System.Drawing.Point(457, 35);
            this.levelInput.Margin = new System.Windows.Forms.Padding(4);
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(169, 22);
            this.levelInput.TabIndex = 18;
            this.levelInput.Text = "Уровень доступа";
            this.levelInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.levelInput_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 140);
            this.label8.MinimumSize = new System.Drawing.Size(200, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 51);
            this.label8.TabIndex = 19;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 250);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.levelInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passwodLbl);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.positionInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sexInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserReg";
            this.Text = "Регистрация нового пльзователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.DomainUpDown sexInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label passwodLbl;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown levelInput;
        private System.Windows.Forms.Label label8;
    }
}