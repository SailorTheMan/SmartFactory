using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Navigation;
using SmartFactory.Models;
using MySql.Data.MySqlClient;
using ZedGraph;
//using Telerik.WinControls.GridView;
//using Telerik.WinControls.GridView;

namespace SmartFactory.Pages
{
    public partial class OverallStats : Telerik.WinControls.UI.RadForm
    {
        public OverallStats()
        {
            InitializeComponent();
            GraphPage gp = new GraphPage();
            gp.Owner = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RadForm1_Load(object sender, EventArgs e)
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

        private void radButton2_Click(object sender, EventArgs e)
        {
            OverallPush.Text = "Отрисовка графика";

            /*
            GraphPage gp = new GraphPage();
            gp.Owner = this;
            gp.ShowDialog();
            //new GraphPage().Show();
            */

            GraphPage2 gp = new GraphPage2();
            gp.Owner = this;
            gp.ShowDialog();
            OverallPush.Text = "";
        }

        private void radDropDownList1_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Всё ок");
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //MessageBox.Show("Всё ок");
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            OverallPush.Text = "Заполнение таблицы";
            //fillTable();
            fillSqlTable();
            OverallPush.Text = "Таблица заполнена";
        }

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
            for(int counter = 0; counter < 12; counter++)
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
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

                }
            }
            //foreach (DataGridViewCell b in this.dataGridView1.Rows[e.RowIndex].Cells[1])

           //var b = this.dataGridView1.Rows[e.RowIndex].Cells[1].;
        }

        /// <summary>
        /// Возвращает элемент класса Machine с обновлённым статусом
        /// </summary>
        

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
            int machid = radDropDownList1.SelectedItem.Index;
            int measure = radDropDownList2.SelectedItem.Index;
            DateTime minDate = radDateTimePicker1.Value;
            DateTime maxDate = radDateTimePicker2.Value;

           
            string[] measures = {"Machine ID", "DateTime", "Temp", "Vibr", "Power", "Load", "Wtime", "id"};

            // XDate dt = new XDate(Convert.ToInt32(parsedD[2]), Convert.ToInt32(parsedD[1]), Convert.ToInt32(parsedD[0]),
            //   Convert.ToInt32(parsedT[0]), Convert.ToInt32(parsedT[1]), Convert.ToInt32(parsedT[2]));


            var select = String.Format("SELECT `Machine ID`, {0} FROM `machine_stats` WHERE {1} AND  AND ", measures[measure]);
            // var select = "SELECT * FROM `machine_stats` WHERE '{$minDate}' <= `DateTime` AND `DateTime` <= '{$maxDate}'";
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
