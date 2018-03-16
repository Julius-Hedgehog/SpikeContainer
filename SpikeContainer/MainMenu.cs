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
    /// <summary>
    /// Main form and menu form of Spike Solution
    /// </summary>
    public partial class MainMenu : Form
    {
        //private int intDevBreakPointCrapper = 0;
        
        /// <summary>
        /// 
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        private void SpikeOne_Click(object sender, EventArgs e)
        {
            Spike_001.Spike001Main frm = new Spike_001.Spike001Main { };

            frm.Show(this);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Spike_Dev_Express_Grid.Spike_DEG_Form_001 frm = new Spike_Dev_Express_Grid.Spike_DEG_Form_001();

            frm.Show(this);
        }

        private void dexbtnSpike1Spur1_Click(object sender, EventArgs e)
        {
            Spike_001_SPUR_001.Spike001Spur001Main frm = new Spike_001_SPUR_001.Spike001Spur001Main();

            frm.Show(this);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        { // SPIKE 0003
            Spike_003.Spike0003_MainMenu frm = new Spike_003.Spike0003_MainMenu();

            frm.Show(this);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Spike_004.Form1 frm = new Spike_004.Form1();
            frm.Show(this);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Spike_005.Spike005Main frm = new Spike_005.Spike005Main();
            frm.Show(this);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // SPIKE SIX
            Spike_006.Spike_006_Main frm = new Spike_006.Spike_006_Main();
            frm.Show(this);
        }
    }
}
