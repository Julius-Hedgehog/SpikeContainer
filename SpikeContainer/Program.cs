using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer
{
    static class Program
    {
        public static SpikeContainer.Spike_013___PTM_Error_Log___Further_Dev.PolartecErrorLog ptmErrorLog;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string strLogFilePath = string.Empty;

            strLogFilePath = ($@"{Application.StartupPath}\LOGS");
            ptmErrorLog = new SpikeContainer.Spike_013___PTM_Error_Log___Further_Dev.PolartecErrorLog(Application.ProductName, strLogFilePath, Properties.Settings.Default.LastServiceRunTime);
            ptmErrorLog.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

            Properties.Settings.Default.LastServiceRunTime = ptmErrorLog.CurrentDateTime;
            Properties.Settings.Default.Save();
            // Clean up, close and dispose
            ptmErrorLog.Stop();
        }
    }
}
