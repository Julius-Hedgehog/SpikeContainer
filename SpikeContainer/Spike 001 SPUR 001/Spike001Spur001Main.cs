﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_001_SPUR_001
{
    public partial class Spike001Spur001Main : Form
    {
        public Spike001Spur001Main()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Spike001Spur001_Grid frm = new Spike001Spur001_Grid();
            frm.ShowDialog(this);
        }
    }
}
