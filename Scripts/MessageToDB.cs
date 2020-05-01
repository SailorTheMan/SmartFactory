using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartFactory.Models;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Design;
using Telerik.Windows.Documents.Spreadsheet.Formatting.FormatStrings.Infos;

namespace SmartFactory.Scripts
{
    class MessageToDB
    {
        public void Save(ChatTextMessage message)
        {
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";
            
            MySqlConnection conn = new MySqlConnection(connStr);

            DateTime dateNow = DateTime.Now;
            DateTime date = dateNow.ToUniversalTime();

            string query = String.Format("INSERT INTO `chat` (`userID`,`name`, `text`, `date`) VALUES ('{0}', '{1}', '{2}', '{3}');", 
                User.ID, User.Name, message.Message, date.ToString());
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с сервером. '\n' Проверьте подключение и попробуйте еще раз.");
            }
            conn.Close();

        }

        public List<ChatTextMessage> GetMessages(int lastMessageID, Author selfAuthor)
        {
            List<ChatTextMessage> messageList = new List<ChatTextMessage>();
            
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connStr);

            string query = String.Format("SELECT `userID`, `name`, `text`, `date` FROM `chat` WHERE id >= {0}",
                lastMessageID.ToString());
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int UserId = int.Parse(reader[0].ToString());
                    string name = reader[1].ToString();
                    string text = reader[2].ToString();
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());

                    DateTime date = DateTime.Parse(reader[3].ToString());
                    DateTime dateNow = System.TimeZoneInfo.ConvertTimeFromUtc(date, System.TimeZoneInfo.Local);

                    Author author = author = new Author(Properties.Resources.avatar, name);

                    if (UserId == User.ID)
                    {
                        author = selfAuthor;
                    }

                    ChatTextMessage message = new ChatTextMessage(text, author, dateNow);

                    messageList.Add(message);
                }

                conn.Close();
                return messageList;
            }
            catch
            {
                MessageBox.Show("Проверьте подключение к интернету.");
                return messageList;
            }
        }
    }
}
