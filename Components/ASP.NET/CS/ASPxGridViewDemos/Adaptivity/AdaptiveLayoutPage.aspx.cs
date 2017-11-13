using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class Panel_AdaptiveLayoutPage : Page {
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected override void FrameworkInitialize() {
        base.FrameworkInitialize();
        ASPxWebControl.GlobalTheme = "Moderno";
        Utils.ResetThemeParameters();
    }
}
