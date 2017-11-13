using System;
using System.Web.UI;
using DevExpress.Web;

public partial class RoundPanel_Features: Page {
    protected void Page_Load(object sender, EventArgs e) {
        UpdateSettings();
    }
    protected void UpdateSettings() {
        bool collapsingEnabled = IsCollapsingEnabled;
        rpShowCollapseButton.Enabled = collapsingEnabled;
        rpEnableAnimation.Enabled = collapsingEnabled;
        rpAllowCollapsingByHeaderClick.Enabled = IsCollapsingEnabled;

        ASPxFormLayout1.FindItemOrGroupByName("CollapsingSettingsGroup").Visible = View == View.Standard;
        
        ASPxRoundPanel1.ShowHeader = rpShowHeader.Checked;
        ASPxRoundPanel1.ShowCollapseButton = rpShowCollapseButton.Checked;
        ASPxRoundPanel1.View = View;
        ASPxRoundPanel1.EnableAnimation = rpEnableAnimation.Checked;
        ASPxRoundPanel1.AllowCollapsingByHeaderClick = rpAllowCollapsingByHeaderClick.Checked;
    }
    protected bool IsCollapsingEnabled {
        get { return View == View.Standard && rpShowHeader.Checked; }
    }
    protected View View {
        get { return (View)rpView.Value; }
    }
}
