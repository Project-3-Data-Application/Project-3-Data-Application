namespace DatabaseForm
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
            this.Toevoegen = new System.Windows.Forms.Button();
            this.annuleren = new System.Windows.Forms.Button();
            this.naam = new System.Windows.Forms.Label();
            this.Ptype = new System.Windows.Forms.Label();
            this.aantal_zitplaatsen = new System.Windows.Forms.Label();
            this.Padres = new System.Windows.Forms.Label();
            this.Pplaats = new System.Windows.Forms.Label();
            this.Pgebied = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.aantal_plaatsen = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.plaats = new System.Windows.Forms.TextBox();
            this.gebied = new System.Windows.Forms.TextBox();
            this.ophalen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Longit = new System.Windows.Forms.TextBox();
            this.lng = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Toevoegen
            // 
            this.Toevoegen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Toevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toevoegen.ForeColor = System.Drawing.SystemColors.Control;
            this.Toevoegen.Location = new System.Drawing.Point(208, 276);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Size = new System.Drawing.Size(75, 39);
            this.Toevoegen.TabIndex = 10;
            this.Toevoegen.Text = "Gegevens Opslaan";
            this.Toevoegen.UseVisualStyleBackColor = false;
            this.Toevoegen.Click += new System.EventHandler(this.opslaan_Click);
            // 
            // annuleren
            // 
            this.annuleren.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.annuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuleren.ForeColor = System.Drawing.SystemColors.Control;
            this.annuleren.Location = new System.Drawing.Point(208, 368);
            this.annuleren.Name = "annuleren";
            this.annuleren.Size = new System.Drawing.Size(75, 23);
            this.annuleren.TabIndex = 12;
            this.annuleren.Text = "Afsluiten";
            this.annuleren.UseVisualStyleBackColor = false;
            this.annuleren.Click += new System.EventHandler(this.annuleren_Click);
            // 
            // naam
            // 
            this.naam.AutoSize = true;
            this.naam.BackColor = System.Drawing.Color.Transparent;
            this.naam.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam.ForeColor = System.Drawing.Color.White;
            this.naam.Location = new System.Drawing.Point(19, 54);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(64, 16);
            this.naam.TabIndex = 14;
            this.naam.Text = "Naam*:";
            // 
            // Ptype
            // 
            this.Ptype.AutoSize = true;
            this.Ptype.BackColor = System.Drawing.Color.Transparent;
            this.Ptype.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptype.ForeColor = System.Drawing.Color.White;
            this.Ptype.Location = new System.Drawing.Point(19, 81);
            this.Ptype.Name = "Ptype";
            this.Ptype.Size = new System.Drawing.Size(57, 16);
            this.Ptype.TabIndex = 16;
            this.Ptype.Text = "Type*:";
            this.Ptype.Click += new System.EventHandler(this.label4_Click);
            // 
            // aantal_zitplaatsen
            // 
            this.aantal_zitplaatsen.AutoSize = true;
            this.aantal_zitplaatsen.BackColor = System.Drawing.Color.Transparent;
            this.aantal_zitplaatsen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantal_zitplaatsen.ForeColor = System.Drawing.Color.White;
            this.aantal_zitplaatsen.Location = new System.Drawing.Point(19, 110);
            this.aantal_zitplaatsen.Name = "aantal_zitplaatsen";
            this.aantal_zitplaatsen.Size = new System.Drawing.Size(127, 16);
            this.aantal_zitplaatsen.TabIndex = 17;
            this.aantal_zitplaatsen.Text = "Aantal plaatsen:";
            this.aantal_zitplaatsen.Click += new System.EventHandler(this.label5_Click);
            // 
            // Padres
            // 
            this.Padres.AutoSize = true;
            this.Padres.BackColor = System.Drawing.Color.Transparent;
            this.Padres.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padres.ForeColor = System.Drawing.Color.White;
            this.Padres.Location = new System.Drawing.Point(19, 138);
            this.Padres.Name = "Padres";
            this.Padres.Size = new System.Drawing.Size(64, 16);
            this.Padres.TabIndex = 18;
            this.Padres.Text = "Adres*:";
            this.Padres.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Pplaats
            // 
            this.Pplaats.AutoSize = true;
            this.Pplaats.BackColor = System.Drawing.Color.Transparent;
            this.Pplaats.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pplaats.ForeColor = System.Drawing.Color.White;
            this.Pplaats.Location = new System.Drawing.Point(19, 167);
            this.Pplaats.Name = "Pplaats";
            this.Pplaats.Size = new System.Drawing.Size(67, 16);
            this.Pplaats.TabIndex = 19;
            this.Pplaats.Text = "Plaats*:";
            // 
            // Pgebied
            // 
            this.Pgebied.AutoSize = true;
            this.Pgebied.BackColor = System.Drawing.Color.Transparent;
            this.Pgebied.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pgebied.ForeColor = System.Drawing.Color.White;
            this.Pgebied.Location = new System.Drawing.Point(19, 195);
            this.Pgebied.Name = "Pgebied";
            this.Pgebied.Size = new System.Drawing.Size(72, 16);
            this.Pgebied.TabIndex = 20;
            this.Pgebied.Text = "Gebied*:";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.Control;
            this.name.Location = new System.Drawing.Point(161, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(299, 21);
            this.name.TabIndex = 22;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.Control;
            this.type.Location = new System.Drawing.Point(161, 81);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(145, 21);
            this.type.TabIndex = 24;
            // 
            // aantal_plaatsen
            // 
            this.aantal_plaatsen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aantal_plaatsen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantal_plaatsen.ForeColor = System.Drawing.SystemColors.Control;
            this.aantal_plaatsen.Location = new System.Drawing.Point(161, 110);
            this.aantal_plaatsen.Name = "aantal_plaatsen";
            this.aantal_plaatsen.Size = new System.Drawing.Size(57, 21);
            this.aantal_plaatsen.TabIndex = 25;
            // 
            // adres
            // 
            this.adres.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adres.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adres.ForeColor = System.Drawing.SystemColors.Control;
            this.adres.Location = new System.Drawing.Point(161, 138);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(299, 21);
            this.adres.TabIndex = 26;
            // 
            // plaats
            // 
            this.plaats.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plaats.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaats.ForeColor = System.Drawing.SystemColors.Control;
            this.plaats.Location = new System.Drawing.Point(161, 167);
            this.plaats.Name = "plaats";
            this.plaats.Size = new System.Drawing.Size(156, 21);
            this.plaats.TabIndex = 27;
            // 
            // gebied
            // 
            this.gebied.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gebied.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebied.ForeColor = System.Drawing.SystemColors.Control;
            this.gebied.Location = new System.Drawing.Point(161, 195);
            this.gebied.Name = "gebied";
            this.gebied.Size = new System.Drawing.Size(156, 21);
            this.gebied.TabIndex = 28;
            // 
            // ophalen
            // 
            this.ophalen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ophalen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ophalen.ForeColor = System.Drawing.SystemColors.Control;
            this.ophalen.Location = new System.Drawing.Point(289, 368);
            this.ophalen.Name = "ophalen";
            this.ophalen.Size = new System.Drawing.Size(75, 23);
            this.ophalen.TabIndex = 11;
            this.ophalen.Text = "Vorige";
            this.ophalen.UseVisualStyleBackColor = false;
            this.ophalen.Click += new System.EventHandler(this.ophalen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(127, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Hoofdmenu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Longit
            // 
            this.Longit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Longit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Longit.ForeColor = System.Drawing.SystemColors.Control;
            this.Longit.Location = new System.Drawing.Point(161, 222);
            this.Longit.Name = "Longit";
            this.Longit.Size = new System.Drawing.Size(145, 21);
            this.Longit.TabIndex = 31;
            // 
            // lng
            // 
            this.lng.AutoSize = true;
            this.lng.BackColor = System.Drawing.Color.Transparent;
            this.lng.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lng.ForeColor = System.Drawing.Color.White;
            this.lng.Location = new System.Drawing.Point(19, 222);
            this.lng.Name = "lng";
            this.lng.Size = new System.Drawing.Size(85, 16);
            this.lng.TabIndex = 30;
            this.lng.Text = "Longitude:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(161, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 21);
            this.textBox2.TabIndex = 33;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lat
            // 
            this.lat.AutoSize = true;
            this.lat.BackColor = System.Drawing.Color.Transparent;
            this.lat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat.ForeColor = System.Drawing.Color.White;
            this.lat.Location = new System.Drawing.Point(19, 249);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(73, 16);
            this.lat.TabIndex = 32;
            this.lat.Text = "Latitude:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(72, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "*Alle velden met een * zijn verplicht om ingevuld te worden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appdesign.Properties.Resources.DatabaseForm;
            this.ClientSize = new System.Drawing.Size(507, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lat);
            this.Controls.Add(this.Longit);
            this.Controls.Add(this.lng);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gebied);
            this.Controls.Add(this.plaats);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.aantal_plaatsen);
            this.Controls.Add(this.type);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Pgebied);
            this.Controls.Add(this.Pplaats);
            this.Controls.Add(this.Padres);
            this.Controls.Add(this.aantal_zitplaatsen);
            this.Controls.Add(this.Ptype);
            this.Controls.Add(this.naam);
            this.Controls.Add(this.annuleren);
            this.Controls.Add(this.ophalen);
            this.Controls.Add(this.Toevoegen);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "opslaan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Toevoegen;
        private System.Windows.Forms.Button annuleren;
        private System.Windows.Forms.Label naam;
        private System.Windows.Forms.Label Ptype;
        private System.Windows.Forms.Label aantal_zitplaatsen;
        private System.Windows.Forms.Label Padres;
        private System.Windows.Forms.Label Pplaats;
        private System.Windows.Forms.Label Pgebied;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox aantal_plaatsen;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox plaats;
        private System.Windows.Forms.TextBox gebied;
        private System.Windows.Forms.Button ophalen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Longit;
        private System.Windows.Forms.Label lng;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lat;
        private System.Windows.Forms.Label label1;
    }
}

