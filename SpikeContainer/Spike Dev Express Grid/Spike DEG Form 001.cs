using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_Dev_Express_Grid
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Spike_DEG_Form_001 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Spike_DEG_Form_001()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Spike_Dev_Express_Grid.DEG_Example_001 frm = new DEG_Example_001 { };
            frm.Show(this);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Spike_Dev_Express_Grid.GridLearnXtraForm frm = new GridLearnXtraForm { };
            frm.Show(this);
        }
    }
}
