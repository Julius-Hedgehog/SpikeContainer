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
    public partial class DevExpressXtraForm011Part2 : DevExpress.XtraEditors.XtraForm
    {
        string[] machineNames =
            {
            "BAREFIELD-PC",
            "BATCHER2-PC",
            "BATCHER-PC",
            "CDC-CLERK-PC",
            "CDC-PC",
            "CLO-PC",
            "CORPLAB-T7-PC",
            "DATACOLOR-PC",
            "DENNEY-PC",
            "DHSPECTRO-PC",
            "DHSUPERVISOR-PC",
            "DLSPECTRO-PC",
            "DOFFER1-PC",
            "DOFFER2-PC",
            "DOFFER3-PC",
            "DOFFER4-PC",
            "DOFFER5-PC",
            "DYECLERK2-PC",
            "DYECLERK-PC",
            "DYELAB2-PC",
            "DYELAB-PC",
            "DYEOFFICE-PC",
            "DYEWEIGH-PC",
            "EARP-PC",
            "FICHECKIN-PC",
            "FI-D-PC",
            "FI-E-PC",
            "FI-F-PC",
            "FI-G-PC",
            "FISUP-PC",
            "FI-W-PC",
            "FRAME-PC",
            "HARRINGTON-PC",
            "HOPKINS-PC",
            "HRCLERK-PC",
            "LEADPERCH-PC",
            "MAINTKIOSK-PC",
            "MAINT-PC",
            "MIS-PC",
            "PLANBOARD-PC",
            "PURCHASECLERK-PC",
            "QCDATAENTRY-PC",
            "QCLAB1-PC",
            "QCLAB2-PC",
            "QCLAB3-PC",
            "QCLAB4-PC",
            "RECEIVING-PC",
            "RECVCLERK-PC",
            "REINSPECT-PC",
            "RI1-VPC",
            "RI2-VPC",
            "SAMPLEROOM-PC",
            "SFSUPERVISOR-PC",
            "SG1-PC",
            "SGOFFICE-PC",
            "WETFINCLERK-PC",
            "WETFINSUPV-PC",
            "ZWICK-PC"
            };

        public DevExpressXtraForm011Part2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<string> strListMissed = new List<string>();

            List<VersionedItems> vIList = new List<VersionedItems>();
            string strPath = "";

            foreach (string system in machineNames)
            {
                try
                {
                    strPath = $@"\\{system}\C$\PFCS\";
                    string strFileFilter =  $@"*PFCS.exe" ;
                    DirectoryInfo di = new DirectoryInfo(strPath);
                    FileVersionInfo fvinfo;
                    IEnumerable<FileInfo> iefiDirContents = di.GetFiles(strFileFilter);
                    foreach (FileInfo fi in iefiDirContents)
                    {
                        fvinfo = FileVersionInfo.GetVersionInfo(fi.FullName);
                    
                            VersionedItems vi = new VersionedItems()
                            {
                                Name = fi.Name,
                                /*version = new Version(fvinfo.ProductVersion),*/
                                IsExtensionable = !string.IsNullOrEmpty(fi.Extension),
                                Extension = (!string.IsNullOrEmpty(fi.Extension)? fi.Extension:null),
                                FullPathandName = fi.FullName,
                                version = new Version(fvinfo.FileVersion),
                                Info = fi
                            };
                            vIList.Add(vi);
                    }

                    gridControl1.DataSource = null;
                    gridControl1.Refresh();
                    gridControl1.DataSource = vIList;
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
                    Trace.WriteLine($@"{strPath}");
                    //Trace.WriteLine($@"");
                    //Trace.WriteLine($@"{fvinfo.ToString()}");
                    Trace.WriteLine($@"");
                    Trace.WriteLine($@"End of Exception Error Output");
                    Trace.WriteLine($@"");
                    Trace.WriteLine($@"");

                    strListMissed.Add(strPath);
                }
                finally
                {

                }
            }

            gridControl2.DataSource = null;
            gridControl2.Refresh();
            gridControl2.DataSource = strListMissed;

        }
    }
}

/*
string [] machineNames = 
{
"BAREFIELD-PC",
"BATCHER2-PC",
"BATCHER-PC",
"CDC-CLERK-PC",
"CDC-PC",
"CLO-PC",
"CORPLAB-T7-PC",
"DATACOLOR-PC",
"DENNEY-PC",
"DHSPECTRO-PC",
"DHSUPERVISOR-PC",
"DLSPECTRO-PC",
"DOFFER1-PC",
"DOFFER2-PC",
"DOFFER3-PC",
"DOFFER4-PC",
"DOFFER5-PC",
"DYECLERK2-PC",
"DYECLERK-PC",
"DYELAB2-PC",
"DYELAB-PC",
"DYEOFFICE-PC",
"DYEWEIGH-PC",
"EARP-PC",
"FICHECKIN-PC",
"FI-D-PC",
"FI-E-PC",
"FI-F-PC",
"FI-G-PC",
"FISUP-PC",
"FI-W-PC",
"FRAME-PC",
"HARRINGTON-PC",
"HOPKINS-PC",
"HRCLERK-PC",
"LEADPERCH-PC",
"MAINTKIOSK-PC",
"MAINT-PC",
"MIS-PC",
"PLANBOARD-PC",
"PURCHASECLERK-PC",
"QCDATAENTRY-PC",
"QCLAB1-PC",
"QCLAB2-PC",
"QCLAB3-PC",
"QCLAB4-PC",
"RECEIVING-PC",
"RECVCLERK-PC",
"REINSPECT-PC",
"RI1-VPC",
"RI2-VPC",
"SAMPLEROOM-PC",
"SFSUPERVISOR-PC",
"SG1-PC",
"SGOFFICE-PC",
"WETFINCLERK-PC",
"WETFINSUPV-PC",
"ZWICK-PC"
}

    */
