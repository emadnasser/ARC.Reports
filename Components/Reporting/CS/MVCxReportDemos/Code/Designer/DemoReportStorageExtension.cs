using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.Web.Demos.Code.Designer;
using DevExpress.Web.Demos;
using System.Text;

public class DemoReportStorageExtension : ReportStorageWebExtension {
    public static DemoReportStorageExtension ReportStorageExtension = new DemoReportStorageExtension();
    public override bool CanSetData(string url) {
        return true;
    }
    public override Dictionary<string, string> GetUrls() {
        return (Dictionary<string, string>)HttpContext.Current.Session["urls"];
    }
    public override byte[] GetData(string url) {
        using(MemoryStream ms = new MemoryStream()) {
            XtraReport report = ReportStorageHelper.LoadReport(url, new HttpSessionStateWrapper(HttpContext.Current.Session));
            if(report == null)
                report = new XtraReport();
            report.SaveLayoutToXml(ms);
            return ms.ToArray();
        }
    }

    public override bool IsValidUrl(string url) {
        return true;
    }

    public override void SetData(XtraReport report, string url) {
        using(MemoryStream ms = new MemoryStream()) {
            report.SaveLayoutToXml(ms);
            ReportStorageHelper.SaveReportLayout(url, ms.ToArray(), new HttpSessionStateWrapper(HttpContext.Current.Session));

        }
    }

    public override string SetNewData(XtraReport report, string newUrl) {
        using(MemoryStream ms = new MemoryStream()) {
            var urls = (Dictionary<string, string>)HttpContext.Current.Session["urls"];
            if(!urls.Select((url) => url.Key).Contains(newUrl)) {
                urls.Add(newUrl, newUrl);
            }
            report.SaveLayoutToXml(ms);
            ReportStorageHelper.SaveReportLayout(newUrl, ms.ToArray(), new HttpSessionStateWrapper(HttpContext.Current.Session));
            return newUrl;
        }
    }
}
