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
    public partial class Spike013XtraForm : DevExpress.XtraEditors.XtraForm
    {
        public Spike013XtraForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"In Spike 013 Main Form, and In Main Form Button Click Event Handler.", true);

            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"Leaving Spike 013 Main Form :: Main Form Button Click Event Handler.", true);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"In Spike 013 Main Form, and In Main Form Button Click Event Handler.", true);

            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"Leaving Spike 013 Main Form :: Main Form Button Click Event Handler.", true);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"In Spike 013 Main Form, and In Main Form Button Click Event Handler.", true);

            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"Leaving Spike 013 Main Form :: Main Form Button Click Event Handler.", true);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"In Spike 013 Main Form, and In Main Form Button Click Event Handler.", true);

            Program.ptmErrorLog.PTMErrorLogOutputMessage($@"Leaving Spike 013 Main Form :: Main Form Button Click Event Handler.", true);
        }
    }
}