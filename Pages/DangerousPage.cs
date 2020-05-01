using MySql.Data.MySqlClient;
using SmartFactory.Scripts;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartFactory.Pages
{
    public partial class DangerousPage : MetroFramework.Forms.MetroForm
    {
        public DangerousPage()
        {
            InitializeComponent();
        }

        private void fillSqlCritTable()
        {
            try
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

                var select = String.Format("SELECT * FROM `machine_stats` WHERE ((`DateTime` >= '{0}') AND (`DateTime` <= '{1}') AND ((`Temp` BETWEEN '{2}' AND '{3}') OR (`Vibr` BETWEEN '{4}' AND '{5}') OR " +
                    "(`Power` BETWEEN '{6}' AND '{7}') OR (`Load` BETWEEN '{8}' AND '{9}') OR (`Wtime` BETWEEN '{10}' AND '{11}')))", minDate, maxDate, Program.dangTemp, Program.critTemp, Program.dangVibr, Program.critVibr,
                    Program.dangPow, Program.critPow, Program.dangLoad, Program.critLoad, Program.dangTime, Program.critTime);
                //Запрос обрабатывается
                var dataAdapter = new MySqlDataAdapter(select, conn);
                var ds = new DataSet();
                dataAdapter.Fill(ds);  //А ds пустой!
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Проверьте подключение к сети");
            }
        }


        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && !(e.Value is DateTime))
            {
                double val = Convert.ToDouble(e.Value);

                // Это условное форматирование ячеек. Можно реюзать.
                switch (this.dataGridView1.Columns[e.ColumnIndex].Name)
                {
                    case "Last Temp":
                        if (val >= Program.dangTemp)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critTemp)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;
                    case "Temp":
                        if (val >= Program.dangTemp)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critTemp)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;

                    case "Last Vibr":
                        if (val >= Program.dangVibr)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critVibr)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;
                    case "Vibr":
                        if (val >= Program.dangVibr)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critVibr)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;

                    case "Last Power":
                        if (val >= Program.dangPow)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critPow)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;
                    case "Power":
                        if (val >= Program.dangPow)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critPow)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;

                    case "Last Load":
                        if (val >= Program.dangLoad)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critLoad)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;
                    case "Load":
                        if (val >= Program.dangLoad)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critLoad)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;

                    case "Worktime":
                        if (val >= Program.dangTime)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critTime)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;
                    case "Wtime":
                        if (val >= Program.dangTime)
                        {
                            e.CellStyle.BackColor = Color.Yellow;
                        }
                        if (val >= Program.critTime)
                        {
                            e.CellStyle.BackColor = Color.Red;
                        }
                        break;

                }
            }
        }

        private void DangerousPage_Load(object sender, EventArgs e)
        {
            fillSqlCritTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
