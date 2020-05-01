using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartFactory.Scripts;

namespace SmartFactory.Pages
{
    public partial class CriticalPage : MetroFramework.Forms.MetroForm
    {
        public CriticalPage()
        {
            InitializeComponent();

        }

        private void CriticalPage_Load(object sender, EventArgs e)
        {
            fillSqlCritTable();
        }

        private void fillSqlCritTable()
        {
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            var lastEntry = "SELECT DateTime FROM `machine_stats` WHERE id = (SELECT MAX(id) FROM `machine_stats`)";

            MySqlCommand command = new MySqlCommand(lastEntry, conn);
            string returnedDate = command.ExecuteScalar().ToString(); //Получаем правильно
            DateTime maxDateDT = DateTime.Parse(returnedDate);
            DateTime minDateDT = maxDateDT.AddHours(-24);
            string minDate = DatToDB.reverseDate(minDateDT.AddHours(-72).ToString());           //Считаем правильно
            string maxDate = DatToDB.reverseDate(maxDateDT.ToString());

            conn.Close();
            var select = String.Format("SELECT * FROM `machine_stats` WHERE ((`DateTime` >= '{0}') AND (`DateTime` <= '{1}') AND ((`Temp` >= '{2}') OR (`Vibr` >= '{3}') OR " +
                "(`Power` >= '{4}') OR (`Load` >= '{5}') OR (`Wtime` >= '{6}')))", minDate, maxDate, Program.critTemp, Program.critVibr, Program.critPow, Program.critLoad, Program.critTime);    
            //Запрос обрабатывается
            var dataAdapter = new MySqlDataAdapter(select, conn);
            var ds = new DataSet();
            dataAdapter.Fill(ds);  //А ds пустой!
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
        private double Cdoub(string input)  //Всякие странные функции для сплита и конвертации
        {
            string[] str = input.Split('\t');
            return Convert.ToDouble(str[1]);
        }
        private double Cint(string input)
        {
            string[] str = input.Split('\t');
            return Convert.ToInt32(str[1]);
        }
    }
}
