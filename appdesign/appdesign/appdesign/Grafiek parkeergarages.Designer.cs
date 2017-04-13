namespace appdesign
{
    partial class Grafiek_parkeergarages
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pgebied = new System.Windows.Forms.Label();
            this.Pplaats = new System.Windows.Forms.Label();
            this.Padres = new System.Windows.Forms.Label();
            this.aantal_zitplaatsen = new System.Windows.Forms.Label();
            this.Ptype = new System.Windows.Forms.Label();
            this.naam = new System.Windows.Forms.Label();
            this.PGgrafiek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataset_RotterdamDataSet1 = new appdesign.Dataset_RotterdamDataSet1();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingTableAdapter = new appdesign.Dataset_RotterdamDataSet1TableAdapters.parkingTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PGgrafiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_RotterdamDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Centrum",
            "Kralingen-Oost",
            "Feijenoord",
            "Zuidplein",
            "Pendrecht",
            "Prins Alexander",
            "Sportdorp"});
            this.comboBox6.Location = new System.Drawing.Point(992, 28);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(131, 21);
            this.comboBox6.TabIndex = 66;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Rotterdam"});
            this.comboBox5.Location = new System.Drawing.Point(848, 28);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(138, 21);
            this.comboBox5.TabIndex = 65;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.SystemColors.Control;
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
            this.comboBox4.Location = new System.Drawing.Point(580, 28);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(262, 21);
            this.comboBox4.TabIndex = 64;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.SystemColors.Control;
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
            this.comboBox3.Location = new System.Drawing.Point(519, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(55, 21);
            this.comboBox3.TabIndex = 63;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Parkeergarage",
            "P + R"});
            this.comboBox2.Location = new System.Drawing.Point(359, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 62;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
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
            this.comboBox1.Location = new System.Drawing.Point(126, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 61;
            // 
            // Pgebied
            // 
            this.Pgebied.AutoSize = true;
            this.Pgebied.BackColor = System.Drawing.Color.Transparent;
            this.Pgebied.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pgebied.ForeColor = System.Drawing.SystemColors.Control;
            this.Pgebied.Location = new System.Drawing.Point(1030, 9);
            this.Pgebied.Name = "Pgebied";
            this.Pgebied.Size = new System.Drawing.Size(63, 16);
            this.Pgebied.TabIndex = 60;
            this.Pgebied.Text = "Gebied:";
            // 
            // Pplaats
            // 
            this.Pplaats.AutoSize = true;
            this.Pplaats.BackColor = System.Drawing.Color.Transparent;
            this.Pplaats.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pplaats.ForeColor = System.Drawing.SystemColors.Control;
            this.Pplaats.Location = new System.Drawing.Point(896, 9);
            this.Pplaats.Name = "Pplaats";
            this.Pplaats.Size = new System.Drawing.Size(58, 16);
            this.Pplaats.TabIndex = 59;
            this.Pplaats.Text = "Plaats:";
            // 
            // Padres
            // 
            this.Padres.AutoSize = true;
            this.Padres.BackColor = System.Drawing.Color.Transparent;
            this.Padres.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padres.ForeColor = System.Drawing.SystemColors.Control;
            this.Padres.Location = new System.Drawing.Point(682, 9);
            this.Padres.Name = "Padres";
            this.Padres.Size = new System.Drawing.Size(55, 16);
            this.Padres.TabIndex = 58;
            this.Padres.Text = "Adres:";
            // 
            // aantal_zitplaatsen
            // 
            this.aantal_zitplaatsen.AutoSize = true;
            this.aantal_zitplaatsen.BackColor = System.Drawing.Color.Transparent;
            this.aantal_zitplaatsen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantal_zitplaatsen.ForeColor = System.Drawing.SystemColors.Control;
            this.aantal_zitplaatsen.Location = new System.Drawing.Point(496, 9);
            this.aantal_zitplaatsen.Name = "aantal_zitplaatsen";
            this.aantal_zitplaatsen.Size = new System.Drawing.Size(127, 16);
            this.aantal_zitplaatsen.TabIndex = 57;
            this.aantal_zitplaatsen.Text = "Aantal plaatsen:";
            // 
            // Ptype
            // 
            this.Ptype.AutoSize = true;
            this.Ptype.BackColor = System.Drawing.Color.Transparent;
            this.Ptype.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptype.ForeColor = System.Drawing.SystemColors.Control;
            this.Ptype.Location = new System.Drawing.Point(406, 9);
            this.Ptype.Name = "Ptype";
            this.Ptype.Size = new System.Drawing.Size(48, 16);
            this.Ptype.TabIndex = 56;
            this.Ptype.Text = "Type:";
            // 
            // naam
            // 
            this.naam.AutoSize = true;
            this.naam.BackColor = System.Drawing.Color.Transparent;
            this.naam.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam.ForeColor = System.Drawing.SystemColors.Control;
            this.naam.Location = new System.Drawing.Point(215, 9);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(55, 16);
            this.naam.TabIndex = 55;
            this.naam.Text = "Naam:";
            // 
            // PGgrafiek
            // 
            this.PGgrafiek.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.PGgrafiek.BackColor = System.Drawing.Color.Transparent;
            this.PGgrafiek.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.PGgrafiek.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Aantal Plaatsen";
            this.PGgrafiek.Legends.Add(legend1);
            this.PGgrafiek.Location = new System.Drawing.Point(3, 55);
            this.PGgrafiek.Name = "PGgrafiek";
            this.PGgrafiek.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Gray;
            series1.BorderColor = System.Drawing.SystemColors.Control;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Gray;
            series1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.SystemColors.Control;
            series1.Legend = "Aantal Plaatsen";
            series1.Name = "Aantal parkeergarages";
            series1.YValuesPerPoint = 6;
            this.PGgrafiek.Series.Add(series1);
            this.PGgrafiek.Size = new System.Drawing.Size(1255, 576);
            this.PGgrafiek.TabIndex = 67;
            this.PGgrafiek.Text = "chart1";
            this.PGgrafiek.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataset_RotterdamDataSet1
            // 
            this.dataset_RotterdamDataSet1.DataSetName = "Dataset_RotterdamDataSet1";
            this.dataset_RotterdamDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "parking";
            this.parkingBindingSource.DataSource = this.dataset_RotterdamDataSet1;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(594, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Laad Gegevens";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grafiek_parkeergarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::appdesign.Properties.Resources.Grafiek;
            this.ClientSize = new System.Drawing.Size(1270, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PGgrafiek);
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
            this.Name = "Grafiek_parkeergarages";
            this.Text = "Grafiek_parkeergarages";
            this.Load += new System.EventHandler(this.Grafiek_parkeergarages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PGgrafiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_RotterdamDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Pgebied;
        private System.Windows.Forms.Label Pplaats;
        private System.Windows.Forms.Label Padres;
        private System.Windows.Forms.Label aantal_zitplaatsen;
        private System.Windows.Forms.Label Ptype;
        private System.Windows.Forms.Label naam;
        private System.Windows.Forms.DataVisualization.Charting.Chart PGgrafiek;
        private Dataset_RotterdamDataSet1 dataset_RotterdamDataSet1;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private Dataset_RotterdamDataSet1TableAdapters.parkingTableAdapter parkingTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}