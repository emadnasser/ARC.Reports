using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Features_Resizing : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/Resizing.html");

            cbAllowResize.Checked = DemoHtmlEditor.SettingsResize.AllowResize;
            seMinWidth.Number = DemoHtmlEditor.SettingsResize.MinWidth;
            seMaxWidth.Number = DemoHtmlEditor.SettingsResize.MaxWidth;
            seMinHeight.Number = DemoHtmlEditor.SettingsResize.MinHeight;
            seMaxHeight.Number = DemoHtmlEditor.SettingsResize.MaxHeight;
        }
        else {
            DemoHtmlEditor.SettingsResize.AllowResize = cbAllowResize.Checked;
            DemoHtmlEditor.SettingsResize.MinWidth = Decimal.ToInt32(seMinWidth.Number);
            DemoHtmlEditor.SettingsResize.MaxWidth = Decimal.ToInt32(seMaxWidth.Number);
            DemoHtmlEditor.SettingsResize.MinHeight = Decimal.ToInt32(seMinHeight.Number);
            DemoHtmlEditor.SettingsResize.MaxHeight = Decimal.ToInt32(seMaxHeight.Number);
        }
    }
}
