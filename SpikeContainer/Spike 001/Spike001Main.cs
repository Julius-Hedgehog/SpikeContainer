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
            Spike001V0 frm = new Spike001V0 { };

            frm.Show(this);
        }

        private void testBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spike001V1 frm = new Spike001V1 { };

            frm.Show(this);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Spike001V3_Grid0 frm = new Spike001V3_Grid0();

            frm.Show(this);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show(this);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
