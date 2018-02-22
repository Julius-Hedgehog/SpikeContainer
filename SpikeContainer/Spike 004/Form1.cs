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

namespace SpikeContainer.Spike_004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Trace.WriteLine(e.FullPath);
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Trace.WriteLine(e.FullPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = true;
            label3.Text = "Watching Selected Watching Path.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog(this))
            {
                fileSystemWatcher1.Path = folderBrowserDialog1.SelectedPath;
                label2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = false;
            label3.Text = "";
        }
    }
}
