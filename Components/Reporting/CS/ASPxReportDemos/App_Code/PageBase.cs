using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;
using DevExpress.XtraReports.Web;

public abstract class PageBase<TReport> : Page {
    public bool IsASPViewer {
        get {
            return Request.Params[ViewerSelectorState.Key] == ViewerSelectorState.ClassicViewer;
        }
    }

    public bool IsHTML5Viewer {
        get {
            return Request.Params[ViewerSelectorState.Key] == null;
        }
    }

    public bool IsMobileViewer {
        get {
            return Request.Params[ViewerSelectorState.Key] == ViewerSelectorState.MobileViewer;

        }
    }
    protected void Page_Init(object sender, EventArgs e) {
        if(!IsPostBack && string.Equals(Request["fromDesigner"], bool.TrueString, StringComparison.OrdinalIgnoreCase)) {
            CleanDocument();

            var redirectUrl = Request.RawUrl.Substring(Request.ApplicationPath.Length);
            redirectUrl = ReportDesignerUrlLogic.CleanUrl(redirectUrl, false);
            Response.Redirect("~/" + redirectUrl);
        }

        var topRightMenuRegion = Master.FindControl("TopRightMenuRegion");
        var showDesignerButton = topRightMenuRegion.FindControl("showDesignerButton") as IShowDesignerButtonControl;
        if(showDesignerButton != null) {
            showDesignerButton.ReportTypeName = ReportTypeName;
        }

        var contentPlaceHolder = Master.FindControl("ContentHolder");
        var documentViewer = contentPlaceHolder.FindControl("documentViewer") as ASPxDocumentViewer;
        if(documentViewer != null) {
            documentViewer.Report = ReportStorageHelper.LoadReport(ReportTypeName, Session);
        }
        var webDocumentViewer = contentPlaceHolder.FindControl("webDocumentViewer") as ASPxWebDocumentViewer;
        if(webDocumentViewer != null) {
            webDocumentViewer.OpenReport(ReportStorageHelper.LoadReport(ReportTypeName, Session));
        }
        var mobileEmulator = contentPlaceHolder.FindControl("mobileEmulator") as IMobileEmulator;
        if(mobileEmulator != null) {
            mobileEmulator.ReportTypeName = ReportTypeName;
        }
        var viewerSelector = topRightMenuRegion.FindControl("viewerSelector") as IMobileEmulator;
        if(viewerSelector != null) {
            viewerSelector.ReportTypeName = ReportTypeName;
        }
    }

    protected string ReportTypeName {
        get { return typeof(TReport).FullName; }
    }

    protected virtual void CleanDocument() {
    }
}
