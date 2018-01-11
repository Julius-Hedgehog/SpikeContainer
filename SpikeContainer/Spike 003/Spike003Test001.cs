using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.Extensions;
using System.Data.Entity;

namespace SpikeContainer.Spike_003
{
    public partial class Spike003Test001 : Form
    {

        private SpikeContainer.DataEntitiy.TestMesDbEntities _db;
        private string _user;

        public Spike003Test001()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InitializeAllData();
        }

        private void InitializeAllData()
        {
            _db?.Dispose();
            _db = new DataEntitiy.TestMesDbEntities();
            _db.Users.Load();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = _db.Users.Local;
            vGridControl1.DataSource = _db.Users.Local;
            treeList1.DataSource = _db.Users.Local;
           
        }
    }
}
