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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=a8mD1n7;Database=Dataset Rotterdam"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
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
                            textBox1.Text += reader.GetString(0) + "\r\n";
                            textBox2.Text += reader.GetString(1) + "\r\n";
                            textBox3.Text += reader.GetString(2) + "\r\n";
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
    }
}
