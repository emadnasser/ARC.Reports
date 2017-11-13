using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxHtmlEditor;

public partial class Features_ToolbarMode: Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "ToolbarItems/ComboBox.html");
        else
            DemoHtmlEditor.ToolbarMode = (HtmlEditorToolbarMode)(int)cbToolbarMode.Value;
    }
}
