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


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*De huidige formulier word gesloten bij het drukken van de knop "Sluiten"*/
            this.Close();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            {
                /*Alle openstaande grafieken worden gesloten en onzichtbaar gemaakt bij het selecteren van de button "Aantal parkeergarages per gebied"*/
                PGgrafiek.Series["Aantal parkeergarages"].Points.Clear();
                PGgrafiek.Visible = false;
                chart1.Series["Aantal plaatsen"].Points.Clear();
                chart1.Visible = false;

                /*De connectie naar de database in PostgreSQL word gedefinieerd"*/
                using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                {
                    /*De gedefinieerde connectie word geopend"*/
                    conn.Open();
                    /*De command word gedefinieerd*/
                    using (var cmd = new NpgsqlCommand())
                    {
                        /*De command die zal worden gegeven zal worden uitgevoerd in de Database waar een connectie mee is gemaakt*/
                        cmd.Connection = conn;
                        /*Querie word gemaakt zodat elk gebied maar eenmaal word weergeven"*/
                        cmd.CommandText = cmd.CommandText = "select distinct gebied from parking;";
                        /*De reader word gedefinieerd*/
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                /*Er word een nieuwe connectie naar de database in PostgreSQL gedefinieerd"*/
                                using (var connx = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                                {
                                    /*De gedefinieerde connectie word geopend"*/
                                    connx.Open();
                                    /*Een nieuwe command word gedefinieerd*/
                                    using (var cmds = new NpgsqlCommand())
                                    {
                                        /*De command die zal worden gegeven zal worden uitgevoerd in de Database waar een connectie mee is gemaakt*/
                                        cmds.Connection = connx;
                                        /*Querie zodat het aantal parkeergarages per gebied word weergeven"*/
                                        cmds.CommandText = "select count(gebied) from parking where gebied = '" + reader.GetString(0) + "';";
                                        Console.WriteLine("select count(gebied) from parking where name = '" + reader.GetString(0) + "';");
                                        /*Een nieuwe reader word gedefinieerd*/
                                        using (var readers = cmds.ExecuteReader())
                                        {
                                            while (readers.Read())
                                            {
                                                /*Waarden toevoegen aan de grafiek*/
                                                this.PGgrafiek.Series["Aantal parkeergarages"].Points.AddXY(reader.GetString(0), readers.GetString(0));
                                                /*Grafiek tonen*/
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
                /*Alle openstaande grafieken worden gesloten en onzichtbaar gemaakt bij het selecteren van de button "Aantal parkeerplaatsen per gebied"*/
                PGgrafiek.Series["Aantal parkeergarages"].Points.Clear();
                PGgrafiek.Visible = false;
                chart1.Series["Aantal plaatsen"].Points.Clear();
                chart1.Visible = false;
                /*De connectie naar de database in PostgreSQL word gedefinieerd"*/
                using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                {
                    /*De gedefinieerde connectie word geopend"*/
                    conn.Open();
                    /*De command word gedefinieerd*/
                    using (var cmd = new NpgsqlCommand())
                    {
                        /*De command die zal worden gegeven zal worden uitgevoerd in de Database waar een connectie mee is gemaakt*/
                        cmd.Connection = conn;
                        /*Querie word gemaakt zodat alle waarden van de table "parking" worden weergeven"*/
                        cmd.CommandText = cmd.CommandText = "select distinct gebied from parking;";
                        /*De reader word gedefinieerd*/
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                /*Een nieuwe connectie naar de database in PostgreSQL word gedefinieerd"*/
                                using (var connx = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
                                {
                                    /*De gedefinieerde connectie word geopend"*/
                                    connx.Open();
                                    /*Een nieuwe command word gedefinieerd*/
                                    using (var cmds = new NpgsqlCommand())
                                    {
                                        /*De command die zal worden gegeven zal worden uitgevoerd in de Database waar een connectie mee is gemaakt*/
                                        cmds.Connection = connx;
                                        /*Querie word gemaakt zodat het aantal parkeerplekken per garage van de table "parking" worden weergeven"*/
                                        cmds.CommandText = "select sum(aantal_plekken) from parking where gebied = '" + reader.GetString(0) + "';";
                                        Console.WriteLine("select sum(aantal_plekken) from parking where gebied = '" + reader.GetString(0) + "';");
                                        /*De reader word gedefinieerd*/
                                        using (var readers = cmds.ExecuteReader())
                                        {
                                            while (readers.Read())
                                            {
                                                /*De grafiek worden weergegeven en de waarden worden toegevoegd aan de grafie*/
                                                chart1.Series["Aantal plaatsen"].Points.AddXY(reader.GetString(0), readers.GetString(0));
                                                chart1.Visible = true;
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