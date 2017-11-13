using System;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class PopupControl_ModalWindow : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/PopupControl/CSS/ModalWindow.css");
    }
}
