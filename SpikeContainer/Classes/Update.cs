using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace PFCS.Classes
{
    internal static class Update
    {
        private static string _updateTarget;

        public static void CheckVersion(string file)
        {
            var app = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            var appPath = AppDomain.CurrentDomain.BaseDirectory;
            _updateTarget = Path.Combine(appPath, $@"{file}.exe");
            CheckFile(file);
            if (file != "Update") return;
           // if (!Data.Global.Debug)
            UpdateVersion(Data.SystemVariables.UpdateDir, appPath, app);
        }

        private static void UpdateVersion(string masterPath, string appPath, string app)
        {
            var currentVersionInfo =
                FileVersionInfo.GetVersionInfo($@"{appPath}\{app}.exe");
            Data.Global.CurVersion = new Version(currentVersionInfo.ProductVersion);
            Data.Global.MasterPath = $@"{masterPath}\{app}.exe";
            var masterVersionInfo = FileVersionInfo.GetVersionInfo(Data.Global.MasterPath);
            var mv = new Version(masterVersionInfo.ProductVersion);
            if (Data.Global.CurVersion == mv) return;
            if (Data.Global.CurVersion > mv)
            {
                if (Data.Global.Debug) return;
                if (
                    Msg.AnswerNo(
                        "The current version of this application is newer than the version on the server.  " +
                        "Do you wish to downgrade versions?", "Confirm Version Downgrade")) return;
            }

            var args = new StringBuilder($"\"{app}\" \"{masterPath}\" \"{appPath}\\\"");
            if (Data.Global.StartupArgs != null)
            {
                foreach (var arg in Data.Global.StartupArgs)
                {
                    args.Append($" \"{arg}\"");
                }
            }
            var proc = new ProcessStartInfo {FileName = _updateTarget, Arguments = args.ToString()};
            Process.Start(proc);
            Process.GetCurrentProcess().Kill();
        }

        private static void CheckFile(string file)
        {
            var updateFile = string.Format(@"{0}\{1}\{1}.exe", Data.SystemVariables.UpdateSource, file);
            if (File.Exists(_updateTarget))
            {
                var currentVersionInfo =
                    FileVersionInfo.GetVersionInfo(_updateTarget);
                var cv = new Version(currentVersionInfo.ProductVersion);
                if (!File.Exists(updateFile)) return;
                var masterVersionInfo = FileVersionInfo.GetVersionInfo(updateFile);
                var mv = new Version(masterVersionInfo.ProductVersion);
                if (file == "Update" && cv >= mv) return;
            }
            File.Copy(updateFile, _updateTarget, true);
        }

        internal static bool UpdateAvailable()
        {
            var masterVersionInfo = FileVersionInfo.GetVersionInfo(Data.Global.MasterPath);
            var mv = new Version(masterVersionInfo.ProductVersion);
            return Data.Global.CurVersion < mv;
        }
    }
}

