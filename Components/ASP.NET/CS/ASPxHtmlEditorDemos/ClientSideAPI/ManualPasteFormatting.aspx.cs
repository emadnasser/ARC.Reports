using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;

public partial class ClientSideAPI_ManualPasteFormatting : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "ClientSideAPI/MobileApp.html");
            DemoHtmlEditor.ClientSideEvents.BeforePaste = "BeforePasteHandler";
        }
    }
}
