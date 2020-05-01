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
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartFactory.Pages
{
    public partial class DiagramPage : MetroFramework.Forms.MetroForm
    {
        public DiagramPage()
        {
            InitializeComponent();

        }

        private void DiagramPage_Load(object sender, EventArgs e)
        {
            DrawDiagram();
        }

        private void DrawDiagram()
        {
            NewOverallStats main = this.Owner as NewOverallStats;
           //main.radDropDownList1.Se
            int machid = main.radDropDownList1.SelectedIndex;
            //int measure = main.radDropDownList2.SelectedItem.Index;

            var Diagramm = new Chart();

            string connStr = Program.connStr;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            DateTime minDate = main.radDateTimePicker1.Value;
            DateTime maxDate = main.radDateTimePicker2.Value;


            var crits = String.Format("SELECT COUNT FROM `machine_stats` WHERE ((`Machine ID` = {7}) AND (`DateTime` >= '{0}') AND (`DateTime` <= '{1}') AND ((`Temp` >= '{2}') OR (`Vibr` >= '{3}') OR " +
                "(`Power` >= '{4}') OR (`Load` >= '{5}') OR (`Wtime` >= '{6}')))", minDate, maxDate, Program.critTemp, Program.critVibr, Program.critPow, Program.critLoad, Program.critTime, machid);
            MySqlCommand command1 = new MySqlCommand(crits, conn);
            string CritC = command1.ExecuteScalar().ToString();

            var dangs = String.Format("SELECT COUNT FROM `machine_stats` WHERE ((`Machine ID` = {12}) AND (`DateTime` >= '{0}') AND (`DateTime` <= '{1}') AND ((`Temp` BETWEEN '{2}' AND '{3}') OR (`Vibr` BETWEEN '{4}' AND '{5}') OR " +
                "(`Power` BETWEEN '{6}' AND '{7}') OR (`Load` BETWEEN '{8}' AND '{9}') OR (`Wtime` BETWEEN '{10}' AND '{11}')))", minDate, maxDate, Program.dangTemp, Program.critTemp, Program.dangVibr, Program.critVibr,
                Program.dangPow, Program.critPow, Program.dangLoad, Program.critLoad, Program.dangTime, Program.critTime, machid);
            MySqlCommand command2 = new MySqlCommand(crits, conn);
            string DangC = command2.ExecuteScalar().ToString();

            Diagramm.Series[0].Points.AddY(DangC);
            Diagramm.Series[0].Points.AddY(CritC);


            conn.Close();
            
        }

    }
}
