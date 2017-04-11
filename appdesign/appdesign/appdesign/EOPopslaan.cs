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
    public partial class EOPopslaan : Form
    {
        public EOPopslaan()
        {
            InitializeComponent();
        }

        private void EOPopslaan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_RotterdamDataSet.psa' table. You can move, or remove it, as needed.
            this.psaTableAdapter.Fill(this.dataset_RotterdamDataSet.psa);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            EOSkm km = new EOSkm();
            km.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Parkingscouting PS = new Parkingscouting();
            PS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool blnfound = false;
            NpgsqlConnection cnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432; User Id=postgres;Password=a8mD1n7;Database=Dataset Rotterdam");
            cnx.Open();
            NpgsqlCommand cmdCheck = new NpgsqlCommand("select * from PSA where adres = '" + adres_EOPopslaan.Text + "' and gebied = '" + gebied_EOPopslaan.Text + "' and plaats = '" + Plaats_EOPopslaan.Text + "';", cnx);
            NpgsqlDataReader dr = cmdCheck.ExecuteReader();
            bool boolError = false;
            if (adres_EOPopslaan.Text == null || adres_EOPopslaan.Text == "" || adres_EOPopslaan.Text == " " || gebied_EOPopslaan.Text == null || gebied_EOPopslaan.Text == "" || gebied_EOPopslaan.Text == " " || Plaats_EOPopslaan.Text == null || Plaats_EOPopslaan.Text == "" || Plaats_EOPopslaan.Text == " ")
            {
                boolError = true;
                MessageBox.Show("Vul alle velden correct in", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            if (dr.Read())
            {
                blnfound = true;
                MessageBox.Show("Dit oplaadpunt is al gerigstreerd", "LRDC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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
                        cmd.CommandText = "insert into PSA values('" + Plaats_EOPopslaan.Text + "', '" + gebied_EOPopslaan.Text + "', '" + adres_EOPopslaan.Text + "');";
                        Console.WriteLine("insert into PSA values('" + Plaats_EOPopslaan.Text + "', '" + gebied_EOPopslaan.Text + "', '" + adres_EOPopslaan.Text + "');");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Oplaadpunt is succesvol toegevoed aan de Database", "ParkingScouting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        conn.Close();
                    }
                }
            }
        }
    }
}
