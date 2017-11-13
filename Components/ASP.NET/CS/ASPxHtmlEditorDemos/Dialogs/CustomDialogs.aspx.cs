using System;
using System.Web.UI;

public partial class Dialogs_CustomDialogs : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Dialogs/CustomDialogs.html");
    }

}
