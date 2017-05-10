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

        WindowsMediaPlayer rainPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer windPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer roosterPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer lightningPlayer = new WindowsMediaPlayer();

        SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public void Run()
        {
            timer.Tick += new EventHandler(GetWeather);
            timer.Tick += new EventHandler(SetWeather);
            timer.Interval = 1000; //Ändra till 60000 sen
            timer.Start();

            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 100;
            
            //Utgår från där den exekverbara filen ligger, så sounds-mappen måste läggas där
            rainPlayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\rain-03.wav");
            rainPlayer.settings.setMode("loop", true);
            rainPlayer.settings.volume = 0;
            rainPlayer.controls.play();

            windPlayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\wind-1.wav");
            windPlayer.settings.setMode("loop", true);
            windPlayer.settings.volume = 0;
            windPlayer.controls.play();

            /* //Har ingen ljudfil till detta
            lightningPlayer.URL = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Sounds\\????????????");
            lightningPlayer.settings.setMode("loop", true);
            lightningPlayer.settings.volume = 0;
            lightningPlayer.controls.play();
            */


            //   Speechrecognition    //
            // Create a simple grammar
            Choices colors = new Choices();
            colors.Add(new string[] { "stockholm", "copenhagen", "warsaw", "kiev", "london", "stockholm", "madrid", "moscow", "washington", "oslo", "reykjavik", "santiago", "Seoul", "bern", "damascus", "budapest", "tokyo", "rome", "dublin", "taipei", "helsinki", "athens", "paris", "beijing", "lima", "lisbon", "ottawa", "sofia", "minsk", "brussels", "vienna", "pyongyang", "belgrade", "cairo", "berlin", "jakarta", "tehran", "jerusalem" });

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
            sre.SetInputToNull(); //ändra till sre.SetInputToDefaultAudioDevice() vid nedtryckning av knapp, och byt tillbak till sre.SetInputToNull() sen igen
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                sre.SetInputToNull();
        }

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            weatherLocation = e.Result.Text;
            //synth.Speak("Location changed to" + e.Result.Text);
            Debug.WriteLine(e.Result.Text);
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
                roosterPlayer.controls.play();
            }
            
            if(weatherDescription == "thunderstorm")
            {
                lightningPlayer.settings.volume = 50;
            }
            else
            {
                lightningPlayer.settings.volume = 0;
            }
        }

    }
}
