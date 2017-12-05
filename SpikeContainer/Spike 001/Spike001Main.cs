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
    /// <summary>
    /// 
    /// </summary>
    public partial class Spike001Main : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Spike001Main()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Spike One is a development test bed for the creation of a 'Numeric Keypad' control for touch screen usage.", "About: Spike One", MessageBoxButtons.OK);
        }

        private void testAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
