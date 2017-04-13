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
    public partial class Grafiek_parkeergarages : Form
    {
        public Grafiek_parkeergarages()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Grafiek_parkeergarages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_RotterdamDataSet1.parking' table. You can move, or remove it, as needed.
            this.parkingTableAdapter.Fill(this.dataset_RotterdamDataSet1.parking);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PGgrafiek.Series["Aantal parkeergarages"].Points.Clear();

            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from parking where \"NAME\" = '" + comboBox1.SelectedItem + "' or \"TYPE\" = '" + comboBox2.SelectedItem + "' or \"AANTAL_PLEKKEN\" = '" + comboBox3.SelectedItem + "' or \"ADRES\" = '" + comboBox4.SelectedItem + "' or \"PLAATS\" = '" + comboBox5.SelectedItem + "' or \"GEBIED\" = '" + comboBox6.SelectedItem + "';";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            using (var connx = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                            {
                                connx.Open();
                                using (var cmds = new NpgsqlCommand())
                                {
                                    cmds.Connection = connx;
                                    cmds.CommandText = "select count(\"GEBIED\") from parking where \"NAME\" = '" + reader.GetString(6) + "';";
                                    Console.WriteLine("select count(\"GEBIED\") from parking where \"NAME\" = '" + reader.GetString(6) + "';");
                                    using (var readers = cmds.ExecuteReader())
                                    {
                                        while (readers.Read())
                                        {
                                            using (var connxs = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                                            {
                                                connxs.Open();
                                                using (var cmdss = new NpgsqlCommand())
                                                {
                                                    cmdss.Connection = connxs;
                                                    cmdss.CommandText = "select distinct \"GEBIED\" from parking;";
                                                    Console.WriteLine("select distinct \"GEBIED\" from parking;");
                                                    using (var readerss = cmdss.ExecuteReader())
                                                    {
                                                        while (readerss.Read())
                                                        {
                                                            this.PGgrafiek.Series["Aantal parkeergarages"].Points.AddXY(readerss.GetString(0), readers.GetString(0));
                                                        }
                                                    }

                                                }
                                                /*   this.PGgrafiek.Series["Aantal parkeergarages"].Points.AddXY((comboBox6.Text), readers.GetString(0));
                                             */
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        /*this.PGgrafiek.Series["Aantal parkeergarages"].XValueMember = (reader.GetString(0));
                        PGgrafiek.DataSource = reader;
                        /*textBox1.Text += reader.GetString(0) + "\r\n";
                        textBox2.Text += reader.GetString(2) + "\r\n";
                        textBox3.Text += reader.GetString(3) + "\r\n";
                        textBox4.Text += reader.GetString(4) + "\r\n";
                        textBox5.Text += reader.GetString(5) + "\r\n";
                        textBox6.Text += reader.GetString(6) + "\r\n";*/
                        comboBox1.SelectedItem = null;
                        comboBox2.SelectedItem = null;
                        comboBox3.SelectedItem = null;
                        comboBox4.SelectedItem = null;
                        comboBox5.SelectedItem = null;
                        comboBox6.SelectedItem = null;
                        /*cmd.CommandText = "select count(\"GEBIED\") from parking where \"NAME\" = '" + comboBox1.SelectedItem + "' or \"TYPE\" = '" + comboBox2.SelectedItem + "' or \"AANTAL_PLEKKEN\" = '" + comboBox3.SelectedItem + "' or \"ADRES\" = '" + comboBox4.SelectedItem + "' or \"PLAATS\" = '" + comboBox5.SelectedItem + "' or \"GEBIED\" = '" + comboBox6.SelectedItem + "';";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                this.PGgrafiek.Series["Aantal parkeergarages"].Points.AddY(reader.GetString(0));
                                comboBox1.SelectedItem = null;
                                comboBox2.SelectedItem = null;
                                comboBox3.SelectedItem = null;
                                comboBox4.SelectedItem = null;
                                comboBox5.SelectedItem = null;
                                comboBox6.SelectedItem = null;
                            }
                        }*/
                    }
                }
            }
        }
    }
}
