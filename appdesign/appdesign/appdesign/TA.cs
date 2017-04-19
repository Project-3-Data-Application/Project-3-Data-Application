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

        private void ophalen_Click(object sender, EventArgs e)
        {
            {
                //Clears list
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                listBox6.Items.Clear();


                /*adres.Clear();
                plaats.Clear();
                attractie.Clear();
                tatb.Clear();
                gebied.Clear();
                openingstijdenTB.Clear();*/

                //Connects to PostGreSQL
                using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=a8mD1n7;Database=Dataset Rotterdam"))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
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
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //puts data in the lists
                                listBox1.Items.Add(reader.GetString(0));
                                listBox2.Items.Add(reader.GetString(1));
                                listBox3.Items.Add(reader.GetString(6));
                                listBox4.Items.Add(reader.GetString(4));
                                listBox5.Items.Add(reader.GetString(7));
                                listBox6.Items.Add(reader.GetString(8));

                                /*attractie.Text += reader.GetString(0) + "\r\n";
                                tatb.Text += reader.GetString(1) + "\r\n";
                                gebied.Text += reader.GetString(6) + "\r\n";
                                adres.Text += reader.GetString(4) + "\r\n";
                                plaats.Text += reader.GetString(7) + "\r\n";
                                openingstijdenTB.Text += reader.GetString(8) + "\r\n";*/

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

        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Vorige_Click(object sender, EventArgs e)
        {

        }

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            //Gmaps gm = new Gmaps();

            //Selected ID
            int id = listBox1.SelectedIndex;

            //Getting the google maps image
            //pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0, 0, 200, 329);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            //Gmaps gm = new Gmaps();

            //Selected ID
            int id = listBox2.SelectedIndex;

            //Getting the google maps image
            //pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0, 0, 200, 329);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            //Gmaps gm = new Gmaps();

            //Selected ID
            int id = listBox3.SelectedIndex;

            //Getting the google maps image
            //pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0, 0, 200, 329);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            //Gmaps gm = new Gmaps();

            //Selected ID
            int id = listBox4.SelectedIndex;

            //Getting the google maps image
            //pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0, 0, 200, 329);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            //Gmaps gm = new Gmaps();

            //Selected ID
            int id = listBox5.SelectedIndex;

            //Getting the google maps image
            //pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0, 0, 200, 329);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            Gmaps gm = new Gmaps();

            //Selected ID
            int id = listBox6.SelectedIndex;

            //Getting the google maps image
            //pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0, 0, 200, 329);

            //Select the row
            makeSelectFormRow(id);
        }

        private void makeSelectFormRow(int id)
        {
            //make the entire row seem selected
            if (listBox1.SelectedIndex != id)
            {
                listBox1.SetSelected(id, true);
            }
            if (listBox2.SelectedIndex != id)
            {
                listBox2.SetSelected(id, true);
            }
            if (listBox3.SelectedIndex != id)
            {
                listBox3.SetSelected(id, true);
            }
            if (listBox4.SelectedIndex != id)
            {
                listBox4.SetSelected(id, true);
            }
            if (listBox5.SelectedIndex != id)
            {
                listBox5.SetSelected(id, true);
            }
            if (listBox6.SelectedIndex != id)
            {
                listBox6.SetSelected(id, true);
            }
        }
    }
}
