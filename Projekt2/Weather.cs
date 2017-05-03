using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Media;
using System.Diagnostics;
using System.Net;
using OpenWeatherMap;
using WMPLib;
using System.Reflection;

namespace Projekt2
{
    public partial class Form1 : Form
    {
        
        private Timer timer = new Timer();
        public string weatherLocation = "Stockholm";
        public double temperature; // I celsius
        public int rainLevel;
        public double windSpeed;

        WindowsMediaPlayer rainPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer windPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer roosterPlayer = new WindowsMediaPlayer();

        public void Run()
        {
            timer.Tick += new EventHandler(GetWeather);
            timer.Tick += new EventHandler(SetWeather);
            timer.Interval = 1000; //Ändra till 60000 sen
            timer.Start();

            rainPlayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\rain-03.wav");
            rainPlayer.settings.setMode("loop", true);
            rainPlayer.settings.volume = 0;
            rainPlayer.controls.play();

            windPlayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\wind-1.wav");
            windPlayer.settings.setMode("loop", true);
            windPlayer.settings.volume = 0;
            windPlayer.controls.play();
        }

        //Hämtar väder och uppdaterar variabler och textfält
        async public void GetWeather(Object obj, EventArgs args)
        {
            var client = new OpenWeatherMapClient("a6157170de4efa67c578f2e6024235c4");
            var currentWeather = await client.CurrentWeather.GetByName(weatherLocation);

            temperature = currentWeather.Temperature.Value - 273.15;
            rainLevel = currentWeather.Clouds.Value;
            windSpeed = currentWeather.Wind.Speed.Value;

            label_location.Text = currentWeather.City.Name;
            label_temperature.Text = temperature.ToString();
            label_rain.Text = rainLevel.ToString();
            label_wind.Text = windSpeed.ToString();
        }

        //Ändrar ljudnivå på alla ljudklipp
        public void SetWeather(Object obj, EventArgs args)
        {
            rainPlayer.settings.volume = rainLevel;
            windPlayer.settings.volume = Convert.ToInt32(windSpeed * 8);

            var time = DateTime.Now;
            if (time.Hour == 12 && time.Minute == 0 && time.Second == 0)
            {
                roosterPlayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\Rooster.wav");
                roosterPlayer.settings.setMode("loop", false);
                windPlayer.controls.play();
            }
        }

    }
}
