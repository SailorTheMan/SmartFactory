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
using SmartFactory;
using MySql.Data.MySqlClient;
using Google.Protobuf.Collections;

namespace SmartFactory
{
    public partial class MainPage : MetroFramework.Forms.MetroForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPush.Text = "Вход в личный кабинет";
            if (User.ID == -1)
            {
                new LoginPage().ShowDialog();

                if (User.ID != -1)
                {
                    loginButton.Text = "Личный кабинет";
                    chatButton1.Enabled = true;
                }
            }
//
            else
            {
                new AccountPage().Show();
            }
            MainPush.Text = "";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPush.Text = "Открытие телеметрии";
            StatPage sp = new StatPage();
            sp.ShadowType = MetroFormShadowType.None;
            sp.Owner = this;
            sp.Show();
            MainPush.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMachineList();
        }

        private void InitMachineList()
        {

            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string query = "SELECT * FROM `machine_stats`";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            bool isRepeated = false;
            bool isFirst = true;

            while (reader.Read())
            {
                if (!isRepeated && (int.Parse(reader[0].ToString()) == 1 && !isFirst))
                {
                    isRepeated = true;
                    
                }

                if (!isRepeated)
                {
                    Program.machineList[int.Parse(reader[0].ToString()) - 1] = new Machine(int.Parse(reader[0].ToString()));
                }

                Program.machineList[int.Parse(reader[0].ToString()) - 1].addTempLog(reader[1].ToString() + '	' + reader[2].ToString());
                Program.machineList[int.Parse(reader[0].ToString()) - 1].addVibrLog(reader[1].ToString() + '	' + reader[3].ToString());
                Program.machineList[int.Parse(reader[0].ToString()) - 1].addPowerLog(reader[1].ToString() + '	' + reader[4].ToString());
                Program.machineList[int.Parse(reader[0].ToString()) - 1].addLoadLog(reader[1].ToString() + '	' + reader[5].ToString());
                Program.machineList[int.Parse(reader[0].ToString()) - 1].addWorkTimeLog(reader[1].ToString() + '	' + reader[6].ToString());
                
                isFirst = false;
            }
            MainPush.Text = "Последние данные загружены";

        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            MainPush.Text = "Загрузка системы картографии";
            new MapPage().Show();
            MainPush.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MainPush.Text = "Загрузка автоматизации склада";
            StorePage sp = new StorePage();
            sp.Show();
            MainPush.Text = "";
        }

        private void chatButton1_Click(object sender, EventArgs e)
        {
            new ChatPage().Show();
        }
    }
}
