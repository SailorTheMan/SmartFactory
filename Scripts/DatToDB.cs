using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartFactory.Models;

namespace SmartFactory.Scripts
{
    class DatToDB
    {
        private string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";
        

        public bool Converter(String path)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            using (StreamReader sr = File.OpenText(path))
            {

                Machine[] machineList = new Machine[20];
                string s;
                sr.ReadLine();
                sr.ReadLine();
                int id = 0;
                //machineList[2].addTempLog()
                //while((s = sr.ReadLine()) != null)
                for (int i = 2; i < 100; i++)
                {
                    s = sr.ReadLine();
                    string[] stringArray = s.Split('\t');

                    //TODO 
                    // придумать где его хранить. Возможно в програм.кс Там неймспейс удобный
                    int intID = Convert.ToInt32(stringArray[0])-1;
                    machineList[intID] = new Machine(intID);
                    machineList[intID].addTempLog(stringArray[1] + '	' + stringArray[2]);
                    machineList[intID].addVibrLog(stringArray[1] + '	' + stringArray[3]);
                    machineList[intID].addPowerLog(stringArray[1] + '	' + stringArray[4]);
                    machineList[intID].addLoadLog(stringArray[1] + '	' + stringArray[5]);
                    machineList[intID].addWorkTimeLog(stringArray[1] + '	' + stringArray[6]);

                    //string query = "INSERT INTO `machine_stats` (`Machine ID`, `DateTime`, `Temp`, `Vibr`, `Power`, `Load`, `Wtime`) " +
                   //     "VALUES(" + stringArray[0] + ", '" + stringArray[1]
                    //    + "', '" + stringArray[2] + "', '" + stringArray[3] + "', '"
                     //   + stringArray[4] + "', '" + stringArray[5] + "', '" + stringArray[6] + "'); ";
                    string query = String.Format("INSERT INTO `machine_stats` (`Machine ID`, `DateTime`, `Temp`, `Vibr`, `Power`, `Load`, `Wtime`) " +
                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", stringArray[0], stringArray[1], stringArray[2], stringArray[3], stringArray[4], stringArray[5], stringArray[6]);
                        

                    MySqlCommand command = new MySqlCommand(query, conn);
                 
                    Console.WriteLine(query);
                    command.ExecuteNonQuery();
                    

                    Console.WriteLine(s);
                   
                    
                }
                conn.Close();
            }

            return true;
        }

    }
}
