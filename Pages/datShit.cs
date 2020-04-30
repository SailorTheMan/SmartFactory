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
using System.Data.SqlClient;
using Telerik.WinControls.UI.Diagrams;

namespace SmartFactory.Pages
{
    public partial class datShit : Form
    {
        public datShit()
        {
            InitializeComponent();
        }

        private void datShit_Load(object sender, EventArgs e)
        {/*
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();

            adapter.Fill(dt);
            ds = dt.Tables[0].DefaultView
            bs.DataSource = ds;
            aGridView.DataSource = bs.DataSource;


        */
            AAAA();
            //PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            string filePath = "February.dat";
            System.IO.TextReader reader = new System.IO.StreamReader(filePath);
            bool colAdded = false;
            DataTable table = new DataTable("data");
            try
            {
                while (reader.Peek() != -1)
                {
                    string[] tokens = System.Text.RegularExpressions.Regex.Split(reader.ReadLine(), "\t");
                    if (!colAdded)
                    {
                        foreach (string token in tokens)
                        {
                            table.Columns.Add(token);
                        }
                        colAdded = true;
                    }
                    else
                    {
                        DataRow row = table.NewRow();
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            row[i] = tokens[i];
                        }
                        table.Rows.Add(row);
                    }
                }
                dataGridView1.DataMember = "data";
                dataGridView1.DataSource = table;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void AAAA()
        {
            var select = "SELECT * FROM `machine_stats` WHERE `DateTime` > '2020-03-01'";
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
