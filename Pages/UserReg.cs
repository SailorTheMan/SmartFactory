using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SmartFactory.Controllers;

namespace SmartFactory.Pages
{
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserController uc = new UserController();
            int t = 0;
            for (int i = 0; i < nameInput.Text.Length; i++)
            {
                if (nameInput.Text[i] == ' ')
                {
                    t++;
                }
            }
            if (nameInput.Text.Equals(""))
            {
                label8.Text = "Введите ФИО";
            }
            else if (t != 2)
            {
                label8.Text = "Введите корректные ФИО";
            }
            else if (positionInput.Text.Equals(""))
            {
                label8.Text = "Введите должность";
            }
            else if (emailInput.Text.Length < 1)
            {
                label8.Text = "Введите email";
            }
            else if (!emailInput.Text.Contains("@"))
            {
                label8.Text = "Введите корректный email";
            }
            else if (sexInput.Text.Equals("ПОЛ"))
            {
                label8.Text = "Введите пол";
            }
            else if (levelInput.Text.Equals("Уровень доступа"))
            {
                label8.Text = "Введите уровень доступа";
            }
            else if (ageInput.Text.Length < 1)
            {
                label8.Text = "Введите возраст";
            }
            else if (expInput.Text.Length < 1)
            {
                label8.Text = "Введите стаж";
            }
            else if (passwordInput.Text.Length < 8)
            {
                passwodLbl.Text = "Пароль (Пароль должен состоять минимум из 8 символов)";
                label8.Text = "Введите пароль";
            }
            else
            {
                label8.Text = "Спасибо за регистрацию." + Environment.NewLine + "Можете войти в личный кабинет.";
                uc.Register(emailInput.Text, uc.Encrypt(passwordInput.Text), nameInput.Text, positionInput.Text, Int32.Parse(ageInput.Text),
                Int32.Parse(expInput.Text), sexInput.Text, levelInput.Text);
            }



        }

        private void nameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешаем бэксп
            if (e.KeyChar.Equals('\b')) return;
            var tb = (TextBox)sender;
           
           
            //Разбираемся с дефисом
            if (e.KeyChar.Equals('-'))
            {
                e.Handled = tb.SelectionStart == 0 || tb.Text[tb.SelectionStart - 1].Equals('-');
                if (!e.Handled)
                {
                    return;
                }
            }
            //Разбираемся с пробелом
            if (e.KeyChar.Equals(' '))
            {
                e.Handled = tb.SelectionStart == 0 || tb.Text[tb.SelectionStart - 1].Equals(' ');
                if (!e.Handled)
                {
                    return;
                }
            }
            
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void ageInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешаем бэксп
            if (e.KeyChar.Equals('\b')) return;
            
            //Разрешаем только цифры
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void positionInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;
            //разрешаем бэксп
            if (e.KeyChar.Equals('\b')) return;
           
            //Разбираемся с дефисом
            if (e.KeyChar.Equals('-'))
            {
                e.Handled = tb.SelectionStart == 0 || tb.Text[tb.SelectionStart - 1].Equals('-');
                if (!e.Handled)
                {
                    return;
                }
            }
            //Разбираемся с пробелом
            if (e.KeyChar.Equals(' '))
            {
                e.Handled = tb.SelectionStart == 0 || tb.Text[tb.SelectionStart - 1].Equals(' ');
                if (!e.Handled)
                {
                    return;
                }
            }
            //Разрешаем только буквы и цифры
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar));
        }

        private void expInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешаем бэксп
            if (e.KeyChar.Equals('\b')) return;
           
            //Разрешаем только цифры
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void emailInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            
            //быстрее было так сделать чем искать нормальное решение
            //разрешаем спец символы !#$%&'*+-/=?^_`{|}~
            if (e.KeyChar.Equals('!') || e.KeyChar.Equals('@') || e.KeyChar.Equals('.') || e.KeyChar.Equals('#') || e.KeyChar.Equals('$') || e.KeyChar.Equals('%') || e.KeyChar.Equals('&') || e.KeyChar.Equals("'") || e.KeyChar.Equals('*') || e.KeyChar.Equals('+') || e.KeyChar.Equals('-') || e.KeyChar.Equals('/') || e.KeyChar.Equals('=') || e.KeyChar.Equals('?') || e.KeyChar.Equals('^') || e.KeyChar.Equals('_') || e.KeyChar.Equals('`') || e.KeyChar.Equals('{') || e.KeyChar.Equals('|') || e.KeyChar.Equals('}') || e.KeyChar.Equals('~'))
            {
                return;
            }
            
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void sexInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void levelInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        
    }
}
