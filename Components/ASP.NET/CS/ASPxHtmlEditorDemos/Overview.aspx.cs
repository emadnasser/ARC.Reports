using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;

public partial class Overview : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Overview/Blueberry.html");
            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1());
            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar2());
            DemoHtmlEditor.Toolbars[1].Items.RemoveAll(item => item.GetType() == typeof(ToolbarParagraphFormattingEdit));
        }
    }
}
