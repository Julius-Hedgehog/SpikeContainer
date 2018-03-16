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
    public partial class DEG_Example_001 : Form
    {
        public DEG_Example_001()
        {
            InitializeComponent();
        }

        private void DEG_Example_001_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testMesDbDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.testMesDbDataSet.Packages);
            // TODO: This line of code loads data into the 'testMesDbDataSet.Packages' table. You can move, or remove it, as needed.
            this.pkgHistTableAdapter1.Fill(this.testMesDbDataSet.PkgHist);
            this.locationsTableAdapter1.Fill(this.testMesDbDataSet.Locations);
            this.workOrdersTableAdapter1.Fill(this.testMesDbDataSet.WorkOrders);
            this.warehousesTableAdapter1.Fill(this.testMesDbDataSet.Warehouses);
            this.statusTableAdapter1.Fill(this.testMesDbDataSet.Status);

        }
    }
}
