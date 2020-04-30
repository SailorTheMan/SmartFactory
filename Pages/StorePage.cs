using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFactory.Scripts;
using MySql.Data.MySqlClient;

namespace SmartFactory.Pages
{
    public partial class StorePage : Form
    {
        public StorePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Данные буду загружены после закрытия этого окна. Вы получите уведомление об успешном завершении.");
                new StoreToDB().Convert(openFileDialog1.FileName);
                MessageBox.Show("Данные успешно были загружены");
            }
            fillTable();
        }

        private void StorePage_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void fillTable()
        {
            var select = "SELECT * FROM store;";
            //var c = new SqlConnection(yourConnectionString); // Your Connection String here
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connStr);
            var dataAdapter = new MySqlDataAdapter(select, conn);

            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

    }
}
