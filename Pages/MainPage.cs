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
using SmartFactory.Pages;

namespace SmartFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LoginPage loginPage;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(User.ID);
            if (User.ID == -1)
            {
                new LoginPage().ShowDialog();
                if (User.ID != -1)
                {
                    button3.Text = "Личный кабинет";
                }
            }

            else
            {
                new AccountPage().ShowDialog();
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
