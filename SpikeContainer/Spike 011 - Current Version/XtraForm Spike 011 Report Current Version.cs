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

namespace SpikeContainer.Spike_011___Current_Version
{
    public partial class XtraForm_Spike_011_Report_Current_Version : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm_Spike_011_Report_Current_Version()
        {
            InitializeComponent();
        }

        private void XtraForm_Spike_011_Report_Current_Version_Load(object sender, EventArgs e)
        {

        }

        private void XtraForm_Spike_011_Report_Current_Version_Shown(object sender, EventArgs e)
        {

        }

        private void XtraForm_Spike_011_Report_Current_Version_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void XtraForm_Spike_011_Report_Current_Version_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        ////private void simpleButton1_Click(object sender, EventArgs e)
        ////{
        ////    string strPath = $@"\\MANUFACTURING\Impact\PFCS\ProgramFiles";
        ////    string strFileFilter = $@"*.*";
        ////    DirectoryInfo di = new DirectoryInfo(strPath);
        ////    IEnumerable<FileInfo> iefiDirContents = di.GetFiles(strFileFilter);
        ////    using (MyVersionEntity db = new MyVersionEntity())
        ////    {
        ////        foreach (FileInfo fi in iefiDirContents)
        ////        {
        ////            var fvinfo = FileVersionInfo.GetVersionInfo(fi.FullName);
        ////            VersionedItems vi = new VersionedItems()
        ////            {
        ////                Name = fi.Name,
        ////                version = new Version(fvinfo.ProductVersion),
        ////            };

        ////            db.VersionedItem.Local.Add(vi);
        ////        }
        ////        gridControl1.DataSource = null;
        ////        gridControl1.Refresh();
        ////        gridControl1.DataSource = db.VersionedItem;
        ////    }

        ////}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string strPath = $@"\\MANUFACTURING\Impact\PFCS\ProgramFiles";
            string [] strFileFilter = { $@"*.exe",$@"*.dll" };
            DirectoryInfo di = new DirectoryInfo(strPath);
            
            List<VersionedItems> vIList = new List<VersionedItems>();
            FileVersionInfo fvinfo;

            foreach (string exten in strFileFilter)
            {
                IEnumerable<FileInfo> iefiDirContents = di.GetFiles(exten);
                foreach (FileInfo fi in iefiDirContents)
                {
                    
                    fvinfo = FileVersionInfo.GetVersionInfo(fi.FullName);

                    try
                    {
                        VersionedItems vi = new VersionedItems()
                        {
                            Name = fi.Name,
                            /*version = new Version(fvinfo.ProductVersion),*/
                            version = new Version(fvinfo.FileVersion),
                        };
                        vIList.Add(vi);
                    }
                    catch (Exception xcptn)
                    {
                        Trace.WriteLine($@"");
                        Trace.WriteLine($@"Begin of Exception Error Output");
                        Trace.WriteLine($@"");
                        Trace.WriteLine($@"{xcptn}");
                        Trace.WriteLine($@"");
                        Trace.WriteLine($@"{xcptn.InnerException}");
                        Trace.WriteLine($@"");
                        Trace.WriteLine($@"{fi.ToString()}");
                        Trace.WriteLine($@"");
                        Trace.WriteLine($@"{fvinfo.ToString()}");
                        Trace.WriteLine($@"");
                        Trace.WriteLine($@"End of Exception Error Output");
                        Trace.WriteLine($@"");
                        Trace.WriteLine($@"");
                    }
                    finally
                    {

                    }
                }
            }

            gridControl1.DataSource = null;
            gridControl1.Refresh();
            gridControl1.DataSource = vIList;

        }
    }
}