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

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            {
                PGgrafiek.Series["Aantal parkeergarages"].Points.Clear();
                PGgrafiek.Visible = false;
                chart1.Series["Aantal plaatsen"].Points.Clear();
                chart1.Visible = false;

                using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = cmd.CommandText = "select distinct gebied from parking;";
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
                                        cmds.CommandText = "select count(gebied) from parking where gebied = '" + reader.GetString(0) + "';";
                                        Console.WriteLine("select count(gebied) from parking where name = '" + reader.GetString(0) + "';");
                                        using (var readers = cmds.ExecuteReader())
                                        {
                                            while (readers.Read())
                                            {
                                                this.PGgrafiek.Series["Aantal parkeergarages"].Points.AddXY(reader.GetString(0), readers.GetString(0));
                                                PGgrafiek.Visible = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            {
                PGgrafiek.Series["Aantal parkeergarages"].Points.Clear();
                PGgrafiek.Visible = false;
                chart1.Series["Aantal plaatsen"].Points.Clear();
                chart1.Visible = false;

                using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = cmd.CommandText = "select * from parking;";
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
                                        cmds.CommandText = "select aantal_plekken from parking where aantal_plekken = '" + reader.GetString(3) + "';";
                                        Console.WriteLine("select aantal_plekken from parking where aantal_plekken = '" + reader.GetString(3) + "';");
                                        using (var readers = cmds.ExecuteReader())
                                        {
                                            while (readers.Read())
                                            {
                                                chart1.Visible = true;
                                                chart1.Series["Aantal plaatsen"].Points.AddXY(reader.GetString(0), readers.GetString(0));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}