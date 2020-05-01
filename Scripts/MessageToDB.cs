using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SmartFactory.Models;
using Telerik.WinControls.UI;

namespace SmartFactory.Scripts
{
    class MessageToDB
    {
        public void Save(ChatTextMessage message)
        {
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";
            
            MySqlConnection conn = new MySqlConnection(connStr);

            string query = String.Format("INSERT INTO `chat` (`userID`,`name`, `text`, `date`) VALUES ('{0}', '{1}', '{2}', '{3}');", 
                User.ID, User.Name, message.Message, DateTime.Now.ToString());

            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();

            conn.Close();

        }

        public List<ChatTextMessage> GetMessages(int lastMessageID, Author selfAuthor)
        {
            List<ChatTextMessage> messageList = new List<ChatTextMessage>();
            
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connStr);

            string query = String.Format("SELECT `userID`, `name`, `text`, `date` FROM `chat` WHERE id >= {0}",
                lastMessageID.ToString());

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

                Author author = author = new Author(Properties.Resources.avatar, name);

                if (UserId == User.ID)
                {
                    author = selfAuthor;
                }

                ChatTextMessage message = new ChatTextMessage(text, author, date);

                messageList.Add(message);
            }

            conn.Close();
            return messageList;
        }
    }
}
