using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace SpikeContainer.Spike_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Int32 n32Jeffe = 1;
            n32Jeffe++;
            Trace.WriteLine("garbage in textBox1_KeyDown");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 n32Jeffe = 1;
            n32Jeffe++;
            Trace.WriteLine("filth in textBox1_KeyPress");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Int32 n32Jeffe = 1;
            n32Jeffe++;
            Trace.WriteLine("refuse in textBox1_KeyPress");
        }
    }
}
