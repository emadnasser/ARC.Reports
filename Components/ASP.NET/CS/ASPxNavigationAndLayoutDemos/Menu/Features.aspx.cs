using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Menu_Features : Page {
    AutoSeparatorMode CurrentAutoSeparatorMode {
        get {
            return (AutoSeparatorMode)Enum.Parse(typeof(AutoSeparatorMode),
                ddlAutoSeparators.SelectedItem.Value.ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        mMain.AllowSelectItem = cbAllowSelectItem.Checked;
        mMain.AutoPostBack = cbAutoPostBack.Checked;
        mMain.EnableAnimation = cbEnableAnimation.Checked;
        mMain.EnableHotTrack = cbEnableHotTrack.Checked;
        mMain.AutoSeparators = CurrentAutoSeparatorMode;
    }

    protected void btnApply_Click(object sender, EventArgs e) {
        int result = 0;

        lblAppearAfterError.Visible = 
            !int.TryParse(tbAppearAfter.Text, out result) || result < 0;
        if(!lblAppearAfterError.Visible)
            mMain.AppearAfter = result;

        lblDisappearAfterError.Visible =
            !int.TryParse(tbDisappearAfter.Text, out result) || result < 0;
        if(!lblDisappearAfterError.Visible)
            mMain.DisappearAfter = result;

        lblMaximumDisplayError.Visible = 
            !int.TryParse(tbMaximumDisplayLevels.Text, out result) || result < 0;
        if(!lblMaximumDisplayError.Visible)
            mMain.MaximumDisplayLevels = result;

        lblOpacityError.Visible = 
            !int.TryParse(tbOpacity.Text, out result) || result < 0 || result > 100;
        if(!lblOpacityError.Visible)
            mMain.Opacity = result;
    }
}
