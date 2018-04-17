using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpikeContainer.Spike_011___Current_Version
{
    public partial class XtraFormSpike011_CurrentVerrsion_Main : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormSpike011_CurrentVerrsion_Main()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SpikeContainer.Spike_011___Current_Version.XtraForm_Spike_011_Report_Current_Version frm = new XtraForm_Spike_011_Report_Current_Version();
            frm.Show(this);
        }
    }
}