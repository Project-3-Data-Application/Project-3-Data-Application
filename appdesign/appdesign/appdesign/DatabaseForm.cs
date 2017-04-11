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
using System.Timers;


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
            bool blnfound = false;
            NpgsqlConnection cnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432; User Id=postgres;Password=a8mD1n7;Database=Dataset Rotterdam");
            cnx.Open();
            NpgsqlCommand cmdCheck = new NpgsqlCommand("select * from parking where \"ADRES\" = '" + adres.Text + "' and \"PLAATS\" = '" + plaats.Text + "';", cnx);
            NpgsqlDataReader dr = cmdCheck.ExecuteReader();
            bool boolError = false;
            if (adres.Text == null || adres.Text == "" || adres.Text == " " || gebied.Text == null || gebied.Text == "" || gebied.Text == " " || plaats.Text == null || plaats.Text == "" || plaats.Text == " " || type.Text == null || type.Text == "" || type.Text == " " || naam.Text == null || naam.Text == "" || naam.Text == " ")
            {
                boolError = true;
                MessageBox.Show("Vul alle velden correct in", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            if (dr.Read())
            {
                blnfound = true;
                MessageBox.Show("Deze parkeergarage is al gerigstreerd", "LRDC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                dr.Close();
                cnx.Close();
            }
            if (blnfound == false && boolError == false)
            {
                using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "insert into parking values('" + name.Text + "', '" + code.Text + "' , '" + type.Text + "' , '" + aantal_plaatsen.Text + "', '"+ adres.Text + "', '"+ plaats.Text + "', '" + gebied.Text + "');";
                        Console.WriteLine("insert into parking values('" + name.Text + "', '" + code.Text + "' , '" + type.Text + "' , '" + aantal_plaatsen.Text + "', '" + adres.Text + "', '" + plaats.Text + "', '" + gebied.Text + "');"); 
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Parkeergarage is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        conn.Close();
                    }
                }
            }
        }

        private void annuleren_Click(object sender, EventArgs e)
        {
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
            this.Close();
            appdesign.Parkingscouting PS = new appdesign.Parkingscouting();
            PS.Show();
        }
    }
}
