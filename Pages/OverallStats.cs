using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            /*
            GraphPage gp = new GraphPage();
            gp.Owner = this;
            gp.ShowDialog();
            //new GraphPage().Show();
            */

            GraphPage2 gp = new GraphPage2();
            gp.Owner = this;
            gp.ShowDialog();
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
            //radGridView1
        }

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
