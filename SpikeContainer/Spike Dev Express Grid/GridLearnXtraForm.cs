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

        List<WeightInGrid> _gWd = new List<WeightInGrid>();
        //List<GridWeightData> _gWd = new List<GridWeightData>();

        private BaseEdit _deXEdit;//----------------    -   -   -  -The Indicator IF and Active Editor is selected in the DevExpress GridView


        List<DevExpress.XtraGrid.Columns.GridColumn> _clms;

        #region [ FORM EVENT HANDLERS ]

        private void GridLearnXtraForm_Load(object sender, EventArgs e)
        {
            Trace.WriteLine($@"private void GridLearnXtraForm_Load(object sender, EventArgs e)");


            InitializeData();
            gridControl2.DataSource = _gWd;
        }

        private void GridLearnXtraForm_Shown(object sender, EventArgs e)
        {
            Trace.WriteLine($@"private void GridLearnXtraForm_Shown(object sender, EventArgs e)");
            gridView2.IndicatorWidth = 30;
            
            _clms = gridView2.Columns.ToList();
            var col = _clms.Where(c => c.Name.Contains("NetResultLbs")).FirstOrDefault();
            col.OptionsColumn.AllowEdit = false;
            col.OptionsColumn.AllowFocus = false;
        }


        private void GridLearnXtraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trace.WriteLine($@"private void GridLearnXtraForm_FormClosing(object sender, FormClosingEventArgs e)");

            int nJeffe = 0;
            nJeffe++;
        }

        #endregion




        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            Trace.WriteLine($@"");
            Trace.WriteLine($@"private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)");
            Trace.WriteLine($@"{e.Value}");
            Trace.WriteLine($@"{gridView2.FocusedColumn}");
            Trace.WriteLine($@"{gridView2.FocusedRowHandle}");
            Trace.WriteLine($@"{gridView2.FocusedValue}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].GrossLbs}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].TareLbs}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].NetResultLbs}");


            if (gridView2.FocusedColumn.Name.Contains("TareLbs"))
            {

            }
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Trace.WriteLine($@"");
            Trace.WriteLine($@"gridView2_RowUpdated");
            Trace.WriteLine($@"{e.Row}");
            Trace.WriteLine($@"{e.RowHandle}");
            Trace.WriteLine($@"{gridView2.FocusedColumn}");
            Trace.WriteLine($@"{gridView2.FocusedRowHandle}");
            Trace.WriteLine($@"{gridView2.FocusedValue}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].GrossLbs}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].TareLbs}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].NetResultLbs}");
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            _gWd[e.RowHandle].NetResultLbs = _gWd[e.RowHandle].GrossLbs - _gWd[e.RowHandle].TareLbs;
            Trace.WriteLine($@"");
            Trace.WriteLine($@"gridView2_ValidateRow");
            Trace.WriteLine($@"");

            if (DialogResult.Yes == MessageBox.Show(this,"Click Yes to add a new Row, or Click No to quit.","Add New Row?", MessageBoxButtons.YesNo))
            {
                InitializeData();
                gridView2.RefreshData();
            }
            Trace.WriteLine($@"{gridView2.FocusedColumn}");
            Trace.WriteLine($@"{gridView2.FocusedRowHandle}");
            Trace.WriteLine($@"{gridView2.FocusedValue}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].GrossLbs}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].TareLbs}");
            Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].NetResultLbs}");
        }




        private void gridView2_RowCountChanged(object sender, EventArgs e)
        {
            Trace.WriteLine($@"gridView2_RowCountChanged");
            Trace.WriteLine($@"{gridView2.FocusedColumn}");
            Trace.WriteLine($@"{gridView2.FocusedRowHandle}");
            Trace.WriteLine($@"{gridView2.FocusedValue}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle]?.GrossLbs}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle]?.TareLbs}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle]?.NetResultLbs}");
        }
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Trace.WriteLine($@"gridView2_FocusedRowChanged");
            Trace.WriteLine($@"{gridView2.FocusedColumn}");
            Trace.WriteLine($@"{gridView2.FocusedRowHandle}");
            Trace.WriteLine($@"{gridView2.FocusedValue}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].GrossLbs}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].TareLbs}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].NetResultLbs}");

        }

        private void gridView2_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            Trace.WriteLine($@"gridView2_FocusedColumnChanged");
            var cs = gridView2.Columns.ToList();
            Trace.WriteLine($@"{gridView2.FocusedColumn}");
            Trace.WriteLine($@"{gridView2.FocusedRowHandle}");
            Trace.WriteLine($@"{gridView2.FocusedValue}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].GrossLbs}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].TareLbs}");
            //Trace.WriteLine($@"{_gWd[gridView2.FocusedRowHandle].NetResultLbs}");
        }




        private void gridControl2_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            Trace.WriteLine($@"gridControl2_FocusedViewChanged");
        }



        private void gridView2_ShownEditor(object sender, EventArgs e)
        {
            Trace.WriteLine($@"");
            Trace.WriteLine($@"gridView2_ShownEditor");

            if (gridView1.GetFocusedDataRow() == null)
            {
                
            }
        }




        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            Trace.WriteLine($@"gridView2_KeyDown");
        }

        private void gridControl2_EditorKeyDown(object sender, KeyEventArgs e)
        {
            Trace.WriteLine($@"gridControl2_EditorKeyDown");
        }

        private void gridControl2_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            Trace.WriteLine($@"gridControl2_EditorKeyPress");
        }

        private void gridControl2_EditorKeyUp(object sender, KeyEventArgs e)
        {
            Trace.WriteLine($@"gridControl2_EditorKeyUp");
        }





        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            Trace.WriteLine($@"gridView2_CustomDrawRowIndicator");
            // set grid view row numbers in row header column
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }












        private void InitializeData()
        {
            Trace.WriteLine($@"InitializeData  -- ADD NEW ROW");

            //_gWd.Add(new GridWeightData(0, 0, 0));
            _gWd.Add(new WeightInGrid(0, 0, 0));
            //_gWd.Add(new WeightInGrid(0, 0, 0));
            //_gWd.Add(new WeightInGrid(0, 0, 0));
            //_gWd.Add(new WeightInGrid(0, 0, 0));
            //_gWd.Add(new WeightInGrid(0, 0, 0));
            //_gWd.Add(new WeightInGrid(0, 0, 0));
            //_gWd.Add(new WeightInGrid(0, 0, 0));

        }








    }
}