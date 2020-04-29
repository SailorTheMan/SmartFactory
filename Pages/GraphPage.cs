using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartFactory.Pages
{
    public partial class GraphPage : Telerik.WinControls.UI.RadForm
    {
        public GraphPage()
        {
            InitializeComponent();
            OverallStats main = this.Owner as OverallStats;
            if (main != null)
            {
                string s = main.radDropDownList1.SelectedItem.Text;
                string d = main.radDropDownList2.SelectedItem.Text;
                MessageBox.Show(s+'\t'+d);
            }
            //Данные можно в графики подгружать из подключенной через его же интерфейс ДБ
        }

        private void GraphPage_Shown(object sender, EventArgs e)
        {
            OverallStats main = this.Owner as OverallStats;         //Шняга для передачи данных между формами. Но нужно соответсвующуе элементы пабликами делать
            if (main != null)
            {
                string s = main.radDropDownList1.SelectedItem.Text;
                string d = main.radDropDownList2.SelectedItem.Text;
                MessageBox.Show(s + '\t' + d);
            }
        }

        private void radChartView1_Click(object sender, EventArgs e)
        {

        }
    }
}
