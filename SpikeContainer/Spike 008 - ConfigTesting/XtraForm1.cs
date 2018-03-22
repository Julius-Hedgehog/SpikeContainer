﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpikeContainer.Spike_008___ConfigTesting
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string v = ConfigSettings.ReturnConfigSettingsConnectionString("MesDbModel");
            Trace.WriteLine(v);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string v = ConfigSettings.ReturnConfigSettingsAppSettingKeyValue("Author");
            Trace.WriteLine(v);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string v = ConfigSettings.ReturnCustomSectionConfigSettingsSettingKeyValue("specialAppSettings","Frankeinstein");
            Trace.WriteLine(v);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            bool b = ConfigSettings.AddConfigSettingsAppSetting("PetShopBoys", "WestEndGirls");
            Trace.WriteLine($@"{b.ToString()}");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            bool b = ConfigSettings.AddConfigSettingsCustomSectionSetting("ScaryMovies","LoveStory", "DeathBecomesHer");
            Trace.WriteLine($@"{b.ToString()}");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            bool b = ConfigSettings.UpdateConfigSettingsAppSetting("PetShopBoys", "Shopping or Crying Game with Boy George");
            Trace.WriteLine($@"{b.ToString()}");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            bool b = ConfigSettings.UpdateConfigCustomSectionAppSetting("ScaryMovies", "LoveStory", "NotIntoNecrophilia");
            Trace.WriteLine($@"{b.ToString()}");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //bool b = ConfigSettings.
        }
    }
}