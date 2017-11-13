using System;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class Menu_TabbedMenu : Page {

    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Menu/CSS/TabbedMenu.css");
    }

}
