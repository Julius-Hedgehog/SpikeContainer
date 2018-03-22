using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using Microsoft.Reporting.WinForms;
using ReportParameter = Microsoft.Reporting.WinForms.ReportParameter;

namespace PFCS.Classes
{
    internal class ReportPrinter
    {
        private bool _landscape;
        private int _mCurrentPageIndex;
        private IList<Stream> _mStreams;

        internal static void Print(string printer, bool landscape, string report, int copies, string[] Params)
        {
            var print = new ReportPrinter();
            print.PrntRpt(printer, landscape, report, copies, Params);
        }

        private void PrntRpt(string printer, bool landscape, string rpt, int copies, IList<string> Params)
        {
            _landscape = landscape;
            var parameters = new List<ReportParameter>();

            for (var i = 0; i < Params.Count - 1; i += 2)
            {
                var pName = Params[i];
                var pValue = Params[i + 1];
                var param = new ReportParameter(pName, pValue);
                parameters.Add(param);
            }

            var server = Data.SystemVariables.SsrsServerUri;

            var path = Data.SystemVariables.SsrsReportPath;

            var report = ConfigureReport(rpt, path, server, parameters);

            var baReport = GetReportByteArray(report);

            for (var i = 0; i < copies; i++)
            {
                PrintReport(printer, _landscape, baReport);
            }
        }

        private static Report ConfigureReport(string reportName, string reportPath, string reportServerUrl,
                                              ICollection<ReportParameter> pParameters)
        {
            var lsReportName = reportName;
            var lsReportPath = reportPath;
            var reportViewer = new ReportViewer {ProcessingMode = ProcessingMode.Remote};
            reportViewer.ServerReport.ReportServerUrl = new Uri(reportServerUrl, UriKind.Absolute);
            reportViewer.ServerReport.ReportPath = $"{lsReportPath}{lsReportName}";
            if (pParameters.Count > 0) reportViewer.ServerReport.SetParameters(pParameters);
            Report report = reportViewer.ServerReport;
            return report;
        }

        private List<byte[]> GetReportByteArray(Report pReport)
        {
            const string format = "Image";
            var p = new StringBuilder();
            var ls = new StringBuilder();
            var pages = new List<byte[]>();

            //Portrait Mode Settings
            p.Append("<DeviceInfo>");
            p.Append("<OutputFormat>EMF</OutputFormat>");
            p.Append("<PageWidth>8.5in</PageWidth>");
            p.Append("<PageHeight>11in</PageHeight>");
            p.Append("<StartPage>{0}</StartPage>");
            p.Append("<EndPage>{0}</EndPage>");
            p.Append("</DeviceInfo>");

            //Landscape Mode Settings
            ls.Append("<DeviceInfo>");
            ls.Append("<OutputFormat>EMF</OutputFormat>");
            ls.Append("<PageWidth>11in</PageWidth>");
            ls.Append("<PageHeight>8.5in</PageHeight>");
            ls.Append("<StartPage>{0}</StartPage>");
            ls.Append("<EndPage>{0}</EndPage>");
            ls.Append("</DeviceInfo>");

            var i = 1;
            while (true)
            {
                var deviceInfo = string.Format(_landscape ? ls.ToString() : p.ToString(), i);

                var currentPage = pReport.Render(format, deviceInfo);

                if (currentPage.Length > 0) pages.Add(currentPage);
                else break;

                i++;
            }

            // Return the rendered report
            return pages;
        }

        private void PrintReport(string printer, bool lsLandscape, IList<byte[]> report)
        {
            _mStreams = new List<Stream>();
            _mCurrentPageIndex = 0;
            for (var i = 0; i < report.Count; i++)
            {
                var ms = new MemoryStream();
                ms.Write(report[i], 0, report[i].Length);
                _mStreams.Add(ms);
                _mStreams[i].Position = 0;
            }

            using (var pd = new PrintDocument())
            {
                pd.PrinterSettings.MaximumPage = report.Count;
                pd.PrinterSettings.MinimumPage = 1;
                pd.PrinterSettings.PrintRange = PrintRange.AllPages;
                pd.DefaultPageSettings.Landscape = lsLandscape;
                pd.PrinterSettings.PrinterName = printer;
                pd.PrintPage += PrintPage;
                pd.Print();
                pd.PrintPage -= PrintPage;
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            using (var pageImage = new Metafile(_mStreams[_mCurrentPageIndex]))
            {
                if (_landscape)
                {
                    ev.Graphics.DrawImage(pageImage, x: 0, y: 0, width: 1075, height: 825);
                }
                else
                {
                    ev.Graphics.DrawImage(pageImage, x: 0, y: 0, width: 825, height: 1075);
                }
            }
            _mCurrentPageIndex++;
            ev.HasMorePages = (_mCurrentPageIndex < _mStreams.Count);
        }
    }
}