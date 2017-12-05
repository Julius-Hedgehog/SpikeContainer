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
    public partial class Spike001Main : Form
    {
        public Spike001Main()
        {
            InitializeComponent();

            this.tenKeypadControl1.Key07.Click += this.tenKeypadControl1Key7_Click;
        }


        private void tenKeypadControl1Key7_Click(object sender, EventArgs e)
        {
            int jeffe = 1;
            jeffe++;

            
        }
    }
}
