using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_001
{
    public partial class Spike001V1 : Form
    {
        public Spike001V1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Spike One is a development test bed for the creation of a 'Numeric Keypad' control for touch screen usage.", "About: Spike One", MessageBoxButtons.OK);
        }
    }
}
