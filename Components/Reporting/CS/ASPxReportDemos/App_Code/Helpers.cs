using System;
using System.IO;
using System.Reflection;
using System.Web;
using DevExpress.XtraReports.UI;

public static class Helper {
    public static string GetReportPath(XtraReport report, string ext) {
        string reportName = report.Name;
        if(string.IsNullOrEmpty(reportName))
            reportName = report.GetType().Name;
        string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        return Path.Combine(directoryName, string.Format("{0}.{1}", reportName, ext));
    }
    
    public static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
        oleDbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
    }
    
    public static string GetRelativePath(string name) {
        return HttpContext.Current.Request.MapPath("~/App_Data/" + name);
    }
    
    public static string GetRelativeStyleSheetPath(string styleSheetPath) {
        return GetRelativePath(styleSheetPath.Substring(styleSheetPath.LastIndexOf('\\') + 1));
    }
    
    static bool IsIE6 {
        get {
            HttpBrowserCapabilities browser = HttpContext.Current.Request.Browser;
            return string.Equals(browser.Browser, "ie", StringComparison.InvariantCultureIgnoreCase) && browser.Version == "6.0";
        }
    }

    public static string GetPageBorderCSSLink() {
        return string.Format(@"<link rel=""stylesheet"" type=""text/css"" href=""{0}/Content/PageBorders/styles{1}.css"" />",
            HttpContext.Current.Request.ApplicationPath, IsIE6 ? "_ie6" : string.Empty);
    }
}
