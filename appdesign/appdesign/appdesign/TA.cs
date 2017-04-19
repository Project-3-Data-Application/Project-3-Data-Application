using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace appdesign
{
    public partial class TA : Form
    {
        public TA()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /*Bij het drukken van de knop "Gegevens Ophalen" worden de opgevraagde gegevens opgehaald uit de database*/
        private void ophalen_Click(object sender, EventArgs e)
        {
            {
                /*Bij het drukken van de knop "Gegevens Ophalen" worden alle textboxen leeggehaald*/
                adres.Clear();
                plaats.Clear();
                attractie.Clear();
                tatb.Clear();
                gebied.Clear();
                openingstijdenTB.Clear();
                /*Een nieuwe connectie word gedefineerd met de database*/
                using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                {
                    /*De gedefinieerde connectie met de database word geopend*/
                    conn.Open();
                    /*Een nieuwe command word gedefinieerd*/
                    using (var cmd = new NpgsqlCommand())
                    {
                        /*De command om de gedefinieerde connectie te openen*/
                        cmd.Connection = conn;
                        /*De command is om een querie te schrijven om alle gegevens op te halen aan de hand van de geselecteerde combobox*/
                        cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "' or tijden = '" + OpeningCB.SelectedItem + "' or tijden = '" + OpeningCB.SelectedItem + "*';";
                        /*Hieronder komen alle if statements om te de juiste gegevens op te halen indien er meerdere comboboxen worden gebruikt*/
                        if (BedektCB.SelectedItem != null && ReserverenCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (BedektCB.SelectedItem != null && TACB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (BedektCB.SelectedItem != null && TACB.SelectedItem != null && ReserverenCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (BedektCB.SelectedItem != null && TACB.SelectedItem != null && ReserverenCB.SelectedItem != null && GebiedCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' and Onderwerp = '" + TACB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (BedektCB.SelectedItem != null && TACB.SelectedItem != null && ReserverenCB.SelectedItem != null && GebiedCB.SelectedItem != null && PlaatsCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' and Onderwerp = '" + TACB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' and plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (AttractieCB.SelectedItem != null && BedektCB.SelectedItem != null && TACB.SelectedItem != null && ReserverenCB.SelectedItem != null && GebiedCB.SelectedItem != null && PlaatsCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' and gebied = '" + GebiedCB.SelectedItem + "' and Onderwerp = '" + TACB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' and plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (AttractieCB.SelectedItem != null && BedektCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (AttractieCB.SelectedItem != null && BedektCB.SelectedItem != null && ReserverenCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (AttractieCB.SelectedItem != null && BedektCB.SelectedItem != null && TACB.SelectedItem != null && ReserverenCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' and Onderwerp = '" + TACB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (AttractieCB.SelectedItem != null && BedektCB.SelectedItem != null && TACB.SelectedItem != null && ReserverenCB.SelectedItem != null && GebiedCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' and Onderwerp = '" + TACB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' and gebied = '" + GebiedCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (AttractieCB.SelectedItem != null && BedektCB.SelectedItem != null && TACB.SelectedItem != null && ReserverenCB.SelectedItem != null && GebiedCB.SelectedItem != null && PlaatsCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' and Onderwerp = '" + TACB.SelectedItem + "' and Bedekt = '" + BedektCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' and gebied = '" + GebiedCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (TACB.SelectedItem != null && ReserverenCB.SelectedItem != null && GebiedCB.SelectedItem != null && PlaatsCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' and Onderwerp = '" + TACB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' and plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (TACB.SelectedItem != null && ReserverenCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (TACB.SelectedItem != null && ReserverenCB.SelectedItem != null && PlaatsCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' and plaats = '" + PlaatsCB.SelectedItem + "';";
                        }
                        if (TACB.SelectedItem != null && GebiedCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' and Onderwerp = '" + TACB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "';";
                        }
                        if (GebiedCB.SelectedItem != null && ReserverenCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' and Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "';";
                        }
                        if (PlaatsCB.SelectedItem != null && ReserverenCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' and plaats = '" + PlaatsCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "';";
                        }
                        if (PlaatsCB.SelectedItem != null && GebiedCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "' and gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "';";
                        }
                        if (PlaatsCB.SelectedItem != null && GebiedCB.SelectedItem != null && ReserverenCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' and plaats = '" + PlaatsCB.SelectedItem + "' and gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "';";
                        }
                        if (BedektCB.SelectedItem != null && GebiedCB.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' and gebied = '" + GebiedCB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "';";
                        }
                        /*De opgevraagde gegevens in de database worden gelezen*/
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                /*De gelezen gegevens worden opgehaald en geplaats in de juiste textbox*/
                                attractie.Text += reader.GetString(0) + "\r\n";
                                tatb.Text += reader.GetString(1) + "\r\n";
                                gebied.Text += reader.GetString(6) + "\r\n";
                                adres.Text += reader.GetString(4) + "\r\n";
                                plaats.Text += reader.GetString(7) + "\r\n";
                                openingstijdenTB.Text += reader.GetString(8) + "\r\n";
                                /*Alle comboboxen worden leeggehaald voor een nieuwe zoekactie van de user*/
                                AttractieCB.SelectedItem = null;
                                TACB.SelectedItem = null;
                                GebiedCB.SelectedItem = null;
                                PlaatsCB.SelectedItem = null;
                                ReserverenCB.SelectedItem = null;
                                BedektCB.SelectedItem = null;
                            }
                        }
                    }
                }
            }

        }
/*Bij het drukken van de knop "Afsluiten" word de applicatie afgesloten*/
        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Vorige_Click(object sender, EventArgs e)
        {

        }
/*Bij het drukken van de knop "Hoofdmenu" word de huidige formulier afgesloten en het hoofdmenu geopend*/
        private void Hoofdmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Parkingscouting PS = new Parkingscouting();
            PS.Show();
        }

        private void PlaatsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AttractieCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TACB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GebiedCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BedektCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openingstijdenTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void plaats_TextChanged(object sender, EventArgs e)
        {

        }

        private void adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void gebied_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
