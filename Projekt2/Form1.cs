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
            Run();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (box_changeLocation.Text == string.Empty)
                return;

            weatherLocation = box_changeLocation.Text;
            box_changeLocation.Text = string.Empty;
        }
    }
}
