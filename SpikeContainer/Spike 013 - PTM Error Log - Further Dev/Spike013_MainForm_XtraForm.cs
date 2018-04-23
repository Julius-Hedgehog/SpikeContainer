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

namespace SpikeContainer.Spike_013___PTM_Error_Log___Further_Dev
{
    public partial class Spike013_MainForm_XtraForm : DevExpress.XtraEditors.XtraForm
    {
        public Spike013_MainForm_XtraForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"In Spike 013 Main Form, and In Main Form Button Click Event Handler.", true);

            SpikeContainer.Spike_013___PTM_Error_Log___Further_Dev.Spike013XtraForm frm = new SpikeContainer.Spike_013___PTM_Error_Log___Further_Dev.Spike013XtraForm();
            frm.Show(this);

            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"Leaving Spike 013 Main Form :: Main Form Button Click Event Handler.", true);
        }
    }
}