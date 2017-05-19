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
        private Timer timer2 = new Timer();
        public string weatherLocation = "Stockholm";
        public double temperature;
        public int rainLevel;
        public double windSpeed;
        public int weatherDescription;

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
            timer.Tick += new EventHandler(SetWeatherDescriptionImage);
            timer.Interval = 1000; //Ändra till 60000 sen
            timer.Start();

            timer2.Tick += new EventHandler(UpdateAudioLevel);
            timer2.Interval = 1;
            timer2.Start();

            //Utgår från där den exekverbara filen ligger, så sounds-mappen måste läggas där
            lightRain.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\lightRain.wav");
            lightRain.settings.setMode("loop", true);
            lightRain.settings.volume = 70;
            lightRain.controls.stop();

            heavyRain.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\heavyRain.wav");
            heavyRain.settings.setMode("loop", true);
            heavyRain.settings.volume = 70;
            heavyRain.controls.stop();

            wind.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\wind.mp3");
            wind.settings.setMode("loop", true);
            wind.settings.volume = 0;
            wind.controls.stop();

            winter.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\winter.wav");
            winter.settings.setMode("loop", true);
            winter.settings.volume = 70;
            winter.controls.stop();

            thunder.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\thunder.wav");
            thunder.settings.setMode("loop", true);
            thunder.settings.volume = 70;
            thunder.controls.stop();

            birds.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\birds.mp3");
            birds.settings.setMode("loop", true);
            birds.settings.volume = 50;
            birds.controls.stop();

            jungle.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\jungle.wav");
            jungle.settings.setMode("loop", true);
            jungle.settings.volume = 70;
            jungle.controls.stop();

            beachCola.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\beachCola.wav");
            beachCola.settings.setMode("loop", true);
            beachCola.settings.volume = 70;
            beachCola.controls.stop();

            summerBee.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\summerBee.wav");
            summerBee.settings.setMode("loop", true);
            summerBee.settings.volume = 70;
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

        //Hämtar väder och uppdaterar variabler, textfält, progressbars och bilder
        async public void GetWeather(Object obj, EventArgs args)
        {
            try
            {
                var client = new OpenWeatherMapClient("a6157170de4efa67c578f2e6024235c4");
                var currentWeather = await client.CurrentWeather.GetByName(weatherLocation);

                temperature = currentWeather.Temperature.Value;
                rainLevel = currentWeather.Clouds.Value;
                windSpeed = currentWeather.Wind.Speed.Value;
                weatherDescription = currentWeather.Weather.Number;

                label_location.Text = currentWeather.City.Name;
                progressBar_temp.Value = (int)temperature;
                progressBar_wind.Value = (int)windSpeed;
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
            sre.RecognizeAsyncStop();
            pictureBox_mic.Image = Properties.Resources.muted;
        }

        void UpdateAudioLevel(Object obj, EventArgs args)
        {
            progressBar_mic.Value = sre.AudioLevel;
        }

        //Ändrar ljudnivå på alla ljudklipp
        public void SetWeather(Object obj, EventArgs args)
        {
            //Temperature
            if(temperature <= -5 + 273.15)
            {
                birds.controls.stop();
                summerBee.controls.stop();
                beachCola.controls.stop();
                jungle.controls.stop();
            }
            else if(temperature > -5 + 273.15 && temperature <= 10 + 273.15)
            {
                birds.controls.play();
                summerBee.controls.stop();
                beachCola.controls.stop();
                jungle.controls.stop();
            }
            else if(temperature > 10 + 273.15 && temperature <= 20 + 273.15)
            {
                birds.controls.stop();
                summerBee.controls.play();
                beachCola.controls.stop();
                jungle.controls.stop();
            }
            else if(temperature > 20 + 273.15 && temperature <= 30 + 273.15)
            {
                birds.controls.stop();
                summerBee.controls.stop();
                beachCola.controls.play();
                jungle.controls.stop();
            }
            else //temp över 30
            {
                birds.controls.stop();
                summerBee.controls.stop();
                beachCola.controls.stop();
                jungle.controls.play();
            }

            //Rain
            if(rainLevel >= 50 && rainLevel <= 80 && weatherDescription >= 500 && weatherDescription < 600)
            {
                lightRain.controls.play();
                heavyRain.controls.stop();
            }
            else if(rainLevel > 80 && weatherDescription >= 500 && weatherDescription < 600)
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
                wind.settings.volume = Convert.ToInt32(windSpeed + 0.2);
            }
            else
            {
                wind.controls.stop();
            }
            
            //Thunder
            if(weatherDescription >= 200 && weatherDescription < 300)
            {
                thunder.controls.play();
            }
            else
            {
                thunder.controls.stop();
            }

            //Snow
            if (weatherDescription >= 600 && weatherDescription < 700 || temperature <= -10 + 273.15)
            {
                winter.controls.play();
            }
            else
            {
                winter.controls.stop();
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

        public void SetWeatherDescriptionImage(Object obj, EventArgs args)
        {
            if (weatherDescription >= 200 && weatherDescription <= 221)
                pictureBox_description.Image = Properties.Resources.bolt;

            else if (weatherDescription >= 230 && weatherDescription <= 232)
                pictureBox_description.Image = Properties.Resources.boltAndRain;

            else if (weatherDescription >= 300 && weatherDescription <= 531)
                pictureBox_description.Image = Properties.Resources.rain;

            else if (weatherDescription >= 600 && weatherDescription <= 622 || weatherDescription == 906)
                pictureBox_description.Image = Properties.Resources.snow;
            
            else if (weatherDescription >= 701 && weatherDescription <= 771)
                pictureBox_description.Image = Properties.Resources.atmosphere;

            else if (weatherDescription >= 801 && weatherDescription <= 804)
                pictureBox_description.Image = Properties.Resources.clouds;

            else if (weatherDescription == 800 || weatherDescription == 951 || weatherDescription == 904)
                pictureBox_description.Image = Properties.Resources.sun;

            else if (weatherDescription >= 900 && weatherDescription <= 902 || weatherDescription == 781 || weatherDescription == 961 || weatherDescription == 962)
                pictureBox_description.Image = Properties.Resources.tornado;

            else if (weatherDescription == 903)
                pictureBox_description.Image = Properties.Resources.cold;
                
            else if (weatherDescription == 951 || weatherDescription == 953 || weatherDescription == 955)
                pictureBox_description.Image = Properties.Resources.pine;

            else if (weatherDescription == 905 || weatherDescription == 954 || weatherDescription >= 956 && weatherDescription <= 958)
                pictureBox_description.Image = Properties.Resources.windCloud;

            else if (weatherDescription == 959 || weatherDescription == 960)
                pictureBox_description.Image = Properties.Resources.storm;

        }

    }
}
