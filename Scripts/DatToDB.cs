using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartFactory.Scripts
{
    class DatToDB
    {
        //private string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

        public bool Convert(String path)
        {
            //MySqlConnection conn = new MySqlConnection(connStr);

            //conn.Open();

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                sr.ReadLine();
                sr.ReadLine();
                int id = 0;

                //while((s = sr.ReadLine()) != null)
                for (int i = 0; i < 5; i++)
                {
                    s = sr.ReadLine();
                    string[] stringArray = s.Split(new char[] { '	' });

                    //TODO Надо сделать массив machinList, заполненный объектами класса Machine, возможно статический, 
                    //и придумать где его хранить

                    machineList[stringArray[0]].addTempLog(stringArray[1] + '	' + stringArray[2]);
                    machineList[stringArray[0]].addVibrLog(stringArray[1] + '	' + stringArray[3]);
                    machineList[stringArray[0]].addPowerLog(stringArray[1] + '	' + stringArray[4]);
                    machineList[stringArray[0]].addLoadLog(stringArray[1] + '	' + stringArray[5]);
                    machineList[stringArray[0]].addWorkTimeLog(stringArray[1] + '	' + stringArray[6]);

                    /*string query = "INSERT INTO `machine_stats` (`Machine ID`, `DateTime`, `Temp`, `Vibr`, `Power`, `Load`, `Wtime`) " +
                        "VALUES("
                        + stringArray[0] + ", '" + stringArray[1]
                        + "', '" + stringArray[2] + "', '" + stringArray[3] + "', '"
                        + stringArray[4] + "', '" + stringArray[5] + "', '" + stringArray[6] + "'); ";
                    
                    MySqlCommand command = new MySqlCommand(query, conn);
                 
                    Console.WriteLine(query);
                    command.ExecuteNonQuery();
                    */

                    Console.WriteLine(s);
                   
                    
                }
                //conn.Close();
            }

            return true;
        }

    }
}
