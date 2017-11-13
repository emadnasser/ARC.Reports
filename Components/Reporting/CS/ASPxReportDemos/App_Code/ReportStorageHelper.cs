using System.IO;
using System.Web.SessionState;
using DevExpress.XtraReports.UI;

public static class ReportStorageHelper {
    public static XtraReport LoadReport(string reportName, HttpSessionState session) {
        var reportLayout = GetReportLayout(reportName, session);
        if(reportLayout != null) {
            using(var stream = new MemoryStream(reportLayout)) {
                return XtraReport.FromStream(stream, true);
            }
        }
        var demoReportsAssembly = typeof(XtraReportsDemos.Overview.Report).Assembly;
        return demoReportsAssembly.CreateInstance(reportName) as XtraReport;
    }

    public static void SaveReportLayout(string reportName, byte[] reportLayout, HttpSessionState session) {
        session[GetKey(reportName)] = reportLayout;
    }

    static byte[] GetReportLayout(string reportName, HttpSessionState session) {
        return session[GetKey(reportName)] as byte[];
    }

    static string GetKey(string reportName) {
        const string SessionPrefix = "XRDesignedReportLayout";
        return SessionPrefix + reportName;
    }
}
