using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            v = ConfigSettings.ReturnConfigSettingsConnectionString("SpikeContainer.Properties.Settings.TestMesDbConnectionString");
            Trace.WriteLine(v);
            v = ConfigSettings.ReturnConfigSettingsConnectionString("TestMesDbEntities");
            Trace.WriteLine(v);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string v = ConfigSettings.ReturnConfigSettingsAppSettingKeyValue("Author");
            Trace.WriteLine(v);
            v = ConfigSettings.ReturnConfigSettingsAppSettingKeyValue("Hodad");
            Trace.WriteLine(v);

            v = ConfigSettings.ReturnConfigSettingsUsersSettingKeyData("SpecialUser");
            Trace.WriteLine(v);
            v = ConfigSettings.ReturnConfigSettingsUsersSettingKeyData("SpecialDomain");
            Trace.WriteLine(v);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string v = ConfigSettings.ReturnCustomSectionConfigSettingsSettingKeyValue("specialAppSettings","Frankeinstein");
            Trace.WriteLine(v);
            v = ConfigSettings.ReturnCustomSectionConfigSettingsSettingKeyValue("applicationSettings", "Company");
            Trace.WriteLine(v);
            v = ConfigSettings.ReturnCustomSectionConfigSettingsSettingKeyValue("applicationSettings", "Product");
            Trace.WriteLine(v);
            v = ConfigSettings.ReturnCustomSectionConfigSettingsSettingKeyValue("applicationSettings", "Who");
            Trace.WriteLine(v);
            v = ConfigSettings.ReturnCustomSectionConfigSettingsSettingKeyValue("applicationSettings", "What");
            Trace.WriteLine(v);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            bool b = ConfigSettings.AddConfigSettingsAppSetting("PetShopBoys", "WestEndGirls");
            Trace.WriteLine($@"{b.ToString()}");
            b = ConfigSettings.AddConfigSettingsAppSetting("TheGoGos", "Our Lips Are Sealed");
            Trace.WriteLine($@"{b.ToString()}");
            b = ConfigSettings.AddConfigSettingsAppSetting("Bangles", "Manic Monday");
            Trace.WriteLine($@"{b.ToString()}");

            ConfigSettings.AddConfigSettingsUsersSetting("Larry", "Moe");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            bool b = ConfigSettings.AddConfigSettingsCustomSectionSetting("ScaryMovies","LoveStory", "DeathBecomesHer");
            b = ConfigSettings.AddConfigSettingsCustomSectionSetting("ScaryMovies", "Silent Scream", "She Slashes");
            b = ConfigSettings.AddConfigSettingsCustomSectionSetting("ScaryMovies", "Young Frankenstein", "No Not Really");
            Trace.WriteLine($@"{b.ToString()}");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            bool b = ConfigSettings.UpdateConfigSettingsAppSetting("PetShopBoys", "Shopping or Crying Game with Boy George");
            Trace.WriteLine($@"{b.ToString()}");


            b = ConfigSettings.UpdateConfigSettingsUsersSetting("", "");
            ConfigSettings.UpdateConfigSettingsUsersSetting("SpecialUser", "Jim Fowler");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            bool b = ConfigSettings.UpdateConfigCustomSectionAppSetting("ScaryMovies", "LoveStory", "NotIntoNecrophilia");
            Trace.WriteLine($@"{b.ToString()}");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //bool b = ConfigSettings.
            bool b = ConfigSettings.UpdateConfigCustomSectionAppSetting("specialAppSettings", "Frankeinstein", "Abby N. Ormal");
            b = ConfigSettings.UpdateConfigCustomSectionAppSetting("applicationSettings", "Who", "Is on First Base");
            Trace.WriteLine($@"{b.ToString()}");
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            StringCollection strArray = SpikeContainer.Properties.Settings.Default.ExcludedDirectories;

            //ConfigSettings.UpdateConfigSettingsUsersSetting("SpecialUser", "Jim Fowler");

            //string v = ConfigSettings.ReturnCustomSectionConfigSettingsSettingKeyValue("applicationSettings", "ExcludedDirs");
            //Trace.WriteLine(v);

            //string returnvalue = ConfigSettings.Testy();
            string returnvalue = ConfigSettings.ReturnConfigSettingsUsersSettingKeyData("ExcludedDirectories");

            string Upity = Environment.NewLine;
            string [] seps = { $@"{Upity}"};
            List<string> strList =  returnvalue.Split(seps,StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> strTimed = strList.Select(r => r.Trim()).ToList();
            List<string> strRefined = strTimed.Where(s => !string.IsNullOrEmpty(s)).ToList();


            string str = ConfigSettings.ReturnCustomSectionConfigSettingsSettingKeyValue("applicationSettings", "ExcludedDirs");
            List<string> strList1 = str.Split(seps, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> strTimed1 = strList1.Select(r => r.Trim()).ToList();
            List<string> strRefined1 = strTimed1.Where(s => !string.IsNullOrEmpty(s)).ToList();


            string str1 = ConfigSettings.ReturnConfigGroupSectionKeyData("userSettings", "SpikeContainer.Properties.Settings","ExcludedDirectories");
            List<string> strList2 = str1.Split(seps, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> strTimed2 = strList1.Select(r => r.Trim()).ToList();
            List<string> strRefined2 = strTimed1.Where(s => !string.IsNullOrEmpty(s)).ToList();
        }




    }
}