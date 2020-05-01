using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using MySql.Data.MySqlClient;

namespace SmartFactory.Scripts
{
    class StoreToDB
    {
        private string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";
        public void Convert(string path)
        {

            MySqlConnection conn = new MySqlConnection(connStr);

            string query = "INSERT INTO `store` (`name`, `type`, `sizetype`, `count in box`, `mass`, `box number`, `count`, " +
                "`location`, `tier`, `price`, `sum`, `link`) VALUES ";
            Console.WriteLine(query);

            using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding("Windows-1251")))
            {
                sr.ReadLine();
                string s;
                while ((s = sr.ReadLine()) != null)
                //for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(s);
                    string[] stringList = s.Split('\t');

                    if (stringList[0] == "")
                    {
                        continue;
                    }

                    query += String.Format("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', ",
                            stringList[0], stringList[1], stringList[2], stringList[3], stringList[4], stringList[5],
                            stringList[6]);

                    string location = stringList[7];
                    if (stringList[stringList.Length - 1].EndsWith(".") || stringList[stringList.Length - 1].EndsWith(". "))
                    {
                        string loc;

                        while ((loc = sr.ReadLine()).EndsWith(".") || (loc.EndsWith(". ")))
                        {
                            location += loc;
                        }

                        string[] locList = loc.Split('\t');
                        location += locList[0];

                        query += String.Format("'{0}', '{1}', '{2}', '{3}', '{4}'), ",
                            location, locList[1], locList[2], locList[3], locList[4]);
                    }
                    else
                    {
                        query += String.Format("'{0}', '{1}', '{2}', '{3}', '{4}'), ",
                            location, stringList[8], stringList[9], stringList[10], stringList[11]);
                    }
                }

                query = query.Remove(query.Length - 2, 2) + ";";

                Console.WriteLine(query);

                conn.Open();
                try
                {
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось установить соединение с сервером. '\n' Проверьте подключение и попробуйте еще раз.");
                }
            }
        }

    }
}
