using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appdesign
{
    public partial class Keuzemenu : Form
    {
        public Keuzemenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseForm.DatabaseFormOphalen F2 = new DatabaseForm.DatabaseFormOphalen();
            F2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Parkingscouting PS = new Parkingscouting();
            PS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DatabaseForm.Form1 F1 = new DatabaseForm.Form1();
            F1.Show();

        }
    }
}
