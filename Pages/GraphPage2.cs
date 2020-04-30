using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using SmartFactory.Models;
using ZedGraph;


namespace SmartFactory.Pages
{
    public partial class GraphPage2 : Telerik.WinControls.UI.RadForm
    {
        public GraphPage2()
        {
            InitializeComponent();
        }

        private void GraphPage2_Load(object sender, EventArgs e)
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

            GraphPane pane = zedGraphControl1.GraphPane;

            pane.CurveList.Clear();

            //DateTime minDate = main.radDateTimePicker1.Value;
            //DateTime maxDate = main.radDateTimePicker2.Value;
            PointPairList list = new PointPairList();

            //double[] xvalues = new double[DataToDraw.Count];
            //double[] yvalues = new double[DataToDraw.Count];

            for (int i = 0; i < DataToDraw.Count; i++)
            {
                string[] couple = DataToDraw[i].Split('\t');
                string[] parsedDT = couple[0].Split(' ');
                string[] parsedD = parsedDT[0].Split('.');
                string[] parsedT = parsedDT[1].Split(':');

                XDate dt = new XDate(Convert.ToInt32(parsedD[2]), Convert.ToInt32(parsedD[1]), Convert.ToInt32(parsedD[0]),
                    Convert.ToInt32(parsedT[0]), Convert.ToInt32(parsedT[1]), Convert.ToInt32(parsedT[2]));

                list.Add(dt, float.Parse(couple[1]));

                /*
                if (i == 0) minDate = dt;
                if (i == DataToDraw.Count - 1) maxDate = dt;
                */

                //s.Points.AddXY(dt, float.Parse(couple[1]));
            }

            

            LineItem myCurve = pane.AddCurve(main.radDropDownList2.SelectedItem.Text + " машины " + (machid+1).ToString(), list, Color.Blue, SymbolType.None);

            pane.Title.IsVisible = false;

            pane.XAxis.Type = AxisType.Date;
            pane.XAxis.Scale.Format = "dd.MM.yyyy HH:mm";

            pane.XAxis.Scale.Min = main.radDateTimePicker1.Value.ToOADate();
            pane.XAxis.Scale.Max = main.radDateTimePicker2.Value.ToOADate();

            pane.XAxis.Title.Text = "Время";
            pane.YAxis.Title.Text = main.radDropDownList2.SelectedItem.Text;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            /*
            chart1.Series.Clear();
            chart1.Series.Add(s);

            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd.mm.yyyy hh:mm:ss";
            chart1.ChartAreas[0].AxisX.Interval = 15;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            //chart1.ChartAreas[0].AxisX.IntervalOffset = Auto;
            chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            */

        }
    }
}
