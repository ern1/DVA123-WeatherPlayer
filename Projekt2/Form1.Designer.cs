namespace Projekt2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_rain = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_wind = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_temperature = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_changeLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(82, 25);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(60, 13);
            this.label_location.TabIndex = 1;
            this.label_location.Text = "<Location>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rain:";
            // 
            // label_rain
            // 
            this.label_rain.AutoSize = true;
            this.label_rain.Location = new System.Drawing.Point(63, 90);
            this.label_rain.Name = "label_rain";
            this.label_rain.Size = new System.Drawing.Size(41, 13);
            this.label_rain.TabIndex = 3;
            this.label_rain.Text = "<Rain>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wind:";
            // 
            // label_wind
            // 
            this.label_wind.AutoSize = true;
            this.label_wind.Location = new System.Drawing.Point(66, 121);
            this.label_wind.Name = "label_wind";
            this.label_wind.Size = new System.Drawing.Size(44, 13);
            this.label_wind.TabIndex = 5;
            this.label_wind.Text = "<Wind>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Temperature:";
            // 
            // label_temperature
            // 
            this.label_temperature.AutoSize = true;
            this.label_temperature.Location = new System.Drawing.Point(101, 59);
            this.label_temperature.Name = "label_temperature";
            this.label_temperature.Size = new System.Drawing.Size(79, 13);
            this.label_temperature.TabIndex = 7;
            this.label_temperature.Text = "<Temperature>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change location";
            // 
            // box_changeLocation
            // 
            this.box_changeLocation.Location = new System.Drawing.Point(28, 181);
            this.box_changeLocation.Name = "box_changeLocation";
            this.box_changeLocation.Size = new System.Drawing.Size(100, 20);
            this.box_changeLocation.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_changeLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_temperature);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_wind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_rain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_rain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_wind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_temperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_changeLocation;
        private System.Windows.Forms.Button button1;
    }
}

