using System;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;

public partial class Features_CustomToolbars : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/CustomToolbar.html");

            DemoHtmlEditor.Toolbars.Add(CreateDemoCustomToolbar("CustomToolbar"));
            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1());
            DemoHtmlEditor.Toolbars["StandardToolbar1"].Visible = false;
            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar2());
            DemoHtmlEditor.Toolbars["StandardToolbar2"].Visible = false;
        }
    }

    protected HtmlEditorToolbar CreateDemoCustomToolbar(string name) {
        return new HtmlEditorToolbar(
            name,
            new ToolbarFontNameEdit(),
            new ToolbarFontSizeEdit(),
            new ToolbarJustifyLeftButton(true),
            new ToolbarJustifyCenterButton(),
            new ToolbarJustifyRightButton(),
            new ToolbarJustifyFullButton(),
            new ToolbarInsertLinkDialogButton(true),
            new ToolbarInsertImageDialogButton()
        ).CreateDefaultItems();
    }

    protected void cbToolbar_ValueChanged(object sender, EventArgs e) {
        bool showStandardToolbars = string.Equals(cbToolbar.Value, "Standard");
        DemoHtmlEditor.Toolbars["CustomToolbar"].Visible = !showStandardToolbars;
        DemoHtmlEditor.Toolbars["StandardToolbar1"].Visible = showStandardToolbars;
        DemoHtmlEditor.Toolbars["StandardToolbar2"].Visible = showStandardToolbars;
    }
}
