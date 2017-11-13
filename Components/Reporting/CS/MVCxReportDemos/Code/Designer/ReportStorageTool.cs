using System;
using System.IO;
using System.Reflection;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;

namespace DevExpress.Web.Demos.Code.Designer {
    public class ReportStorageTool : IReportStorageTool {
        readonly Assembly assembly = typeof(XtraReportsDemos.ReportNames).Assembly;

        public bool IsValidUrl(string url) {
            return assembly.GetType(url, false, false) != null;
        }

        public byte[] GetData(string url) {
            var type = assembly.GetType(url, false, false);
            if(type == null) {
                return null;
            }
            var report = Activator.CreateInstance(type) as XtraReport;
            if(report == null) {
                return null;
            }
            using(report)
            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                return stream.ToArray();
            }
        }

        public bool CanSetData(string url) {
            return false;
        }

        public void SetData(XtraReport report, Stream stream) {
            throw new NotSupportedException();
        }

        public void SetData(XtraReport report, string url) {
            throw new NotSupportedException();
        }
    }
}
