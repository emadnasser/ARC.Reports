using System;
using System.Web.UI;

public partial class Templates_CardView : Page {
    protected void chkShowHeaders_CheckedChanged(object sender, EventArgs e) {
        grid.Settings.ShowColumnHeaders = chkShowHeaders.Checked;
    }
}
