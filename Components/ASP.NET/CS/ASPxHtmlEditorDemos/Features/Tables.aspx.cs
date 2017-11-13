using System;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;

public partial class Features_SpellChecking : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/Tables.html");

            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1());
            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar2());
            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateTableToolbar());

            UpdateVisibility();
        }
    }

    protected void rbTable_CheckedChanged(object sender, EventArgs e) {
        UpdateVisibility();
    }

    protected void UpdateVisibility() {
        bool showTableToolbar = rbTableToolbar.Checked;
        DemoHtmlEditor.Toolbars["TableToolbar"].Visible = showTableToolbar;
        DemoHtmlEditor.Toolbars["StandardToolbar1"].Items.FindByText("Insert Table").Visible = !showTableToolbar;
    }
}
