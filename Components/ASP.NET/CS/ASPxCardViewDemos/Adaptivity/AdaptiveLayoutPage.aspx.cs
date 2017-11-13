using System;
using System.Web.UI;

public partial class Panel_AdaptiveLayoutPage : Page {
    protected void Page_Load(object sender, EventArgs e) { }
    protected override void FrameworkInitialize() {
        base.FrameworkInitialize();
        DevExpress.Web.ASPxWebControl.GlobalTheme = "Moderno";
        DevExpress.Web.Demos.Utils.ResetThemeParameters();
    }
}
