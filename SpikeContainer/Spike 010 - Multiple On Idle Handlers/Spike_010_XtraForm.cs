using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpikeContainer.Spike_010___Multiple_On_Idle_Handlers
{
    public partial class Spike_010_XtraForm : DevExpress.XtraEditors.XtraForm
    {
        public Spike_010_XtraForm()
        {
            InitializeComponent();
        }

        private void ApplicationIdle1Idle(object sender, EventArgs e)
        {
            textBox1.Text += $@"applicationIdle1 Firing, to fire every 1 minute. {DateTime.Now.ToLongTimeString()} {Environment.NewLine}";
            applicationIdle1.Start();
        }
        private void ApplicationIdle2Idle(object sender, EventArgs e)
        {
            textBox1.Text += $@"applicationIdle2 Firing, to fire every 3 minute. {DateTime.Now.ToLongTimeString()} {Environment.NewLine}";
            applicationIdle2.Start();
        }
        private void ApplicationIdle3Idle(object sender, EventArgs e)
        {
            textBox1.Text += $@"applicationIdle3 Firing, to fire every 5 minute. {DateTime.Now.ToLongTimeString()} {Environment.NewLine}";
            applicationIdle3.Start();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            applicationIdle1.IdleTime = new TimeSpan(0, 0, 30);
            applicationIdle1.Start();

            textBox1.Text += $@"applicationIdle1 Has started, to fire every 1 minute. {Environment.NewLine}";

            applicationIdle2.IdleTime = new TimeSpan(0, 0, 45);
            applicationIdle2.Start();

            textBox1.Text += $@"applicationIdle2 Has started, to fire every 3 minutes. {Environment.NewLine}";

            applicationIdle3.IdleTime = new TimeSpan(0, 1, 0);
            applicationIdle3.Start();

            textBox1.Text += $@"applicationIdle3 Has started, to fire every 5 minutes. {Environment.NewLine}";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            applicationIdle1.Stop();

            textBox1.Text += $@"applicationIdle1 Stopping. {Environment.NewLine}";

            applicationIdle2.Stop();

            textBox1.Text += $@"applicationIdle1 Stopping. {Environment.NewLine}";

            applicationIdle3.Stop();

            textBox1.Text += $@"applicationIdle1 Stopping. {Environment.NewLine}";
        }
    }
}