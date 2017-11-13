using System;
using System.IO;
using System.Web.UI;

public partial class ToolbarItems_CustomCSS : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "ToolbarItems/CustomCSS.html");
    }

}
