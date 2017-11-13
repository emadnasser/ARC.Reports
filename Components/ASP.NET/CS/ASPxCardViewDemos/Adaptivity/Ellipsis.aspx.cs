using System;

public partial class Ellipsis : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        CardView.SettingsBehavior.AllowEllipsisInText = EnableEllipsisCheckBox.Checked;
    }
}
