using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpikeContainer.Spike_007_QAD_Implment_Utilities
{
    public partial class Spike007_Utitlity_001_XtraForm : DevExpress.XtraEditors.XtraForm
    {
        public Spike007_Utitlity_001_XtraForm()
        {
            InitializeComponent();
        }

        private void Spike007_Utitlity_001_XtraForm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int wOrderNum = 0;

            using (var db = new DataEntitiy.TestMesDbEntities())
            {
                db.WorkOrders.Where(r => r.WorkOrder == wOrderNum).Load();


            }
        }
    }
}