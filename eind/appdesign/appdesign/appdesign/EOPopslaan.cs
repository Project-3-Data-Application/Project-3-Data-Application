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

        }
/*De huidige formulier word gesloten en het keuzemenu word geopend bij het klikken van de knop "Vorige"*/
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            EOSkm km = new EOSkm();
            km.Show();
        }
/*De huidige formulier word gesloten en het Hoofdmenu word geopend bij het klikken van de knop "Hoofdmenu"*/
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Parkingscouting PS = new Parkingscouting();
            PS.Show();
        }
/*De Applicatie word gesloten bij het klikken van de knop "Afsluiten"*/
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
/*De ingevulde gegevens worden opgeslagen in de database bij het klikken van de knop "Gegevens Opslaan"*/
        private void button1_Click(object sender, EventArgs e)
        {
            /*De blnfound functie word gebruikt om te controleren of de primary keys al bestaan in de database*/
            bool blnfound = false;
            /*De connectie met de database word gedefinieerd*/
            NpgsqlConnection cnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam");
            /*De gedefinieerde connectie met de database word geopend*/
            cnx.Open();
            /*De command word gedefinieerd. Hiermee worden alle gegevens opgehaald uit de database*/
            NpgsqlCommand cmdCheck = new NpgsqlCommand("select * from PSA where adres = '" + adres_EOPopslaan.Text + "' and gebied = '" + gebied_EOPopslaan.Text + "' and plaats = '" + Plaats_EOPopslaan.Text + "';", cnx);
            /*De reader word gedefinieerd*/
            NpgsqlDataReader dr = cmdCheck.ExecuteReader();
            /*De boolerrorfunctie controleerd of alle velden wel zijn ingevuld*/
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
