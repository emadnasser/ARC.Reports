using System.Web;
using System.Web.UI;

public partial class UserControls_ShowDesignerButtonControl : UserControl, IShowDesignerButtonControl {
    public string ReportTypeName { get; set; }

    protected string RunDesignerUrl {
        get {
            var reportName = HttpUtility.UrlEncode(ReportTypeName);
            var redirectUrl = Request.RawUrl;
            redirectUrl = HttpUtility.UrlEncode(redirectUrl);
            redirectUrl = ReportDesignerUrlLogic.CleanUrl(redirectUrl, true);
            return string.Format("~/Designer.aspx?reportName={0}&amp;redirectUrl={1}", reportName, redirectUrl);
        }
    }
}
