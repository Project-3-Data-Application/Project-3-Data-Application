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

        private void button4_Click(object sender, EventArgs e)
        {
            //Clears list
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            //Connects to PostGreSQL
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=a8mD1n7;Database=Dataset Rotterdam"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    //Search for every combination given
                    cmd.CommandText = "SELECT * FROM PSA where Adres = '" + comboBox1.SelectedItem + "' or gebied = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox3.SelectedItem + "';";
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
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            Parkingscouting PS = new Parkingscouting();
            PS.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
