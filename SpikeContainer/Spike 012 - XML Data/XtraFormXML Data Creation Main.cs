using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpikeContainer.Spike_012___XML_Data
{
    public partial class XtraFormXML_Data_Creation_Main : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormXML_Data_Creation_Main()
        {
            InitializeComponent();
        }

        private void XtraFormXML_Data_Creation_Main_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Create DataSet
            // Create DataTables
            // Add Tables to DataSet

            // DataSet. WriteXML with data and scheme 
            FileMoverServiceDB db = new FileMoverServiceDB();

            db.Clear();

            db.WriteXml($@"DBSource", XmlWriteMode.WriteSchema);

            db.Movers.AddMoversRow(1, $@"\\MANUFACTURING\d$\SigConnect\Archive", $@"\\MANUFACTURING\d$\SigConnect_Archives", $@"*.sig*", 86400000);
            db.Run.AddRunRow(1,db.Movers.OrderBy(o=>o.m_Index).FirstOrDefault(),DateTime.Now,200);
            db.WriteXml($@"DataAndScheme", XmlWriteMode.WriteSchema);
        }
    }

}