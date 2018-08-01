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

using SpikeContainer;
using SpikeContainer.DataEntitiy;


namespace SpikeContainer.SPIKE_014___Testing_WorkOrders
{
    public partial class XtraFormSearchFindOpenWorkOrders : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormSearchFindOpenWorkOrders()
        {
            InitializeComponent();
        }

        private void XtraFormSearchFindOpenWorkOrders_Load(object sender, EventArgs e)
        {

        }

        private void XtraFormSearchFindOpenWorkOrders_Shown(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var db = new SpikeContainer.DataEntitiy.TestMesDbEntities())
            {

            }
        }
    }
}