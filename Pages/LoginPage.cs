using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SmartFactory.Controllers;
using SmartFactory.Models;

namespace SmartFactory.Pages
{
    public partial class LoginPage : MetroFramework.Forms.MetroForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

         UserReg UserRegPage;

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            UserController uc = new UserController();

            String login = loginInput.Text;
            String password = uc.Encrypt(passwordInput.Text);
            label1.Text = "Загрузка...";
            AccountPage f1 = new AccountPage();
            if (loginInput.Text.Length < 1)
            {
                label1.Text = "Введите свой Email";
            }
            else if (!loginInput.Text.Contains("@"))
            {
                label1.Text = "Введите корректный Email";
            }
            else if (passwordInput.Text.Length < 1)
            {
                label1.Text = "Введите свой пароль";
            }

            else if (uc.Login(login, password))
            {
                MessageBox.Show("Выполнен вход.");
                this.Close();
            }
            else
            {
                label1.Text = "Проверьте правильность ввода Email/пароля";
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegPage = new UserReg();
            UserRegPage.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
