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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM parking where \"NAME\" = '" + comboBox1.SelectedItem + "' or \"TYPE\" = '" + comboBox2.SelectedItem + "' or \"AANTAL_PLEKKEN\" = '" + comboBox3.SelectedItem + "' or \"ADRES\" = '" + comboBox4.SelectedItem + "' or \"PLAATS\" = '" + comboBox5.SelectedItem + "' or \"GEBIED\" = '" + comboBox6.SelectedItem + "';";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox1.Text += reader.GetString(1) + "\r\n";
                            textBox2.Text += reader.GetString(3) + "\r\n";
                            textBox3.Text += reader.GetString(4) + "\r\n";
                            textBox4.Text += reader.GetString(5) + "\r\n";
                            textBox5.Text += reader.GetString(6) + "\r\n";
                            textBox6.Text += reader.GetString(7) + "\r\n";
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
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    /*cmd.CommandText = "SELECT * FROM parking where \"NAME\" = '" + name.Text + "' or \"ADRES\" = '" + adres.Text + "' or \"TYPE\" = '" + type.Text + "' or \"GEBIED\" = '" + gebied.Text + "' or \"PLAATS\" = '" + plaats.Text + "';";
                    Console.WriteLine("SELECT * FROM parking where \"NAME\" = '" + name.Text + "' or \"ADRES\" = '" + adres.Text + "' or \"TYPE\" = '" + type.Text + "' or \"GEBIED\" = '" + gebied.Text + "' or \"PLAATS\" = '" + plaats.Text + "';");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name.Text = reader.GetString(1);
                            type.Text = reader.GetString(3);
                            aantal_plaatsen.Text = reader.GetString(4);
                            adres.Text = reader.GetString(5);
                            plaats.Text = reader.GetString(6);
                            gebied.Text = reader.GetString(7);
                        }
                    }*/
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
    }
}
