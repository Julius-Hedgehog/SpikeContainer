using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeContainer.Spike_005
{
    public partial class Spike005Main : Form
    {
        public Spike005Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DirectoryInfo di = new DirectoryInfo($@"C:\Code\Repos\SigConn - SigConnXfer\SigCon-SigConXfer\WorkingTest\Junk Test Files");

            //FileInfo[] fileInfoArray = di.GetFiles("pr*.sig|pr*.sig_?"); // ERRORED ILLEGAL CHAR IN PATH
            //FileInfo[] fileInfoArray = di.GetFiles($@"pr*.sig|pr*.sig_?"); // ERRORED ILLEGAL CHAR IN PATH
            //FileInfo[] fileInfoArray = di.GetFiles($@"pr*.sig*",SearchOption.AllDirectories);
            //DirectoryInfo[] dirInfoArray = di.GetDirectories($@"pr*.sig*", SearchOption.AllDirectories);


            var files = new List<string>();
            var targetPath = $@"C:\Code\Repos\SigConn - SigConnXfer\SigCon-SigConXfer\WorkingTest\Junk Test Files";
            var targetFile = "pr*.sig"; // "pr123456.sig";

            var dir = new DirectoryInfo(targetPath);
            files.AddRange(dir.GetFiles((targetFile + "*"),SearchOption.AllDirectories).Select(r => r.Name).ToList());
            foreach (string subDir in Directory.GetDirectories(targetPath, "*", SearchOption.AllDirectories))
            {
                var sub = new DirectoryInfo(subDir);
                files.AddRange(sub.GetFiles(targetFile + "*").Select(r => r.Name));
            }
            if (files.Count != 0)
            {
                var lstfile = files.Max();
                var seq = lstfile.Contains("_") ? Convert.ToInt32(lstfile.Split('_').Last()) + 1 : 1;
                targetFile = targetFile + "_" + seq;
            }


            /*
             *  var files = new List<string>();
                var targetPath = "";
                var targetFile ="pr123456.sig";

                var dir = new DirectoryInfo(targetPath);
                files.AddRange(dir.GetFiles((targetFile + "*")).Select(r => r.Name).ToList());
                foreach (string subDir in Directory.GetDirectories(targetPath, "*", SearchOption.AllDirectories))
                {
                    var sub = new DirectoryInfo(subDir);
                    files.AddRange(sub.GetFiles(targetFile + "*").Select(r => r.Name));
                }
                if (files.Count != 0)
                {
                    var lstfile = files.Max();
                    var seq = lstfile.Contains("_") ? Convert.ToInt32(lstfile.Split('_').Last()) + 1 : 1;
                    targetFile = targetFile + "_" + seq;
                }
                try
                {
                    File.Copy(targetFile, newpath);
                    File.Move(targetFile, newpath);
                }
                catch (Exception xcpt)
                {

                }
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
