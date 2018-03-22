using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFCS.Classes
{
    internal static class Msg
    {
        internal static void ProgError(string msg, Exception innerException)
        {
            XtraMessageBox.Show(msg + " - " + innerException, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void Error(string message)
        {
            XtraMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void Confirmation(string message)
        {
            XtraMessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void Update(bool restart)
        {
            const string str1 = "There is a newer version of this program. ";
            var str2 = restart
                ? "This program will close and update in 5 minutes."
                : "Please save all work and re-start program to update.";
            var message = str1 + Environment.NewLine + str2;
            XtraMessageBox.Show(message, "Update Available",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        internal static bool ConfirmExit()
        {
            return
                (XtraMessageBox.Show("Are you sure want to exit without saving?  All changes will be lost.",
                                     "Confirm Exit",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                 DialogResult.Yes);
        }

        internal static bool ConfirmAction(string message, string action)
        {
            return
                (XtraMessageBox.Show(message, $@"Confirm {action}",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                 DialogResult.Yes);
        }

        internal static bool AnswerYes(string message, string caption)
        {
            return
                (XtraMessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes);
        }

        internal static bool AnswerNo(string message, string caption)
        {
            return
                (XtraMessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No);
        }

        //internal static void SendErrorEmail(string formText, string error)
        //{
        //    try
        //    {
        //        using (var message = new MailMessage())
        //        {
        //            message.From = new MailAddress(Data.General.GetSystemErrorErrorFromAddress("System Error"));
        //            foreach (var to in Data.General.GetAeAddresses("System Error"))
        //            {
        //                message.To.Add(to);
        //            }
        //            message.Subject = $@"{formText} Error on {Data.Global.MachineName}";
        //            message.Body = $@"{Data.Global.FullUserName(Data.Global.User)} on {Data.Global.MachineName
        //                } encountered the following error: {Environment.NewLine}{error}";
        //            using (var smtpClient = new SmtpClient())
        //            {
        //                smtpClient.Host = Data.SystemVariables.SmtpServer;
        //                smtpClient.Send(message);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ProgError(ex.Message, ex.InnerException);
        //    }
        //}
    }
}
