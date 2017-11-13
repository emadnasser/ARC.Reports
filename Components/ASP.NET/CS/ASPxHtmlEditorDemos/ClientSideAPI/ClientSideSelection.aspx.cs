using System;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;

public partial class ClientSideAPI_ClientSideSelection : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "ClientSideAPI/ClientSideSelection.html");

            HtmlEditorToolbarItem changeCaseItem = DemoHtmlEditor.Toolbars[0].Items.FindByCommandName("ChangeCase");
            changeCaseItem.Image.Url = HtmlEditorUtils.IsDarkTheme(Theme)
                ? "../Content/Demo/Toolbar/case-dark.png"
                : "../Content/Demo/Toolbar/case.png";
        }
    }

}
