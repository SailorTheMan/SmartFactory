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
            if (User.ID == -1)//
            {
                MainPush.Text = "Открытие входа в личный кабинет";
                new LoginPage().Show();
                if (User.ID != -1)
                {
                    button3.Text = "Личный кабинет";
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
            new StatPage().Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.machineList.Length -1 ; i++)
            {
                Console.WriteLine(i.ToString() + " " + Program.machineList[i].getLoadLog()[0]);
            }
            
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
    }
}
