﻿

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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTMCommonClassesCode;

// <code include= 'using {external project namespace};' />
using PFCS;
using PFCS.Classes;

namespace PFCS.Classes
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
                Msg.ProgError(excpt.Message, excpt);
                //PolartecErrorLog.PTMErrorLogExceptionOutput(excpt);
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
                Msg.ProgError(excpt.Message, excpt);
                //PolartecErrorLog.PTMErrorLogExceptionOutput(excpt);
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
                Msg.ProgError(excpt.Message, excpt);
                //PolartecErrorLog.PTMErrorLogExceptionOutput(excpt);
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
                Msg.ProgError(excpt.Message, excpt);
                //PolartecErrorLog.PTMErrorLogExceptionOutput(excpt);
            }
            return bMethodReturnValue;
        }

        #endregion

        //#region [ Internal Classes ]
        //#endregion
    }
}
