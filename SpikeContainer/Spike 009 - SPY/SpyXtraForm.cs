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

namespace SpikeContainer.Spike_009___SPY
{
    public partial class SpyXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public SpyXtraForm()
        {
            InitializeComponent();
        }

        private void SpyXtraForm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // ALL OPEN FOLDER DLG
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // START FILE WATCHER AT SELECTED LOCATION
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // STOP FILE WATCHER
        }
    }
}