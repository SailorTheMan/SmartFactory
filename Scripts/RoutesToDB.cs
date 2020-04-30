using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SmartFactory.Scripts
{
    class RoutesToDB
    {
        private string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

        public void Convert(string path, string routeName)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            string query = String.Format("INSERT INTO `routelist` (`name`) VALUES ('{0}');", routeName);
            Console.WriteLine(query);

            MySqlCommand command = new MySqlCommand(query, conn);

            conn.Open();

            command.ExecuteNonQuery();

            query = String.Format("CREATE TABLE `{0}` ("+
                    "`id` INT NOT NULL AUTO_INCREMENT," +
                    "`latitude` FLOAT NOT NULL," +
                    "`longitude` FLOAT NULL," +
                    "`elevation` FLOAT NULL," +
                    "PRIMARY KEY(`id`)," +
                    "UNIQUE INDEX `id_UNIQUE` (`id` ASC));", routeName + "route");

            command = new MySqlCommand(query, conn);

            command.ExecuteNonQuery();

            using (StreamReader sr = File.OpenText(path))
            {

                sr.ReadLine();
                string s;

                

                query = String.Format("INSERT INTO {0} (`latitude`, `longitude`, `elevation`) VALUES", routeName + "route");
                while ((s = sr.ReadLine()) != null)
                //for (int i = 0; i < 45; i++)
                {
                    string[] stringList = s.Split(',');
                    
                    query +=  String.Format("({0}, {1}, {2}),",stringList[0], stringList[1], stringList[2]);

                }

                query = query.Remove(query.Length - 1) + ";";

                command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
