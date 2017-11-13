using System;
using System.Web;
using DevExpress.Web.Internal;
using DashboardDemos.Core;

public partial class _Default : System.Web.UI.Page {
    const string LOCAL_TOUCHBOARD_RELATIVE_PATH = "/DashboardViewer.aspx";
    const string QRCODE_URL = "http://go.devexpress.com/DashboardTabletDemo.aspx";
    
    protected override void OnInit(EventArgs e) {
        base.OnInit(e);
        if(DashboardDemosUtils.ShouldRecreateDatabases(null))
            Response.Redirect("DatabaseGenerationForm.aspx");     
    }
    protected void Page_Load(object sender, EventArgs e) {
        if(RenderUtils.Browser.Platform.IsTouchUI || !string.IsNullOrEmpty(Request.Params["noredirect"]))
            Response.Redirect(DemoUrl);
    }
    public string DemoUrl {
        get { 
            string fullUrl = Page.Request.Url.ToString().ToLower();           
            return fullUrl.Remove(fullUrl.LastIndexOf("/")) + LOCAL_TOUCHBOARD_RELATIVE_PATH;
        }
    }
    public int QRCodeSize {
        get { return 124; }
    }
    public string QRCodeUrl {
        get { return string.Format("http://chart.apis.google.com/chart?cht=qr&chs={0}x{1}&chl={2}&chld=H|0", QRCodeSize, QRCodeSize, HttpUtility.UrlEncode(QRCODE_URL)); }
    }
}
