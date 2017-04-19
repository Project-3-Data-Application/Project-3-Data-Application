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
/*Bij het drukken van de knop "Parkeergarages zoeken" word het huidige formulier afgesloten en het formulier voor het ophalen van de parkeergarages geopend*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseForm.DatabaseFormOphalen F2 = new DatabaseForm.DatabaseFormOphalen();
            F2.Show();
        }
/*Bij het drukken van de knop "Hoofdmenu" word het huidige formulier afgesloten en het hoofdmenu geopend*/
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Parkingscouting PS = new Parkingscouting();
            PS.Show();
        }
/*Bij het drukken van de knop "Parkeergarages toevoegen" word het huidige formulier afgesloten en het formulier voor het invoeren van nieuwe parkeergarages geopend*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DatabaseForm.Form1 F1 = new DatabaseForm.Form1();
            F1.Show();

        }
    }
}
