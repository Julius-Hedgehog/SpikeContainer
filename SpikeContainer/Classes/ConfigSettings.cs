

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
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
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

        /*
         <?xml version="1.0" encoding="utf-8"?>
            <configuration>
                <configSections>

                    <!-- ** SEE CREF =  -->
                    <section name="{name of section}" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />

                    <!-- ** SEE CREF = region [ CUSTOM CONFIGURATION GROUP with SECTION  ] ** -->
                    <sectionGroup name="{name of group}" type="System.Configuration.UserSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
                      <section name="{name of section in group}" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowExeDefinition="MachineToLocalUser" requirePermission="false" />
                    </sectionGroup>

                    <!-- ** SEE CREF = region [ USER SETTINGS SECTION ] ** -->
                    <sectionGroup name="userSettings" type="System.Configuration.UserSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
                      <section name="{{project Namespace Name}.Properties.Settings}" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowExeDefinition="MachineToLocalUser" requirePermission="false" />
                    </sectionGroup>

                </configSections>

                <startup>
                    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.2" />
                </startup>

                <userSettings>
                <!-- ** SEE CREF = region [ USER SETTINGS SECTION ] ** -->
                    <{{project Namespace Name}.Properties.Settings}>
                        <setting name="{name of section in group}" serializeAs="String">
                                <value>{settingValue}</value>
                        </setting>
                    </{{project Namespace Name}.Properties.Settings}>
                </userSettings>

                <connectionStrings> 
                    <!-- ** SEE CREF = region [ CONNECTIONS STRING SECTION ] ** -->
                    <add name="{Connection string name}" connectionString="{connection string}" providerName="System.Data.SqlClient" />
                </connectionStrings>

                <appSettings>
                    <!-- ** SEE CREF = region [ APPLICATION SECTION ] ** -->
                    <add key="keyname" value="keyValue" />
                </appSettings>

                <{name of group}>
                <!-- ** SEE CREF = region [ CUSTOM CONFIGURATION GROUP with SECTION  ] ** -->
                <{name of section}>
                    <setting name="{settingName}" serializeAs="String">
                        <value>{settingValue}</value>
                    </setting>
                </{name of section}>
                </{name of group}>

                <{name of section}>
                <!-- ** SEE CREF = region [ CUSTOM CONFIG SECTION (no group) ] ** -->
                    <setting name="{settingName}" serializeAs="String">
                        <value>{settingValue}</value>
                    </setting>
                </{name of section}>

        </configuration>
        */

        #region [ CONNECTIONS STRING SECTION ]

        // SEE ABOVE REFERENCE **
        /*
         <?xml version="1.0" encoding="utf-8"?>
            <configuration>
                <configSections>
                ...
                </configSections>
            
            ...

                <connectionStrings> 
                    <add name="{Connection string name}" connectionString="{connection string}" providerName="System.Data.SqlClient" />
                </connectionStrings>

            ...

         </configuration>
         */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settingName"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static string ReturnConfigSettingsConnectionString(string settingName, string provider = null)
        {
            string configConnString = "";
            try
            {
                ConfigurationManager.RefreshSection("connectionStrings");
                // OPENS THE CONFIG TO CONNECTIONS STRINGS SECTION
                //
                //Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //ConnectionStringsSection csc =  configFile.ConnectionStrings;
                //ConnectionStringSettingsCollection cssc = csc.ConnectionStrings;
                //foreach (ConnectionStringSettings css in cssc)
                //    if (css.Name.Contains(settingName))
                //    {
                //        configConnString = css.ConnectionString;
                //        //configConnString = css.ProviderName;
                //    }
                //

                ConnectionStringSettingsCollection configMan = ConfigurationManager.ConnectionStrings;
                configConnString = configMan[settingName].ConnectionString;
                if (!string.IsNullOrEmpty(provider))
                    configConnString = configMan[settingName].ProviderName;
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
        /// <param name="settingName"></param>
        /// <param name="connection"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool AddConfigSettingsConnectionString(string settingName, string connection, string provider)
        {
            bool bMethodReturnValue = false;
            try
            {
                //Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //ConnectionStringsSection csc = configFile.ConnectionStrings;
                //ConnectionStringSettingsCollection cssc = csc.ConnectionStrings;
                //bool bHasSetting = false;
                //foreach (ConnectionStringSettings css in cssc)
                //    if (css.Name.Contains(settingName))
                //    {
                //        bHasSetting = true;
                //        break;
                //    }

                //if (!bHasSetting)
                //{
                //    ConnectionStringSettings css = new ConnectionStringSettings(settingName, connection, provider);
                //    cssc.Add(css);
                //    bMethodReturnValue = true;
                //    configFile.Save(ConfigurationSaveMode.Modified, true);
                //    bMethodReturnValue = true;
                //    ConfigurationManager.RefreshSection(csc.SectionInformation.Name);
                //}
                ConfigurationManager.RefreshSection("connectionStrings");
                ConnectionStringSettingsCollection configMan = ConfigurationManager.ConnectionStrings;
                ConnectionStringSettings css = new ConnectionStringSettings(settingName, connection, provider);
                configMan.Add(css);
                bMethodReturnValue = true;
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }

            return bMethodReturnValue;
        }

        #endregion

        #region [ APPLICATION SECTION ]

        // SEE ABOVE REFERENCE **
        /*
         <?xml version="1.0" encoding="utf-8"?>
            <configuration>
                <configSections>
                ...
                </configSections>
            
            ...

            <appSettings>
                <add key = "{keyname}" value="{keyValue}" />
            </appSettings>

            ...

         </configuration>
         */


        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string ReturnConfigSettingsAppSettingKeyValue(string keyName)
        {
            string appSettingsString = "";
            string[] keyArray;
            try
            {
                ConfigurationManager.RefreshSection("appSettings");
                // OPENS THE CONFIG TO CONNECTIONS STRINGS SECTION
                //
                //Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //AppSettingsSection a5s = configFile.AppSettings;
                //KeyValueConfigurationCollection kvcc = a5s.Settings;
                ////var y = kvcc[keyName].Value;
                //foreach (string css in kvcc.AllKeys)
                //    if (css.Contains(keyName))
                //    {
                //        appSettingsString = kvcc[keyName].Value;
                //        break;
                //    }

                NameValueCollection appSettings = ConfigurationManager.AppSettings;
                keyArray = appSettings.GetValues(keyName);
                foreach (string s in keyArray)
                    appSettingsString += s;
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
                // OPENS THE CONFIG TO CONNECTIONS STRINGS SECTION
                //
                //Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //AppSettingsSection a5s = configFile.AppSettings;
                //KeyValueConfigurationCollection kvcc = a5s.Settings;
                //bool bHasKey = false;
                //foreach (string css in kvcc.AllKeys)
                //    if (css.Contains(keyName))
                //    {
                //        bHasKey = true;
                //        break;
                //    }
                //if (!bHasKey)
                //{
                //    KeyValueConfigurationElement kvce = new KeyValueConfigurationElement(keyName, value);
                //    kvcc.Add(kvce);
                //}
                ConfigurationManager.RefreshSection("appSettings");
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = configFile.AppSettings;
                if (appSettings.Settings[keyName] == null)
                {
                    appSettings.Settings.Add(keyName, value);
                    bMethodReturnValue = true;
                }
                configFile.Save(ConfigurationSaveMode.Modified, true);
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
        /// <param name="keyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool UpdateConfigSettingsAppSetting(string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                // OPENS THE CONFIG TO CONNECTIONS STRINGS SECTION
                //
                //Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //AppSettingsSection a5s = configFile.AppSettings;
                //KeyValueConfigurationCollection kvcc = a5s.Settings;
                //bool bHasKey = false;
                //foreach (string css in kvcc.AllKeys)
                //    if (css.Contains(keyName))
                //    {
                //        bHasKey = true;
                //        break;
                //    }
                //if (bHasKey)
                //{
                //    kvcc[keyName].Value = value;
                //}
                ConfigurationManager.RefreshSection("appSettings");
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = configFile.AppSettings;
                if (appSettings.Settings[keyName] != null)
                {
                    appSettings.Settings[keyName].Value = value;
                    bMethodReturnValue = true;
                }
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

        #region [ USER SETTINGS SECTION ]

        // SEE ABOVE REFERENCE **
        /*
          <?XML version ="1.0' encoding="utf-8">
          <configuration>
          <configSections>
                ...
                <sectionGroup name="userSettings" type="System.Configuration.UserSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
                    <section name="{project Namespace name}.Properties.Settings" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowExeDefinition="MachineToLocalUser" requirePermission="false" />
                </sectionGroup>

                <sectionGroup name="{name of group}" type="System.Configuration.UserSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
                    <section name="{name of section in group}" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowExeDefinition="MachineToLocalUser" requirePermission="false" />
                </sectionGroup>
                ...
            </configSections>
              ...
          <userSettings>
                <{project Namespace name}.Properties.Settings>
                    <setting name="{settingName}" serializeAs="String">
                            <value>{settingValue}</value>
                    </setting>
                </{project Namespace name}.Properties.Settings>
            </userSettings>
            ...
          <{name of group}>
                <{name of section in group}>
                    <setting name="{settingName}" serializeAs="String">
                            <value>{settingValue}</value>
                    </setting>
                </{name of section in group}>
            </{name of group}>
            ...
            </configuration>
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string ReturnConfigSettingsUsersSettingKeyData(string keyName)
        {
            string appSettingsString = "";
            try
            {
                ConfigurationManager.RefreshSection("userSettings");
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSectionGroup csg = configFile.GetSectionGroup("userSettings");

                // - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                //var a = (ClientSettingsSection)(csg.Sections.Get("SpikeContainer.Properties.Settings"));
                //var r = (ClientSettingsSection)(csg.Sections[0]);
                //var m = r.Settings.Get(keyName).Value.ValueXml.InnerText;
                //appSettingsString = m;
                // - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

                ClientSettingsSection mySection = new ClientSettingsSection();
                foreach (ClientSettingsSection cs in csg.Sections)
                    if (cs.SectionInformation.Name.Contains(".Properties.Settings"))
                    {
                        mySection = cs;
                        break;
                    }


                 foreach (SettingElement se in mySection.Settings)
                    if (se.Name.Contains(keyName))
                    {
                        var x = se.SerializeAs;
                        SettingValueElement y = se.Value;
                        var j = y.ValueXml.Value;
                        appSettingsString = se.Value.ValueXml.InnerText;
                        break;
                    }
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
        public static bool AddConfigSettingsUsersSetting(string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                ConfigurationManager.RefreshSection("userSettings");
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSectionGroup csg = configFile.GetSectionGroup("userSettings");
                ClientSettingsSection confSect = (ClientSettingsSection)csg.Sections.Get("SpikeContainer.Properties.Settings");

                bool bHasKey = false;
                foreach (SettingElement sea in confSect.Settings)
                {
                    if (sea.Name.Contains(keyName))
                    {
                        bHasKey = true;
                    }
                }

                if (!bHasKey)
                {
                    SettingElement se = new SettingElement(keyName, SettingsSerializeAs.String);
                    SettingValueElement sve = new SettingValueElement
                    {
                        ValueXml = new System.Xml.XmlDocument { InnerXml = $@"<value>{value}</value>" }
                    };
                    se.Value = sve;
                    confSect.Settings.Add(se);
                    configFile.Save(ConfigurationSaveMode.Modified, true);
                    bMethodReturnValue = true;
                    ConfigurationManager.RefreshSection(confSect.SectionInformation.Name);
                }

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
        public static bool UpdateConfigSettingsUsersSetting(string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                ConfigurationManager.RefreshSection("userSettings");
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSectionGroup csg = configFile.GetSectionGroup("userSettings");
                ClientSettingsSection confSect = (ClientSettingsSection)csg.Sections.Get("SpikeContainer.Properties.Settings");

                bool bHasKey = false;
                foreach (SettingElement sea in confSect.Settings)
                    if (sea.Name.Contains(keyName))
                    {
                        bHasKey = true;
                        break;
                    }

                if (bHasKey)
                {
                    SettingElement se = new SettingElement(keyName, SettingsSerializeAs.String);
                    SettingValueElement sve = new SettingValueElement
                    {
                        ValueXml = new System.Xml.XmlDocument { InnerXml = $@"<value>{value}</value>" }
                    };
                    se.Value = sve;
                    confSect.Settings.Add(se);
                    configFile.Save(ConfigurationSaveMode.Modified, true);
                    bMethodReturnValue = true;
                    ConfigurationManager.RefreshSection(confSect.SectionInformation.Name);
                }

            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return bMethodReturnValue;
        }

        

        #endregion

        #region [ CUSTOM CONFIGURATION GROUP with SECTION  ]

        // SEE ABOVE REFERENCE **
        /*
          <?XML version ="1.0' encoding="utf-8">
          <configuration>
          <configSections>
                ...
                <sectionGroup name="{name of group}" type="System.Configuration.UserSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
                    <section name="{name of section in group}" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowExeDefinition="MachineToLocalUser" requirePermission="false" />
                </sectionGroup>
                ...
            </configSections>
            ...
          <{name of group}>
                <{name of section in group}>
                    <setting name="{settingName}" serializeAs="String">
                            <value>{settingValue}</value>
                    </setting>
                </{name of section in group}>
            </{name of group}>
            ...
            </configuration>
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configGroupName">sectionGroup name="userSettings"</param>
        /// <param name="sectionName">section name="SpikeContainer.Properties.Settings" </param>
        /// <param name="keyName">setting name="MainPassword"</param>
        /// <returns></returns>
        public static string ReturnConfigGroupSectionKeyData(string configGroupName, string sectionName, string keyName)
        {
            string appSettingsString = "";
            try
            {
                ConfigurationManager.RefreshSection(configGroupName);
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSectionGroup csg = configFile.GetSectionGroup(configGroupName);

                // - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                //var a = (ClientSettingsSection)(csg.Sections.Get("SpikeContainer.Properties.Settings"));
                //var r = (ClientSettingsSection)(csg.Sections[0]);
                //var m = r.Settings.Get(keyName).Value.ValueXml.InnerText;
                //appSettingsString = m;
                // - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

                ClientSettingsSection mySection = new ClientSettingsSection();
                foreach (ClientSettingsSection cs in csg.Sections)
                    if (cs.SectionInformation.Name.Contains(sectionName))
                    {
                        mySection = cs;
                        break;
                    }


                foreach (SettingElement se in mySection.Settings)
                    if (se.Name.Contains(keyName))
                    {
                        var x = se.SerializeAs;
                        SettingValueElement y = se.Value;
                        var j = y.ValueXml.Value;
                        appSettingsString = se.Value.ValueXml.InnerText;
                        break;
                    }
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
        /// <param name="configGroupName"></param>
        /// <param name="sectionName"></param>
        /// <param name="keyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool AddConfigGroupSectionKeyValue(string configGroupName, string sectionName, string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                ConfigurationManager.RefreshSection(configGroupName);
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSectionGroup csg = configFile.GetSectionGroup(configGroupName);
                ClientSettingsSection confSect = (ClientSettingsSection)csg.Sections.Get(sectionName);

                bool bHasKey = false;
                foreach (SettingElement sea in confSect.Settings)
                {
                    if (sea.Name.Contains(keyName))
                    {
                        bHasKey = true;
                    }
                }

                if (!bHasKey)
                {
                    SettingElement se = new SettingElement(keyName, SettingsSerializeAs.String);
                    SettingValueElement sve = new SettingValueElement
                    {
                        ValueXml = new System.Xml.XmlDocument { InnerXml = $@"<value>{value}</value>" }
                    };
                    se.Value = sve;
                    confSect.Settings.Add(se);
                    configFile.Save(ConfigurationSaveMode.Modified, true);
                    bMethodReturnValue = true;
                    ConfigurationManager.RefreshSection(confSect.SectionInformation.Name);
                }

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
        /// <param name="configGroupName"></param>
        /// <param name="sectionName"></param>
        /// <param name="keyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool UpdateConfigGroupSectionKeyValue(string configGroupName, string sectionName, string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                ConfigurationManager.RefreshSection(configGroupName);
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSectionGroup csg = configFile.GetSectionGroup(configGroupName);
                ClientSettingsSection confSect = (ClientSettingsSection)csg.Sections.Get(sectionName);

                bool bHasKey = false;
                foreach (SettingElement sea in confSect.Settings)
                    if (sea.Name.Contains(keyName))
                    {
                        bHasKey = true;
                        break;
                    }

                if (bHasKey)
                {
                    SettingElement se = new SettingElement(keyName, SettingsSerializeAs.String);
                    SettingValueElement sve = new SettingValueElement
                    {
                        ValueXml = new System.Xml.XmlDocument { InnerXml = $@"<value>{value}</value>" }
                    };
                    se.Value = sve;
                    confSect.Settings.Add(se);
                    configFile.Save(ConfigurationSaveMode.Modified, true);
                    bMethodReturnValue = true;
                    ConfigurationManager.RefreshSection(confSect.SectionInformation.Name);
                }

            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return bMethodReturnValue;
        }

        #endregion

        #region [ CUSTOM CONFIG SECTION (no group) ]

        // SEE ABOVE REFERENCE **
        /*
          <?XML version ="1.0' encoding="utf-8">
          <configuration>
          <configSections>
            ...
            <section name="{name of section}" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
            ...
          </configSections>
          <applicationSettings>
            <setting name="settingName" serializeAs="String">
                <value>settingValue</value>
            <setting name="Frankeinstein" serializeAs="String">
                <value>The Monster is ALIVE!</value>
            </setting>
            </setting>
          </applicationSettings>
          <{name of section}>
            <setting name="{setting name}" serializeAs="String">
                <value>{setting value}</value>
            </setting>
            </{name of section}>
          </{name of section}>
        */

        public static string ReturnCustomSectionConfigSettingsSettingKeyValue(string sectionName, string keyName)
        {
            string appSettingsString = "";
            try
            {
                ConfigurationManager.RefreshSection(sectionName);
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ClientSettingsSection confSect = (ClientSettingsSection)configFile.GetSection(sectionName);
                SettingElementCollection appSettings = confSect.Settings;

                var v = appSettings.Get(keyName);

                appSettingsString = Convert.ToString(v.Value.ValueXml.InnerText);
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }
            return appSettingsString;
        }

        public static bool AddConfigSettingsCustomSectionSetting(string sectionName, string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                ConfigurationManager.RefreshSection(sectionName);
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
                    bMethodReturnValue = true;
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

        public static bool UpdateConfigCustomSectionAppSetting(string sectionName, string keyName, string value)
        {
            bool bMethodReturnValue = false;
            try
            {
                ConfigurationManager.RefreshSection(sectionName);
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection confSect = (AppSettingsSection)configFile.GetSection(sectionName);
                if (confSect.Settings[keyName] != null)
                {
                    confSect.Settings[keyName].Value = value;
                    bMethodReturnValue = true;
                }
                configFile.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection(confSect.SectionInformation.Name);
            }
            catch (Exception excpt)
            {
                Msg.ProgError(excpt.Message, excpt);
                //PolartecErrorLog.PTMErrorLogExceptionOutput(excpt);
            }
            return bMethodReturnValue;
        }

        #endregion


        private static bool OpenConfigIntoDataSet()
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

        public static string Testy()
        {
            string appSettingsString = "";
            try
            {
                ConfigurationManager.RefreshSection("userSettings");
                //ConfigurationManager.
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSectionGroup csg = configFile.GetSectionGroup("userSettings");

                // - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                //var a = (ClientSettingsSection)(csg.Sections.Get("SpikeContainer.Properties.Settings"));
                //var r = (ClientSettingsSection)(csg.Sections[0]);
                //var m = r.Settings.Get(keyName).Value.ValueXml.InnerText;
                //appSettingsString = m;
                // - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

                ClientSettingsSection mySection = new ClientSettingsSection();
                foreach (ClientSettingsSection cs in csg.Sections)
                    //if (cs.SectionInformation.Name.Contains(string.Format($@"{0}.Properties.Settings", "SpikeContainer")))
                    if (cs.SectionInformation.Name.Contains(".Properties.Settings"))
                    {
                        mySection = cs;
                        break;
                    }


                foreach (SettingElement se in mySection.Settings)
                    if (se.Name.Contains("ExcludedDirectories"))
                    {
                        var y = se.ElementInformation;
                        appSettingsString = se.Value.ValueXml.InnerText;
                        break;
                    }
            }
            catch (Exception excpt)
            {
                Trace.WriteLine($@"{excpt.Message} {excpt.Source} {excpt.StackTrace}");
            }

            return appSettingsString;
        }
    }
}
