using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_003
{
    public partial class Spike0003_MainMenu : Form
    {
        public Spike0003_MainMenu()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Spike003Test001 frm = new Spike003Test001();
            frm.Show(this);
        }
    }
}
