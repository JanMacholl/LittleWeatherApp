using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace LittleWeatherApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string apiKey = "a7b48c5add3d6670b065219fc2f4ed65";

            private string requestUrl = "https://api.openweathermap.org/data/2.5/weather";

                 public MainWindow()
        {
            InitializeComponent();

            HttpClient httpClient = new HttpClient();

            var city = "Wilhelmshaven";
            var finalUri = requestUrl + "?q=" + city + "&appid=" + apiKey + "&units=metric";
           
            HttpResponseMessage httpResponse = httpClient.GetAsync(finalUri).Result;

            string response = httpResponse.Content.ReadAsStringAsync().Result;

            Console.WriteLine(response);
        }
    }
}
