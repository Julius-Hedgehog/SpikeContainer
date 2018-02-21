using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.Extensions;
using System.Data.Entity;
using SpikeContainer.DataEntitiy;

namespace SpikeContainer.Spike_003
{
    public partial class Spike003Test001 : Form
    {

        private SpikeContainer.DataEntitiy.TestMesDbEntities _db;
        private string _user;
        DataTable _dtTempValues;

        public Spike003Test001()
        {
            InitializeComponent();

            InitializeAllData();

        }



        private void InitializeAllData()
        {
            _db?.Dispose();
            _db = new DataEntitiy.TestMesDbEntities();

            // - - - - - - - - - - - - - - - - - - - - 

#if RUNNINGTHIS

            _db.Users.Load();
            _db.WorkOrders.Load();
            _db.Permissions.Load();
            _db.Packages.Load();

#else
            // - - - - - - - - - - - - - - - - - - - - 

            _db.Users.Load();
            _db.WorkOrders.Include("Packages").Include("Status1").Load();

#endif

            gridControl1.DataSource = _db.Users.Local;
            vGridControl1.DataSource = _db.WorkOrders.Local;
            treeList1.DataSource = _db.Packages.Local;
            gridControl2.DataSource = _db.Status.Local;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CreateTempTable();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            


        }

        private void CreateTempTable()
        {
            _dtTempValues?.Dispose();
            _dtTempValues = new DataTable("MyTempAccessValues");

            // NONE         0
            // STANDARD     1000
            // MANAGER      4000
            // ADMIN        6000
            // INFOTEK      8000
            Int32[] n32Array = {0, 1000, 3000,  4000, 6000, 8000 };
            List<String> listName = new List<string>{"None", "Standard", "Supervisor", "Management", "Administrator", "InformationTech" };
            _dtTempValues.Columns.Add("RecID", Type.GetType("System.Int32"));
            _dtTempValues.Columns.Add("Name", Type.GetType("System.String"));
            _dtTempValues.Columns.Add("Value", Type.GetType("System.Int32"));

            DataRow dr;

            for (int j = 0; j <= 5; j++)
            {
                dr = _dtTempValues.NewRow();  // Creating a ZERO'ed DataRow
                dr[0] = j+1;
                dr[1] = listName[j];
                dr[2] = n32Array[j]; 
                _dtTempValues.Rows.Add(dr);           // ZERO'ed DataRow added to dtTempTable
            }

            listBoxControl1.DisplayMember = "Name";
            listBoxControl1.DataSource = _dtTempValues;

            lookUpEdit1.Properties.DataSource = _dtTempValues;
            lookUpEdit1.Properties.DisplayMember = "Name";

            listBoxControl1.SelectedIndex = 0;
            comboBoxEdit1.SelectedIndex = 0;

            lookUpEdit1.EditValue = "None";
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trace.WriteLine("listBoxControl1_SelectedIndexChanged");
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trace.WriteLine("comboBoxEdit1_SelectedIndexChanged");
        }

        private void comboBoxEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            Trace.WriteLine("comboBoxEdit1_Properties_EditValueChanged");
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Trace.WriteLine("lookUpEdit1_EditValueChanged");
        }

        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            Trace.WriteLine("lookUpEdit1_Properties_EditValueChanged");
        }
    }
}
