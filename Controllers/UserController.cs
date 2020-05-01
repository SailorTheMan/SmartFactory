using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SmartFactory.Models.Repository;
using System.Security.Cryptography;
using SmartFactory.Models;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Data;

using MySql.Data.MySqlClient;
using SmartFactory.Models;
using System.Linq.Expressions;
using System.Windows;

namespace SmartFactory.Controllers
{

    public class UserController //: Controller
    {
        ///TODO: Превратить Viewbag в пуши (уведомления окошками). 
        ///Придумать как обойти request (или просто переписать всю функцию нормально без хттп-хлама)


        public bool Login(string login, string password)
        {
            try
            {

            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string sql = "SELECT password FROM users WHERE email = '" + login + "'";

            MySqlCommand command = new MySqlCommand(sql, conn);
            string pwd;
                if (command.ExecuteScalar() == null)
                {
                    return false;
                }
                pwd = command.ExecuteScalar().ToString();

                if (pwd == password)
                {
                    string query = "SELECT * FROM users WHERE email = '" + login + "'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User.ID = int.Parse(reader[0].ToString());
                        User.Name = reader[1].ToString();
                        User.Age = int.Parse(reader[2].ToString());
                        User.Sex = reader[3].ToString();
                        User.Position = reader[4].ToString();
                        User.Email = reader[6].ToString();
                        User.Experience = reader[5].ToString();
                        User.Level = int.Parse(reader[8].ToString());
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Проверьте подключение к интернету");
                return false;
            }
            catch
            {
                return false;
            }
        }
    
        public string Encrypt(string p)
        {
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(p);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string finaliized = Convert.ToBase64String(tmpHash);
            return finaliized;
        }

        public bool Register(string email, string password, string name, string position, int age,
                int exp, string sex, string level)
        {
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();
            int numLevel = 0;
            switch (level)
            {
                case "сотрудник":
                    numLevel = 3;
                    break;

                case "руководитель отдела":
                    numLevel = 2;
                    break;

                case "руководитель предприятия":
                    numLevel = 1;
                    break;
                case "админ":
                    numLevel = 0;
                    break;
            }

            try
            {

                string query = String.Format("INSERT INTO users (name, age, sex, position, email, exp, password, level) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", name, age.ToString(), sex, position, email, exp.ToString(),
                    password, numLevel);

                MySqlCommand command = new MySqlCommand(query, conn);

                command.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером. '\n'Проверьте подключение и попробуйте еще раз.");
            }
            return true;
        }
    }
}
