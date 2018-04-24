//******************************************************************************************************
// PolartecErrorLog.cs -::- SigConnXfer: Assembly - EDI Monitor System: Solution - SigConnXfer: Project
//
// Copyright © 2017 - 2018, Polartec Tennesee Manufacturing LLC. All Rights Reserved.
//
// Unless agreed to in writing, the subject software distributed under the License is distributed on an
// "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
// License for the specific language governing permissions and limitations.
//
// Initial date :: 01/2018 - jph
//
//******************************************************************************************************


// ----------------------------------
// precompile directives and pragmas
// #define
// #pragma
// ----------------------------------
// = = = = = = = = = = = = = = = = = =

// = = = = = = = = = = = = = = = = = =
// ----------------------------------

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SpikeContainer.Spike_013___PTM_Error_Log___Further_Dev
{
    /// <summary>
    /// Class Wraps ErrorLog and RunLog functionality 
    /// to be instantiated in the Program class and used as a 
    /// global access to log output
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <exception cref="ArgumentNullException"></exception>
    public partial class PolartecErrorLog : IDisposable
    {

        //----------------------------
        // Application, 
        // AppDomain, 
        // Environment, 
        // Screen, 
        // SystemInformation, 
        // Properties
        // Process, 
        // Program, 
        //----------------------------

        #region [ Members ]

        private bool disposed = false; // IDisposable implementation

        //-- Force file name format
        //private const string stringLogFileNameFormat = "LogFile_{0}_{1}.txt";
        private const string stringLogFileNameFormat = "LogFile_{0}_{1}_{2}.txt";

        private int _intRefileCount = 0;
        private DateTime _dtReference;
        private string _applicationID;

        //--
        private string stringLogFileName = "";
        private string stringLogFilePath = "";
        private string stringFullNamePathLogFile = "";

        private PolartecErrorLogFileManager PTMRunLogFileManager = null; // file house keeping

        #endregion

        #region [ Constructors ]


        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="applicationId"> The name of the application that is using the 'Error Log' instance. normally Application.ProductName can be passed
        /// <see cref="Application.ProductName"/> 
        /// <see cref="string"/></param>
        /// <param name="dtLastRun"> Normally a localy stored setting or property that is the last run of Error Log instance <see cref="DateTime"/></param>
        /// <exception cref="ArgumentNullException"> if passed applicationId name is null or empty</exception>
        /// <remarks> 
        /// Here is a sample usage
        /// <example>
        /// <code>
        /// static void Main(string[] args)
        /// {
        /// 
        ///    Application.EnableVisualStyles();
        ///    Application.SetCompatibleTextRenderingDefault(false);
        ///    
        ///    // --
        ///    // Initialize 'Error Log' instance
        ///    ptmErrorLog = new PolartecErrorLog(Application.ProductName, Properties.Settings.Default.LastRunTime);
        ///    
        ///    Application.Run(new Main(args));
        ///    
        ///    // -- 
        ///    // Save 'LastRunTime' setting
        ///    Properties.Settings.Default.LastRunTime = ptmErrorLog.CurrentDateTime;
        ///    Properties.Settings.Default.Save();
        ///    
        ///    // --
        ///    // Clean up, close and dispose
        ///    ptmErrorLog.CleanUp();
        ///    ptmErrorLog.Dispose();
        ///    ptmErrorLog = null;
        /// }
        ///</code>
        ///</example>
        ///</remarks>
        public PolartecErrorLog(string applicationId, DateTime dtLastRun)
        {
            
            if (applicationId != string.Empty || applicationId != null)
            {
                _dtReference = DateTime.UtcNow;
                _applicationID = applicationId;
                string[] arrayInfo = {$@"{_applicationID}", $@"{_dtReference.Ticks.ToString()}", $@"{_intRefileCount}" };
                //stringLogFileName = string.Format(PolartecErrorLog.stringLogFileNameFormat, _applicationID, DateTime.UtcNow.Ticks.ToString());
                stringLogFileName = string.Format(PolartecErrorLog.stringLogFileNameFormat, arrayInfo);
                stringLogFilePath = $@"{Application.StartupPath}\{Application.ProductName}_ErrorLogs";
                stringFullNamePathLogFile = string.Format("{0}\\{1}", stringLogFilePath, stringLogFileName);

                try
                {
                    // --
                    // Check Log File Directory - create if not there
                    DirectoryInfo directoryInfoErrorLog = new DirectoryInfo(stringLogFilePath);
                    if (!directoryInfoErrorLog.Exists)
                    {
                        directoryInfoErrorLog.Create();
                    }

                }
                catch (Exception excpt)
                {
                    MessageBox.Show($@"Exception occurred in Error Log -> msg = {excpt.Message} ; with stack trace = {excpt.StackTrace}");
                }

                Trace.Listeners.Clear();
                Trace.Listeners.Add(new TextWriterTraceListener(stringFullNamePathLogFile));// create a trace listener as a run log

                if (dtLastRun == null)
                {

                    dtLastRun = DateTime.Now;

                }

                this.PTMRunLogFileManager = new PolartecErrorLogFileManager(dtLastRun, PolartecErrorLog.stringLogFileNameFormat, stringLogFilePath);

            }
            else
            {

                ArgumentNullException argNullExcpt = new ArgumentNullException("applicationId",
                "The constructor parameter 'string applicationId' was passed either null or empty, when it was expected to be an initialized string object.");
                throw argNullExcpt;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="logFilePath"></param>
        /// <param name="dtLastRun"></param>
        public PolartecErrorLog(string applicationId, string logFilePath, DateTime dtLastRun)
        {

            if (applicationId != string.Empty || applicationId != null)
            {
                _dtReference = DateTime.UtcNow;
                _applicationID = applicationId;
                string[] arrayInfo = { $@"{_applicationID}", $@"{_dtReference.Ticks.ToString()}", $@"{_intRefileCount}" };
                //stringLogFileName = string.Format(PolartecErrorLog.stringLogFileNameFormat, _applicationID, DateTime.UtcNow.Ticks.ToString());
                stringLogFileName = string.Format(PolartecErrorLog.stringLogFileNameFormat, arrayInfo);
                stringLogFilePath = $@"{logFilePath}\{Application.ProductName}_ErrorLogs";
                stringFullNamePathLogFile = string.Format("{0}\\{1}", stringLogFilePath, stringLogFileName);

                try
                {
                    // --
                    // Check Log File Directory - create if not there
                    DirectoryInfo directoryInfoErrorLog = new DirectoryInfo(stringLogFilePath);
                    if (!directoryInfoErrorLog.Exists)
                    {
                        directoryInfoErrorLog.Create();
                    }

                }
                catch (Exception excpt)
                {
                    MessageBox.Show($@"Exception occurred in Error Log -> msg = {excpt.Message} ; with stack trace = {excpt.StackTrace}");
                }

                Trace.Listeners.Clear();
                Trace.Listeners.Add(new TextWriterTraceListener(stringFullNamePathLogFile));// create a trace listener as a run log

                if (dtLastRun == null)
                {

                    dtLastRun = DateTime.Now;

                }

                this.PTMRunLogFileManager = new PolartecErrorLogFileManager(dtLastRun, PolartecErrorLog.stringLogFileNameFormat, stringLogFilePath);

            }
            else
            {

                ArgumentNullException argNullExcpt = new ArgumentNullException("applicationId",
                "The constructor parameter 'string applicationId' was passed either null or empty, when it was expected to be an initialized string object.");
                throw argNullExcpt;

            }
        }


        /// <summary>
        /// Destructor
        /// </summary>
        ~PolartecErrorLog() {  }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// <see cref="string"/>
        /// </summary>
        public string logFileName
        {
            get { return this.stringLogFileName; }
        }


        /// <summary>
        /// <see cref="string"/>
        /// </summary>
        public string logFilePath
        {
            get { return this.stringLogFilePath; }
        }


        /// <summary>
        /// <see cref="string"/>
        /// </summary>
        public string logFileFullPathName
        {
            get { return this.stringFullNamePathLogFile; }
        }


        /// <summary>
        /// <see cref="DateTime"/>
        /// </summary>
        public DateTime CurrentDateTime
        {
            get { return this.PTMRunLogFileManager.CurrentDateTime; }
        }

        #endregion

        #region [ Methods ]

        #region [ IDisposable ]

        /// <summary>
        /// 
        /// </summary>
        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"><see cref="bool"/></param>
        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {

            if (disposed)
            {

                return;

            }

            if (disposing)
            {

                Trace.Flush();
                Trace.Listeners.Clear();

                //--
                // put the call to deal with house cleaning here

                if (this.PTMRunLogFileManager != null)
                {

                    this.PTMRunLogFileManager.Dispose();
                    this.PTMRunLogFileManager = null;

                }
            }

            // Free any unmanaged objects here.
            disposed = true;

        }

        #endregion

        #region [ Implementation ]

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="outputMsgHeading"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private void PTMErrorLogWriteLine(string message, bool outputMsgHeading = false)
        {

            if (message != string.Empty || message != null)
            {
                if (outputMsgHeading)
                {
                    Trace.WriteLine("-- new log message --");
                }
                Trace.WriteLine(message);
            }
            else
            {
                ArgumentNullException argNullExcpt = new ArgumentNullException("message", "The method parameter 'string message' was passed either null or empty, when it was expected to be an initialized string object.");
                throw argNullExcpt;
            }
        }

        /// <summary>
        /// An method to output exception data to the trace output
        /// </summary>
        /// <param name="excpt"> <see cref="Exception"/></param>
        /// <exception cref="ArgumentNullException"> excpt </exception>
        public void PTMErrorLogOutputException(Exception excpt)
        {
            if (excpt != null)
            {

                this.PTMErrorLogWriteLine("Reporting Exception in 'SigConnXfer' assembly program.", true);
                this.PTMErrorLogWriteLine("Exception 'Message'");
                this.PTMErrorLogWriteLine(excpt.Message);
                this.PTMErrorLogWriteLine("Exception 'Source'");
                this.PTMErrorLogWriteLine(excpt.Source);
                this.PTMErrorLogWriteLine("Exception 'StackTrace'");
                this.PTMErrorLogWriteLine(excpt.StackTrace);
                this.PTMErrorLogWriteLine("Exception 'Data'");
                this.PTMErrorLogWriteLine(excpt.Data.ToString());

                if (excpt.InnerException != null)
                {

                    this.PTMErrorLogWriteLine("Exception InnerException 'Message'");
                    this.PTMErrorLogWriteLine(excpt.InnerException.Message);
                    this.PTMErrorLogWriteLine("Exception InnerException 'Source'");
                    this.PTMErrorLogWriteLine(excpt.InnerException.Source);
                    this.PTMErrorLogWriteLine("Exception InnerException 'StackTrace'");
                    this.PTMErrorLogWriteLine(excpt.InnerException.StackTrace);
                    this.PTMErrorLogWriteLine("Exception InnerException 'Data'");
                    this.PTMErrorLogWriteLine(excpt.InnerException.Data.ToString());

                }
            }
            else
            {
                ArgumentNullException argNullExcept = new ArgumentNullException("Exception excpt", "The Exception parameter except is null.");
                throw argNullExcept;
            }
        }

        /// <summary>
        /// POLYMORPH
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="excpt"></param>
        public void PTMErrorLogOutputException(string msg, Exception excpt)
        {
            PTMErrorLogOutputMessage(msg);
            PTMErrorLogOutputException(excpt);
        }

        /// <summary>
        /// polymorph method
        /// this takes a single string object
        /// </summary>
        /// <param name="message"> string message <see cref="string"/></param>
        /// <exception cref="ArgumentNullException">throw the deeper exception</exception>
        public void PTMErrorLogOutputMessage(string message)
        {
            try
            {

                this.PTMErrorLogWriteLine(message, true);

            }
            catch (ArgumentNullException excpt)
            {

                this.PTMErrorLogOutputException(excpt);
                throw excpt;

            }
        }


        /// <summary>
        /// polymorph method
        /// this takes a string array object
        /// </summary>
        /// <param name="message">string array <see cref="string"/></param>
        public void PTMErrorLogOutputMessage(string[] message)
        {

            if (message != null)
            {

                for (int i = 0; i < message.Length; i++)
                {

                    try
                    {

                        this.PTMErrorLogWriteLine(message[i], (i == 0 ? true : false));

                    }
                    catch (ArgumentNullException excpt)
                    {

                        this.PTMErrorLogOutputException(excpt);
                        throw excpt;

                    }
                }
                CheckCurrentLogFileSize();
            }
        }

        /// <summary>
        /// polymorph method
        /// this takes a single string object
        /// also outputs stack trace
        /// </summary>
        /// <remarks>
        /// <see cref="StackTrace"/>
        /// </remarks>
        /// <param name="message">string message <see cref="string"/></param>
        /// <param name="isWithDiagnostics"> boolean indicator to output Stack Trace <see cref="bool"/></param>
        public void PTMErrorLogOutputMessage(string message, bool isWithDiagnostics = false)
        {
            try
            {
                this.PTMErrorLogOutputMessage(message);
                if (isWithDiagnostics)
                {
                    this.PTMERLogOutputStackTrace();
                }
            }
            catch (ArgumentNullException excpt)
            {
                this.PTMErrorLogOutputException(excpt);
                throw excpt;
            }
            CheckCurrentLogFileSize();
        }

        /// <summary>
        /// polymorph method
        /// this takes a string array object
        /// also outputs stack trace
        /// </summary>
        /// <remarks>
        /// <see cref="StackTrace"/>
        /// </remarks>
        /// <param name="message">string message <see cref="string"/></param>
        /// <param name="isWithDiagnostics"> boolean indicator to output Stack Trace <see cref="bool"/></param>
        public void PTMErrorLogOutputMessage(string[] message, bool isWithDiagnostics = false)
        {
            try
            {
                this.PTMErrorLogOutputMessage(message);
                if (isWithDiagnostics)
                {
                    this.PTMERLogOutputStackTrace();
                }
            }
            catch (ArgumentNullException excpt)
            {
                this.PTMErrorLogOutputException(excpt);
                throw excpt;
            }
            CheckCurrentLogFileSize();
        }

        /// <summary>  </summary>
        /// <exception cref="ArgumentNullException"></exception>
        private void PTMERLogOutputStackTrace()
        {
            try
            {
                StackTrace stackTrace = new StackTrace(true);
                this.PTMErrorLogWriteLine(stackTrace.ToString());
            }
            catch (ArgumentNullException excpt)
            {

                this.PTMErrorLogOutputException(excpt);
                throw excpt;
            }
        }

        /// <summary>
        /// this class' public interface to clean up.
        /// </summary>
        public void CleanUp()
        {
            this.PTMRunLogFileManager.PolarERLManHouseClean();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            PTMErrorLogOutputMessage($@"Error/Run Log started at {DateTime.Now.ToString()}");
        }

        /// <summary>
        /// 
        /// </summary>
        public void Stop()
        {
            PTMErrorLogOutputMessage($@"Error/Run Log Closing at {DateTime.Now.ToString()}");
            CleanUp();
            Dispose();
        }

    /*
    private static void LogEvent(string filePath)
    {
        var outpath = $@"{Properties.Settings.Default.LogsPath}";
        var outfile = $@"{outpath}{Properties.Settings.Default.LogName}";
        var oldlogPath = $@"{outpath}{Properties.Settings.Default.ArchiveLogName}";
        var logFile = new FileInfo(outfile);
        var oldlog = new FileInfo(oldlogPath);
        if ((logFile.Exists) && (logFile.Length > 10240))
        {
            if (oldlog.Exists) oldlog.Delete();
            logFile.MoveTo(oldlogPath);
        }
        using (var writer = new StreamWriter(outfile,true))
        {
            writer.WriteLine($"{DateTime.UtcNow.ToLocalTime()}: {filePath}");
        }
    }
    */

        public void CheckCurrentLogFileSize()
        {
            try
            {
                // --
                // Check Log File Directory - create if not there
                FileInfo fi = new FileInfo(stringFullNamePathLogFile);
                if (fi.Exists)
                {
                    long l = fi.Length;

                    if (l >= 16777216)// 16Meg Limit Line
                    {
                        Trace.Flush();
                        Trace.Listeners.Clear();
                        _intRefileCount++;

                        string[] arrayInfo = { $@"{_applicationID}", $@"{_dtReference.Ticks.ToString()}", $@"{_intRefileCount}" };
                        stringLogFileName = string.Format(PolartecErrorLog.stringLogFileNameFormat, arrayInfo);
                        stringFullNamePathLogFile = string.Format("{0}\\{1}", stringLogFilePath, stringLogFileName);

                        Trace.Listeners.Add(new TextWriterTraceListener(stringFullNamePathLogFile));// create a trace listener as a run log

                        Trace.WriteLine($@"Starting ReFile {stringLogFileName}");
                        Trace.WriteLine($@"Starting ReFile At Path {stringFullNamePathLogFile}");
                        Trace.Flush();
                    }
                }
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt}");
            }
        }
        #endregion

        #endregion

        #region [ Static ]

        /// <summary>
        /// the public means to output a program exception into the error log
        /// </summary>
        /// <param name="excpt"> the exception <see cref="Exception"/></param>
        public static void PTMErrorLogExceptionOutput(Exception excpt)
        {
            if (excpt != null)
            {
                Trace.WriteLine("Reporting Exception in 'SigConnXfer' assembly program.");
                Trace.WriteLine("Exception 'Message'");
                Trace.WriteLine(excpt.Message);
                Trace.WriteLine("Exception 'Source'");
                Trace.WriteLine(excpt.Source);
                Trace.WriteLine("Exception 'StackTrace'");
                Trace.WriteLine(excpt.StackTrace);
                Trace.WriteLine("Exception 'Data'");
                Trace.WriteLine(excpt.Data.ToString());

                if (excpt.InnerException != null)
                {
                    Trace.WriteLine("Exception InnerException 'Message'");
                    Trace.WriteLine(excpt.InnerException.Message);
                    Trace.WriteLine("Exception InnerException 'Source'");
                    Trace.WriteLine(excpt.InnerException.Source);
                    Trace.WriteLine("Exception InnerException 'StackTrace'");
                    Trace.WriteLine(excpt.InnerException.StackTrace);
                    Trace.WriteLine("Exception InnerException 'Data'");
                    Trace.WriteLine(excpt.InnerException.Data.ToString());
                }
            }
            else
            {
                ArgumentNullException argNullExcept = new ArgumentNullException("Exception excpt", "The Exception parameter except is null.");
                throw argNullExcept;
            }
        }

        #endregion

        #region [ Internal Classes ]

        /// <summary>
        /// wraps functionality to manage the Error/log files produced by the 
        /// class PolartecErrorRunLog
        /// 
        /// Especially directory cleanup and Error/Log file clean up
        /// </summary>
        private class PolartecErrorLogFileManager : IDisposable
        {
            #region [ Members ]

            private bool disposed = false;          // IDisposable implementation
            private DateTime dtLastRunDateTime;     //
            private DateTime dtCurrentDateTime;
            private int archiveDaysLimit = 10;      //
            private int archiveFileQntyLimit = 100;  //
            private DateTime dtFileDateLimit;
            private string stringNameFormat = "";
            private string stringStoragePath = "";

            #endregion

            #region [ Constructors ]

            public PolartecErrorLogFileManager(DateTime dtLastRun, string strNameFormat, string strLogPath)
            {
                this.dtLastRunDateTime = dtLastRun;
                this.dtCurrentDateTime = DateTime.Now;
                this.dtFileDateLimit = this.CurrentDateTime.AddDays(-archiveDaysLimit);
                this.stringNameFormat = strNameFormat;
                this.stringStoragePath = strLogPath;
            }

            ~PolartecErrorLogFileManager()
            { }

            #endregion

            #region [ Properties ]

            public DateTime CurrentDateTime
            {
                get { return this.dtCurrentDateTime; }
            }

            #endregion

            #region [ Methods ]

            #region [ IDisposable ]

            /// <summary>
            /// Public implementation of Dispose pattern callable by consumers.
            /// </summary>
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            /// <summary>Protected implementation of Dispose pattern.</summary>
            /// <param name="disposing"><see cref="bool"/></param>
            protected virtual void Dispose(bool disposing)
            {
                if (disposed)
                {
                    return;
                }

                if (disposing)
                { }
                // Free any unmanaged objects here.
                disposed = true;
            }

            #endregion

            #region [ Implementation ]


            /// <summary>  </summary>
            public void PolarERLManHouseClean()
            { int cleanupcount = DoFileHouseKeeping(); }

            /// <summary> </summary>
            /// <returns></returns>
            private int DoFileHouseKeeping()
            {
                DirectoryInfo dirinfoLogDirectory = new DirectoryInfo(this.stringStoragePath);
                FileInfo[] fia = dirinfoLogDirectory.GetFiles("LogFile*.txt");
                int intMethodReturnValue = -1;
                // if the directory has a lot of files OR I ran this a really long time ago
                // THEN I will check to clean up files
                if ((fia.Length > archiveFileQntyLimit) || (dtLastRunDateTime < dtFileDateLimit))
                {
                    int filecleanupcount = fia.Length - archiveFileQntyLimit;
                    foreach (FileInfo fi in fia)
                    {
                        if (fi.LastWriteTime < dtFileDateLimit || filecleanupcount >= 1)
                        {
                            // To Implement; A process to clean up only the very oldest files first
                            // consider - fortunate it looks as though how i named file
                            // by making DateTime.Now.UTCTick() part of name makes the 
                            // earliest alphabetical file the oldest file
                            try
                            {
                                fi.Delete();
                                filecleanupcount--;
                                intMethodReturnValue++;
                            }
                            catch (IOException ioexcpt)
                            {
                                PolartecErrorLog.PTMErrorLogExceptionOutput(ioexcpt);
                            }
                            catch (UnauthorizedAccessException uaexcpt)
                            {
                                PolartecErrorLog.PTMErrorLogExceptionOutput(uaexcpt);
                            }
                            catch (Exception excpt)
                            {
                                PolartecErrorLog.PTMErrorLogExceptionOutput(excpt);
                            }
                        }
                    }
                }
                return intMethodReturnValue;
            }

            #endregion

            #endregion

        }

        #endregion

    }
}
/*
    private static void LogEvent(string filePath)
    {
        var outpath = $@"{Properties.Settings.Default.LogsPath}";
        var outfile = $@"{outpath}{Properties.Settings.Default.LogName}";
        var oldlogPath = $@"{outpath}{Properties.Settings.Default.ArchiveLogName}";
        var logFile = new FileInfo(outfile);
        var oldlog = new FileInfo(oldlogPath);
        if ((logFile.Exists) && (logFile.Length > 10240))
        {
            if (oldlog.Exists) oldlog.Delete();
            logFile.MoveTo(oldlogPath);
        }
        using (var writer = new StreamWriter(outfile,true))
        {
            writer.WriteLine($"{DateTime.UtcNow.ToLocalTime()}: {filePath}");
        }
    }
*/
