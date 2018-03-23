

//******************************************************************************************************
// ConfigSettings.cs -::- PTMCommonClassesCode: Assembly - PTMCommonClassesCode: Solution - PTMCommonClassesCode: Project
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

/*
 * // - - - - - - - - - - - - - - - - - - - - - - - - - 
 *  ConfigSettings.cs
 *  INCLUSION USAGE INSTRUCTIONS
 *  Add project Reference to 
 *  using System.Configuration;
 *  using System.Collections.Specialized;
 *  <code> <text ei=
 *  using {external project namespace};/>
 *  </code>
 *  </code>
 * // - - - - - - - - - - - - - - - - - - - - - - - - - 
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeContainer.Spike_008___ConfigTesting
{
    /// <summary>
    /// A simple common class to wrap config file calls for PTM application code
    /// </summary>
    public class ConfigSettings : IDisposable
    {
        #region [ Members ]
        // Nested Types
        // Constants
        // Delegates
        // Events
        // Fields

        #endregion

        #region [ Constructors ]

       /// <summary>
       /// public contructor
       /// </summary>
        public ConfigSettings()
        {   }

        #endregion

        #region [ Properties ]

        #endregion

        #region [ Methods ]

        #region [ IDisposable ]

        private bool disposedValue = false; // To detect redundant calls

        /// <summary>
        /// disposition
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                disposedValue = true;
            }
        }

        // override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ConfigSettings() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        /// <summary>
        /// This code added to correctly implement the disposable pattern.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        #region [ Implementation ]

        #endregion

        #endregion

        //#region [ Operators ]
        //#endregion

        #region [ Static ]

        // Static Fields
        // Static Constructor
        // Static Properties
        // Static Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settingName"></param>
        /// <returns></returns>
        public static string ReturnConfigSettingsConnectionString(string settingName)
        {
            string configConnString = "";
            try
            {
                ConnectionStringSettingsCollection configMan = ConfigurationManager.ConnectionStrings;
                configConnString = configMan[settingName].ConnectionString;
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return configConnString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string ReturnConfigSettingsAppSettingKeyValue(string keyName)
        {
            string appSettingsString = "";
            try
            {
                NameValueCollection appSettings = ConfigurationManager.AppSettings;
                appSettingsString = appSettings[keyName];
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return appSettingsString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string ReturnConfigSettingsUsersSettingKeyValue(string keyName)
        {
            string appSettingsString = "";
            try
            {
                var appSettingsSection = (ClientSettingsSection)(ConfigurationManager.GetSection("userSettings"));
                //var appSettingsSection = (ClientSettingsSection)(ConfigurationManager.GetSection("SpikeContainer.Properties.Settings"));
                var appSettings = appSettingsSection.Settings;
                var x = appSettings.Get(keyName).Value;
                appSettingsString = Convert.ToString(x);
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return appSettingsString;
        }

        public static string ReturnCustomSectionConfigSettingsSettingKeyValue(string sectionName, string keyName)
        {
            string appSettingsString = "";
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ClientSettingsSection confSect = (ClientSettingsSection)configFile.GetSection(sectionName);
                SettingElementCollection appSettings = confSect.Settings;

                var v = appSettings.Get(keyName);

                appSettingsString =Convert.ToString(v.Value.ValueXml.InnerText);
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return appSettingsString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool AddConfigSettingsAppSetting(string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = configFile.AppSettings;
                if (appSettings.Settings[keyName] == null) { appSettings.Settings.Add(keyName, value); }
                configFile.Save(ConfigurationSaveMode.Modified,true);
                ConfigurationManager.RefreshSection(appSettings.SectionInformation.Name);
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}"); 
            }
            return bMethodReturnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="keyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool AddConfigSettingsCustomSectionSetting(string sectionName, string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ClientSettingsSection confSect = (ClientSettingsSection)configFile.GetSection(sectionName);
                if (confSect == null)
                {
                    ClientSettingsSection adding = new ClientSettingsSection();
                    configFile.Sections.Add(sectionName, adding);

                    configFile.Save(ConfigurationSaveMode.Modified, true);

                    confSect = (ClientSettingsSection)configFile.GetSection(sectionName);
                }
                
                SettingElementCollection appSettings = confSect.Settings;
                if (appSettings.Get(keyName) == null)
                {
                    SettingElement se = new SettingElement(keyName, SettingsSerializeAs.String);

                    SettingValueElement sve = new SettingValueElement
                    {
                        ValueXml = new System.Xml.XmlDocument { InnerXml = $@"<value>{value}</value>" }
                    };
                    se.Value = sve;
                    appSettings.Add(se);
                }
                configFile.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection(confSect.SectionInformation.Name);
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return bMethodReturnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool UpdateConfigSettingsAppSetting(string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = configFile.AppSettings;
                if (appSettings.Settings[keyName] == null) { appSettings.Settings[keyName].Value = value; }
                configFile.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection(appSettings.SectionInformation.Name);
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return bMethodReturnValue;
        }

        public static bool UpdateConfigCustomSectionAppSetting(string sectionName, string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection confSect = (AppSettingsSection)configFile.GetSection(sectionName);
                if (confSect.Settings[keyName] == null) { confSect.Settings[keyName].Value = value; }
                configFile.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection(confSect.SectionInformation.Name);
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return bMethodReturnValue;
        }

        public static bool OpenConfigIntoDataSet()
        {
            bool bReturnValue = false;

            try
            {
                Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string strFilePath = conf.FilePath;
                DataSet ds = new DataSet("MyTestConfig");
                ds.ReadXml(strFilePath);

                ds.Clear();
                ds.Dispose();
            }
            catch (Exception xcpt)
            {
                Trace.WriteLine($@"{xcpt.Message}");
            }

            return bReturnValue;
        }

        #endregion

        //#region [ Internal Classes ]
        //#endregion
    }
}
