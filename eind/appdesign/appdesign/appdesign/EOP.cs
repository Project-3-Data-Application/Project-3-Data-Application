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
    public partial class EOP : Form
    {
        public EOP()
        {
            InitializeComponent();
        }

        private void EOP_Load(object sender, EventArgs e)
        {

        }
/*Bij het drukken van de knop "Gegevens Ophalen" worden de opgevraagde gegevens opgehaald uit de database*/
        private void button4_Click(object sender, EventArgs e)
        {
            /*Bij het drukken van de knop "Gegevens Ophalen" worden de textboxes geleegd*/
/*            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            /*Hier word een connectie gedefinieerd met de database*/
/*            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))*/
            //Clears list
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            //Connects to PostGreSQL
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
            {
                /*De gedefinieerde connectie word geopend*/
                conn.Open();
                /*Een definitie voor een command word gecreerd*/
                using (var cmd = new NpgsqlCommand())
                {
                    /*De command om de gedefinieerde connectie te openen*/
                    cmd.Connection = conn;
                    /*De command is om een querie te schrijven om alle gegevens op te halen aan de hand van de geselecteerde combobox*/

                    //Search for every combination given
                    cmd.CommandText = "SELECT * FROM PSA where Adres = '" + comboBox1.SelectedItem + "' or gebied = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox3.SelectedItem + "';";
                    /*Hieronder komen alle if statements om te de juiste gegevens op te halen indien er meerdere comboboxen worden gebruikt*/
                    if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                    {
                        cmd.CommandText = "SELECT * FROM PSA where Adres = '" + comboBox1.SelectedItem + "' and gebied = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox3.SelectedItem + "';";
                    }
                    if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
                    {
                        cmd.CommandText = "SELECT * FROM PSA where Adres = '" + comboBox1.SelectedItem + "' and gebied = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox3.SelectedItem + "';";
                    }
                    if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
                    {
                        cmd.CommandText = "SELECT * FROM PSA where Adres = '" + comboBox1.SelectedItem + "' or gebied = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox3.SelectedItem + "';";
                    }
                    if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
                    {
                        cmd.CommandText = "SELECT * FROM PSA where Adres = '" + comboBox1.SelectedItem + "' and plaats = '" + comboBox3.SelectedItem + "' or gebied = '" + comboBox2.SelectedItem + "';";
                    }
                    /*De opgevraagde gegevens in de database worden gelezen*/
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            /*De gelezen gegevens uit de database worden opgehaald en geplaatst in de juiste textboxen
                            textBox1.Text += reader.GetString(0) + "\r\n";
                            textBox2.Text += reader.GetString(1) + "\r\n";
                            textBox3.Text += reader.GetString(2) + "\r\n";
                            /*De comboboxen worden geleegd zodat de user een nieuwe zoekactie kan verrichten*/
                            //puts data in the lists
                            listBox1.Items.Add(reader.GetString(0));
                            listBox2.Items.Add(reader.GetString(1));
                            listBox3.Items.Add(reader.GetString(2));
                            comboBox1.SelectedItem = null;
                            comboBox2.SelectedItem = null;
                            comboBox3.SelectedItem = null;
                        }
                    }
                }
            }
        }
/*Bij het drukken van de knop "Hoofdmenu" word het hoofdmenu weergegeven en de huidige formulier gesloten*/
        private void button2_Click(object sender, EventArgs e)
        {
            Parkingscouting PS = new Parkingscouting();
            PS.Show();
            this.Close();
        }
/*Bij het drukken van de knop "Afsluiten" word de applicatie gesloten*/
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 /*Bij het drukken van de knop "Vorige" word het keuzemenu weergegeven en de huidige formulier gesloten*/
        private void button1_Click(object sender, EventArgs e)
        {
            EOSkm EOSkm = new EOSkm();
            EOSkm.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            Gmaps gm = new Gmaps();
            
            //Selected Text
            string city = listBox1.GetItemText(listBox1.SelectedItem);

            //Selected ID
            int id = listBox1.SelectedIndex;

            //Gathering more info
            string citypart = listBox2.GetItemText(listBox2.Items[id]);
            string adress = listBox3.GetItemText(listBox3.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0,0, 200, 329);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            Gmaps gm = new Gmaps();
            
            //Selected ID
            int id = listBox2.SelectedIndex;

            //Gathering more info
            string city = listBox1.GetItemText(listBox1.Items[id]);
            string citypart = listBox2.GetItemText(listBox2.Items[id]);
            string adress = listBox3.GetItemText(listBox3.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0, 0, 200, 329);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image functions
            Gmaps gm = new Gmaps();

            //Selected ID
            int id = listBox3.SelectedIndex;

            //Gathering more info
            string city = listBox1.GetItemText(listBox1.Items[id]);
            string citypart = listBox2.GetItemText(listBox2.Items[id]);
            string adress = listBox3.GetItemText(listBox3.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(adress + "," + citypart + "," + city, 0, 0, 200, 329);

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
        }
    }
}
