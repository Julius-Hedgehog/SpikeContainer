using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace SpikeContainer.Spike_011___Current_Version
{
    public partial class DevExpressXtraForm011Part2 : DevExpress.XtraEditors.XtraForm
    {
        private string[] machineNames =
            {
            "BAREFIELD-PC",
            "BATCHER2-PC",
            "BATCHER-PC",
            "CDC-BATCH-PC",
            "CDC-CLERK-PC",
            "CDC-PC",
            "CLO-PC",
            "CORINO-PC",
            "CORPLAB-T7-PC",
            "DATACOLOR-PC",
            "DENNEY-PC",
            "DHSPECTRO-PC",
            "DHSUPERVISOR-PC",
            "DLSPECTRO-PC",
            "PRINTER-PC",
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
            "FLATFOLDER-PC",
            "FRAME-PC",
            "HARRINGTON-PC",
            "HOPKINS-PC",
            "HRCLERK-PC",
            "LEADPERCH-PC",
            "MAINTKIOSK-PC",
            "MAINT-PC",
            "MIS-PC",
            "NAPPER1-PC",
            "NAPPER2-PC",
            "NAPPER3-PC",
            "NAPPER4-PC",
            "NAPPER5-PC",
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
            "SANDER-PC",
            "SFSUPERVISOR-PC",
            "SG1-PC",
            "SGOFFICE-PC",
            "SHEAR20-PC",
            "SHEAR21-PC",
            "SHEAR22-PC",
            "SHEAR23-PC",
            "SHEAR24-PC",
            "SHEAR25-PC",
            "SHEAR26-PC",
            "SINGLEACT11-PC",
            "SINGLEACT12-PC",
            "SINGLEACT13-PC",
            "SINGLEACT14-PC",
            "SUEDER-PC",
            "TURBANG-PC",
            "WETFINCLERK-PC",
            "WETFINSUPV-PC",
            "ZONCO-PC",
            "ZWICK-PC"
            };

        public DevExpressXtraForm011Part2()
        {
            InitializeComponent();
        }

        string _sourceOriginalArchive = $@"\\Manufacturing\Impact\PFCS\ProgramFiles\";
        string _installedPFCSPath = $@"\\{{0}}\C$\PFCS\";
        string _FileFilter = $@"*PFCS.exe";

        string _loadingString = $@"Searching ... {{0}} of {{1}} ... Searching {{2}}";

        private void DevExpressXtraForm011Part2_Load(object sender, EventArgs e)
        {

        }

        private void DevExpressXtraForm011Part2_Shown(object sender, EventArgs e)
        {
            gridView1.IndicatorWidth = 40;
            gridView2.IndicatorWidth = 40;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            lookUpEdit1.Properties.DataSource = machineNames;
            lookUpEdit1.ItemIndex = 0;
        }

        #region [ TAB CONTROL - TAB PAGE ONE ]


        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Thread myNewThread = new Thread(CodeForThread);
            myNewThread.Start();
        }

        private void CodeForThread()
        {
            List<string> strListMissed = new List<string>();

            List<VersionedItems> vIList = new List<VersionedItems>();
            string strPath = string.Empty;

            int cap = machineNames.Length;
            int iter = 1;
            string progress = $@"";

            SetProgressBar();
            ShowProgressPanel();

            foreach (string system in machineNames)
            {

                StepProgressBar();

                try
                {
                    //strPath = $@"\\{system}\C$\PFCS\";
                    strPath = string.Format(_installedPFCSPath, system);

                    UpdateProgressPanel(string.Format(_loadingString,iter,cap,strPath));
                    iter++;

                    string strFileFilter = _FileFilter;
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
                            Extension = (!string.IsNullOrEmpty(fi.Extension) ? fi.Extension : null),
                            FullPathandName = fi.FullName,
                            version = new Version(fvinfo.FileVersion),
                            Info = fi
                        };
                        vIList.Add(vi);
                    }

                    SetDataGrid1(vIList);
                }
                catch (Exception xcptn)
                {
                    InvokeTrace(string.Empty);
                    InvokeTrace($@"Begin of Exception Error Output");
                    //Trace.WriteLine(string.Empty);
                    //Trace.WriteLine($@"Begin of Exception Error Output");
                    Trace.WriteLine(string.Empty);
                    Trace.WriteLine($@"{xcptn}");
                    Trace.WriteLine(string.Empty);
                    Trace.WriteLine($@"{xcptn.InnerException}");
                    Trace.WriteLine(string.Empty);
                    Trace.WriteLine($@"{strPath}");
                    //Trace.WriteLine($@"");
                    //Trace.WriteLine($@"{fvinfo.ToString()}");
                    Trace.WriteLine(string.Empty);
                    Trace.WriteLine($@"End of Exception Error Output");
                    Trace.WriteLine(string.Empty);
                    Trace.WriteLine(string.Empty);

                    strListMissed.Add(strPath);
                }
                finally
                {

                }
            }

            SetDataGrid2(strListMissed);
            HideProgressPanel();
        }

        private void InvokeTrace(string str)
        {
            Action actionT = () =>
            {
                Trace.WriteLine(str);
            };
            this.Invoke(actionT);
        }

        private void SetProgressBar()
        {
            Action action = () =>
            {
                progressBarControl1.Position = 0;
                progressBarControl1.Properties.Step = 1;
                progressBarControl1.Properties.PercentView = true;
                progressBarControl1.Properties.Maximum = machineNames.Length;
                progressBarControl1.Properties.Minimum = 0;
            };
            this.Invoke(action);
        }

        private void StepProgressBar()
        {
            Action action1 = () =>
            {
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            };
            this.Invoke(action1);
        }

        private void SetDataGrid1(List<VersionedItems> vIList)
        {
            Action action2 = () =>
            {
                gridControl1.DataSource = null;
                gridControl1.Refresh();
                gridControl1.DataSource = vIList;
            };
            this.Invoke(action2);
        }

        private void SetDataGrid2(List<string> strListMissed)
        {
            Action action3 = () =>
            {
                gridControl2.DataSource = null;
                gridControl2.Refresh();
                gridControl2.DataSource = strListMissed;
            };
            this.Invoke(action3);
        }

        private void ShowProgressPanel()
        {
            Action actionZ = () =>
            {
                progressPanel1.Description = $@"Searching ...";
                progressPanel1.Visible = true;
            };
            this.Invoke(actionZ);
        }
        private void UpdateProgressPanel(string msg)
        {
            Action actionZ = () =>
            {
                progressPanel1.Description = msg;
            };
            this.Invoke(actionZ);
        }

        private void HideProgressPanel()
        {
            Action actionZ = () =>
            {
                progressPanel1.Description = $@"Searching ...";
                progressPanel1.Visible = false;
            };
            this.Invoke(actionZ);
        }

        #endregion

        #region [ TAB CONTROL - TAB PAGE TWO ]

        

        #endregion


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
"PRINTER-PC",
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
