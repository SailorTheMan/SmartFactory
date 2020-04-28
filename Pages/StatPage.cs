﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SmartFactory.Scripts;

namespace SmartFactory.Pages
{
    public partial class StatPage : Form
    {
        public StatPage()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (new DatToDB().Converter(openFileDialog1.FileName))
                {
                    MessageBox.Show("Всё ок");
                }
                else
                {
                    MessageBox.Show("Все пошло по пизде :|");
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new OverallStats().Show();
        }
    }
}
