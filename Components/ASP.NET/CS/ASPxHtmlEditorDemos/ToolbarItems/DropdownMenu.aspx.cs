using System;
using System.Web.UI;

public partial class ToolbarItems_DropdownMenu : Page {
    
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "ToolbarItems/DropdownMenu.html");
    }

}
