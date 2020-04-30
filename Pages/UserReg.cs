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

            uc.Register(emailInput.Text, passwordInput.Text, nameInput.Text, positionInput.Text, Int32.Parse(ageInput.Text), 
                Int32.Parse(expInput.Text), sexInput.Text, levelInput.Text);

           
        }
    }
}
