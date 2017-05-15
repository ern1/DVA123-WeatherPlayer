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
using System.Speech.Synthesis;
using Microsoft.Speech.Recognition;

namespace Projekt2
{
    public partial class Form1 : Form
    {
        
        private Timer timer = new Timer();
        public string weatherLocation = "Stockholm";
        public double temperature; // I celsius
        public int rainLevel;
        public double windSpeed;
        public string weatherDescription;

        WindowsMediaPlayer lightRain = new WindowsMediaPlayer();
        WindowsMediaPlayer heavyRain = new WindowsMediaPlayer();
        WindowsMediaPlayer wind = new WindowsMediaPlayer();
        WindowsMediaPlayer winter = new WindowsMediaPlayer();
        WindowsMediaPlayer thunder = new WindowsMediaPlayer();
        WindowsMediaPlayer birds = new WindowsMediaPlayer();
        WindowsMediaPlayer jungle = new WindowsMediaPlayer();
        WindowsMediaPlayer beachCola = new WindowsMediaPlayer();
        WindowsMediaPlayer summerBee = new WindowsMediaPlayer();


        SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SoundPlayer locationChanged = new SoundPlayer(Properties.Resources.pling);
        SoundPlayer SpeechRecognitionStarted = new SoundPlayer(Properties.Resources.mechsound);
        
        public void Run()
        {
            timer.Tick += new EventHandler(GetWeather);
            timer.Tick += new EventHandler(SetWeather);
            timer.Interval = 1000; //Ändra till 60000 sen
            timer.Start();

            //Utgår från där den exekverbara filen ligger, så sounds-mappen måste läggas där
            lightRain.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\lightRain.wav");
            lightRain.settings.setMode("loop", false);
            lightRain.settings.volume = 50;
            lightRain.controls.stop();

            heavyRain.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\heavyRain.wav");
            heavyRain.settings.setMode("loop", false);
            heavyRain.settings.volume = 50;
            heavyRain.controls.stop();

            wind.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\wind.mp3");
            wind.settings.setMode("loop", true);
            wind.settings.volume = 0;
            wind.controls.stop();

            winter.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\winter.wav");
            winter.settings.setMode("loop", true);
            winter.settings.volume = 50;
            winter.controls.stop();

            thunder.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\thunder.wav");
            thunder.settings.setMode("loop", true);
            thunder.settings.volume = 50;
            thunder.controls.stop();

            birds.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\birds.mp3");
            birds.settings.setMode("loop", true);
            birds.settings.volume = 50;
            birds.controls.stop();

            jungle.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\jungle.wav");
            jungle.settings.setMode("loop", true);
            jungle.settings.volume = 50;
            jungle.controls.play();

            beachCola.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\beachCola.wav");
            beachCola.settings.setMode("loop", true);
            beachCola.settings.volume = 50;
            beachCola.controls.stop();

            summerBee.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\summerBee.wav");
            summerBee.settings.setMode("loop", true);
            summerBee.settings.volume = 50;
            summerBee.controls.stop();



            //   Speechrecognition    //
            // Create a simple grammar
            Choices colors = new Choices();
            colors.Add(new string[] { "stockholm", "copenhagen", "warsaw", "kiev", "london", "madrid", "moscow", "washington", "oslo", "reykjavik", "santiago", "Seoul", "bern", "damascus", "budapest", "tokyo", "rome", "dublin", "taipei", "helsinki", "athens", "paris", "beijing", "lima", "lisbon", "ottawa", "sofia", "minsk", "brussels", "vienna", "pyongyang", "belgrade", "cairo", "berlin", "jakarta", "tehran", "jerusalem" });

            // Create a GrammarBuilder object and append the Choices object.
            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = new System.Globalization.CultureInfo("en-US");
            gb.Append(colors);

            // Create the Grammar instance and load it into the speech recognition engine.
            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);

            // Register a handler for the SpeechRecognized event.
            sre.SpeechRecognized +=
                new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
            sre.SetInputToDefaultAudioDevice();
            sre.RecognizeAsyncStop();
        }

        //Hämtar väder och uppdaterar variabler och textfält
        async public void GetWeather(Object obj, EventArgs args)
        {
            try
            {
                var client = new OpenWeatherMapClient("a6157170de4efa67c578f2e6024235c4");
                var currentWeather = await client.CurrentWeather.GetByName(weatherLocation);

                temperature = currentWeather.Temperature.Value - 273.15;
                rainLevel = currentWeather.Clouds.Value;
                windSpeed = currentWeather.Wind.Speed.Value;
                weatherDescription = currentWeather.Weather.Value;

                label_location.Text = currentWeather.City.Name;
                label_temperature.Text = temperature.ToString();
                label_rain.Text = rainLevel.ToString();
                label_wind.Text = windSpeed.ToString();
                label_description.Text = weatherDescription;
            }
            catch (OpenWeatherMapException e)
            {
            }
        }

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            weatherLocation = e.Result.Text;
            locationChanged.Play();
            Debug.WriteLine("weatherLocation: " + weatherLocation);
            Debug.WriteLine("SpeechRecognition: " + e.Result.Text);
            
        }

        //Ändrar ljudnivå på alla ljudklipp
        public void SetWeather(Object obj, EventArgs args)
        {
            //Temperature
            if(temperature < -5)
            {
                winter.controls.play();
                birds.controls.play();
                summerBee.controls.stop();
                beachCola.controls.stop();
                jungle.controls.stop();
            }
            else if(temperature > -5 && temperature <= 10)
            {
                winter.controls.stop();
                birds.controls.play();
                summerBee.controls.stop();
                beachCola.controls.stop();
                jungle.controls.stop();
            }
            else if(temperature > 10 && temperature <= 20)
            {
                winter.controls.stop();
                birds.controls.stop();
                summerBee.controls.play();
                beachCola.controls.stop();
                jungle.controls.stop();
            }
            else if(temperature > 20 && temperature <= 30)
            {
                winter.controls.stop();
                birds.controls.stop();
                summerBee.controls.stop();
                beachCola.controls.play();
                jungle.controls.stop();
            }
            else if(temperature > 30)
            {
                winter.controls.stop();
                birds.controls.stop();
                summerBee.controls.stop();
                beachCola.controls.stop();
                jungle.controls.play();
            }
            else
            {
                winter.controls.stop();
                birds.controls.play();
                summerBee.controls.stop();
                beachCola.controls.stop();
                jungle.controls.stop();
            }

            //Rain
            if(rainLevel >= 50 && rainLevel <= 80)
            {
                lightRain.controls.play();
                heavyRain.controls.stop();
            }
            else if(rainlevel > 80)
            {
                lightRain.controls.stop();
                heavyRain.controls.play();
            }
            else
            {
                lightRain.controls.stop();
                heavyRain.controls.stop();
            }
               
            //Wind
            if(windSpeed >= 3)
            {
                wind.controls.play();
                wind.settings.volume = Convert.ToInt32(windSpeed) + 0.2;
            }
            else
            {
                wind.controls.stop();
            }
            
            //Thunder
            if(weatherDescription == "thunderstorm")
            {
                thunder.controls.play();
            }
            else
            {
                thunder.controls.stop();
            }
            
            var time = DateTime.Now;
            if (time.Hour == 12 && time.Minute == 0 && time.Second == 0)
            {
                using (var roosterPlayer = new SoundPlayer(Properties.Resources.Rooster))
                {
                    roosterPlayer.Play();
                }
            }
        }

    }
}
