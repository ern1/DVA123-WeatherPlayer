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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_location = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_changeLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar_temp = new System.Windows.Forms.ProgressBar();
            this.progressBar_wind = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_mic = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_description = new System.Windows.Forms.PictureBox();
            this.pictureBox_wind = new System.Windows.Forms.PictureBox();
            this.pictureBox_temp = new System.Windows.Forms.PictureBox();
            this.pictureBox_location = new System.Windows.Forms.PictureBox();
            this.pictureBox_mic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_location.Location = new System.Drawing.Point(111, 111);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(60, 13);
            this.label_location.TabIndex = 1;
            this.label_location.Text = "<Location>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change location";
            // 
            // box_changeLocation
            // 
            this.box_changeLocation.Location = new System.Drawing.Point(291, 296);
            this.box_changeLocation.Name = "box_changeLocation";
            this.box_changeLocation.Size = new System.Drawing.Size(100, 20);
            this.box_changeLocation.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(396, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar_temp
            // 
            this.progressBar_temp.Location = new System.Drawing.Point(168, 222);
            this.progressBar_temp.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_temp.Maximum = 400;
            this.progressBar_temp.Minimum = 200;
            this.progressBar_temp.Name = "progressBar_temp";
            this.progressBar_temp.Size = new System.Drawing.Size(75, 19);
            this.progressBar_temp.TabIndex = 20;
            this.progressBar_temp.Value = 200;
            // 
            // progressBar_wind
            // 
            this.progressBar_wind.Location = new System.Drawing.Point(30, 222);
            this.progressBar_wind.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_wind.Maximum = 20;
            this.progressBar_wind.Name = "progressBar_wind";
            this.progressBar_wind.Size = new System.Drawing.Size(75, 19);
            this.progressBar_wind.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Press F1 to activate microphone";
            // 
            // progressBar_mic
            // 
            this.progressBar_mic.Location = new System.Drawing.Point(354, 199);
            this.progressBar_mic.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_mic.Name = "progressBar_mic";
            this.progressBar_mic.Size = new System.Drawing.Size(75, 19);
            this.progressBar_mic.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projekt2.Properties.Resources.MinimizeWhite;
            this.pictureBox3.Location = new System.Drawing.Point(430, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projekt2.Properties.Resources.CloseWhite;
            this.pictureBox2.Location = new System.Drawing.Point(467, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_CloseButton);
            // 
            // pictureBox_description
            // 
            this.pictureBox_description.Location = new System.Drawing.Point(94, 266);
            this.pictureBox_description.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_description.Name = "pictureBox_description";
            this.pictureBox_description.Size = new System.Drawing.Size(75, 73);
            this.pictureBox_description.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_description.TabIndex = 19;
            this.pictureBox_description.TabStop = false;
            // 
            // pictureBox_wind
            // 
            this.pictureBox_wind.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_wind.Image")));
            this.pictureBox_wind.Location = new System.Drawing.Point(30, 138);
            this.pictureBox_wind.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_wind.Name = "pictureBox_wind";
            this.pictureBox_wind.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_wind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_wind.TabIndex = 17;
            this.pictureBox_wind.TabStop = false;
            // 
            // pictureBox_temp
            // 
            this.pictureBox_temp.Image = global::Projekt2.Properties.Resources.temperature;
            this.pictureBox_temp.Location = new System.Drawing.Point(168, 138);
            this.pictureBox_temp.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_temp.Name = "pictureBox_temp";
            this.pictureBox_temp.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_temp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_temp.TabIndex = 16;
            this.pictureBox_temp.TabStop = false;
            // 
            // pictureBox_location
            // 
            this.pictureBox_location.Image = global::Projekt2.Properties.Resources.map;
            this.pictureBox_location.Location = new System.Drawing.Point(94, 32);
            this.pictureBox_location.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_location.Name = "pictureBox_location";
            this.pictureBox_location.Size = new System.Drawing.Size(86, 77);
            this.pictureBox_location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_location.TabIndex = 15;
            this.pictureBox_location.TabStop = false;
            // 
            // pictureBox_mic
            // 
            this.pictureBox_mic.Image = global::Projekt2.Properties.Resources.muted;
            this.pictureBox_mic.Location = new System.Drawing.Point(344, 91);
            this.pictureBox_mic.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_mic.Name = "pictureBox_mic";
            this.pictureBox_mic.Size = new System.Drawing.Size(95, 103);
            this.pictureBox_mic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mic.TabIndex = 14;
            this.pictureBox_mic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt2.Properties.Resources.info;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(503, 370);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar_mic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_wind);
            this.Controls.Add(this.progressBar_temp);
            this.Controls.Add(this.pictureBox_description);
            this.Controls.Add(this.pictureBox_wind);
            this.Controls.Add(this.pictureBox_temp);
            this.Controls.Add(this.pictureBox_location);
            this.Controls.Add(this.pictureBox_mic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_changeLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_location);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "WeatherPlayer";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_changeLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_mic;
        private System.Windows.Forms.PictureBox pictureBox_location;
        private System.Windows.Forms.PictureBox pictureBox_temp;
        private System.Windows.Forms.PictureBox pictureBox_wind;
        private System.Windows.Forms.PictureBox pictureBox_description;
        private System.Windows.Forms.ProgressBar progressBar_temp;
        private System.Windows.Forms.ProgressBar progressBar_wind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_mic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

