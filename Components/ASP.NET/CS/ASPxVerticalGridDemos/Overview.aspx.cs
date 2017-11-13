using DevExpress.Web.Demos;
using System;

public partial class Overview : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
            VerticalGrid.Settings.HeaderAreaWidth = Utils.IsLargeTheme ? 220 : 150;
            VerticalGrid.Settings.RecordWidth = Utils.IsLargeTheme ? 200 : 170;
    }
}
