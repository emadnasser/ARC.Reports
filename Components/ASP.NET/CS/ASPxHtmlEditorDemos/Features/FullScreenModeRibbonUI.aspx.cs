using System;
using DevExpress.Web;

public partial class Features_FullScreenModeRibbonUI : System.Web.UI.Page {

    protected void Page_PreInit(object sender, EventArgs e) {
        ASPxWebControl.GlobalTheme = "Mulberry";
        DevExpress.Web.Demos.Utils.ResetThemeParameters();
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/FullScreenModeContent.html");
    }
}
