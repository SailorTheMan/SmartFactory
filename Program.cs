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
        public static double dangTemp = 45.00;
        public static double dangVibr = 0.75;
        public static double dangPow = 0.65;
        public static double dangLoad = 80.00;
        public static int dangTime = 70000;

        public static double critTemp = 50.00;
        public static double critVibr = 1.00;
        public static double critPow = 0.7;
        public static double critLoad = 95.00;
        public static int critTime = 85000;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainPage());
            Application.Run(new MainPage());

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
