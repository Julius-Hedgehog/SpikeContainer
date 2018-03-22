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
    /// <summary> A general class to hold custom email functionality </summary>
    public static class Email
    {
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
    }
}
