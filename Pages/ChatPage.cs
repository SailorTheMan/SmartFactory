using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFactory.Models;
using SmartFactory.Scripts;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Barcode.Symbology;

namespace SmartFactory.Pages
{
    public partial class ChatPage : MetroFramework.Forms.MetroForm
    {
        private int lastMessageID = 1;
        private bool messageSaved = false;
        private Author author = new Author(Properties.Resources.avatar, User.Name);
        public ChatPage()
        {
            InitializeComponent();
        }

        private void ChatPage_Load(object sender, EventArgs e)
        {
            this.radChat1.Author = author;
            this.radChat1.SendMessage += SaveMessage;
            //UpdateMessages();
        }

        private void SaveMessage(object sender, SendMessageEventArgs e)
        {
            ChatTextMessage textMessage = e.Message as ChatTextMessage;

            new MessageToDB().Save(textMessage);

            lastMessageID ++;

        }


        private void UpdateMessages()
        {
            List<ChatTextMessage> messageList = new MessageToDB().GetMessages(lastMessageID, author);
            messageSaved = true;
            for (int i = 0; i < messageList.Count; i++)
            {
                this.radChat1.AddMessage(messageList[i]);
                lastMessageID++;
            }
            
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            UpdateMessages();

        }
    }
}
