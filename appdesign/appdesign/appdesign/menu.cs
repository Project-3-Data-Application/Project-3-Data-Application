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
    public partial class Parkingscouting : Form
    {
        public Parkingscouting()
        {
            InitializeComponent();
        }
/*Bij het drukken van de knop "Parkeergarages" word de huidige formulier afgesloten en het keuzemenu voor de parkeergarages geopend*/
        private void parkingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Keuzemenu km = new Keuzemenu();
            km.Show();
        }
/*Bij het drukken van de knop "Oplaadpunten" word de huidige formulier afgesloten en het keuzemenu voor de elektrische oplaadpalen geopend*/
        private void chargingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EOSkm frm = new EOSkm();
            frm.Show();
        }
/*Bij het drukken van de knop "Toeristische Attracties" word de huidige formulier afgesloten en het formulier voor de Toeristische Attracties geopend*/
        private void eventbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TA TA = new TA();
            TA.Show();
        }

        private void instructionsbtn_Click(object sender, EventArgs e)
        {

        }

        private void creditsbtn_Click(object sender, EventArgs e)
        {

        }
/*Bij het drukken van de knop "Afluiten" word de Applicatie afgesloten*/
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Parkingscouting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            gmaptest gmap = new gmaptest();
            gmap.Show();
        }
    }
}
