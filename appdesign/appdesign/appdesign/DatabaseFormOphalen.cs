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

namespace DatabaseForm
{
    public partial class DatabaseFormOphalen : Form
    {
        public DatabaseFormOphalen()
        {
            InitializeComponent();
        }

        private void ophalen_Click(object sender, EventArgs e)
        {
            /*Hierdoor worden alle textboxen leeggehaald bij een volgende zoekopdracht*/
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            /*Een connectie maken met de database van postgres*/
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
            {
                /*Connectie openen*/
                conn.Open();
                /*Een Command definieren in postgres*/
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    /*Hierdoor worden verschillende comboboxitems gecombineerd*/
                    if (comboBox3.SelectedItem != null)
                    {
                        cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + "or type = '" + comboBox2.SelectedItem + "' or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and type = '" + comboBox2.SelectedItem + "' or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "or adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "or adres = '" + comboBox4.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "or adres = '" + comboBox4.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        if (comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        /*De readerfunctie definieren voor de command die gegeven is voor postgreSQL*/
                        using (var reader = cmd.ExecuteReader())
                        {
                            /*Waarden van de tabellen in postgres worden opgehaald*/
                            while (reader.Read())
                            {
                                /*De opgehaalde waarden vanuit postgreSQL worden in de te*/
                                textBox1.Text += reader.GetString(0) + "\r\n";
                                textBox2.Text += reader.GetString(1) + "\r\n";
                                textBox3.Text += reader.GetString(2) + "\r\n";
                                textBox4.Text += reader.GetString(3) + "\r\n";
                                textBox5.Text += reader.GetString(4) + "\r\n";
                                textBox6.Text += reader.GetString(5) + "\r\n";
                                comboBox1.SelectedItem = null;
                                comboBox2.SelectedItem = null;
                                comboBox3.SelectedItem = null;
                                comboBox4.SelectedItem = null;
                                comboBox5.SelectedItem = null;
                                comboBox6.SelectedItem = null;
                            }
                        }
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 +"or type = '" + comboBox2.SelectedItem + "' or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 +"and adres = '" + comboBox4.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 +"and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 +"and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 +"and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"and type = '" + comboBox2.SelectedItem + "' or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken ='" + comboBox3.SelectedItem + "'and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken ='" + comboBox3.SelectedItem + "'or adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"or adres = '" + comboBox4.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"or adres = '" + comboBox4.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        if (comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 +"and adres = '" + comboBox4.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                textBox1.Text += reader.GetString(0) + "\r\n";
                                textBox2.Text += reader.GetString(1) + "\r\n";
                                textBox3.Text += reader.GetString(2) + "\r\n";
                                textBox4.Text += reader.GetString(3) + "\r\n";
                                textBox5.Text += reader.GetString(4) + "\r\n";
                                textBox6.Text += reader.GetString(5) + "\r\n";
                                comboBox1.SelectedItem = null;
                                comboBox2.SelectedItem = null;
                                comboBox3.SelectedItem = null;
                                comboBox4.SelectedItem = null;
                                comboBox5.SelectedItem = null;
                                comboBox6.SelectedItem = null;
                            }
                        }
                    }
                }
            }
        }

        private void DatabaseFormOphalen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_RotterdamDataSet.parking' table. You can move, or remove it, as needed.

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void annuleren_Click(object sender, EventArgs e)
        {
            this.Close();
            appdesign.Keuzemenu km = new appdesign.Keuzemenu();
            km.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            appdesign.Parkingscouting PS = new appdesign.Parkingscouting();
            PS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appdesign.Grafiek_parkeergarages GP = new appdesign.Grafiek_parkeergarages();
            GP.Show();
        }
    }
}
