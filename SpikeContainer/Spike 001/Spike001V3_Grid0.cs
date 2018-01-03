using SpikeContainer.DataEntitiy;
using System;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SpikeContainer.Spike_001
{
    public partial class Spike001V3_Grid0 : Form
    {
        private MesDbEntities _db;
        private DataTable dtTempTable;

        DevExpress.XtraEditors.BaseEdit deXEdit = null; // indicator IF and Active Editor is selected in the GridView
        int ROW;                                        // Editor row
        DevExpress.XtraGrid.Columns.GridColumn COL;     // editor column

        public Spike001V3_Grid0()
        {
            InitializeComponent();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        private void Spike001V3_Grid0_Shown(object sender, EventArgs e)
        {
            gridView1.IndicatorWidth = 30;

            InitDtTempTable();                          // dtTempTable is initialized with one data row ZEROed out                     
            gridControl1.DataSource = dtTempTable;      // Assign dtTempTable as the DataSource for gridControl implementation
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {   // set grid view row numbers in row header
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            Trace.WriteLine("gridView1_ShownEditor Showing Active Editor ");

            try
            {
                if (gridView1.GetFocusedDataRow() == null)    // IF NO 'NEXT' DATA ROW -- you gota create it
                {
                    InitDtTempTableDataRow();               // CREATE AND ADD THE NEW NEXT DATA ROW INTO THE DATA TABLE
                    gridView1.GetFocusedDataRow();     // Focus on the new row just added here
                    gridView1.ShowEditor();
                }

                ROW = gridView1.FocusedRowHandle;   // CLASS VAR SET HERE - the focused row handle - grid/gridview index
                COL = gridView1.FocusedColumn;      // CLASS VAR SET HERE - the grid/gridview column
                deXEdit = gridView1.ActiveEditor;   // CLASS VAR SET HERE - A pointer to the active editor
                Trace.WriteLine(string.Format("gridView1_ShownEditor Showing Active Editor ( Row = {0} , Column = {1} )", ROW.ToString(), COL.AbsoluteIndex.ToString()));

                tenKeypadControl11.CurrentValue = (Convert.ToString(dtTempTable.Rows[ROW][COL.AbsoluteIndex]) == "0" ? "" : Convert.ToString(dtTempTable.Rows[ROW][COL.AbsoluteIndex]));
                Trace.WriteLine(string.Format("gridView1_ShownEditor  ( Row = {0} , Column = {1} )", ROW.ToString(), COL.AbsoluteIndex.ToString()));
                Trace.WriteLine(string.Format("gridView1_ShownEditor SETTING tenKeypadControl11.CurrentValue =  {0} )", tenKeypadControl11.CurrentValue));
            }
            catch (Exception exctp)
            {
                Trace.WriteLine(string.Format("gridView1_ShownEditor. TRY {ERROR} EXCEPTION MESSAGE = {0}  ", exctp.Message));
                Trace.WriteLine(string.Format("gridView1_ShownEditor. TRY {ERROR} EXCEPTION STACK TRACE = {0}  ", exctp.StackTrace));
                return;
            }
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            Trace.WriteLine(string.Format("gridView1_ValidatingEditor {0}  {1} ", e.Valid.ToString(), e.Value.ToString()));
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        //////private void TenKeypadControl11_KeyPress(object sender, KeyPressEventArgs e)
        //////{
        //////    Trace.WriteLine(string.Format("tenKeypadControl11_KeyPress char = {0} :: Handled =  {1} ", e.KeyChar, e.Handled.ToString()));

        //////    dtTempTable.Rows[ROW][COL.AbsoluteIndex] += e.KeyChar.ToString();

        //////    Trace.WriteLine(string.Format("TenKeypadControl11_KeyPress deXEdit.Text = ' {0} ' ", deXEdit.Text));
        //////}

        private void TenKeypadControl11_CustTenKeyEvent(object sender, TenKeypadContol1EventArgs e)
        {
            Trace.WriteLine(string.Format("tenKeypadControl11_CustTenKeyEvent {0}  {1} ", e.DISPLAY, e.KEY.ToString()));
            if (deXEdit == null) return; // no active grid editor

            DoWork(e);
            gridView1.RefreshData();
        }
        ////private void TenKeypadControl11_CustTenKeyEvent(object sender, TenKeypadContol1EventArgs e)
        ////{
        ////    Trace.WriteLine(string.Format("tenKeypadControl11_CustTenKeyEvent {0}  {1} ", e.DISPLAY, e.KEY.ToString()));

        ////   if (e.KEY != Keys.Y && e.KEY != Keys.N)
        ////    {
        ////        

        ////        DataRow dr = null;
        ////        try
        ////        {
        ////            dr = gridView1.GetFocusedDataRow();

        ////            if (dr != null)
        ////            {
        ////                dr[COL.AbsoluteIndex] = (e.DISPLAY == "" ? 0 : Convert.ToInt32(e.DISPLAY)); // ten key value pass into datarow of datatable

        ////                if (COL.AbsoluteIndex == 1)
        ////                {
        ////                    //if (!IsGrossWeightGreaterThanTareWeight(dr))
        ////                    {
        ////                        tenKeypadControl11.CurrentValue = (Convert.ToString(dr[COL.AbsoluteIndex]) == "0" ? "" : Convert.ToString(dr[COL.AbsoluteIndex]));

        ////                        gridView1.Focus();
        ////                        gridView1.ShowEditor();
        ////                        return;
        ////                    }
        ////                }
        ////            }
        ////        }
        ////        catch (Exception excpt)
        ////        {
        ////            Trace.WriteLine(string.Format("tenKeypadControl11_CustTenKeyEvent ERROR {0}  {1}", excpt.Message, excpt.StackTrace));
        ////        }
        ////    }
        ////    else
        ////    {
        ////        if (deXEdit == null) return;            // if no active editor being shown - return

        ////        DataRow dr = null;
        ////        dr = gridView1.GetFocusedDataRow();
        ////        //if (!IsGrossWeightGreaterThanTareWeight(dr))
        ////        //{
        ////        //    gridView1.Focus();
        ////        //    gridView1.ShowEditor();
        ////        //    return;
        ////        //}

        ////        if (COL.AbsoluteIndex == 0)
        ////        {   //COL. - the GROSS WEIGHT COLUMN IS THE COLUMN RECEIVING DATA - from tenkeycontrol - MOVE TO TARE WEIGHT COLUMN
        ////            FocusMoveToNextColumnCellInGrid(0);
        ////        }
        ////        else if (COL.AbsoluteIndex == 1)
        ////        {   // COL. - the TARE WEIGHT COLUMN IS THE COLUMN RECEIVING DATA - from tenkeycontrol
        ////            if ((ROW + 1) == (gridView1.RowCount - 1) && /* the current focused row is the last row in gridview*/
        ////                    (gridView1.RowCount - 1) == gridView1.DataRowCount && /* the last row in grid view count is the same as datarow count*/
        ////                            ROW == (gridView1.DataRowCount - 1)) /* the current row has a data row*/ // AM I FOCUSED AND EDITING ON THE LAST DATA ROW?
        ////            {
        ////                //if (PFCS.Classes.Msg.ConfirmAction("Is there another cart for this job?", "Add Another Cart"))
        ////                {   // - IF YES - ASK TO ADD NEW ROW
        ////                    FocusMoveToNextColumnCellInGrid(1); // added new row - move to next gross weight column
        ////                }
        ////                //else
        ////                //{
        ////                //    simpleButtonPrepData.Enabled = true;    // IF A AM ON THE LAST ROW IN GRID - AND - I DO NOT WANT TO ADD ANOTHER CART -  I AM READY TO PREP DATA
        ////                //    simpleButtonPrepData.Focus();           // I NOW WANT TO ACTIVATE THE DATA PREP BUTTON AND CLOSE FOCUS ON GRID
        ////                //}
        ////            }
        ////        }
        ////    }
        ////}

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        private void InitializeMesDbEntitiesObject()
        {   // if the database object PFCS.DataEntities.MesDbEntities is not previously disposed and null kill it
            DisposeMesDbEntitiesObject();
            _db = new MesDbEntities();  // CLASS VAR is Initialized HERE
        }

        private void DisposeMesDbEntitiesObject()
        {
            _db?.Dispose();                     // kill-kill-kill-kill-kill
        }

        private bool GetRawData(int shopOrder)
        {
            InitializeMesDbEntitiesObject();
            return GetDataUserData(shopOrder);
        }

        private bool GetDataUserData(Int32 shopOrder)
        {
            _db.Packages.Where(r => r.ShopOrderNo == shopOrder && r.Status1.Inv).Include("ShopOrders").Load();
            //_db.Packages.Where(r => r.ShopOrderNo == shopOrder && r.Status1.Inv).Load();
            //_db.Packages.Where(r => r.ShopOrderNo == shopOrder).Load();

            //intPackagesCount = _db.Packages.Local.Count();

            // I must have valid SHOP ORDER and AT LEAST ONE (to many [1 <= X <= Infinity]) VALID PACKAGES TABLE ROWS - (For the SHOP ORDER and Status.Inv == 1 [or true])
            return ((_db.ShopOrders.Local.Count() == 1/* && intPackagesCount >= 1*/) ? true : false);
        }

        private void InitDtTempTable(bool bisToHaveInitRow = true)
        {
            dtTempTable?.Dispose();
            dtTempTable = new DataTable();
            dtTempTable.Columns.Add("Gross", Type.GetType("System.Int32"));
            dtTempTable.Columns.Add("Tare", Type.GetType("System.Int32"));

            if (bisToHaveInitRow) { InitDtTempTableDataRow(); }
        }

        private void InitDtTempTableDataRow(int ngrossVal = 0, int ntareVal = 0)
        {
            DataRow dr = dtTempTable.NewRow();  // Creating a ZERO'ed DataRow
            dr[0] = ngrossVal;
            dr[1] = ntareVal;
            dtTempTable.Rows.Add(dr);           // ZERO'ed DataRow added to dtTempTable
        }

        private void DoWork(TenKeypadContol1EventArgs e)
        {
            Trace.WriteLine(string.Format("DoWork {0}  {1} ", e.DISPLAY, e.KEY.ToString()));
            if (deXEdit == null) return;            // if no active editor being shown - return
            if (e.KEY != Keys.Y && e.KEY != Keys.N)
            {
                try
                {
                    Trace.WriteLine(string.Format("DoWork  ( Row = {0} , Column = {1} )", ROW.ToString(), COL.AbsoluteIndex.ToString()));
                    dtTempTable.Rows[ROW][COL.AbsoluteIndex] = (e.DISPLAY == "" ? 0 : Convert.ToInt32(e.DISPLAY));
                    gridView1.RefreshData();

                    if (COL.AbsoluteIndex == 1)
                    {
                        //if (!IsGrossWeightGreaterThanTareWeight(dtTempTable.Rows[ROW]))
                        {
                            tenKeypadControl11.CurrentValue = (Convert.ToString(dtTempTable.Rows[ROW][COL.AbsoluteIndex]) == "0" ? "" : Convert.ToString(dtTempTable.Rows[ROW][COL.AbsoluteIndex]));
                            Trace.WriteLine(string.Format("DoWork SETTING tenKeypadControl11.CurrentValue =  {0} )", tenKeypadControl11.CurrentValue));
                            gridView1.Focus();
                            gridView1.ShowEditor();
                            return;
                        }
                    }
                    
                }
                catch (Exception excpt)
                {
                    Trace.WriteLine(string.Format("tenKeypadControl11_CustTenKeyEvent ERROR {0}  {1}", excpt.Message, excpt.StackTrace));
                }
            }
            else
            {
                //if (!IsGrossWeightGreaterThanTareWeight(dtTempTable.Rows[ROW]))
                //{
                //    gridView1.Focus();
                //    gridView1.ShowEditor();
                //    return;
                //}

                if (COL.AbsoluteIndex == 0)
                {   //COL. - the GROSS WEIGHT COLUMN IS THE COLUMN RECEIVING DATA - from tenkeycontrol - MOVE TO TARE WEIGHT COLUMN
                    FocusMoveToNextColumnCellInGrid(0);
                }
                else if (COL.AbsoluteIndex == 1)
                {   // COL. - the TARE WEIGHT COLUMN IS THE COLUMN RECEIVING DATA - from tenkeycontrol
                    if ((ROW + 1) == (gridView1.RowCount - 1) && /* the current focused row is the last row in gridview*/
                            (gridView1.RowCount - 1) == gridView1.DataRowCount && /* the last row in grid view count is the same as datarow count*/
                                    ROW == (gridView1.DataRowCount - 1)) /* the current row has a data row*/ // AM I FOCUSED AND EDITING ON THE LAST DATA ROW?
                    {
                        //if (PFCS.Classes.Msg.ConfirmAction("Is there another cart for this job?", "Add Another Cart"))
                        {   // - IF YES - ASK TO ADD NEW ROW
                            FocusMoveToNextColumnCellInGrid(1); // added new row - move to next gross weight column
                        }
                        //else
                        //{
                        //    simpleButtonPrepData.Enabled = true;    // IF A AM ON THE LAST ROW IN GRID - AND - I DO NOT WANT TO ADD ANOTHER CART -  I AM READY TO PREP DATA
                        //    simpleButtonPrepData.Focus();           // I NOW WANT TO ACTIVATE THE DATA PREP BUTTON AND CLOSE FOCUS ON GRID
                        //}
                    }
                }
            }
        }


        private bool FocusMoveToNextColumnCellInGrid(Int32 currentColumnAbsoluteIndex)
        {
            bool bReturnValue = false;

            DevExpress.XtraGrid.Columns.GridColumn nextCol;

            if (currentColumnAbsoluteIndex == 1)// in last column in data row
            {
                InitDtTempTableDataRow();       // SET UP TO FOCUS ON NEXT ROW
                gridView1.GetFocusedDataRow();  // AFTER I HAVE ADDED A NEW DATATABLE DATAROW
            }
            nextCol = gridView1.GetVisibleColumn(((currentColumnAbsoluteIndex + 1) % 2));
            gridView1.FocusedColumn = (nextCol); // SET UP TO FOCUS ON GROSS Column
            gridView1.ShowEditor(); // FOCUS ON THE FIRST COLUMN OF THE NEXT (NEW) DATA ROW IN GRID VIEW

            return bReturnValue;
        }
    }
}
