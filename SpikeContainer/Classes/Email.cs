//******************************************************************************************************
// Email.cs -::- PFCS: Assembly - PFCS: Solution - PFCS: Project
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Entity; // Add Solution level/Project level assembly reference
using System.DirectoryServices; // Add Solution level/Project level assembly reference
using System.Globalization;
using System.Linq;
using System.Net; // Add Solution level/Project level assembly reference
using System.Net.Mail; // Add Solution level/Project level assembly reference


namespace PFCS.Classes
{
    /// <summary>
    ///  A common class to handle common aspects of sending email programatically within C# code
    /// </summary>
    public static class Email
    {
        internal static string From;
        internal static StringCollection To = new StringCollection();
        internal static StringCollection Cc = new StringCollection();
        internal static string Sub;
        internal static string Body;
        internal static readonly StringCollection Attachments = new StringCollection();

        //internal static void Send()
        //{
        //    try
        //    {
        //        using (var message = new MailMessage())
        //        {
        //            var basicCredential = new NetworkCredential(Data.Global.EmailUserName, Data.Global.EmailUserPassword);
        //            message.From = new MailAddress(From);
        //            foreach (var i in To)
        //            {
        //                message.To.Add(i);
        //            }
        //            if (Cc != null)
        //            {
        //                foreach (var i in Cc)
        //                {
        //                    message.CC.Add(i);
        //                }
        //            }
        //            message.Subject = Sub;
        //            message.Body = Body;
        //            if (Attachments != null)
        //            {
        //                foreach (var i in Attachments)
        //                {
        //                    message.Attachments.Add(new Attachment(i));
        //                }
        //            }
        //            using (var smtp = new SmtpClient())
        //            {
        //                smtp.Host = ConfigSettings.ReturnConfigSettingsAppSettingKeyValue("smtp");

        //                smtp.UseDefaultCredentials = false;
        //                smtp.Credentials = basicCredential;
        //                smtp.Send(message);
        //            }
        //        }
        //        Msg.Confirmation("Email Sent");
        //    }
        //    catch (Exception ex)
        //    {
        //        //Msg.ProgError(ex.ToString());
        //    }
        //}

        internal static DataTable GetContacts(string user, string pw, string domain, string smtp, string ldap)
        {
            using (var dt = new DataTable())
            {
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Address", typeof(string));

                var myArr = new DictionaryEntry[GetGal(user, pw, domain, ldap).Count];
                GetGal(user, pw, domain, ldap).CopyTo(myArr, 0);
                foreach (var t in myArr)
                {
                    var row = dt.NewRow();
                    row["Name"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(t.Key.ToString());
                    row["Address"] = t.Value.ToString().ToLower();
                    dt.Rows.Add(row);
                }

                try
                {
                    var service = new ExchangeService
                    {
                        UseDefaultCredentials = false,
                        Credentials = new WebCredentials(user, pw, domain),
                        Url = new Uri(String.Format(@"https://{0}/EWS/Exchange.asmx", smtp)),
                    };

                    foreach (var v in service.FindItems(WellKnownFolderName.Contacts,
                        new ItemView(1000)))
                    {
                        var contact = v as Contact;

                        if (contact == null) continue;
                        if (!contact.EmailAddresses.Contains(EmailAddressKey.EmailAddress1)) continue;
                        if (contact.EmailAddresses[EmailAddressKey.EmailAddress1].Address == null) continue;
                        var row = dt.NewRow();
                        var exists = dt.AsEnumerable().Any(c => c.Field<string>("Name").Equals(contact.DisplayName));
                        if (exists) continue;
                        row["Name"] = contact.DisplayName;
                        row["Address"] = contact.EmailAddresses[EmailAddressKey.EmailAddress1].Address;
                        dt.Rows.Add(row);
                    }
                }
                catch (Exception ex)
                {
                    //Msg.ProgError(ex.Message);
                }
                return dt;
            }
        }

        private static StringDictionary GetGal(string user, string pw, string domain, string ldap)
        {
            const string sFilter = "(&(mailnickname=*)(|(objectcategory=user)(objectcategory=group)))";
            try
            {
                var userName = String.Format("{0}\\{1}", domain, user);
                var returnArray = new StringDictionary();
                var deDirEntry = new DirectoryEntry(String.Format(@"LDAP://{0}", ldap),
                    userName,
                    pw,
                    AuthenticationTypes.None);
                var mySearcher = new DirectorySearcher(deDirEntry);
                mySearcher.PropertiesToLoad.Add("name");
                mySearcher.PropertiesToLoad.Add("mail");

                mySearcher.Filter = sFilter;
                mySearcher.Sort.Direction = SortDirection.Ascending;
                mySearcher.Sort.PropertyName = "name";
                mySearcher.PageSize = 1000;
                var results = mySearcher.FindAll();
                foreach (SearchResult resEnt in results)
                {
                    var propcoll = resEnt.Properties;
                    var name = "";
                    var mail = "";
                    if (propcoll.PropertyNames != null)
                        foreach (string key in propcoll.PropertyNames)
                        {
                            switch (key)
                            {
                                case "name":
                                    foreach (
                                        var values in
                                            propcoll[key].Cast<object>().Where(
                                                values =>
                                                    !values.ToString().Contains("{") && !values.ToString().Contains("-"))
                                        )
                                    {
                                        name = values.ToString();
                                    }
                                    break;
                                case "mail":
                                    foreach (var values in propcoll[key])
                                    {
                                        mail = values.ToString();
                                    }
                                    break;
                            }
                        }
                    if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(mail))
                    {
                        returnArray.Add(name, mail);
                    }
                }
                return returnArray;
            }
            catch (Exception ex)
            {
                //Msg.ProgError(ex.Message);
                return null;
            }
        }
    }

    /// <summary>
    /// Automatic Email for IT Internal Use for Error-Issue tracking from PTM Software
    /// </summary>
    public static class AutomaticEmail
    {
        /*
        [EMAIL]
        smtpServer= "192.168.101.12"
        MailFrom= AE@Polartec.com
        ErrorMailTo= HyderJ@Polartec.com
        smtpServer= "192.168.101.12"
        connString=Server=MANUFACTURING;Uid=VIUser; Pwd=VIUser; database=impact
        smtpServer=192.168.101.12
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formText"></param>
        /// <param name="error"></param>
        public static void SendErrorEmail(string formText, string error)
        {
            try
            {
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(Data.General.GetSystemErrorErrorFromAddress("SysError"));

                    var toAddresses = Data.General.GetSystemErrorEmailToAddresses("SysError");
                    foreach (var to in toAddresses)
                    {
                        message.To.Add(to);
                    }
                    message.Subject = $@"{formText} Error on {Data.Global.MachineName}";
                    message.Body = $@" {formText} for: 
                                    {Data.Global.FullUserName(Data.Global.User)} on {Data.Global.MachineName
                                    } encountered the following error: {Environment.NewLine}{error}";
                    using (var smtpClient = new SmtpClient())
                    {
                        smtpClient.Host = Data.SystemVariables.SmtpServer;
                        smtpClient.Send(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.ProgError($@" Error in Automatic Email on error.{Environment.NewLine}Message: {ex.Message} , Source: {ex.Source} , Stack {ex.StackTrace} ", ex.InnerException);
                // a program log of this would be nice
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formText"></param>
        /// <param name="error"></param>
        public static void SendOperationStatusEmail(string formText, string error)
        {
            try
            {
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(Data.General.GetSystemErrorErrorFromAddress("SysError"));

                    var toAddresss = "hyderj@polartec.com";
                    //foreach (var to in toAddresses)
                    //{
                    //    message.To.Add(to);
                          message.To.Add(toAddresss);
                    //}
                    message.Subject = $@"{formText} Error on {Data.Global.MachineName}";
                    message.Body = $@" {formText} for: 
                                    {Data.Global.FullUserName(Data.Global.User)} on {Data.Global.MachineName
                                    } encountered the following error: {Environment.NewLine}{error}";
                    using (var smtpClient = new SmtpClient())
                    {
                        smtpClient.Host = Data.SystemVariables.SmtpServer;
                        smtpClient.Send(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.ProgError($@" Error in Automatic Email on error.{Environment.NewLine}Message: {ex.Message} , Source: {ex.Source} , Stack {ex.StackTrace} ", ex.InnerException);
                // a program log of this would be nice
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SendAlert()
        {
            //try
            //{
            //    var mail = new MailMessage();
            //    var to = GetMailTo("SysError");
            //    foreach (var t in to) mail.To.Add(t);
            //    mail.From = new MailAddress(_from);
            //    mail.Subject = "Arel Integrator Error";
            //    mail.Body = $"{_file} failed to transfer. The following error occurred: {_errorCode}";
            //    smtpServer.Send(mail);
            //}
            //catch (Exception ex)
            //{
            //    PTMCommClass.Msg.ProgError(ex.Message, ex.InnerException.ToString());

            //    WriteLog(ex.Message, ex.StackTrace);
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SendAlertEmail()
        {
            //try
            //{
            //    var ini = new IniFile($@"{_appPath}\EDI.ini");
            //    var mail = new MailMessage();
            //    var smtpServer = new SmtpClient(ini.IniReadValue("EMAIL", "smtpServer"));
            //    var to = GetMailTo("System Error");
            //    foreach (var t in to) mail.To.Add(t);
            //    mail.From = new MailAddress(_mailFrom);
            //    mail.Subject = "EDI Transport Error";
            //    mail.Body = $"{_file} failed to transfer. The following error occurred: {_errorCode}";
            //    smtpServer.Send(mail);
            //    Application.Exit();

            //}
            //catch (Exception ex)
            //{
            //    PTMCommonClassesCode.Msg.ProgError(ex.Message, ex.InnerException.ToString());

            //    WriteLog(ex.Message, ex.StackTrace);
            //    Application.Exit();
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SendNotification()
        {
            //try
            //{
            //    var ini = new IniFile(_appPath + "\\EDI.ini");
            //    var mail = new MailMessage();
            //    var smtpServer = new SmtpClient(ini.IniReadValue("EMAIL", "smtpServer"));
            //    foreach (var to in _noteTo)
            //    {
            //        mail.To.Add(to);
            //    }
            //    mail.From = new MailAddress(_mailFrom);
            //    mail.Subject = _noteSubject;
            //    mail.Body = _notice;

            //    smtpServer.Send(mail);
            //}
            //catch (Exception ex)
            //{
            //    PTMCommonClassesCode.Msg.ProgError(ex.Message, ex.InnerException.ToString());

            //    WriteLog(ex.Message, ex.StackTrace);
            //    Application.Exit();
            //}
        }

        //private static string _from;
        //private static List<string> GetMailTo(string call)
        //{
        //    using (var db = new MesDbEntities())
        //    {
        //        var addresses = db.AutomatedEmails.First(r => r.Call == call);
        //        _from = addresses.FromAddress;
        //        var to = addresses.ToAddress;
        //        var list = to.Split(new[] { "; " }, StringSplitOptions.None);
        //        return list.ToList();
        //    }
        //}


        //private bool Email_BevRpt(Array data)
        //{
        //    const string reportName = "Beverly Shipment";
        //    try
        //    {
        //        var t = new BevRecRept { DataSource = data };
        //        using (var html = new MemoryStream())
        //        {
        //            t.ExportToHtml(html);
        //            var body = html.ToArray();
        //            using (var pdf = new MemoryStream())
        //            {
        //                t.ExportToPdf(pdf);
        //                var attach = pdf.ToArray();
        //                EmailBevReports(reportName, attach, body);
        //                return true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($@"{reportName} - {ex.Message}");
        //        return false;
        //    }
        //}
        //private void EmailBevReports(string reportName, byte[] attach, byte[] body)
        //{
        //    try
        //    {
        //        var filename = $"{_file.Name}.pdf";
        //        using (var ms = new MemoryStream(attach))
        //        {
        //            using (var message = new MailMessage())
        //            {
        //                using (var attachment = new Attachment(ms, filename))
        //                {
        //                    message.Attachments.Add(attachment);
        //                    message.From = new MailAddress(Settings.Default.From);
        //                    var tos = Settings.Default.To.Split(new[] { "; " }, StringSplitOptions.None).ToList();
        //                    if (tos.Count == 0) return;
        //                    foreach (var to in tos)
        //                    {
        //                        message.To.Add(to);
        //                    }

        //                    message.Subject = "Beverly Shipment Summary";
        //                    message.IsBodyHtml = true;
        //                    message.Body = Encoding.UTF8.GetString(body);
        //                    using (var smtpClient = new SmtpClient())
        //                    {
        //                        smtpClient.Host = Settings.Default.smtp;
        //                        smtpClient.Send(message);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"{reportName} - {ex.Message}");
        //    }
        //}
        //private bool Email_WtTolRpt(Array data)
        //{
        //    const string reportName = "Beverly Weight Tolerance";
        //    try
        //    {
        //        var t = new WtTolRpt { DataSource = data };
        //        using (var html = new MemoryStream())
        //        {
        //            t.ExportToHtml(html);
        //            var body = html.ToArray();
        //            using (var xls = new MemoryStream())
        //            {
        //                t.ExportToXls(xls);
        //                var attach = xls.ToArray();
        //                EmailWtTolReports(reportName, attach, body);
        //                return true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"{reportName} - {ex.Message}");
        //        return false;
        //    }
        //}
        //private void EmailWtTolReports(string reportName, byte[] attach, byte[] body)
        //{
        //    try
        //    {
        //        var filename = $"BevWtTol{Regex.Replace(DateTime.Now.ToString(), "[^0-9]", "")}.xls";
        //        using (var ms = new MemoryStream(attach))
        //        {
        //            using (var message = new MailMessage())
        //            {
        //                using (var attachment = new Attachment(ms, filename))
        //                {
        //                    message.Attachments.Add(attachment);
        //                    message.From = new MailAddress(Settings.Default.From);
        //                    var tos = Settings.Default.WeightTolTo.Split(new[] { "; " }, StringSplitOptions.None).ToList();
        //                    if (tos.Count == 0) return;
        //                    foreach (var to in tos)
        //                    {
        //                        message.To.Add(to);
        //                    }

        //                    message.Subject = "Beverly Weight Tolerance";
        //                    message.IsBodyHtml = true;
        //                    message.Body = Encoding.UTF8.GetString(body);
        //                    using (var smtpClient = new SmtpClient())
        //                    {
        //                        smtpClient.Host = Settings.Default.smtp;
        //                        smtpClient.Send(message);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"{reportName} - {ex.Message}");
        //    }
        //}

    }
}
