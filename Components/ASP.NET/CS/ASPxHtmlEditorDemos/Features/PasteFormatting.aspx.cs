using System;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;

public partial class Features_PasteFormatting: Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/PasteFormatting.html");
            cbEnablePasteOptions.Checked = DemoHtmlEditor.SettingsHtmlEditing.EnablePasteOptions;
            cbPasteMode.Value = (int)DemoHtmlEditor.SettingsHtmlEditing.PasteMode;
        }
        else {
            DemoHtmlEditor.SettingsHtmlEditing.EnablePasteOptions = cbEnablePasteOptions.Checked;
            DemoHtmlEditor.SettingsHtmlEditing.PasteMode = (HtmlEditorPasteMode)(int)cbPasteMode.Value;
        }
    }
}
