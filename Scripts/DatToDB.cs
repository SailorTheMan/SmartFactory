using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartFactory.Models;
using SmartFactory;
using Telerik.Windows.Documents.Spreadsheet.Formatting.FormatStrings.Infos;
using Telerik.WinControls.UI;


namespace SmartFactory.Scripts
{
    class DatToDB
    {
        private string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";
        

        public bool Converter(String path)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlConnection conn1 = new MySqlConnection(connStr);
            

            using (StreamReader sr = File.OpenText(path))
            {

                string s;
                string query = "INSERT INTO `machine_stats` (`Machine ID`, `DateTime`, `Temp`, `Vibr`, `Power`, `Load`, `Wtime`) VALUES";
                int id = 0;

                string checkQuery = "SELECT `Machine ID` FROM `machine_stats` WHERE ";

                

                sr.ReadLine();
                sr.ReadLine();

                //machineList[2].addTempLog()
                while((s = sr.ReadLine()) != null)

                //for (int i = 0; i < 20; i++)
                {
                  //  s = sr.ReadLine();

                    string[] stringArray = s.Split('\t');

                    int intID = Convert.ToInt32(stringArray[0])-1;

                    string dateStr = reverseDate(stringArray[1]);

                    query += String.Format("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'),", 
                        stringArray[0], dateStr, stringArray[2], stringArray[3], stringArray[4], stringArray[5], stringArray[6]);

                    checkQuery += String.Format("`Machine ID`='{0}' AND `DateTime`='{1}' OR ", stringArray[0], dateStr);

                }
                checkQuery = checkQuery.Remove(checkQuery.Length - 3, 3) + ";";
                conn.Open();
                MySqlCommand command = new MySqlCommand(checkQuery, conn);

                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    query = query.Remove(query.Length - 1) + ";";

                    conn1.Open();
                    MySqlCommand command1 = new MySqlCommand(query, conn1);
                    command1.ExecuteNonQuery();
                    conn1.Close();
                    
                }
                else
                {
                    MessageBox.Show("Обнаружены поветорения. Уберите их вручную и попробуйте снова.");
                }
                conn.Close();
            }

            return true;
        }

        private string reverseDate(string date) //Превращает 01.02.2020 1:23:45 в 2020-02-01 1:23:45
        {
            string[] dateArr1 = date.Split('.');
            string[] dateArr2 = dateArr1[2].Split(' ');

            string result = dateArr2[0] + "-" + dateArr1[1] + "-" + dateArr1[0] + " " + dateArr2[1];

            return result;

        }

    }
}
