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
            this.parkingbtn = new System.Windows.Forms.Button();
            this.chargingbtn = new System.Windows.Forms.Button();
            this.eventbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parkingbtn
            // 
            this.parkingbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.parkingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.parkingbtn.Location = new System.Drawing.Point(85, 65);
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
            this.chargingbtn.Location = new System.Drawing.Point(85, 205);
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
            this.eventbtn.Location = new System.Drawing.Point(85, 135);
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
            this.exitbtn.Location = new System.Drawing.Point(128, 300);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(84, 23);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(247, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "gmaptest";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Parkingscouting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appdesign.Properties.Resources.menu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(334, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.eventbtn);
            this.Controls.Add(this.chargingbtn);
            this.Controls.Add(this.parkingbtn);
            this.MaximizeBox = false;
            this.Name = "Parkingscouting";
            this.Text = "Parkingscouting";
            this.Load += new System.EventHandler(this.Parkingscouting_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button parkingbtn;
        private System.Windows.Forms.Button chargingbtn;
        private System.Windows.Forms.Button eventbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button button1;
    }
}

