using System;
using System.IO;
using System.Reflection;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;

public class ReportStorageTool : IReportStorageTool {
    readonly Assembly assembly = typeof(XtraReportsDemos.ReportNames).Assembly;

    bool IReportStorageTool.IsValidUrl(string url) {
        return assembly.GetType(url, false, false) != null;
    }

    byte[] IReportStorageTool.GetData(string url) {
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

    bool IReportStorageTool.CanSetData(string url) {
        return false;
    }

    void IReportStorageTool.SetData(XtraReport report, Stream stream) {
        throw new NotSupportedException();
    }

    void IReportStorageTool.SetData(XtraReport report, string url) {
        throw new NotSupportedException();
    }
}
