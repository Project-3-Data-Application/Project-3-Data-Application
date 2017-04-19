namespace appdesign
{
    partial class Parkingscouting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parkingscouting));
            this.parkingbtn = new System.Windows.Forms.Button();
            this.chargingbtn = new System.Windows.Forms.Button();
            this.eventbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingbtn
            // 
            this.parkingbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.parkingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.parkingbtn.Location = new System.Drawing.Point(100, 104);
            this.parkingbtn.Name = "parkingbtn";
            this.parkingbtn.Size = new System.Drawing.Size(160, 45);
            this.parkingbtn.TabIndex = 2;
            this.parkingbtn.Text = "Parkeergarages";
            this.parkingbtn.UseVisualStyleBackColor = false;
            this.parkingbtn.Click += new System.EventHandler(this.parkingbtn_Click);
            // 
            // chargingbtn
            // 
            this.chargingbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chargingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chargingbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargingbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chargingbtn.Location = new System.Drawing.Point(100, 244);
            this.chargingbtn.Name = "chargingbtn";
            this.chargingbtn.Size = new System.Drawing.Size(160, 45);
            this.chargingbtn.TabIndex = 3;
            this.chargingbtn.Text = "Oplaadpunten";
            this.chargingbtn.UseVisualStyleBackColor = false;
            this.chargingbtn.Click += new System.EventHandler(this.chargingbtn_Click);
            // 
            // eventbtn
            // 
            this.eventbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eventbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eventbtn.Location = new System.Drawing.Point(100, 174);
            this.eventbtn.Name = "eventbtn";
            this.eventbtn.Size = new System.Drawing.Size(160, 45);
            this.eventbtn.TabIndex = 4;
            this.eventbtn.Text = "Toeristische attracties";
            this.eventbtn.UseVisualStyleBackColor = false;
            this.eventbtn.Click += new System.EventHandler(this.eventbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitbtn.Location = new System.Drawing.Point(143, 339);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(84, 23);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::appdesign.Properties.Resources.Project_3_Icoon1_555;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 86);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Parkingscouting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appdesign.Properties.Resources.menu2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(366, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.eventbtn);
            this.Controls.Add(this.chargingbtn);
            this.Controls.Add(this.parkingbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Parkingscouting";
            this.Text = "ParkScouting";
            this.Load += new System.EventHandler(this.Parkingscouting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button parkingbtn;
        private System.Windows.Forms.Button chargingbtn;
        private System.Windows.Forms.Button eventbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

