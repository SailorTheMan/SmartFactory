﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using SmartFactory.Models;

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
                MainPush.Text = "Загрузка...";
                Thread uploadingData = new Thread(createUploadThread);
                uploadingData.Start();
                label1.Text = "";
                MainPush.Text = "";
            }

        }

        private void createUploadThread()
        {
            MessageBox.Show("Загрузка данных произойдет в фоновом режиме. Вы получите сообщение об успешной загрузке");
            new DatToDB().Converter(openFileDialog1.FileName);
            MessageBox.Show("Загрузка данных успешно завершена.");
            //timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPush.Text = "Загрузка телеметрии";
            new OverallStats().Show();
            MainPush.Text = "";
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            new StatUpdater().UpdateStat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPush.Text = "Вход в личный кабинет";
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

        private void StatPage_Load(object sender, EventArgs e)
        {
            if (User.ID != -1)
            {
                button3.Text = "Личный кабинет";
            }
        }
    }
}
