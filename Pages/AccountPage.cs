using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFactory.Models;

namespace SmartFactory.Pages
{
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AccountPage_Load(object sender, EventArgs e)
        {
            nameLbl.Text = User.Name;
            ageLbl.Text = User.Age.ToString();
            sexLbl.Text = User.Sex;
            posLbl.Text = User.Position;
            emailLbl.Text = User.Email;
            expLbl.Text = User.Experience.ToString();

            if (User.Level == 0)
            {
                levelLbl.Text = "админ";
            }

            if (User.Level == 1)
            {
                levelLbl.Text = "руководитель предприятия";
            }

            if (User.Level == 2)
            {
                levelLbl.Text = "руководитель отдела";
            }

            if (User.Level == 3)
            {
                levelLbl.Text = "сотрудник";
            }

        }
    }
}
