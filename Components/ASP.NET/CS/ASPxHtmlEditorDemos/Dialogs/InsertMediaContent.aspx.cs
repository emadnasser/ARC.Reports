using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Features_MediaSelector: Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Dialogs/MediaSelector.html");
            SetEditorsState();
        }
    }
    protected void SetEditorsState() {
        cbAllowHTML5MediaElements.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowHTML5MediaElements;
        cbAllowObjectAndEmbedElements.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowObjectAndEmbedElements;
        cbAllowYouTubeVideoIFrames.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowYouTubeVideoIFrames;
    }
    protected void cbAllowHTML5MediaElements_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsHtmlEditing.AllowHTML5MediaElements = ((ASPxCheckBox)sender).Checked;
    }
    protected void cbAllowObjectAndEmbedElements_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsHtmlEditing.AllowObjectAndEmbedElements = ((ASPxCheckBox)sender).Checked;
    }
    protected void cbAllowYouTubeVideoIFrames_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsHtmlEditing.AllowYouTubeVideoIFrames = ((ASPxCheckBox)sender).Checked;
    }
}
