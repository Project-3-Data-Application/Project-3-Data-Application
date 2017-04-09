namespace DatabaseForm
{
    partial class DatabaseFormOphalen
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
            this.components = new System.ComponentModel.Container();
            this.Pgebied = new System.Windows.Forms.Label();
            this.Pplaats = new System.Windows.Forms.Label();
            this.Padres = new System.Windows.Forms.Label();
            this.aantal_zitplaatsen = new System.Windows.Forms.Label();
            this.Ptype = new System.Windows.Forms.Label();
            this.naam = new System.Windows.Forms.Label();
            this.annuleren = new System.Windows.Forms.Button();
            this.ophalen = new System.Windows.Forms.Button();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset_RotterdamDataSet = new DatabaseForm.Dataset_RotterdamDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.parkingTableAdapter = new DatabaseForm.Dataset_RotterdamDataSetTableAdapters.parkingTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_RotterdamDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Pgebied
            // 
            this.Pgebied.AutoSize = true;
            this.Pgebied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pgebied.Location = new System.Drawing.Point(916, 21);
            this.Pgebied.Name = "Pgebied";
            this.Pgebied.Size = new System.Drawing.Size(59, 16);
            this.Pgebied.TabIndex = 38;
            this.Pgebied.Text = "Gebied";
            // 
            // Pplaats
            // 
            this.Pplaats.AutoSize = true;
            this.Pplaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pplaats.Location = new System.Drawing.Point(782, 21);
            this.Pplaats.Name = "Pplaats";
            this.Pplaats.Size = new System.Drawing.Size(52, 16);
            this.Pplaats.TabIndex = 37;
            this.Pplaats.Text = "Plaats";
            // 
            // Padres
            // 
            this.Padres.AutoSize = true;
            this.Padres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padres.Location = new System.Drawing.Point(568, 21);
            this.Padres.Name = "Padres";
            this.Padres.Size = new System.Drawing.Size(49, 16);
            this.Padres.TabIndex = 36;
            this.Padres.Text = "Adres";
            // 
            // aantal_zitplaatsen
            // 
            this.aantal_zitplaatsen.AutoSize = true;
            this.aantal_zitplaatsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantal_zitplaatsen.Location = new System.Drawing.Point(382, 21);
            this.aantal_zitplaatsen.Name = "aantal_zitplaatsen";
            this.aantal_zitplaatsen.Size = new System.Drawing.Size(116, 16);
            this.aantal_zitplaatsen.TabIndex = 35;
            this.aantal_zitplaatsen.Text = "Aantal plaatsen";
            // 
            // Ptype
            // 
            this.Ptype.AutoSize = true;
            this.Ptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptype.Location = new System.Drawing.Point(292, 21);
            this.Ptype.Name = "Ptype";
            this.Ptype.Size = new System.Drawing.Size(44, 16);
            this.Ptype.TabIndex = 34;
            this.Ptype.Text = "Type";
            // 
            // naam
            // 
            this.naam.AutoSize = true;
            this.naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam.Location = new System.Drawing.Point(101, 21);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(49, 16);
            this.naam.TabIndex = 32;
            this.naam.Text = "Naam";
            // 
            // annuleren
            // 
            this.annuleren.Location = new System.Drawing.Point(554, 418);
            this.annuleren.Name = "annuleren";
            this.annuleren.Size = new System.Drawing.Size(75, 23);
            this.annuleren.TabIndex = 30;
            this.annuleren.Text = "sluiten";
            this.annuleren.UseVisualStyleBackColor = true;
            this.annuleren.Click += new System.EventHandler(this.annuleren_Click);
            // 
            // ophalen
            // 
            this.ophalen.Location = new System.Drawing.Point(473, 418);
            this.ophalen.Name = "ophalen";
            this.ophalen.Size = new System.Drawing.Size(75, 23);
            this.ophalen.TabIndex = 29;
            this.ophalen.Text = "ophalen";
            this.ophalen.UseVisualStyleBackColor = true;
            this.ophalen.Click += new System.EventHandler(this.ophalen_Click);
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "parking";
            this.parkingBindingSource.DataSource = this.dataset_RotterdamDataSet;
            // 
            // dataset_RotterdamDataSet
            // 
            this.dataset_RotterdamDataSet.DataSetName = "Dataset_RotterdamDataSet";
            this.dataset_RotterdamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Parkeergarage Erasmusbrug",
            "Parkeergarage Schouwburgplein",
            "Parkeergarage Erasmus MC",
            "Parkeergarage Museumpark",
            "P + R Beverwaard",
            "Parkeergarage Weena",
            "Parkeergarage Plaza/Casino",
            "Parkeergarage Kruiskade",
            "Parkeergarage Westblaak",
            "Parkeergarage Lijnbaan",
            "Parkeergarage Bijenkorf",
            "Parkeergarage Beursplein",
            "Parkeergarage WTC-V&D",
            "Parkeergarage Oude Haven",
            "P + R Kralingse Zoom",
            "Parkeergarage Boompjes",
            "Parkeergarage World Port Center",
            "Parkeergarage Zuidplein",
            "Parkeergarage Ahoy",
            "P + R Slinge benedendek",
            "P + R Alexander",
            "Parkeergarage Kiphof",
            "P + R Noorderhelling"});
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Parkeergarage",
            "P + R"});
            this.comboBox2.Location = new System.Drawing.Point(245, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 50;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "780",
            "540",
            "460",
            "435",
            "229",
            "1700",
            "623",
            "505",
            "1400",
            "439",
            "849",
            "473",
            "339",
            "322"});
            this.comboBox3.Location = new System.Drawing.Point(405, 40);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(55, 21);
            this.comboBox3.TabIndex = 51;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Hartmansstraat 35",
            "Crispijnstraat 6",
            "Aert van Nesstraat 16",
            "Bulgersteyn 5",
            "Leeuwenstraat 2",
            "Burgemeester van Walsumweg 718",
            "Kralingse Zoom 50",
            "Terwenakker 18",
            "Wilhelminakade 981",
            "Twentestraat 10",
            "Montessoriweg 9",
            "Slinge 763",
            "Prins Alexanderlaan 35",
            "Kipstraat 177",
            "Stadionweg 1"});
            this.comboBox4.Location = new System.Drawing.Point(466, 40);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(262, 21);
            this.comboBox4.TabIndex = 52;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Rotterdam"});
            this.comboBox5.Location = new System.Drawing.Point(734, 40);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(138, 21);
            this.comboBox5.TabIndex = 53;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Centrum",
            "Kralingen-Oost",
            "Feijenoord",
            "Zuidplein",
            "Pendrecht",
            "Prins Alexander",
            "Sportdorp"});
            this.comboBox6.Location = new System.Drawing.Point(878, 40);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(131, 21);
            this.comboBox6.TabIndex = 54;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(227, 318);
            this.textBox1.TabIndex = 55;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(154, 318);
            this.textBox2.TabIndex = 56;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(405, 67);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(55, 318);
            this.textBox3.TabIndex = 57;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(466, 67);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(262, 318);
            this.textBox4.TabIndex = 58;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(734, 67);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(138, 318);
            this.textBox5.TabIndex = 59;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(878, 67);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(131, 318);
            this.textBox6.TabIndex = 60;
            // 
            // DatabaseFormOphalen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 455);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Pgebied);
            this.Controls.Add(this.Pplaats);
            this.Controls.Add(this.Padres);
            this.Controls.Add(this.aantal_zitplaatsen);
            this.Controls.Add(this.Ptype);
            this.Controls.Add(this.naam);
            this.Controls.Add(this.annuleren);
            this.Controls.Add(this.ophalen);
            this.Name = "DatabaseFormOphalen";
            this.Text = "DatabaseFormOphalen";
            this.Load += new System.EventHandler(this.DatabaseFormOphalen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_RotterdamDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Pgebied;
        private System.Windows.Forms.Label Pplaats;
        private System.Windows.Forms.Label Padres;
        private System.Windows.Forms.Label aantal_zitplaatsen;
        private System.Windows.Forms.Label Ptype;
        private System.Windows.Forms.Label naam;
        private System.Windows.Forms.Button annuleren;
        private System.Windows.Forms.Button ophalen;
        private Dataset_RotterdamDataSet dataset_RotterdamDataSet;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private Dataset_RotterdamDataSetTableAdapters.parkingTableAdapter parkingTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}