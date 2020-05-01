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
using SmartFactory.Models;

namespace SmartFactory.Pages
{
    public partial class NewOverallStats : MetroFramework.Forms.MetroForm
    {
        public NewOverallStats()
        {
            InitializeComponent();
        }

        private void NewOverallStats_Load(object sender, EventArgs e)
        {
            radDateTimePicker1.MinDate = new DateTime(2020, 2, 1);
            radDateTimePicker1.MaxDate = new DateTime(2020, 3, 31);
            radDateTimePicker1.Value = DateTime.Today;

            radDateTimePicker2.MinDate = new DateTime(2020, 2, 1);
            radDateTimePicker2.MaxDate = new DateTime(2020, 3, 31);
            radDateTimePicker2.Value = DateTime.Today;

            radDateTimePicker1.Format = DateTimePickerFormat.Custom;
            radDateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            radDateTimePicker2.Format = DateTimePickerFormat.Custom;
            radDateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";

            fillTable();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OverallPush.Text = "Заполнение таблицы";
            //fillTable();
            fillSqlTable();
            OverallPush.Text = "Таблица заполнена";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OverallPush.Text = "Отрисовка графика";

            /*
            GraphPage gp = new GraphPage();
            gp.Owner = this;
            gp.ShowDialog();
            //new GraphPage().Show();
            */

            NewGraphPage gp = new NewGraphPage();
            gp.ShadowType = MetroFormShadowType.None;
            gp.Owner = this;
            gp.Show();
            OverallPush.Text = "";
        }

        private void fillTable()
        {
            DataTable table = new DataTable();
            //Задаём столбики
            table.Columns.Add("Machine Id", typeof(int));
            table.Columns.Add("Dangerous Status", typeof(bool));
            table.Columns.Add("Critical Status", typeof(bool));
            table.Columns.Add("Last Temp", typeof(double));
            table.Columns.Add("Last Vibr", typeof(double));
            table.Columns.Add("Last Power", typeof(double));
            table.Columns.Add("Last Load", typeof(double));
            table.Columns.Add("Worktime", typeof(int));


            //Обработка всех машин. Отображение последней пачки данных. 
            for (int counter = 0; counter < 12; counter++)
            {
                Machine mek = CritChecker(Program.machineList[counter]);
                table.Rows.Add(mek.getID(), mek.isDangerous(), mek.isCritical(), Cdoub(mek.getTempLog().Last()), Cdoub(mek.getVibrLog().Last()),
                    Cdoub(mek.getPowerLog().Last()), Cdoub(mek.getLoadLog().Last()), Cint(mek.getWorkTimeLog().Last()));
            }

            dataGridView1.DataSource = table;
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

        private Machine CritChecker(Machine e)
        {
            double t = Cdoub(e.getTempLog().Last());
            double v = Cdoub(e.getVibrLog().Last());
            double w = Cdoub(e.getPowerLog().Last());
            double l = Cdoub(e.getLoadLog().Last());
            double h = Cdoub(e.getWorkTimeLog().Last());        //Надо хакнуть Last


            if (t >= Program.critTemp || v >= Program.critVibr || w >= Program.critPow || l >= Program.critLoad || h >= Program.critTime)
            {
                e.CriticalStatus = true;
            }
            else if (t >= Program.dangTemp || v >= Program.dangVibr || w >= Program.dangPow || l >= Program.dangLoad || h >= Program.dangTime)
            {
                e.DangerousStatus = true;
            }
            return e;
        }

        private void fillSqlTable()
        {
            int machid = radDropDownList1.SelectedItem.Index+1;
            int measure = radDropDownList2.SelectedItem.Index+2;
            DateTime minDate = radDateTimePicker1.Value;
            DateTime maxDate = radDateTimePicker2.Value;

            string minDateS = minDate.GetDateTimeFormats('s')[0];
            string maxDateS = maxDate.GetDateTimeFormats('s')[0];
            try
            {
                string[] measures = { "Machine ID", "DateTime", "Temp", "Vibr", "Power", "Load", "Wtime", "id" };

                var select = String.Format("SELECT `Machine ID`, `DateTime`, `{0}` FROM `machine_stats` WHERE (`Machine ID` = {1}) AND (`DateTime` >= '{2}') AND (`DateTime` <= '{3}')", measures[measure], machid, minDateS, maxDateS);

                string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connStr);
                var dataAdapter = new MySqlDataAdapter(select, conn);
                //dataGridView1.Rows[0]
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером. '\n' Проверьте подключение и попробуйте еще раз.");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}
