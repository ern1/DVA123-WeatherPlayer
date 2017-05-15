using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Run();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (box_changeLocation.Text == string.Empty)
                return;

            weatherLocation = box_changeLocation.Text;
            box_changeLocation.Text = string.Empty;
            locationChanged.Play();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                try
                {
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                    SpeechRecognitionStarted.Play();
                }
                catch (InvalidOperationException ioe)
                { }
            }

            if(e.KeyCode == Keys.Up)
            {
                wind.settings.rate += 0.05;
            }

            if (e.KeyCode == Keys.Down)
            {
                wind.settings.rate -= 0.05;
            }

            if (e.KeyCode == Keys.Left)
            {
                wind.settings.rate = 0.85;
            }

            if (e.KeyCode == Keys.Right)
            {
                wind.settings.rate = 1.25;
            }
        }
    }
}
