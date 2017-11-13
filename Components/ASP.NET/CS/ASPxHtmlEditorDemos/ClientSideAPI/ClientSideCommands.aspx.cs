using System;
using System.Web.UI;

public partial class ClientSideAPI_ClientSideCommands : Page {
    
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "ClientSideAPI/ClientSideCommands.html");
    }

}
