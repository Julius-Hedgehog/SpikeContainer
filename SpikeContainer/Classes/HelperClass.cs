using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Reflection;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using System.Windows.Forms;
using System.Security;
using System.Diagnostics;
using System.Security.Permissions;

namespace PFCS.Classes
{
    internal static class HelperClass
    {
        internal static int GetRowHandleByColumnValue(ColumnView view, string columnFieldName, object value)
        {
            const int result = GridControl.InvalidRowHandle;
            for (var i = 0; i < view.RowCount; i++)
                if (view.GetRowCellValue(i, columnFieldName).Equals(value))
                    return i;
            return result;
        }
      
        internal static string HexadecimalToString(string data)
        {
            try
            {
                var sData = "";
                while (data.Length > 0)
                {
                    var data1 = Convert.ToChar(Convert.ToUInt32(data.Substring(0, 2), 16)).ToString();
                    sData = sData + data1;
                    data = data.Substring(2, data.Length - 2);
                }
                return sData;
            }
            catch (Exception ex)
            {
                Msg.ProgError(ex.Message, ex.InnerException);
            }
            return null;
        }

        internal static string StringToHexadecimal(string data)
        {
            return data.Select(c => $"{Convert.ToUInt32(c):X}").Aggregate("", (current, sValue) => current + sValue);
        }

        internal static bool IsDomainAdmin(string username, string domain)
        {
            var domainctx = new PrincipalContext(ContextType.Domain,
                                                 domain);
            var userPrincipal =
                UserPrincipal.FindByIdentity(domainctx, IdentityType.SamAccountName, username);
            return userPrincipal != null && userPrincipal.IsMemberOf(domainctx, IdentityType.Name, "Domain Admins");
        }
      
        internal static DataTable ToDataTable<T>(this IEnumerable<T> varlist)
        {
            using (var dtReturn = new DataTable())
            {
                // column names
                PropertyInfo[] oProps = null;

                if (varlist == null) return dtReturn;

                foreach (var rec in varlist)
                {
                    // Use reflection to get property names, to create table, Only first time, others will follow
                    if (oProps == null)
                    {
                        oProps = rec.GetType().GetProperties();
                        foreach (var pi in oProps)
                        {
                            var colType = pi.PropertyType;

                            if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                            {
                                colType = colType.GetGenericArguments()[0];
                            }

                            dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                        }
                    }

                    var dr = dtReturn.NewRow();

                    foreach (var pi in oProps)
                    {
                        dr[pi.Name] = pi.GetValue(rec, null) ?? DBNull.Value;
                    }

                    dtReturn.Rows.Add(dr);
                }
                return dtReturn;
            }
        }
        
        #region Enum Description Attribute
        
        [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
        internal sealed class EnumDescriptionAttribute : Attribute
        {
            internal string Description { get; set; }

            internal EnumDescriptionAttribute(string description)
            {
                Description = description;
            
            }
        }

        internal static class EnumHelper
        {
            private static string GetDescription(Enum value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                var description = value.ToString();
                var fieldInfo = value.GetType().GetField(description);
                var attributes =
                   (EnumDescriptionAttribute[])
                 fieldInfo.GetCustomAttributes(typeof(EnumDescriptionAttribute), false);

                if (attributes.Length > 0)
                {
                    description = attributes[0].Description;
                }
                return description;
            }

            internal static IList ToList(Type type)
            {
                if (type == null)
                {
                    throw new ArgumentNullException("type");
                }

                var list = new ArrayList();
                var enumValues = Enum.GetValues(type);

                foreach (Enum value in enumValues)
                {
                    list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
                }
                
                return list;
            }
        }

        #endregion
        internal static class FormUtils
        {
            public static void SetDefaultIcon()
            {
                //if (Data.Global.Debug) return;
                var icon = Icon.ExtractAssociatedIcon(EntryAssemblyInfo.ExecutablePath);
                typeof(Form)
                    .GetField("defaultIcon", BindingFlags.NonPublic | BindingFlags.Static)?.SetValue(null, icon);
            }
        }
        public static class EntryAssemblyInfo
        {
            private static string _executablePath;

            public static string ExecutablePath
            {
                get
                {
                    if (_executablePath == null)
                    {
                        PermissionSet permissionSets = new PermissionSet(PermissionState.None);
                        permissionSets.AddPermission(new FileIOPermission(PermissionState.Unrestricted));
                        permissionSets.AddPermission(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode));
                        permissionSets.Assert();

                        string uriString = null;
                        var entryAssembly = Assembly.GetEntryAssembly();

                        if (entryAssembly == null)
                            uriString = Process.GetCurrentProcess().MainModule.FileName;
                        else
                            uriString = entryAssembly.CodeBase;

                        PermissionSet.RevertAssert();

                        if (string.IsNullOrWhiteSpace(uriString))
                            throw new Exception("Can not Get EntryAssembly or Process MainModule FileName");
                        else
                        {
                            var uri = new Uri(uriString);
                            if (uri.IsFile)
                                _executablePath = string.Concat(uri.LocalPath, Uri.UnescapeDataString(uri.Fragment));
                            else
                                _executablePath = uri.ToString();
                        }
                    }

                    return _executablePath;
                }
            }
        }
    }
}