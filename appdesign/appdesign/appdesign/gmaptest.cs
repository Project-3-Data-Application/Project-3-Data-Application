using Google.Maps;
using Google.Maps.StaticMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace appdesign
{
    public partial class gmaptest : Form
    {
        static bool fisOpened = false;
        public gmaptest()
        {
            InitializeComponent();
        }

        private void events_Load(object sender, EventArgs e)
        {
            if (!fisOpened)
            {
                fisOpened = true;
            }
            else
            {
                this.Dispose();
            }

            //Recieving data and show an Google Map image
            Gmaps gm = new Gmaps();
            pictureBox1.ImageLocation = gm.getGoogleMap("Buitenwatersloot 102, Delft", 52.0077271, 4.3496006);
        }
        private void events_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fisOpened)
            {
                fisOpened = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
