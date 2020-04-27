using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // TODO: Подтянуть пароль по логину из дб, сравнить, если все ок, подгрузить остальные поля из дб в глобальную переменную User в program.cs
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegPage = new UserReg();
            UserRegPage.Show();
        }
    }
}
