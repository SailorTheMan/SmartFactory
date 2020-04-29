using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using SmartFactory.Models;
using SmartFactory.Pages;

namespace SmartFactory
{
    static class Program
    {

        public static Machine[] machineList = new Machine[20];

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /* не нужно
            ///TODO
            ///Проверить, работает ли вообще
            ///Для этого нужно засунуть путь до бд в JSON и реализовать хоть какое-то взаимодействие в контроллерах
            ///Добавить в уголок иконку о подключении к удалённой дб
            
            
            /// ПОЛУЧЕНИЕ НАСТРОЕК БД ИЗ JSON ///
            var builder = new ConfigurationBuilder();   // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory()); // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsetting.json");   // создаем конфигурацию
            var config = builder.Build();  // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");
            */
        }

    }
}
