﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Google.Maps;
using Google.Maps.StaticMaps;
using appdesign;
using System.Globalization;
using System.Threading;

namespace DatabaseForm
{
    public partial class DatabaseFormOphalen : Form
    {
        //Declares lat long vars
        String[] latpos = new string[300];
        String[] longpos = new string[300];

        public DatabaseFormOphalen()
        {
            InitializeComponent();
        }

        private void ophalen_Click(object sender, EventArgs e)
        {
            //Clears list
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            //Connects to PostGreSQL
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=Oujdaoui#48;Database=Dataset Rotterdam"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    /*//Search for every combination gives
                    cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                    if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
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
                        /*De readerfunctie definieren voor de command die gegeven is voor postgreSQL
                        using (var reader = cmd.ExecuteReader())
                        {
                            var i = 0;
                            /*Waarden van de tabellen in postgres worden opgehaald
                            while (reader.Read())
                            {
                                /*De opgehaalde waarden vanuit postgreSQL worden in de te
                                listBox1.Items.Add(reader.GetString(0));
                                listBox2.Items.Add(reader.GetString(1));
                                listBox3.Items.Add(reader.GetString(2));
                                listBox4.Items.Add(reader.GetString(3));
                                listBox5.Items.Add(reader.GetString(4));
                                listBox6.Items.Add(reader.GetString(5));
                                //puts coordinates data in the arrays
                                latpos[i] = reader.GetString(6);
                                longpos[i] = reader.GetString(7);
                                i++;
                                comboBox1.SelectedItem = null;
                                comboBox2.SelectedItem = null;
                                comboBox3.SelectedItem = null;
                                comboBox4.SelectedItem = null;
                                comboBox5.SelectedItem = null;
                                comboBox6.SelectedItem = null;
                            }
                        }*/
                    cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                    if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
                    {
                        cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 + "or type = '" + comboBox2.SelectedItem + "' or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 + "and adres = '" + comboBox4.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 + "and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 + "and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal_plekken =" + comboBox3.SelectedItem + 0 + "and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "and type = '" + comboBox2.SelectedItem + "' or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + "or adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "or adres = '" + comboBox4.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "or adres = '" + comboBox4.SelectedItem + "' and gebied = '" + comboBox6.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        if (comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                        {
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal_plekken =" + comboBox3.SelectedItem + 0 + "and adres = '" + comboBox4.SelectedItem + "' or gebied = '" + comboBox6.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "';";
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            var i = 0;
                            while (reader.Read())
                            {
                                /*textBox1.Text += reader.GetString(0) + "\r\n";
                                textBox2.Text += reader.GetString(1) + "\r\n";
                                textBox3.Text += reader.GetString(2) + "\r\n";
                                textBox4.Text += reader.GetString(3) + "\r\n";
                                textBox5.Text += reader.GetString(4) + "\r\n";
                                textBox6.Text += reader.GetString(5) + "\r\n";*/
                                listBox1.Items.Add(reader.GetString(0));
                                listBox2.Items.Add(reader.GetString(1));
                                listBox3.Items.Add(reader.GetString(2));
                                listBox4.Items.Add(reader.GetString(3));
                                listBox5.Items.Add(reader.GetString(4));
                                listBox6.Items.Add(reader.GetString(5));
                                //puts coordinates data in the arrays
                                latpos[i] = reader.GetString(6);
                                longpos[i] = reader.GetString(7);
                                i++;
                                comboBox1.SelectedItem = null;
                                comboBox2.SelectedItem = null;
                                comboBox3.SelectedItem = null;
                                comboBox4.SelectedItem = null;
                                comboBox5.SelectedItem = null;
                                comboBox6.SelectedItem = null;
                            }/*
                            cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal plekken = " + comboBox3.SelectedItem + " or type = '" + comboBox2.SelectedItem + "' or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal plekken = " + comboBox3.SelectedItem + " and adres = '" + comboBox4.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal plekken = " + comboBox3.SelectedItem + " and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null && comboBox5.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal plekken = " + comboBox3.SelectedItem + " and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox2.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' and aantal plekken = " + comboBox3.SelectedItem + " and adres = '" + comboBox4.SelectedItem + "' and type = '" + comboBox2.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " and type = '" + comboBox2.SelectedItem + "' or adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " and type = '" + comboBox2.SelectedItem + "' and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' and plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " and adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " or adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "';";
                            }
                            if (comboBox4.SelectedItem != null && comboBox6.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " or adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox6.SelectedItem + "' or plaats = '" + comboBox5.SelectedItem + "';";
                            }
                            if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " or adres = '" + comboBox4.SelectedItem + "' and plaats = '" + comboBox6.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "';";

                            }
                            if (comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                            {
                                cmd.CommandText = "SELECT * FROM parking where name = '" + comboBox1.SelectedItem + "' or type = '" + comboBox2.SelectedItem + "' or aantal plekken = " + comboBox3.SelectedItem + " and adres = '" + comboBox4.SelectedItem + "' or plaats = '" + comboBox6.SelectedItem + "' and plaats = '" + comboBox5.SelectedItem + "';";
                            }
                            while (reader.Read())
                            {
                                //puts data in the lists
                                listBox1.Items.Add(reader.GetString(0));
                                listBox2.Items.Add(reader.GetString(1));
                                listBox3.Items.Add(reader.GetString(2));
                                listBox4.Items.Add(reader.GetString(3));
                                listBox5.Items.Add(reader.GetString(4));
                                listBox6.Items.Add(reader.GetString(5));
                                //puts coordinates data in the arrays
                                latpos[i] = reader.GetString(6);
                                longpos[i] = reader.GetString(7);

                                comboBox1.SelectedItem = null;
                                comboBox2.SelectedItem = null;
                                comboBox3.SelectedItem = null;
                                comboBox4.SelectedItem = null;
                                comboBox5.SelectedItem = null;
                                comboBox6.SelectedItem = null;

                                i++;

                            }
                        }*/
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image and make it so that doubles are translated with the dot
            Gmaps gm = new Gmaps();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");

            //Selected Text
            string name = listBox1.GetItemText(listBox1.SelectedItem);

            //Selected ID
            int id = listBox1.SelectedIndex;

            //Gathering more info
            string adress = listBox4.GetItemText(listBox4.Items[id]);
            string city = listBox5.GetItemText(listBox5.Items[id]);
            string citypart = listBox6.GetItemText(listBox6.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(name + "," + adress + "," + citypart + "," + city, Double.Parse(latpos[id]), Double.Parse(longpos[id]), 200, 316);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image and make it so that doubles are translated with the dot
            Gmaps gm = new Gmaps();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");

            //Selected ID
            int id = listBox2.SelectedIndex;

            //Selected Text
            string name = listBox1.GetItemText(listBox1.Items[id]);

            //Gathering more info
            string adress = listBox4.GetItemText(listBox4.Items[id]);
            string city = listBox5.GetItemText(listBox5.Items[id]);
            string citypart = listBox6.GetItemText(listBox6.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(name + "," + adress + "," + citypart + "," + city, Double.Parse(latpos[id]), Double.Parse(longpos[id]), 200, 316);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image and make it so that doubles are translated with the dot
            Gmaps gm = new Gmaps();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");

            //Selected ID
            int id = listBox3.SelectedIndex;

            //Selected Text
            string name = listBox3.GetItemText(listBox1.Items[id]);

            //Gathering more info
            string adress = listBox4.GetItemText(listBox4.Items[id]);
            string city = listBox5.GetItemText(listBox5.Items[id]);
            string citypart = listBox6.GetItemText(listBox6.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(name + "," + adress + "," + citypart + "," + city, Double.Parse(latpos[id]), Double.Parse(longpos[id]), 200, 316);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image and make it so that doubles are translated with the dot
            Gmaps gm = new Gmaps();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");

            //Selected ID
            int id = listBox4.SelectedIndex;

            //Selected Text
            string name = listBox1.GetItemText(listBox1.Items[id]);

            //Gathering more info
            string adress = listBox4.GetItemText(listBox4.Items[id]);
            string city = listBox5.GetItemText(listBox5.Items[id]);
            string citypart = listBox6.GetItemText(listBox6.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(name + "," + adress + "," + citypart + "," + city, Double.Parse(latpos[id]), Double.Parse(longpos[id]), 200, 316);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image and make it so that doubles are translated with the dot
            Gmaps gm = new Gmaps();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");

            //Selected ID
            int id = listBox5.SelectedIndex;

            //Selected Text
            string name = listBox1.GetItemText(listBox1.Items[id]);

            //Gathering more info
            string adress = listBox4.GetItemText(listBox4.Items[id]);
            string city = listBox5.GetItemText(listBox5.Items[id]);
            string citypart = listBox6.GetItemText(listBox6.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(name + "," + adress + "," + citypart + "," + city, Double.Parse(latpos[id]), Double.Parse(longpos[id]), 200, 316);

            //Select the row
            makeSelectFormRow(id);
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting our stuff ready, gmaps for google map image and make it so that doubles are translated with the dot
            Gmaps gm = new Gmaps();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");

            //Selected ID
            int id = listBox6.SelectedIndex;

            //Selected Text
            string name = listBox1.GetItemText(listBox1.Items[id]);

            //Gathering more info
            string adress = listBox4.GetItemText(listBox4.Items[id]);
            string city = listBox5.GetItemText(listBox5.Items[id]);
            string citypart = listBox6.GetItemText(listBox6.Items[id]);

            //Getting the google maps image
            pictureBox1.ImageLocation = gm.getGoogleMap(name + "," + adress + "," + citypart + "," + city, Double.Parse(latpos[id]), Double.Parse(longpos[id]), 200, 316);

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
            if (listBox4.SelectedIndex != id)
            {
                listBox4.SetSelected(id, true);
            }
            if (listBox5.SelectedIndex != id)
            {
                listBox5.SetSelected(id, true);
            }
            if (listBox6.SelectedIndex != id)
            {
                listBox6.SetSelected(id, true);
            }
        }
    }
}
