﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.Charting;
using Telerik.Windows.Controls.Diagrams;
using Telerik.Charting.Styles;
using SmartFactory.Models;
using System.Windows.Forms.DataVisualization.Charting;



namespace SmartFactory.Pages
{
    public partial class GraphPage : Telerik.WinControls.UI.RadForm
    { 
        public GraphPage()
        {
            InitializeComponent();
            //Данные можно в графики подгружать из подключенной через его же интерфейс ДБ
        }

        private void GraphPage_Shown(object sender, EventArgs e)
        {
            OverallStats main = this.Owner as OverallStats;         //Шняга для передачи данных между формами. Но нужно соответсвующуе элементы пабликами делать
            if (main != null)
            {
                string s = main.radDropDownList1.SelectedItem.Text;
                string d = main.radDropDownList2.SelectedItem.Text;
                
            }
            
        }

        private void radChartView1_Click(object sender, EventArgs e)
        {

        }

        private void GraphPage_Load(object sender, EventArgs e)
        {

            fillChart();

        }

        private void fillChart()
        {
            //DataSet ds = new DataSet();
            //ds.Tables[0].Rows[0][0];
            //chart1.Series["Series1"].LegendText = "График XY";

            OverallStats main = this.Owner as OverallStats;         //Шняга для передачи данных между формами. Но нужно соответсвующуе элементы пабликами делать
            
            int machid = main.radDropDownList1.SelectedItem.Index;
            int measure = main.radDropDownList2.SelectedItem.Index;
            Machine dummy = Program.machineList[machid];
            List<string> DataToDraw = new List<string>();

            var s = new Series();
            s.ChartType = SeriesChartType.Line;

            switch (measure)
            {
                case 0:
                    DataToDraw = dummy.getTempLog();
                    break;
                case 1:
                    DataToDraw = dummy.getVibrLog();
                    break;
                case 2:
                    DataToDraw = dummy.getPowerLog();
                    break;
                case 3:
                    DataToDraw = dummy.getLoadLog();
                    break;
                case 4:
                    DataToDraw = dummy.getWorkTimeLog();
                    break;

            }

            DateTime minDate = main.radDateTimePicker1.Value;
            DateTime maxDate = main.radDateTimePicker2.Value; 

            for (int i = 0; i < DataToDraw.Count; i++)
            {
                string[] couple = DataToDraw[i].Split('\t');
                string[] parsedDT = couple[0].Split(' ');
                string[] parsedD = parsedDT[0].Split('.');
                string[] parsedT = parsedDT[1].Split(':');

               

                DateTime dt = new DateTime(Convert.ToInt32(parsedD[2]), Convert.ToInt32(parsedD[1]), Convert.ToInt32(parsedD[0]),
                    Convert.ToInt32(parsedT[0]), Convert.ToInt32(parsedT[1]), Convert.ToInt32(parsedT[2]));
                /*
                if (i == 0) minDate = dt;
                if (i == DataToDraw.Count - 1) maxDate = dt;
                */
                s.Points.AddXY(dt, float.Parse(couple[1]));
            }
            chart1.Series.Clear();
            chart1.Series.Add(s);

            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd.mm.yyyy hh:mm:ss";
            chart1.ChartAreas[0].AxisX.Interval = 15;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            //chart1.ChartAreas[0].AxisX.IntervalOffset = Auto;
            chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

        }

        
    }
}
