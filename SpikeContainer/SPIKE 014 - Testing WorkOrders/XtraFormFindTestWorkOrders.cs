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

namespace SpikeContainer.SPIKE_014___Testing_WorkOrders
{
    public partial class XtraFormFindTestWorkOrders : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormFindTestWorkOrders()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SpikeContainer.SPIKE_014___Testing_WorkOrders.XtraFormSearchFindOpenWorkOrders frm = new XtraFormSearchFindOpenWorkOrders();
            frm.Show(this);
        }
    }
}