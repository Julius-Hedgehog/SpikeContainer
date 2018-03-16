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

namespace SpikeContainer.Spike_006
{
    public partial class Spike_006_Main : Form
    {
        public Spike_006_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? op = 0;
            int wo = Convert.ToInt32(400000);

            var path = $@"{Application.StartupPath}\Temp\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var filename = $@"TEST_wi{DateTime.Now.ToFileTime()}.sig";
            var filePath = path + filename;

            var dt = DateTime.Now.ToString("MM/dd/yy");

            using (var swfile = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (var swFile = new StreamWriter(swfile))
                {
                    for(int i = 0; i<= 10; i++) // for each roll in Item Group
                    {
                        string item = $@"G9110";
                        var qty = 1001.9;
                        var sn = $@"123456";

                        //swFile.WriteLine($"{wo},{op},{dt},{item},{op},{qty},{sn},{wo},/r/n");
                        // ?? ?? ?? ?? ?? ?? 
                        swFile.WriteLine($"{wo},{op},{dt},{item},{op},{qty},{sn},{wo},");
                    }
                }
            }
        }
    }
}
