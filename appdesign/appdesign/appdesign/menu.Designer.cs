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
            this.instructionsbtn = new System.Windows.Forms.Button();
            this.creditsbtn = new System.Windows.Forms.Button();
            this.parkingbtn = new System.Windows.Forms.Button();
            this.chargingbtn = new System.Windows.Forms.Button();
            this.eventbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsbtn
            // 
            this.instructionsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionsbtn.Location = new System.Drawing.Point(12, 274);
            this.instructionsbtn.Name = "instructionsbtn";
            this.instructionsbtn.Size = new System.Drawing.Size(75, 23);
            this.instructionsbtn.TabIndex = 0;
            this.instructionsbtn.Text = "Instructies";
            this.instructionsbtn.UseVisualStyleBackColor = true;
            this.instructionsbtn.Click += new System.EventHandler(this.instructionsbtn_Click);
            // 
            // creditsbtn
            // 
            this.creditsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditsbtn.Location = new System.Drawing.Point(247, 274);
            this.creditsbtn.Name = "creditsbtn";
            this.creditsbtn.Size = new System.Drawing.Size(75, 23);
            this.creditsbtn.TabIndex = 1;
            this.creditsbtn.Text = "Credits";
            this.creditsbtn.UseVisualStyleBackColor = true;
            this.creditsbtn.Click += new System.EventHandler(this.creditsbtn_Click);
            // 
            // parkingbtn
            // 
            this.parkingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingbtn.Location = new System.Drawing.Point(85, 65);
            this.parkingbtn.Name = "parkingbtn";
            this.parkingbtn.Size = new System.Drawing.Size(160, 45);
            this.parkingbtn.TabIndex = 2;
            this.parkingbtn.Text = "Parkeergarages";
            this.parkingbtn.UseVisualStyleBackColor = true;
            this.parkingbtn.Click += new System.EventHandler(this.parkingbtn_Click);
            // 
            // chargingbtn
            // 
            this.chargingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chargingbtn.Location = new System.Drawing.Point(85, 205);
            this.chargingbtn.Name = "chargingbtn";
            this.chargingbtn.Size = new System.Drawing.Size(160, 45);
            this.chargingbtn.TabIndex = 3;
            this.chargingbtn.Text = "Oplaadpunten";
            this.chargingbtn.UseVisualStyleBackColor = true;
            this.chargingbtn.Click += new System.EventHandler(this.chargingbtn_Click);
            // 
            // eventbtn
            // 
            this.eventbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventbtn.Location = new System.Drawing.Point(85, 135);
            this.eventbtn.Name = "eventbtn";
            this.eventbtn.Size = new System.Drawing.Size(160, 45);
            this.eventbtn.TabIndex = 4;
            this.eventbtn.Text = "Toeristische attracties";
            this.eventbtn.UseVisualStyleBackColor = true;
            this.eventbtn.Click += new System.EventHandler(this.eventbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Gray;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Location = new System.Drawing.Point(128, 326);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(84, 23);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Parkingscouting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.eventbtn);
            this.Controls.Add(this.chargingbtn);
            this.Controls.Add(this.parkingbtn);
            this.Controls.Add(this.creditsbtn);
            this.Controls.Add(this.instructionsbtn);
            this.Name = "Parkingscouting";
            this.Text = "Parkingscouting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button instructionsbtn;
        private System.Windows.Forms.Button creditsbtn;
        private System.Windows.Forms.Button parkingbtn;
        private System.Windows.Forms.Button chargingbtn;
        private System.Windows.Forms.Button eventbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

