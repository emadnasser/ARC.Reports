using System;
using DevExpress.Web;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class PopupControl_ClientSideAPI : Page {

    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/PopupControl/CSS/ClientSideAPI.css");
        foreach(PopupWindow window in pcHint.Windows)
            window.ShowOnPageLoad = false;
        pcError.ShowOnPageLoad = false;
    }

}
