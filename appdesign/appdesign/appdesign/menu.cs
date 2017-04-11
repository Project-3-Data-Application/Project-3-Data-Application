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

        private void parkingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Keuzemenu km = new Keuzemenu();
            km.Show();
        }

        private void chargingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EOSkm frm = new EOSkm();
            frm.Show();
        }

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
