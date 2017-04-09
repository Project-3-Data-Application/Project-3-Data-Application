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
            this.opslaan = new System.Windows.Forms.Button();
            this.annuleren = new System.Windows.Forms.Button();
            this.Coördinaten = new System.Windows.Forms.Label();
            this.naam = new System.Windows.Forms.Label();
            this.Pcode = new System.Windows.Forms.Label();
            this.Ptype = new System.Windows.Forms.Label();
            this.aantal_zitplaatsen = new System.Windows.Forms.Label();
            this.Padres = new System.Windows.Forms.Label();
            this.Pplaats = new System.Windows.Forms.Label();
            this.Pgebied = new System.Windows.Forms.Label();
            this.coordinaten = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.aantal_plaatsen = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.plaats = new System.Windows.Forms.TextBox();
            this.gebied = new System.Windows.Forms.TextBox();
            this.ophalen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opslaan
            // 
            this.opslaan.Location = new System.Drawing.Point(154, 292);
            this.opslaan.Name = "opslaan";
            this.opslaan.Size = new System.Drawing.Size(75, 23);
            this.opslaan.TabIndex = 10;
            this.opslaan.Text = "opslaan";
            this.opslaan.UseVisualStyleBackColor = true;
            this.opslaan.Click += new System.EventHandler(this.opslaan_Click);
            // 
            // annuleren
            // 
            this.annuleren.Location = new System.Drawing.Point(224, 321);
            this.annuleren.Name = "annuleren";
            this.annuleren.Size = new System.Drawing.Size(75, 23);
            this.annuleren.TabIndex = 12;
            this.annuleren.Text = "sluiten";
            this.annuleren.UseVisualStyleBackColor = true;
            this.annuleren.Click += new System.EventHandler(this.annuleren_Click);
            // 
            // Coördinaten
            // 
            this.Coördinaten.AutoSize = true;
            this.Coördinaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coördinaten.Location = new System.Drawing.Point(12, 58);
            this.Coördinaten.Name = "Coördinaten";
            this.Coördinaten.Size = new System.Drawing.Size(92, 16);
            this.Coördinaten.TabIndex = 13;
            this.Coördinaten.Text = "Coördinaten";
            // 
            // naam
            // 
            this.naam.AutoSize = true;
            this.naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam.Location = new System.Drawing.Point(12, 84);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(49, 16);
            this.naam.TabIndex = 14;
            this.naam.Text = "Naam";
            // 
            // Pcode
            // 
            this.Pcode.AutoSize = true;
            this.Pcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pcode.Location = new System.Drawing.Point(12, 113);
            this.Pcode.Name = "Pcode";
            this.Pcode.Size = new System.Drawing.Size(45, 16);
            this.Pcode.TabIndex = 15;
            this.Pcode.Text = "Code";
            // 
            // Ptype
            // 
            this.Ptype.AutoSize = true;
            this.Ptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptype.Location = new System.Drawing.Point(12, 140);
            this.Ptype.Name = "Ptype";
            this.Ptype.Size = new System.Drawing.Size(44, 16);
            this.Ptype.TabIndex = 16;
            this.Ptype.Text = "Type";
            this.Ptype.Click += new System.EventHandler(this.label4_Click);
            // 
            // aantal_zitplaatsen
            // 
            this.aantal_zitplaatsen.AutoSize = true;
            this.aantal_zitplaatsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantal_zitplaatsen.Location = new System.Drawing.Point(12, 169);
            this.aantal_zitplaatsen.Name = "aantal_zitplaatsen";
            this.aantal_zitplaatsen.Size = new System.Drawing.Size(116, 16);
            this.aantal_zitplaatsen.TabIndex = 17;
            this.aantal_zitplaatsen.Text = "Aantal plaatsen";
            this.aantal_zitplaatsen.Click += new System.EventHandler(this.label5_Click);
            // 
            // Padres
            // 
            this.Padres.AutoSize = true;
            this.Padres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padres.Location = new System.Drawing.Point(12, 197);
            this.Padres.Name = "Padres";
            this.Padres.Size = new System.Drawing.Size(49, 16);
            this.Padres.TabIndex = 18;
            this.Padres.Text = "Adres";
            this.Padres.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Pplaats
            // 
            this.Pplaats.AutoSize = true;
            this.Pplaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pplaats.Location = new System.Drawing.Point(12, 226);
            this.Pplaats.Name = "Pplaats";
            this.Pplaats.Size = new System.Drawing.Size(52, 16);
            this.Pplaats.TabIndex = 19;
            this.Pplaats.Text = "Plaats";
            // 
            // Pgebied
            // 
            this.Pgebied.AutoSize = true;
            this.Pgebied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pgebied.Location = new System.Drawing.Point(12, 254);
            this.Pgebied.Name = "Pgebied";
            this.Pgebied.Size = new System.Drawing.Size(59, 16);
            this.Pgebied.TabIndex = 20;
            this.Pgebied.Text = "Gebied";
            // 
            // coordinaten
            // 
            this.coordinaten.Location = new System.Drawing.Point(154, 58);
            this.coordinaten.Name = "coordinaten";
            this.coordinaten.Size = new System.Drawing.Size(282, 20);
            this.coordinaten.TabIndex = 21;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(154, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(299, 20);
            this.name.TabIndex = 22;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(154, 113);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(75, 20);
            this.code.TabIndex = 23;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(154, 140);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(145, 20);
            this.type.TabIndex = 24;
            // 
            // aantal_plaatsen
            // 
            this.aantal_plaatsen.Location = new System.Drawing.Point(154, 169);
            this.aantal_plaatsen.Name = "aantal_plaatsen";
            this.aantal_plaatsen.Size = new System.Drawing.Size(57, 20);
            this.aantal_plaatsen.TabIndex = 25;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(154, 197);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(299, 20);
            this.adres.TabIndex = 26;
            // 
            // plaats
            // 
            this.plaats.Location = new System.Drawing.Point(154, 226);
            this.plaats.Name = "plaats";
            this.plaats.Size = new System.Drawing.Size(156, 20);
            this.plaats.TabIndex = 27;
            // 
            // gebied
            // 
            this.gebied.Location = new System.Drawing.Point(154, 254);
            this.gebied.Name = "gebied";
            this.gebied.Size = new System.Drawing.Size(156, 20);
            this.gebied.TabIndex = 28;
            // 
            // ophalen
            // 
            this.ophalen.Location = new System.Drawing.Point(294, 292);
            this.ophalen.Name = "ophalen";
            this.ophalen.Size = new System.Drawing.Size(75, 23);
            this.ophalen.TabIndex = 11;
            this.ophalen.Text = "ophalen";
            this.ophalen.UseVisualStyleBackColor = true;
            this.ophalen.Click += new System.EventHandler(this.ophalen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 424);
            this.Controls.Add(this.gebied);
            this.Controls.Add(this.plaats);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.aantal_plaatsen);
            this.Controls.Add(this.type);
            this.Controls.Add(this.code);
            this.Controls.Add(this.name);
            this.Controls.Add(this.coordinaten);
            this.Controls.Add(this.Pgebied);
            this.Controls.Add(this.Pplaats);
            this.Controls.Add(this.Padres);
            this.Controls.Add(this.aantal_zitplaatsen);
            this.Controls.Add(this.Ptype);
            this.Controls.Add(this.Pcode);
            this.Controls.Add(this.naam);
            this.Controls.Add(this.Coördinaten);
            this.Controls.Add(this.annuleren);
            this.Controls.Add(this.ophalen);
            this.Controls.Add(this.opslaan);
            this.Name = "Form1";
            this.Text = "opslaan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button opslaan;
        private System.Windows.Forms.Button annuleren;
        private System.Windows.Forms.Label Coördinaten;
        private System.Windows.Forms.Label naam;
        private System.Windows.Forms.Label Pcode;
        private System.Windows.Forms.Label Ptype;
        private System.Windows.Forms.Label aantal_zitplaatsen;
        private System.Windows.Forms.Label Padres;
        private System.Windows.Forms.Label Pplaats;
        private System.Windows.Forms.Label Pgebied;
        private System.Windows.Forms.TextBox coordinaten;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox aantal_plaatsen;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox plaats;
        private System.Windows.Forms.TextBox gebied;
        private System.Windows.Forms.Button ophalen;
    }
}

