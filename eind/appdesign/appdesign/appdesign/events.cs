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
    public partial class events : Form
    {
        static bool fisOpened = false;
        public events()
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
        }
        private void events_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fisOpened)
            {
                fisOpened = false;
            }
        }
    }
}
