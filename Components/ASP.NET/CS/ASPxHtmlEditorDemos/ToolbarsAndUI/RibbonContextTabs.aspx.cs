using System;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Utils;
using DevExpress.Web.Internal;
using DevExpress.Web;

public partial class Features_RibbonContextTabs : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/RibbonContextTabs.html");
    }
}
