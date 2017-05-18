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
                    pictureBox_mic.Image = Projekt2.Properties.Resources.microphone;
                }
                catch (InvalidOperationException ioe)
                { }
            }
        }

        private void pictureBox1_click(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(" Icons made by FreePik and Madebyoliver from www.flaticon.com" +
                                                 "\n\n This application uses these sounds from freesound:" +
                                                 "\n beacher goers and surf by John Sipos" +
                                                 "\n Borneo jungle - day by RTB45" +
                                                 "\n Heavy rain by lebcraftlp" +
                                                 "\n Thunder- 1 by bone666138" +
                                                 "\n crickets, birds summer ambient by Nikodemus_Christian" +
                                                 "\n\n It also uses these sounds from soundbible:" +
                                                 "\n wasp- by Mike Koenig" +
                                                 "\n open soda can by KP" +
                                                 "\n sunny day by stephan" +
                                                 "\n Wind by Stilgar");
        }
    }
}
