using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Menu_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            return;
        nbMain.AllowExpanding = cbAllowExpanding.Checked;
        nbMain.AllowSelectItem = cbAllowSelectItem.Checked;
        nbMain.AutoCollapse = cbAutoCollapse.Checked;
        nbMain.AutoPostBack = cbAutoPostBack.Checked;
        nbMain.EnableHotTrack = cbEnableHotTrack.Checked;
        nbMain.EnableAnimation = cbEnableAnimation.Checked;
    }
}
