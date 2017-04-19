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
    public partial class charging : Form
    {
        static bool fisOpened = false;
        public charging()
        {
            InitializeComponent();
        }

        private void charging_Load(object sender, EventArgs e)
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
        private void charging_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fisOpened)
            {
                fisOpened = false;
            }
        }
    }
}
