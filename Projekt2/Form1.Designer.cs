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
            this.label9 = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_location.Location = new System.Drawing.Point(109, 31);
            this.label_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(78, 17);
            this.label_location.TabIndex = 1;
            this.label_location.Text = "<Location>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rain:";
            // 
            // label_rain
            // 
            this.label_rain.AutoSize = true;
            this.label_rain.Location = new System.Drawing.Point(84, 111);
            this.label_rain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rain.Name = "label_rain";
            this.label_rain.Size = new System.Drawing.Size(53, 17);
            this.label_rain.TabIndex = 3;
            this.label_rain.Text = "<Rain>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wind:";
            // 
            // label_wind
            // 
            this.label_wind.AutoSize = true;
            this.label_wind.Location = new System.Drawing.Point(88, 149);
            this.label_wind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_wind.Name = "label_wind";
            this.label_wind.Size = new System.Drawing.Size(56, 17);
            this.label_wind.TabIndex = 5;
            this.label_wind.Text = "<Wind>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Temperature:";
            // 
            // label_temperature
            // 
            this.label_temperature.AutoSize = true;
            this.label_temperature.Location = new System.Drawing.Point(135, 73);
            this.label_temperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_temperature.Name = "label_temperature";
            this.label_temperature.Size = new System.Drawing.Size(106, 17);
            this.label_temperature.TabIndex = 7;
            this.label_temperature.Text = "<Temperature>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change location";
            // 
            // box_changeLocation
            // 
            this.box_changeLocation.Location = new System.Drawing.Point(37, 241);
            this.box_changeLocation.Margin = new System.Windows.Forms.Padding(4);
            this.box_changeLocation.Name = "box_changeLocation";
            this.box_changeLocation.Size = new System.Drawing.Size(132, 22);
            this.box_changeLocation.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(196, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Description: ";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(131, 180);
            this.label_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(95, 17);
            this.label_description.TabIndex = 12;
            this.label_description.Text = "<Description>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label9);
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
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_description;
    }
}

