using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.Demos;

public partial class FormLayout_ResponsiveLayoutPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {
    
    }
    protected override void FrameworkInitialize() {
        base.FrameworkInitialize();
        DevExpress.Web.ASPxWebControl.GlobalTheme = "Moderno";
        Utils.ResetThemeParameters();
    }
}
