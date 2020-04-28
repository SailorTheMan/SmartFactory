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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

         UserReg UserRegPage;

        private void loginButton_Click(object sender, EventArgs e)
        {
            String login = loginInput.Text;
            String password = passwordInput.Text;

            UserController uc = new UserController();

            AccountPage f1 = new AccountPage();

            if (uc.Login(login, password))
            {
                MessageBox.Show("Выполнен вход.");

                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность ввода логина/пароля");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegPage = new UserReg();
            UserRegPage.Show();
        }
    }
}
