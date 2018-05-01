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

namespace SpikeContainer.Spike_Dev_Express_Grid
{
    public partial class XtraFormGridLearnThree : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormGridLearnThree()
        {
            InitializeComponent();
        }

        List<CodedEntity.WeightInGrid> _deWeightInGrid;

        private void XtraFormGridLearnThree_Load(object sender, EventArgs e)
        {
            _deWeightInGrid = new List<CodedEntity.WeightInGrid>();
            gridControl1.DataSource = _deWeightInGrid;
            _deWeightInGrid.Add(new CodedEntity.WeightInGrid(0,0,0));

            //gridView1.AddNewRow();

            //gridView1.AddNewRow();

            //gridView1.AddNewRow();

            //gridView1.AddNewRow();

            //gridView1.AddNewRow();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //gridView1.AddNewRow();

            //gridView1.AddNewRow();

            //gridView1.AddNewRow();

            //gridView1.AddNewRow();

            //gridView1.AddNewRow();
            _deWeightInGrid.Add(new CodedEntity.WeightInGrid(0, 0, 0));
        }
    }
}