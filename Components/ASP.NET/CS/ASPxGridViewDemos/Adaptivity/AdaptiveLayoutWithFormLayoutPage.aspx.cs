using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class Panel_AdaptiveLayoutPage : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            ((GridViewDataColumn)ASPxGridView1.Columns["CategoryID"]).GroupBy();
            ASPxGridView1.ExpandRow(0);
        }
    }
    protected override void FrameworkInitialize() {
        base.FrameworkInitialize();
        DevExpress.Web.ASPxWebControl.GlobalTheme = "Moderno";
        Utils.ResetThemeParameters();
    }
}
