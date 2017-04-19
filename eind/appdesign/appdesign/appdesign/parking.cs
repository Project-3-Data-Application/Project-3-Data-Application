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
    public partial class parking : Form
    {
        static bool fisOpened = false; //is form already open? then closes a duplicate
        public parking()
        {
            InitializeComponent();
        }

        private void parking_Load(object sender, EventArgs e)
        {
            if(!fisOpened)
            {
                fisOpened = true;
            }else
            {
                this.Dispose();
            }
        }
        private void parking_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(fisOpened)
            {
                fisOpened = false;
            }
        }
    }
}
