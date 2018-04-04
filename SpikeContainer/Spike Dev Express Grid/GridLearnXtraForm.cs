using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SpikeContainer.Spike_Dev_Express_Grid;
using SpikeContainer.Spike_Dev_Express_Grid.CodedEntity;
using SpikeContainer.Spike_Dev_Express_Grid.Data;

namespace SpikeContainer.Spike_Dev_Express_Grid
{
    public partial class GridLearnXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public GridLearnXtraForm()
        {
            InitializeComponent();
        }

        List<Weights> _wEights = new List<Weights>();
        List<WeightInGrid> _wIg = new List<WeightInGrid>();
        List<GridWeightData> _gWd = new List<GridWeightData>();

        #region [ FORM EVENT HANDLERS ]

        private void GridLearnXtraForm_Load(object sender, EventArgs e)
        {
            Trace.WriteLine($@"private void GridLearnXtraForm_Load(object sender, EventArgs e)");
        }

        private void GridLearnXtraForm_Shown(object sender, EventArgs e)
        {
            Trace.WriteLine($@"private void GridLearnXtraForm_Shown(object sender, EventArgs e)");

            InitializeData();

            gridControl3.DataSource = _wEights;
            //gridControl3.DataMember = "Weights";

            gridControl2.DataSource = _gWd;
            //gridControl2.DataMember = "GridWeightData";

            gridControl1.DataSource = _wIg;
            //gridControl1.DataMember = "WeightInGrid";
        }


        private void GridLearnXtraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trace.WriteLine($@"private void GridLearnXtraForm_FormClosing(object sender, FormClosingEventArgs e)");

            int nJeffe = 0;
            nJeffe++;
        }

        #endregion

        #region [ GRID THREE (3) ]

        private void gridView3_KeyDown(object sender, KeyEventArgs e)
        {
            Trace.WriteLine($@"private void gridView3_KeyDown(object sender, KeyEventArgs e)");
        }

        private void gridView3_ShownEditor(object sender, EventArgs e)
        {
            Trace.WriteLine($@"private void gridView3_ShownEditor(object sender, EventArgs e)");
        }

        private void gridView3_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            Trace.WriteLine($@"private void gridView3_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)");
        }

        private void gridView3_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            Trace.WriteLine($@"private void gridView3_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)");
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Trace.WriteLine($@"private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)");
        }

        private void gridView3_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Trace.WriteLine($@"private void gridView3_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)");
        }

        #endregion




        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            Trace.WriteLine($@"private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)");
        }


















        private void InitializeData()
        {
            Trace.WriteLine($@"");

            _wEights.Add(new Weights(0, 0, 0));

            _wIg.Add(new WeightInGrid(0, 0, 0));

            _gWd.Add(new GridWeightData(0, 0, 0));
        }


    }
}