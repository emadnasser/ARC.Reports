using System;
using System.Web.UI;

public partial class ToolbarItems_DropdownItemPicker : Page {
    
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "ToolbarItems/DropdownItemPicker.html");

            DemoHtmlEditor.Toolbars[0].Items[7].Image.Url = HtmlEditorUtils.IsDarkTheme(Theme)
                ? "../Content/Demo/Toolbar/symbol-dark.png"
                : "../Content/Demo/Toolbar/symbol.png";
        }
    }

}
