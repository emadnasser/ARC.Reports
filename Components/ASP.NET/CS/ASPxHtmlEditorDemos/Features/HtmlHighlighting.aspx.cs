using System;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;

public partial class Features_HtmlHighlighting : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/General.html");
            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1());
            DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar2());
            DemoHtmlEditor.Toolbars[1].Items.RemoveAll(item => item.GetType() == typeof(ToolbarBackColorButton));
        }
        DemoHtmlEditor.Settings.SettingsHtmlView.EnableTagAutoClosing = cbEnableTagAutoClosing.Checked;
        DemoHtmlEditor.Settings.SettingsHtmlView.EnableAutoCompletion = cbEnableAutoCompletion.Checked;
        DemoHtmlEditor.Settings.SettingsHtmlView.HighlightActiveLine = cbHighlightActiveLine.Checked;
        DemoHtmlEditor.Settings.SettingsHtmlView.HighlightMatchingTags = cbHighlightMatchingTags.Checked;
        DemoHtmlEditor.Settings.SettingsHtmlView.ShowLineNumbers = cbShowLineNumbers.Checked;
        DemoHtmlEditor.Settings.SettingsHtmlView.ShowCollapseTagButtons = cbShowCollapseTagButtons.Checked;
        DemoHtmlEditor.Settings.SettingsHtmlView.Mode = (HtmlEditorHtmlEditingMode)(int)cbHtmlEditingMode.Value;
    }
}
