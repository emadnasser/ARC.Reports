using System;
using DevExpress.Web.ASPxRichEdit;

public partial class RichEditDemoRibbonCustomization : OfficeDemoPage {
    RichEditRibbonMode CurrentRibbonMode {
        get {
            return (RichEditRibbonMode)Enum.Parse(typeof(RichEditRibbonMode),
                ddlRibbonMode.SelectedItem.Value.ToString());
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack) {
            DemoRichEdit.RibbonMode = CurrentRibbonMode;
            DemoRichEdit.ShowStatusBar = cbShowStatusBar.Checked;

            if(CurrentRibbonMode.Equals(RichEditRibbonMode.ExternalRibbon)) {
                ExternalRibbon.Visible = true;
                DemoRichEdit.AssociatedRibbonID = ExternalRibbon.ID;
            } else {
                ExternalRibbon.Visible = false;
            }
        }
    }
    protected void DemoRichEdit_PreRender(object sender, EventArgs e) {
        DemoRichEdit.Focus();
    }
}
