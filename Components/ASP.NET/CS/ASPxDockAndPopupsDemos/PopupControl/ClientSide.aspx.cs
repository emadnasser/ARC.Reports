using System;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class PopupControl_ClientSide : Page {

    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/PopupControl/CSS/ClientSide.css");
    }

}
