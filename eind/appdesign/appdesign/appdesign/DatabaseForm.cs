﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace DatabaseForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void opslaan_Click(object sender, EventArgs e)
        {
            /*De blnfound functie zal worden gebruikt om te controleren of de primary keys al bestaan in de database*/
            bool blnfound = false;
            /*Er word een connectie gedefinieerd met de database*/
            NpgsqlConnection cnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam");
            /*De gedefinieerd database word geopend*/
            cnx.Open();
            /*De command word gedefinieerd*/
            NpgsqlCommand cmdCheck = new NpgsqlCommand("select * from parking where adres = '" + adres.Text + "' and name = '" + name.Text + "' and gebied = '" + gebied.Text + "' and type = '" + type.Text + "' and plaats = '" +  plaats.Text + "';", cnx);
            /*De waarden van de command worden ingelezen*/
            NpgsqlDataReader dr = cmdCheck.ExecuteReader();
            /*De boolError functie zal worden gebruikt om te controleren of de primary keys in de formulier zijn ingevuld*/
            bool boolError = false;
            if (adres.Text == "" || gebied.Text == "" || plaats.Text == "" || type.Text == "" || naam.Text == "")
            {
                boolError = true;
                MessageBox.Show("Vul alle velden correct in", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            if (dr.Read() && boolError == false)
            {
                blnfound = true;
                MessageBox.Show("Deze parkeergarage is al gerigstreerd", "LRDC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dr.Close();
                cnx.Close();
            }
            if (blnfound == false && boolError == false)
            {
                if (aantal_plaatsen.Text == "" && textBox2.Text == "" && Longit.Text == "")
                {
                    using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + 0 + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', " + textBox2.Text + 0.0 + ", " + Longit.Text + 0.0 + ");";
                            Console.WriteLine("insert into parking values('" + name.Text + "', '"  + type.Text + "' , '" + aantal_plaatsen.Text + "', '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', '" + textBox2.Text + "', '" + Longit.Text + "');");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            conn.Close();
                        }
                    }
                }
                if (aantal_plaatsen.Text == "")
                {
                    using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + 0 + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', " + textBox2.Text + ", " + Longit.Text + ");";
                            Console.WriteLine("insert into parking values('" + name.Text + "', '"  + type.Text + "' , '" + aantal_plaatsen.Text + "', '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', '" + textBox2.Text + "', '" + Longit.Text + "');");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            conn.Close();
                        }
                    }
                }
                if (textBox2.Text == "")
                {
                    using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', " + textBox2.Text + 0.0 + ", " + Longit.Text + ");";
                            Console.WriteLine("insert into parking values('" + name.Text + "', '"  + type.Text + "' , '" + aantal_plaatsen.Text + "', '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', '" + textBox2.Text + "', '" + Longit.Text + "');");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            conn.Close();
                        }
                    }
                }
                if (Longit.Text == "")
                {
                    using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', " + textBox2.Text + ", " + Longit.Text + 0.0 + ");";
                            Console.WriteLine("insert into parking values('" + name.Text + "', '"  + type.Text + "' , '" + aantal_plaatsen.Text + "', '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', '" + textBox2.Text + "', '" + Longit.Text + "');");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            conn.Close();
                        }
                    }
                }
                if (textBox2.Text == "" && Longit.Text == "")
                {
                    using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', " + textBox2.Text + 0.0 + ", " + Longit.Text + 0.0 + ");";
                            Console.WriteLine("insert into parking values('" + name.Text + "', '"  + type.Text + "' , '" + aantal_plaatsen.Text + "', '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', '" + textBox2.Text + "', '" + Longit.Text + "');");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            conn.Close();
                        }
                    }
                }
                if (textBox2.Text == "" && aantal_plaatsen.Text == "")
                {
                    using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + 0 + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', '" + textBox2.Text + 0.0 + ", " + Longit.Text + ");";
                            Console.WriteLine("insert into parking values('" + name.Text + "', '"  + type.Text + "' , '" + aantal_plaatsen.Text + 0 + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', '" + textBox2.Text + "', '" + Longit.Text + "');");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            conn.Close();
                        }
                    }
                }
                if (Longit.Text == "" && aantal_plaatsen.Text == "")
                {
                    using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + 0 + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', " + textBox2.Text + ", " + Longit.Text + 0.0 + ");";
                            Console.WriteLine("insert into parking values('" + name.Text + "', '"  + type.Text + "' , '" + aantal_plaatsen.Text + "', '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', '" + textBox2.Text + "', '" + Longit.Text + "');");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            conn.Close();
                        }
                    }
                }
                else
                {
                    using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', " + textBox2.Text + ", " + Longit.Text + ");";
                            Console.WriteLine("insert into parking values('" + name.Text + "', '"  + type.Text + "' , " + aantal_plaatsen.Text + ", '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "', " + textBox2.Text + ", " + Longit.Text + ");");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            conn.Close();
                        }
                    }
                }
            }
        }
        private void annuleren_Click(object sender, EventArgs e)
        {
            /*De Applicatie word gesloten bij het klikken van de knop "Afsluiten"*/
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ophalen_Click(object sender, EventArgs e)
        {
            /*De huidige formulier word gesloten en het keuzemenu word geopend bij het klikken van de knop "Vorige"*/
            this.Close();
            appdesign.Keuzemenu km = new appdesign.Keuzemenu();
            km.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*De huidige formulier word gesloten en het Hoofdmenu word geopend bij het klikken van de knop "Hoofdmenu"*/
            this.Close();
            appdesign.Parkingscouting PS = new appdesign.Parkingscouting();
            PS.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
