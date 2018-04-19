using System;
using System.Linq;
using PFCS.DataEntities;
using System.Windows.Forms;
using System.Data.Entity;
using System.Management;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Threading;
using PFCS.General;
using ObjectQuery = System.Management.ObjectQuery;

namespace PFCS.Classes
{
    internal class Data
    {
        internal class Global
        {
            internal static string Config;
            internal static string User;
            internal static List<string> UserPermissions;
            internal static readonly string MachineName = Environment.MachineName;
            internal static string Catalog;
            internal static string AisCatalog;
            internal static int UserTimeOut;
            internal static bool Admin;
            internal static bool Debug;
            internal static bool LoggedIn;
            internal static string DebugUser;

            internal static string DebugPw;

            internal static readonly string BasePath = AppDomain.CurrentDomain.BaseDirectory;
            internal static string MasterPath;

            internal static Version CurVersion;
            internal static int UpdatePostponed;
            internal static DateTime UpdateTime;
            internal static string[] StartupArgs;

            internal static string FullUserName(string userId)
            {
                using (var db = new MesDbEntities(true))
                {
                    var user = db.Users.SingleOrDefault(r => r.UserId == userId);
                    return user == null ? "" : $@"{user.FirstName} {user.LastName}";
                }
            }

            internal static string GetUserId(string badgeno)
            {
                using (var db = new MesDbEntities(true))
                {
                    var user = db.Users.FirstOrDefault(r => r.BadgeNo == badgeno && r.Active)?.UserId;
                    if (user == null)
                    {
                        Msg.Error("Invalid or inactive user id!");
                    }
                    return user;
                }
            }

            internal static void CloseLoading()
            {
                var aProc = Process.GetProcessesByName("Loading");
                foreach (var proc in aProc)
                {
                    proc.Kill();
                }
            }
        }

        internal class SystemVariables
        {
            internal static string UpdateDir;
            internal static string SmtpServer;
            internal static string SsrsServerUri;
            internal static string SsrsReportPath;
            internal static string LabelDir;
            internal static string UpdateSource;
            internal static string SysUser;
            internal static string SysHash;
            internal static string AisUser;
            internal static string AisHash;
            internal static string SigConnFolder;

            internal static bool GetConfig()
            {
                if (ValidConfig()) return true;
                Msg.Error(
                    $"{Global.Config} config is not in the database. " + "Please contact the system administrator. " +
                    "This program will now close.");
                return false;
            }

            private static bool ValidConfig()
            {
                try
                {
                    using (var db = new MesDbEntities())
                    {
                        var config = db.SystemParams.FirstOrDefault(r => r.Config == Global.Config.Trim());
                        if (config?.Catalog == null) return false;
                        Global.Catalog = config.Catalog;
                        Global.AisCatalog = config.AisCatalog;
                        UpdateDir = config.updateDir;
                        SmtpServer = config.smtpServer;
                        SsrsServerUri = config.SSRSserverURI;
                        SsrsReportPath = config.SSRSreportPath;
                        LabelDir = config.LabelsDir;
                        UpdateSource = config.UpdateProgramSource;
                        SysUser = config.SysUser;
                        SysHash = config.SysHash;
                        AisUser = config.AisUser;
                        AisHash = config.AisHash;
                        SigConnFolder = config.SigConnFolder;
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Msg.ProgError(ex.Message, ex.InnerException);
                    Global.CloseLoading();
                    return false;
                }
            }
        }


        internal class LocalSysVariables
        {

            internal static string LabelPrinter;
            internal static string HostId;

            internal static void GetLocalVariables()
            {
                try
                {
                    using (var db = new MesDbEntities(true))
                    {
                        db.LocalVariables.Where(r => r.Machine == Global.MachineName
                                                     || r.Machine == "Default (Template)").Load();

                        if (db.LocalVariables.Local.All(r => r.Machine != Global.MachineName))
                        {
                            if (db.LocalVariables.Local.All(r => r.Machine != "Default (Template)"))
                            {
                                Msg.Error("There is no 'default machine in the LocalVariables table. " +
                                          "Please Contact the system administrator.  This program will now close.");
                                Application.Exit();
                                return;
                            }
                            var src = db.LocalVariables.Local.First(r => r.Machine == "Default (Template)");
                            var clone = new LocalVariables();

                            db.LocalVariables.Add(clone);
                            var sourceValues = db.Entry(src).CurrentValues;
                            db.Entry(clone).CurrentValues.SetValues(sourceValues);
                            clone.Machine = Global.MachineName;
                            db.SaveChanges();
                        }
                        var locvar = db.LocalVariables.Local.First(r => r.Machine == Global.MachineName);

                        LabelPrinter = locvar.LabelPrinter;
                        HostId = locvar.HostID;
                    }
                }
                catch
                    (Exception ex)
                {
                    Msg.ProgError(ex.Message, ex.InnerException);
                    Application.Exit();
                }
            }

            internal static string GetDefaultPrinterName()
            {
                var query = new ObjectQuery("SELECT * FROM Win32_Printer");
                using (var searcher = new ManagementObjectSearcher(query))
                {
                    return
                        (from ManagementObject mo in searcher.Get()
                         where ((bool?)mo["Default"]) ?? false
                         select mo["Name"] as string).FirstOrDefault();
                }
            }

            internal static void SavePfcsVersion()
            {
                try
                {
                    using (var db = new MesDbEntities(true))
                    {
                        db.LocalVariables.Where(r => r.Machine == Global.MachineName).Load();

                        if (db.LocalVariables.Local.All(r => r.Machine == Global.MachineName))
                        {
                            var app = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                            var appPath = AppDomain.CurrentDomain.BaseDirectory;
                            var currentVersionInfo =
                                FileVersionInfo.GetVersionInfo($@"{appPath}\{app}.exe");
                            var version = new Version(currentVersionInfo.ProductVersion);

                            var t = db.LocalVariables.Local.FirstOrDefault();
                            // TODO : UNDO Comments when PfcsVersion Field/Column added to TestMesDb/MesDb Entity 
                            //t.PfcsVersion = version.ToString();
                            //db.SaveChanges();
                        }
                    }
                }
                catch
                    (Exception ex)
                {
                    Msg.ProgError(ex.Message, ex.InnerException);
                }
            }
        }

        internal class General
        {
            internal static string GetSystemErrorErrorFromAddress(string call)
            {
                using (var db = new MesDbEntities(true))
                {
                    return db.AutomatedEmail.FirstOrDefault(r => r.Call.Contains(call))?.FromAddress;
                }
            }
            
            internal static string [] GetSystemErrorEmailToAddresses(string call)
            {
                using (var db = new MesDbEntities(true))
                {
                    var strAddresses =  db.AutomatedEmail.FirstOrDefault(r => r.Call.Contains(call))?.ToAddress;
                    var vrtrn =  strAddresses?.Split(',');
                    return vrtrn;
                }
            }

            internal static string ListString(List<string> list)
            {
                return $"'{string.Join("','", list)}'";
            }

            internal static bool IsValidEmail(string email)
            {
                var reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                return reg.IsMatch(email);
            }

            internal static bool ValidUser(string user)
            {
                using (var db = new MesDbEntities(true))
                {
                    if (db.Users.Any(r => r.UserId == user && r.Active)) return true;
                    Msg.Error("User not valid.");
                    return false;
                }
            }

            internal static string UserByBadgeNo(string badgeNo)
            {
                using (var db = new MesDbEntities(true))
                {
                    return db.Users.FirstOrDefault(r => r.BadgeNo == badgeNo)?.UserId;
                }
            }

            internal static bool ValidSupervisor(string user, bool bDisplayMsg = true)
            {
                using (var db = new MesDbEntities(true))
                {
                    if (db.Users.Any(r => r.UserId == user && r.SupOverRide)) return true;

                    if (bDisplayMsg) { Msg.Error("User is not a supervisor."); }
                    return false;
                }
            }

            internal static bool ValidComputer(string domain, string computer)
            {
                using (var domainContext = new PrincipalContext(ContextType.Domain, domain))
                {
                    using (var comp = new ComputerPrincipal(domainContext))
                    {
                        comp.Name = computer;

                        using (var pS = new PrincipalSearcher())
                        {
                            pS.QueryFilter = comp;

                            using (var results = pS.FindAll())
                            {
                                if (results.Any())
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }

            internal static string GetOverrideUser()
            {
                using (var form = new Admin.OverRideAuth{ StartPosition = FormStartPosition.CenterScreen })
                {
                    form.ShowDialog();
                    return form.User;
                }
            }

            internal static List<string> QadMach(int? machId = null, string shortName = null)
            {
                using (var db = new MesDbEntities(true))
                {
                    return machId == null
                        ? db.Machines.Where(r => r.ShortName == shortName).Select(r => r.QadMach).ToList()
                        : db.Machines.Where(r => r.MachId == machId).Select(r => r.QadMach).ToList();
                }
            }

            internal static fn_GetRouter_Result SelectedRouteStep(int workorder, string workcenter = null, string qadmachine = null)
            {
                using (var form = new ValidRouteSteps
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    WorkOrder = workorder,
                    WorkCenter = workcenter,
                    QadMachine = qadmachine
                })
                {
                    form.ShowDialog();
                    return form.RouteStep;
                }
            }

            internal static string NextSeqNo(string prefix)
            {
                using (var db = new MesDbEntities(true))
                {
                    return db.Database.SqlQuery<string>($"EXEC [dbo].[sp_NextSeqNo] '{prefix}'").FirstOrDefault();
                }
            }

            //db.sp_PostMesOp(WorkOrderValue, OpStepNo,(Mach!=null && Mach!=string.Empty ? Mach : null), user,(isOverRide ? overRideUser : null /* ?? OR "" ??*/), dtChangedDate);
            internal static bool PostMesOp(int wo, int opNmbr, string user, bool isOverRide = false, string overRideUser = "")
            {
                bool bReturnvalue = true;

                if (isOverRide && string.IsNullOrEmpty(overRideUser)) return false; // REJECT IF NO overRideUser if isOverRide

                using (var db = new MesDbEntities(true)) // You got to be connected
                {
                    try
                    {
                        var dtChangeDate = DateTime.Now;

                        db.Packages.Where(p => p.Status == "WIP" && p.WorkOrder == wo).Load();
                        var listSerialNos1 = db.Packages.Local.Where(p => p.Status == "WIP" && p.WorkOrder == wo).Select(s => s.SerialNo).ToList();
                        var dbPkgs = db.Packages.Local.Where(p => p.Status == "WIP" && p.WorkOrder == wo).ToList();
                        Thread.Sleep(1500);
                        var rOuteStep = db.fn_GetRouter(wo).FirstOrDefault(s => s.OpStepNo == opNmbr);

                        var strWhereClause = $@"SerialNo IN ({ListString(listSerialNos1)})";

                        foreach (var p in dbPkgs)
                        {
                            p.LstOpStep = opNmbr;
                            p.LstOp = rOuteStep?.Op;
                            p.LstMach = rOuteStep?.Mach;
                            p.Location = "";
                            p.ChangedBy = user;
                            p.ChangedDate = dtChangeDate;
                            p.HoldPiece = null;
                            p.HoldFor = null;
                        }
                        db.SaveChanges();
                        Thread.Sleep(1500);
                        db.sp_InsertPkgHist(strWhereClause, rOuteStep?.Descr, dtChangeDate, (isOverRide ? overRideUser : null));
                    }
                    catch (Exception xcpt)
                    {
                        Email.SendOperationStatusEmail($@"PostMesOp failure for {wo}, ({opNmbr})",
                            $@"internal static bool PostMesOp(int wo = {wo}, int opNumr = {opNmbr}, string user = {user}, bool isOverRide = {isOverRide}, string overRideUser = {overRideUser})" +
                            $@"Exception in PostMesOp 'Save'... PostMesOp failure for {wo}, ({opNmbr}). - Message = {xcpt.Message} {Environment.NewLine}" +
                            $@"Source = {xcpt.Source} {Environment.NewLine} Stack Trace = {xcpt.StackTrace} {Environment.NewLine} Data = {xcpt.Data}" +
                            $@" {(xcpt.InnerException != null ? xcpt.InnerException.Message : "")} {Environment.NewLine} " +
                            $@"Source = {(xcpt.InnerException != null ? xcpt.InnerException.Source : "")} {Environment.NewLine} " +
                            $@"Stack Trace = {(xcpt.InnerException != null ? xcpt.InnerException.StackTrace : "")}");

                        Msg.ProgError($@"Exception in PostMesOp ... Message = {xcpt.Message} {Environment.NewLine}" +
                            $@"Source = {xcpt.Source} {Environment.NewLine} Stack Trace = {xcpt.StackTrace} {Environment.NewLine} Data = {xcpt.Data}",
                            xcpt.InnerException);

                        bReturnvalue = false;
                    }
                }
                return bReturnvalue;
            }

        internal static bool PostLabor(int wo, int op, string mach)
            {
                try
                {
                    var path = $@"{Global.BasePath}\Temp\";
                    path = path.Replace($@"\\", $@"\");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var filename = $@"lp{DateTime.Now.ToFileTime()}.sig";
                    var filePath = path + filename;

                    var dt = DateTime.Now.ToString("MM/dd/yy");

                    using (var db = new MesDbEntities(true))
                    {
                        var yds = db.WorkOrderTotals.First(r => r.WorkOrder == wo).ProcYds ?? 0;
                        var srt = (db.fn_OpInfo(wo, op, null)).FirstOrDefault()?.StdRunTime ?? 0;
                        var runtime = Math.Round(((decimal)yds * srt), 3);

                        using (var swfile = new FileStream(filePath, FileMode.OpenOrCreate))
                        {
                            using (var swFile = new StreamWriter(swfile))
                            {
                                swFile.WriteLine($"{wo},{op},{mach},{yds},{dt},{runtime},");
                                Trace.WriteLine($"{wo},{op},{mach},{yds},{dt},{runtime},");
                            }
                        }
                        return MoveSigConnectFile(filePath, filename);
                    }
                }
                catch (Exception e)
                {
                    Msg.ProgError(e.Message, e.InnerException);
                    return false;
                }
            }

            internal static bool WoComponentIssue(int wo, int op, string item, float qty)
            {
                try
                {
                    var path = $@"{Global.BasePath}\Temp\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var filename = $@"wi{DateTime.Now.ToFileTime()}.sig";
                    var filePath = path + filename;

                    var dt = DateTime.Now.ToString("MM/dd/yy");

                    using (var swfile = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        using (var swFile = new StreamWriter(swfile))
                        {
                            swFile.WriteLine($"{wo},,{op},{dt},,{item},{op},{qty},");
                        }
                    }
#if GOTEST //TODO: UNCOMMENT FOR ACTUAL OPERATION DEBUG OR RELEASE - jpHyder
                    Trace.WriteLine($@"WoComponentIssue({wo}, {op}, {item}, {qty}) -- MoveSigConnectFile(filePath-{filePath}, filename-{filename}); //TODO: UNCOMMENT FOR ACTUAL OPERATION DEBUG OR RELEASE - jpHyder");
                    return true;
#else
                    return MoveSigConnectFile(filePath, filename);
#endif                
                }
                catch (Exception e)
                {
                    Msg.ProgError(e.Message, e.InnerException);
                    return false;
                }
            }

            internal static bool PostUnPlanIssRoll(string item, string serialno, string wo, string qty, DateTime dt, string rmks = "")
            {
                try
                {
                    var path = $@"{Global.BasePath}\Temp\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var filename = $@"ui{DateTime.Now.ToFileTime()}.sig";
                    var filePath = path + filename;
                    var date = dt.ToString("MM/dd/yy");
                    using (var swfile = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        using (var swFile = new StreamWriter(swfile))
                        {
                            swFile.WriteLine(
                                $@"{item},{qty},{DefaultLocation(item)},{serialno},{wo},{rmks},{date}");
                        }
                    }
                    return MoveSigConnectFile(filePath, filename);
                }
                catch (Exception e)
                {
                    Msg.ProgError(e.Message, e.InnerException);
                    return false;
                }
            }

            internal static bool PostUnPlanRcptRoll(string item, string serialno, string wo, string qty, DateTime dt)
            {
                try
                {
                    var path = $@"{Global.BasePath}\Temp\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var filename = $@"ur{DateTime.Now.ToFileTime()}.sig";
                    var filePath = path + filename;
                    var date = dt.ToString("MM/dd/yy");
                    using (var swfile = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        using (var swFile = new StreamWriter(swfile))
                        {
                            swFile.WriteLine(
                                $@"{item},{qty},{DefaultLocation(item)},{serialno},{wo},{date}");
                        }
                    }
                    return MoveSigConnectFile(filePath, filename);
                }
                catch (Exception e)
                {
                    Msg.ProgError(e.Message, e.InnerException);
                    return false;
                }
            }

            internal static bool MoveSigConnectFile(string filepath, string filename)
            {
                try
                {
                    var targetPath = $@"{SystemVariables.SigConnFolder}\";
                    var targetFile = targetPath + filename;

                    var files = new List<string>();

                    var dir = new DirectoryInfo(targetPath);
                    files.AddRange(dir.GetFiles((filename + "*")).Select(r => r.Name).ToList());
                    foreach (var subDir in Directory.GetDirectories(targetPath, "*", SearchOption.AllDirectories))
                    {
                        var sub = new DirectoryInfo(subDir);
                        files.AddRange(sub.GetFiles(filename + "*").Select(r => r.Name));
                    }
                    if (files.Count != 0)
                    {
                        var lstfile = files.Max();
                        var seq = lstfile.Contains("_") ? Convert.ToInt32(lstfile.Split('_').Last()) + 1 : 1;
                        targetFile = targetFile + "_" + seq;
                    }

                    File.Move(filepath, targetFile);
                    return true;
                }
                catch (Exception e)
                {
                    Msg.ProgError(e.Message, e.InnerException);
                    return false;
                }
            }

            internal static string DefaultLocation(string item)
            {
                using (var db = new MesDbEntities(true))
                {
                    return db.Database.SqlQuery<string>($"SELECT dbo.fn_DefaultLocation('{item}')").Single();
                }
            }

            internal static bool ReleaseWorkOrder(IEnumerable<int> woList)
            {
                try
                {
                    var path = $@"{Global.BasePath}\Temp\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var filename = $@"wr{DateTime.Now.ToFileTime()}.sig";
                    var filePath = path + filename;

                    using (var swfile = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        using (var swFile = new StreamWriter(swfile))
                        {
                            foreach (var wo in woList)
                            {
                                swFile.WriteLine($"{wo},");
                            }
                        }
                    }
                    return MoveSigConnectFile(filePath, filename);
                }
                catch (Exception e)
                {
                    Msg.ProgError(e.Message, e.InnerException);
                    return false;
                }
            }
        }

        internal static class Qc
        {

            internal static bool QmsPass(int so)
            {
                using (var db = new AISDbEntities(true))
                {
                    return db.Database.SqlQuery<bool>($"SELECT dbo.fn_QmsPass({so})").Single();
                }
            }

            internal static bool PTestPass(int shopOrder)
            {
                using (var db = new AISDbEntities(true))
                {
                    var t =
                        !db.TestResults.Any(
                           r =>
                               r.ShopOrder == shopOrder &&
                               ((r.ResultType == 1 && (r.Result < r.Lower || r.Result > r.Upper)) ||
                               (r.ResultType == 2 && r.Result == 0) ||
                               r.Result == null));
                    return t;
                }
            }

            internal static bool SgPass(int shopOrder)
            {
                using (var db = new AISDbEntities(true))
                {
                    var t = !db.SgResults.Any(r =>
                     r.ShopOrder == shopOrder &&
                    (r.PassFail == false ||
                    r.PassFail == null));
                    return t;
                }
            }

            internal static void CheckIntoQc(int workOrder, string user, bool auto = true)
            {
                using (var db = new MesDbEntities(true))
                {
                    try
                    {
                        var w = db.WorkOrders.First(r => r.WorkOrder == workOrder);
                        if (w.QcCheckInDt != null)
                        {
                            if (!auto) Msg.Error($"{workOrder} has already been check in to QC!");
                            return;
                        }
                        w.QcCheckInBy = user;
                        w.QcCheckInDt = DateTime.Now;
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Msg.ProgError(ex.Message, ex.InnerException);
                    }

                }
            }

            internal static void QcRelease(int workOrder, string user)
            {
                try
                {
                    using (var db = new MesDbEntities(true))
                    {
                        var dt = DateTime.Now;
                        var wo = db.WorkOrders.Single(r => r.WorkOrder == workOrder);
                        if (wo.QcCheckInDt ==null) CheckIntoQc(workOrder,user);
                        wo.QcReleasedBy = user;
                        wo.QcReleasedDt = dt;
                        var pkgs = db.Packages.Where(r =>
                            r.WorkOrders.WorkOrder == workOrder && r.QualCode == "F" && r.Status == "QCH").ToList();
                        foreach (var p in pkgs)
                        {
                            if (p.MasterItem.StartsWith("B") || p.MasterItem.StartsWith("RB"))
                            {
                                p.Status = "AVL";
                                p.LstWorkOrder = p.WorkOrder;
                                p.WorkOrder = null;
                            }
                            else
                            {
                                p.Status = "FRG";
                            }
                            p.ChangedBy = user;
                            p.ChangedDate = dt;
                        }
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Msg.ProgError(ex.Message, ex.InnerException);
                }
            }

            //internal static bool CommitFrfg(string formName, DateTime dt)
            //{
            //    using (var mesDb = new MesDbEntities(true))
            //    {
            //        using (var aisDb = new AISDbEntities(true))
            //        {
            //            var asgnpkgs =
            //                mesDb.Rolls.Where(
            //                    p => p.DelschedID != 0 && p.FRFG == false && p.Status == "FRG" && p.Warehouse == "DIS")
            //                    .ToList();
            //            var delscheds = mesDb.Delscheds.Where(d => d.assignFRFGqty > 0).ToList();
            //            var pkgs = (from p in asgnpkgs
            //                        join x in mesDb.EDIskuXrefs on p.skuno equals x.skuno
            //                        join d in delscheds on p.delschedID equals d.identity_column
            //                        join e in mesDb.EDIordersIns on
            //                            new { d.orderdet.orderhdr.custrefno, custPOline = d.custPOline.Trim() }
            //                            equals new { e.custrefno, custPOline = e.custPOlin.ToString() }
            //                        join qar in aisDb.QARs on p.shadegroup equals qar.ShadeGroup into qp
            //                        from q in qp.DefaultIfEmpty()
            //                        select new
            //                        {
            //                            p.serialno,
            //                            x.custno,
            //                            p.skuno,
            //                            x.custSKU,
            //                            d.scheddate,
            //                            x.custItem,
            //                            x.custColor,
            //                            p.finorderno,
            //                            p.finlength,
            //                            grossWt = p.tarewt + p.netqty,
            //                            usewidth = p.usewidth == 0 ? p.finwidth : p.usewidth,
            //                            pono = e.pono == "0" ? e.salesordno.ToString() : e.pono,
            //                            polnno = e.polnno == 0 ? e.salesordline : e.polnno,
            //                            p.frfg,
            //                            p.warehouse,
            //                            p.location,
            //                            p.palletno,
            //                            p.shadegroup,
            //                            MilLot = q == null ? "               " : q.MilLot
            //                        }).Distinct().ToList();
            //            if (pkgs.Count == 0)
            //            {
            //                Msg.SendErrorEmail(formName, "There is nothing to send");
            //                return false;
            //            }
            //            foreach (var p in pkgs)
            //            {
            //                var fo = p.finorderno.StartsWith("FO-")
            //                    ? p.finorderno.Replace("FO-", "").TrimStart('0')
            //                    : p.finorderno;
            //                //var milLot = p.shadegroup != null ? null : GetMilLot(p.shadegroup);

            //                mesDb.FRFGs.Add(new FRFG
            //                {
            //                    custno = p.custno,
            //                    skuno = p.skuno,
            //                    custSKU = p.custSKU,
            //                    scheddate = p.scheddate,
            //                    FRFGsent = false,
            //                    changedby = Global.User,
            //                    changedate = dt,
            //                    filetype = "UG",
            //                    serialno = p.serialno,
            //                    custItem = p.custItem,
            //                    custColor = p.custColor,
            //                    finorderno = fo,
            //                    quality = "F",
            //                    grade = "A",
            //                    finlength = p.finlength,
            //                    grossWgt = p.grossWt,
            //                    usewidth = p.usewidth ?? 0,
            //                    findate = dt,
            //                    custPO = p.pono,
            //                    custPOlineno = p.polnno.ToString(),
            //                    location = p.warehouse == "DIS" ? p.location : "      ",
            //                    container = p.warehouse == "DIS" ? p.palletno : "    ",
            //                    MilLot = p.MilLot
            //                });
            //            }

            //            foreach (var p in asgnpkgs)
            //            {
            //                p.frfg = true;
            //                p.custno = "POL01";
            //                p.status = "BHD";
            //                p.changedate = dt;
            //                p.changetime = time;
            //                p.changedby = Global.User;
            //            }
            //            foreach (var ds in delscheds)
            //            {
            //                ds.FRFGprodqty = ds.FRFGprodqty + ds.assignFRFGqty;
            //                if (ds.FRFGprodqty == 0)
            //                    LogError(ds.identity_column.ToString(), ds.FRFGprodqty.ToString(),
            //                        ds.assignFRFGqty.ToString());
            //                ds.shippedqty = ds.shippedqty + ds.assignFRFGqty;
            //                ds.orderdet.shippedqty = ds.orderdet.shippedqty + ds.assignFRFGqty;
            //                ds.orderdet.orderhdr.shippedqty = ds.orderdet.orderhdr.shippedqty + ds.assignFRFGqty;
            //                ds.assignFRFGqty = 0;
            //            }
            //            try
            //            {
            //                mesDb.SaveChanges();
            //                var p = pkgs.Select(r => r.serialno).ToList();
            //                var lst = string.Join("','", p);
            //                var list = $"'{lst}'";
            //                mesDb.spr_addpkghitdt($"serialno IN ({list})", "FRFG Committed", dt);
            //            }

            //            catch (DbEntityValidationException ex)
            //            {
            //                // Retrieve the error messages as a list of strings.
            //                var errorMessages = ex.EntityValidationErrors
            //                    .SelectMany(x => x.ValidationErrors)
            //                    .Select(x => x.ErrorMessage);

            //                // Join the list to a single string.
            //                var fullErrorMessage = string.Join("; ", errorMessages);

            //                // Combine the original exception message with the new one.
            //                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ",
            //                    fullErrorMessage);

            //                // Throw a new DbEntityValidationException with the improved exception message.
            //                Msg.Error(exceptionMessage);
            //                return false;
            //            }

            //            return true;
            //        }
            //    }
            //}

            internal static string GetMilLot(string sg)
            {
                using (var db = new AISDbEntities(true))
                {
                    return db.QARs.FirstOrDefault(r => r.ShadeGroup == sg)?.MilLot;
                }
            }

            internal static void LogError(string par1, string par2, string par3)
            {
                var localstore = $@"{AppDomain.CurrentDomain.BaseDirectory}\Temp\";
                var filepath = Path.Combine(localstore, "ErrorLog.txt");
                using (var file = new StreamWriter(filepath, true))
                {
                    file.WriteLine($"{par1}  {par2}  {par3}");
                }
            }

            internal static bool ValidStep(string shoporder, string process)
            {

                return true;
            }

            //internal static bool CreateFrfg(string text)
            //{
            //    using (var db = new impactEntities(true))
            //    {
            //        var edi = db.CustEDIs.FirstOrDefault(c => c.custno == "POL01");
            //        if (edi == null)
            //        {
            //            const string msg =
            //                "There is no entry for Polartec (POL01) in the CustEDI table. No file will be created or sent.";
            //            Msg.Error(msg);
            //            Msg.SendErrorEmail(text, msg);
            //            return false;
            //        }
            //        var frfg = db.FRFGs.Where(r => r.FRFGsent == false).ToList();
            //        var filename = "FRFG" + Regex.Replace(DateTime.Now.ToString(), "[^0-9]", "") + ".txt";
            //        var edIstore = $@"\\{edi.EdiRoot}\{edi.ediFolder.Trim()}\{edi.frfgFolder.Trim()}\";
            //        var localstore = $@"{AppDomain.CurrentDomain.BaseDirectory}\Temp\";
            //        var remotestore = $@"\\{edi.FTPaddr}\{edi.custFrfgFolder}\";
            //        var filepath = Path.Combine(localstore, filename);
            //        if (!Directory.Exists(localstore)) Directory.CreateDirectory(localstore);
            //        try
            //        {
            //            using (var file = new StreamWriter(filepath, true))
            //            {
            //                foreach (var r in frfg)
            //                {
            //                    file.WriteLine(
            //                        $@"{r.filetype}" +
            //                        $@"{r.serialno}" +
            //                        $@"{r.custItem.PadRight(12, ' ')}" +
            //                        $@"{r.custColor.PadRight(12, ' ')}" +
            //                        $@"{r.finorderno.PadLeft(8, '0')}" +
            //                        $@"{r.quality.PadLeft(2, ' ')}" +
            //                        $@"{r.grade.PadLeft(2, ' ')}" +
            //                        $@"{r.MilLot?.PadRight(15, ' ') ?? "               "}" +
            //                        $@"{r.location.PadLeft(6, ' ')}" +
            //                        $@"{((r.finlength * 100).ToString()).Replace(".00", "").PadLeft(5, '0')}" +
            //                        $@"{((r.grossWgt * 100).ToString()).Replace(".00", "").PadLeft(5, '0')}" +
            //                        $@"{((r.usewidth * 100).ToString()).Replace(".00", "").PadRight(4, '0')}" +
            //                        @"  " +
            //                        @"  " +
            //                        $@"{r.findate.ToString("yyyyMMdd")}" +
            //                        $@"{r.container.PadLeft(4, ' ')}" +
            //                        $@"{r.custPO.PadLeft(6, '0')}" +
            //                        @" " +
            //                        $@"{r.custPOlineno.Trim().PadLeft(3, '0')}" +
            //                        @"         ");
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Msg.ProgError(ex.Message, ex.InnerException);
            //            Msg.SendErrorEmail(text,
            //                $@"Error creating FRFG file.  {Environment.NewLine}{ex.Message} - {ex.InnerException}");
            //            return false;
            //        }
            //        try
            //        {
            //            var impersonationContext = new WrappedImpersonationContext(edi.FTPuser.Split('\\')[0],
            //                edi.FTPuser.Split('\\')[1], edi.FTPpassword);
            //            impersonationContext.Enter();
            //            if (!Directory.Exists(remotestore))
            //            {
            //                var msg = $"'{remotestore}' cannot be reached. This path may not be valid. " +
            //                          "No file will be sent. Check local directory for file.";
            //                Msg.Error(msg);
            //                Msg.SendErrorEmail(text, msg);
            //                impersonationContext.Leave();
            //                return false;
            //            }
            //            File.Copy(filepath, Path.Combine(remotestore, filename));
            //            impersonationContext.Leave();
            //            foreach (var r in frfg)
            //            {
            //                r.FRFGsent = true;
            //            }
            //            db.SaveChanges();
            //            if (!Directory.Exists(edIstore))
            //            {
            //                var msg = $"'{edIstore}' cannot be reached. This path may not be valid. " +
            //                          "File has been sent but is still local.";
            //                Msg.Error(msg);
            //                Msg.SendErrorEmail(text, msg);
            //                return false;
            //            }
            //            File.Move(filepath, Path.Combine(edIstore, filename));
            //        }

            //        catch (Exception ex)
            //        {
            //            Msg.ProgError(ex.Message, ex.InnerException);
            //            Msg.SendErrorEmail(text,
            //                $@"Error copying or moving FRFG file.  {Environment.NewLine}{ex.Message} - {
            //                    ex.InnerException}");
            //            return false;
            //        }
            //        SendPtFile(text);
            //        Msg.Confirmation("FRFG file has been created and sent.");
            //        return true;
            //    }
            //}

            //internal static void SendPtFile(string text)
            //{
            //    using (var aisDb = new AISDbEntities(true))
            //    {
            //        var reslist = aisDb.TestResults.Where(r => r.Result != null && r.PostedDt == null).ToList();
            //        var sglist = aisDb.SgResults.Where(r => r.SC != null && r.PostedDt == null).ToList();
            //        if (reslist.Count == 0 && sglist.Count == 0) return;
            //        using (var impDb = new impactEntities(true))
            //        {
            //            var edi = impDb.CustEDIs.FirstOrDefault(c => c.custno == "POL01");
            //            if (edi == null)
            //            {
            //                const string msg =
            //                    "There is no entry for Polartec (POL01) in the CustEDI table. No file will be created or sent.";
            //                Msg.Error(msg);
            //                Msg.SendErrorEmail(text, msg);
            //                return;
            //            }
            //            var sos =
            //                reslist.Select(r => r.ShopOrder.ToString())
            //                    .Distinct()
            //                    .ToList()
            //                    .Union(sglist.Select(r => r.ShopOrder.ToString()).Distinct().ToList());

            //            var fr = impDb.FRFGs.Where(f => sos.Contains(f.finorderno)
            //                                            && f.FRFGsent
            //                ).Select(f => new
            //                {
            //                    f.finorderno,
            //                    f.custSKU,
            //                    f.custPO,
            //                    f.custPOlineno,
            //                    f.findate
            //                }).Distinct().ToList();
            //            if (fr.Count == 0) return;
            //            var res =
            //                reslist.Where(
            //                    r => fr.Select(f => f.finorderno).Contains(r.ShopOrder.ToString()) && r.PostedDt == null)
            //                    .ToList();
            //            var sg =
            //                sglist.Where(
            //                    r => fr.Select(f => f.finorderno).Contains(r.ShopOrder.ToString()) && r.PostedDt == null)
            //                    .ToList();

            //            var filename = "TestResults" + Regex.Replace(DateTime.Now.ToString(), "[^0-9]", "") + ".txt";
            //            var edIstore = $@"\\{edi.EdiRoot}\{edi.ediFolder.Trim()}\{edi.ptResultsFolder.Trim()}\";
            //            var localstore = $@"{AppDomain.CurrentDomain.BaseDirectory}\Temp\";
            //            var remotestore = $@"\\{edi.FTPaddr}\{edi.custPtResultsFolder}\";
            //            var filepath = Path.Combine(localstore, filename);
            //            if (!Directory.Exists(localstore)) Directory.CreateDirectory(localstore);
            //            try
            //            {
            //                using (var file = new StreamWriter(filepath, true))
            //                {
            //                    foreach (var f in fr)
            //                    {
            //                        var findate = f.findate.ToString("yyyyMMdd",
            //                            System.Globalization.CultureInfo.InvariantCulture);
            //                        file.WriteLine(
            //                            @"10" +
            //                            $@"{f.custPO.PadLeft(6, ' ')}" +
            //                            $@"{f.custPOlineno.PadLeft(3, ' ')}" +
            //                            $@"{f.custSKU.PadLeft(15, ' ')}" +
            //                            $@"{f.finorderno.PadLeft(10, ' ')}" +
            //                            $@"{findate}" +
            //                            @" " +
            //                            @"1");
            //                        var ptres =
            //                            reslist.Where(r => r.ShopOrder.ToString() == f.finorderno && r.PostedDt == null)
            //                                .ToList();
            //                        foreach (var r in ptres)
            //                        {
            //                            var symb = r.Result < 0 ? "-" : "+";
            //                            var result = r.ResultType == 1
            //                                ? (r.Result <= r.Upper && r.Result >= r.Lower ? 1 : 0)
            //                                : r.Result == 0 ? 0 : 1;
            //                            file.WriteLine(
            //                                @"20" +
            //                                $@"{r.ShopOrder.ToString().PadLeft(10, ' ')}" +
            //                                $@"{r.TestID.PadLeft(20, ' ')}" +
            //                                $@"{r.Result.ToString().PadLeft(18, ' ')}" +
            //                                $@"{symb}" +
            //                                $@"{result}");
            //                        }
            //                        var sgres =
            //                            sglist.Where(r => r.ShopOrder.ToString() == f.finorderno && r.PostedDt == null)
            //                                .ToList();
            //                        foreach (var r in sgres)
            //                        {
            //                            file.WriteLine(
            //                                @"20" +
            //                                $@"{r.ShopOrder.ToString().PadLeft(10, ' ')}" +
            //                                @"SG                  " +
            //                                $@"{r.SC.ToString().PadLeft(18, ' ')}" +
            //                                @"+" +
            //                                $@"{r.PassFail}");
            //                        }
            //                    }
            //                    file.WriteLine("EOF");
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                Msg.ProgError(ex.Message, ex.InnerException);
            //                Msg.SendErrorEmail(text,
            //                    $@"Error creating PT Results file.  {Environment.NewLine}{ex.Message} - {ex
            //                        .InnerException}");
            //            }
            //            try
            //            {
            //                var impersonationContext = new WrappedImpersonationContext(edi.FTPuser.Split('\\')[0],
            //                    edi.FTPuser.Split('\\')[1], edi.FTPpassword);
            //                impersonationContext.Enter();
            //                if (!Directory.Exists(remotestore))
            //                {
            //                    var msg = $"'{remotestore}' cannot be reached. This path may not be valid. " +
            //                              "No file will be sent. Check local directory for file.";
            //                    Msg.Error(msg);
            //                    Msg.SendErrorEmail(text, msg);
            //                    impersonationContext.Leave();
            //                    return;
            //                }
            //                File.Copy(filepath, Path.Combine(remotestore, filename));
            //                impersonationContext.Leave();
            //                var dt = DateTime.Now;
            //                var ptso = res.Select(r => r.ShopOrder).Distinct().ToList();
            //                if (ptso.Count > 0)
            //                {
            //                    aisDb.TestResults.Where(t => ptso.Contains(t.ShopOrder))
            //                        .Update(t => new TestResult
            //                        {
            //                            PostedDt = dt
            //                        });
            //                }
            //                var sgso = sg.Select(r => r.ShopOrder).Distinct().ToList();
            //                if (sgso.Count > 0)
            //                {
            //                    aisDb.SgResults.Where(t => sgso.Contains(t.ShopOrder))
            //                        .Update(t => new SgResult()
            //                        {
            //                            PostedDt = dt
            //                        });
            //                }
            //                if (!Directory.Exists(edIstore))
            //                {
            //                    var msg = $"'{edIstore}' cannot be reached. This path may not be valid. " +
            //                              "File has been sent but is still local.";
            //                    Msg.Error(msg);
            //                    Msg.SendErrorEmail(text, msg);
            //                    return;
            //                }
            //                File.Move(filepath, Path.Combine(edIstore, filename));
            //            }

            //            catch (Exception ex)
            //            {
            //                Msg.ProgError(ex.Message, ex.InnerException);
            //                Msg.SendErrorEmail(text,
            //                    $@"Error copying or moving PT Results file.  {Environment.NewLine}{ex.Message} - {
            //                        ex.InnerException}");
            //            }
            //        }
            //    }
            //}
        }
    }
}

