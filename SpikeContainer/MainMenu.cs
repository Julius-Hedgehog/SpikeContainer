using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SpikeOne_Click(object sender, EventArgs e)
        {
            Spike_001.Spike001Main frm = new Spike_001.Spike001Main();
            frm.ShowDialog(this);

            frm.Dispose();
        }
    }
}
