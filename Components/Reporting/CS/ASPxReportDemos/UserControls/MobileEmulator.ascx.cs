using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.Design;
using System.Web.UI.WebControls;

public partial class UserControls_MobileEmulator : System.Web.UI.UserControl, IMobileEmulator {
    public bool IsLandscape {
        get {
            return ReportTypeName == "XtraReportsDemos.CharacterComb.Report" ||
                ReportTypeName == "XtraReportsDemos.PivotGridAndChart.Report";
        }
    }
    public string ReportTypeName { get; set; }
    public string Url {
        get {
            return string.Format("~/MobileViewer.aspx?reportName={0}", HttpUtility.UrlEncode(ReportTypeName));
        }
    }
    public int QRCodeSize {
        get { return 124; }
    }
    public string QRCodeUrl {
        get {
            var absoluteUri = new System.Uri(Page.Request.Url, ResolveClientUrl(Url)).AbsoluteUri;
            return string.Format("http://chart.apis.google.com/chart?cht=qr&chs={0}x{1}&chl={2}&chld=H%7C0", QRCodeSize, QRCodeSize, absoluteUri);
        }
    }
}
