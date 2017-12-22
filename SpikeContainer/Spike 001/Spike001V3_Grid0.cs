using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpikeContainer.DataEntitiy;

namespace SpikeContainer.Spike_001
{
    public partial class Spike001V3_Grid0 : Form
    {
        private MesDbEntities _db;
        private DataTable dtTempTable;

        public Spike001V3_Grid0()
        {
            InitializeComponent();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        private void Spike001V3_Grid0_Load(object sender, EventArgs e)
        {

        }

        private void Spike001V3_Grid0_Shown(object sender, EventArgs e)
        {
            gridView1.IndicatorWidth = 30;

            InitDtTempTable();                          // dtTempTable is initialized with one data row ZEROed out                     
            gridControl1.DataSource = dtTempTable;      // Assign dtTempTable as the DataSource for gridControl implementation
        }

        private void Spike001V3_Grid0_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {

        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {

        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        private void tenKeypadControl11_CustTenKeyEvent(object sender, TenKeypadContol1EventArgs e)
        {

        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        private void InitializeMesDbEntitiesObject()
        {   // if the database object PFCS.DataEntities.MesDbEntities is not previously disposed and null kill it
            DisposeMesDbEntitiesObject();
            //_db = new MesDbEntities();  // CLASS VAR is Initialized HERE
        }

        private void DisposeMesDbEntitiesObject()
        {
            //_db?.Dispose();                     // kill-kill-kill-kill-kill
        }

        private bool GetRawData(int shopOrder)
        {
            InitializeMesDbEntitiesObject();
            return GetDataUserData(shopOrder);
        }

        private bool GetDataUserData(Int32 shopOrder)
        {
            //_db.Packages.Where(r => r.ShopOrderNo == shopOrder && r.Status1.Inv).Include("ShopOrders").Load();
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
    }
}
