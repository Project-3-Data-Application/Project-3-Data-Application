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
    public partial class EOSkm : Form
    {
        public EOSkm()
        {
            InitializeComponent();
        }
/*Bij het drukken van de knop "Oplaadpunten zoeken" word het huidige formulier afgesloten en het formulier voor het ophalen van de oplaadpunten geopend*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            EOP EOP = new EOP();
            EOP.Show();
        }
/*Bij het drukken van de knop "Hoofdmenu" word het huidige formulier afgesloten en het hoofdmenu geopend*/
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Parkingscouting PS = new Parkingscouting();
            PS.Show();
        }
/*Bij het drukken van de knop "Parkeergarages toevoegen" word het huidige formulier afgesloten en het formulier voor het toevoegen van nieuwe oplaadpunten geopend*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            EOPopslaan EOPopslaan = new EOPopslaan();
            EOPopslaan.Show();
        }

        private void EOSkm_Load(object sender, EventArgs e)
        {

        }
    }
}
