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
    public partial class RouteNameInput : Form
    {
        public RouteNameInput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MapPage main = this.Owner as MapPage;

            main.routeName = textBox1.Text;
            this.Close();
        }
    }
}
