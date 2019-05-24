using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace EarthQuakesExamWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _url = "https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson";
        //private List<Earthquake> _earthquakeList = new List<Earthquake>();
        private Rootobject earthquake = new Rootobject();
        public MainWindow()
        {
            InitializeComponent();

            string json = "";

            WebClient client = new WebClient();
            using (Stream stream = client.OpenRead(_url))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    json += reader.ReadToEnd();
                }
            }

            earthquake = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(json);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //{
            //    new EarthQuake { Magnitude = "M", EpicenterDepth = "ED", Place = "P", Date = DateTime.Now }
            //};
            //dataGrid.Items.Add(earthQuakesList);

            



            //_RootobjectList = JsonConvert.DeserializeObject<List<Rootobject>>(json);
            
        }
    }
}
