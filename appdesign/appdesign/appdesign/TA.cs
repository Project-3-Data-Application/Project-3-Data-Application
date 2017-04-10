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
                adres.Clear();
                plaats.Clear();
                attractie.Clear();
                tatb.Clear();
                gebied.Clear();
                openingstijdenTB.Clear();
                using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM Toeristische_Attracties where Toeristische_Attractie = '" + AttractieCB.SelectedItem + "' or gebied = '" + GebiedCB.SelectedItem + "' or Onderwerp = '" + TACB.SelectedItem + "' or Bedekt = '" + BedektCB.SelectedItem + "' or Reserveren_verplicht = '" + ReserverenCB.SelectedItem + "' or plaats = '" + PlaatsCB.SelectedItem + "';";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                attractie.Text += reader.GetString(0) + "\r\n";
                                tatb.Text += reader.GetString(1) + "\r\n";
                                gebied.Text += reader.GetString(6) + "\r\n";
                                adres.Text += reader.GetString(4) + "\r\n";
                                plaats.Text += reader.GetString(7) + "\r\n";
                                openingstijdenTB.Text += reader.GetString(8) + "\r\n";
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
    }
}
