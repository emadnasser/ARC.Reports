using System.IO;
using System.Threading;
using System.Web;
using System.Web.Hosting;
using DevExpress.XtraReports.UI;

namespace ReportWebDemo.ReportCaching {
    public static class CacheReportHelper {
        static HttpContext currentContext;
        static CancellationTokenSource cancellation;

        public static void StartCreatingReports() {
            currentContext = HttpContext.Current;
            cancellation = new CancellationTokenSource();
            StartCreatingReports(Directory.GetFiles(HostingEnvironment.MapPath("~/App_Data/Dictionaries"), "*.txt"));
        }

        public static void EndCreatingReports() {
            cancellation.Cancel();
        }

        static void StartCreatingReports(string[] files) {
            var thread = new Thread(ThreadStart) {
                Priority = ThreadPriority.BelowNormal,
                IsBackground = true
            };
            thread.Start(files);
        }

        static void ThreadStart(object arg) {
            var fileNames = (string[])arg;
            foreach(string fileName in fileNames) {
                if(File.Exists(Path.ChangeExtension(fileName, "sav")))
                    continue;
                if(cancellation.IsCancellationRequested) {
                    break;
                }
                string savingFile = Path.ChangeExtension(fileName, "saving");
                using(FileStream stream = File.Create(savingFile)) {
                    using(XtraReport report = new XtraReportsDemos.DictionaryReport.Report(fileName)) {
                        report.CreateDocument();
                        DevExpress.XtraPrinting.InternalAccess.PrintingSystemAccessor.SaveIndependentPages(report.PrintingSystem, stream);
                    }
                    stream.Flush();
                }
                lock(typeof(CacheReportHelper)) {
                    File.Move(savingFile, Path.ChangeExtension(fileName, "sav"));
                }
            }
        }
    }
}
