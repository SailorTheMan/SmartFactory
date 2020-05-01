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
            try
            {
                string connStr = Program.connStr;
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                var lastEntry = "SELECT DateTime FROM `machine_stats` WHERE id = (SELECT MAX(id) FROM `machine_stats`)";

            MySqlCommand command = new MySqlCommand(lastEntry, conn);
            string returnedDate = command.ExecuteScalar().ToString(); //Получаем правильно
            DateTime maxDateDT = DateTime.Parse(returnedDate);
            DateTime minDateDT = maxDateDT.AddHours(-24);
            string minDate = DatToDB.reverseDate(minDateDT.ToString());           //Считаем правильно
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
            catch
            {
                MessageBox.Show("Проверьте подключение к интернету");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
