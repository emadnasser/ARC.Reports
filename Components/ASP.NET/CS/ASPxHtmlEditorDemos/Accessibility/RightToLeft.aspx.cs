using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Accessibility_RightToLeft : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Accessibility/RightToLeft.html");
    }
}
