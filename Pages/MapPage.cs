using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using SmartFactory.Models;
using SmartFactory.Scripts;
using System.Threading;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;

namespace SmartFactory.Pages
{
    public partial class MapPage : MetroFramework.Forms.MetroForm
    {

        private List<Filial> filialList = new List<Filial>();
        private GMapOverlay markersOverlay = new GMapOverlay("markers");
        private GMapOverlay routesOverlay = new GMapOverlay("routes");
        private GMapOverlay peopleMarkersOverlay = new GMapOverlay("peopleMarkers");

        public string routeName { get; set; }

        public MapPage()
        {
            InitializeComponent();
        }

        private void MapPage_Load(object sender, EventArgs e)
        {
            
            InitializeGmap();
            InitializeFilialsArray();

            gMapControl1.Position = new PointLatLng(filialList[0].latitude, filialList[0].longitude);

            InitializeMarkers();

            InitializeRoutes();

            InitializePeopleLocation();

            CheckRoot();
            
        }
        public void CheckRoot()
        {
            if (User.Level == 0)
            {
                button1.Enabled = true;
            }
        }

        private void InitializeGmap()
        {
            //Настройки для компонента GMap.
            gMapControl1.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            ///с помощью правой кнопки мыши.
            gMapControl1.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.GrayScaleMode = true;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControl1.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            gMapControl1.MaxZoom = 18;

            //Указываем значение минимального приближения.
            gMapControl1.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            gMapControl1.NegativeMode = false;

            //Разрешаем полигоны.
            gMapControl1.PolygonsEnabled = true;

            //Разрешаем маршруты
            gMapControl1.RoutesEnabled = true;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControl1.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            gMapControl1.Zoom = 5;

            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются
            //соответствующим образом.
            gMapControl1.Dock = DockStyle.Fill;

            //Указываем что будем использовать карты Google.
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            //Если вы используете интернет через прокси сервер,
            //указываем свои учетные данные.
            GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
        }

        private void InitializeFilialsArray()
        {
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string query = "SELECT * FROM filials";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                filialList.Add(new Filial(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                    int.Parse(reader[5].ToString()), bool.Parse(reader[6].ToString()), float.Parse(reader[7].ToString()),
                    float.Parse(reader[8].ToString())));

            }

        }

        private void InitializeMarkers()
        {
            
            for (int i = 0; i < filialList.Count; i++) {

                GMarkerGoogle marker = new GMarkerGoogle(
                    new PointLatLng(filialList[i].latitude, filialList[i].longitude),
                    GMarkerGoogleType.red);

                marker.ToolTip = new GMapRoundedToolTip(marker);

                marker.ToolTipText = InitializeToolTextForFilial(filialList[i]);

                markersOverlay.Markers.Add(marker);
            }
        }

        private string InitializeToolTextForFilial(Filial filial)
        {
            string text = filial.name + '\n' + filial.country + '\n' + filial.address + '\n' + filial.director + '\n' 
                + filial.numberOfEmployees  + '\n';
            if (filial.function)
            {
                text += "Функционирует";
            }
            else
            {
                text += "Не функционирует";
            }

            return text;
        }

        private void InitializeRoutes()
        {
            
            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string query = "SELECT name FROM routelist";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {

                MySqlConnection conn1 = new MySqlConnection(connStr);

                conn1.Open();

                query = String.Format("SELECT latitude, longitude FROM {0}", reader1[0].ToString().ToLower() + "route");

                MySqlCommand cmd1 = new MySqlCommand(query, conn1);

                Console.WriteLine(query);

                MySqlDataReader reader2 = cmd1.ExecuteReader();
                
                List<PointLatLng> points = new List<PointLatLng>();

                while (reader2.Read())
                {

                    points.Add(new PointLatLng(float.Parse(reader2[0].ToString()), float.Parse(reader2[1].ToString())));

                }

                GMapRoute route = new GMapRoute(points, reader1[0].ToString() + "route");

                route.Stroke = new Pen(Color.Blue, 3);

                routesOverlay.Routes.Add(route);

                conn1.Close();

            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RouteNameInput rni = new RouteNameInput();
                rni.Owner = this;

                rni.ShowDialog();

                MessageBox.Show("Вы получите сообщение об окончании загрузки маршрута. " +
                    "Закройте это сооющение, чтобы начать загрузку маршрута");

                RoutesToDB rtdb = new RoutesToDB();
                rtdb.Convert(openFileDialog1.FileName, routeName);

                MessageBox.Show("Маршрут успешно загружен");
                
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            int index = gMapControl1.Overlays.IndexOf(routesOverlay);

            if (index == -1)
            {
                gMapControl1.Overlays.Add(routesOverlay);
            }
            else
            {
                gMapControl1.Overlays.Remove(routesOverlay);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            int index = gMapControl1.Overlays.IndexOf(markersOverlay);

            if (index == -1)
            {
                gMapControl1.Overlays.Add(markersOverlay);
            }
            else
            {
                gMapControl1.Overlays.Remove(markersOverlay);
            }

        }

        private void InitializePeopleLocation()
        {

            List<Employee> peopleList = InitializePeopleList();

            for (int i = 0; i < peopleList.Count; i++)
            {

                GMarkerGoogle marker = new GMarkerGoogle(
                    new PointLatLng(peopleList[i].latitude, peopleList[i].longitude),
                    GMarkerGoogleType.black_small);

                marker.ToolTip = new GMapRoundedToolTip(marker);

                marker.ToolTipText = InitializeToolTextForPeople(peopleList[i]);

                peopleMarkersOverlay.Markers.Add(marker);
            }

        }

        private List<Employee> InitializePeopleList()
        {
            List<Employee> peopleList = new List<Employee>();

            string connStr = "server=baltika.mysql.database.azure.com;user=sailor@baltika;database=smartfactory;password=Baltika123;charset=utf8;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string query = "SELECT * FROM employees";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                peopleList.Add(new Employee(reader[1].ToString(), reader[2].ToString(), int.Parse(reader[3].ToString()), reader[4].ToString(),
                    reader[5].ToString(), int.Parse(reader[6].ToString()), reader[7].ToString(), 
                    float.Parse(reader[8].ToString()), float.Parse(reader[9].ToString())));

            }

            return peopleList;
        }

        private string InitializeToolTextForPeople(Employee employee)
        {

                string text = employee.name + '\n' + employee.country + '\n' + employee.age + '\n' + employee.sex + '\n' + employee.position + '\n'
                    + employee.exp + '\n' + employee.address + '\n';

                return text;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int index = gMapControl1.Overlays.IndexOf(peopleMarkersOverlay);

            if (index == -1)
            {
                gMapControl1.Overlays.Add(peopleMarkersOverlay);
            }
            else
            {
                gMapControl1.Overlays.Remove(peopleMarkersOverlay);
            }
        }

        }
    }
