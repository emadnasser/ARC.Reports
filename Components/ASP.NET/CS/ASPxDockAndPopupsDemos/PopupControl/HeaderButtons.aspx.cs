using System;
using System.Web.UI;

public partial class PopupControl_HeaderButtons : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack){
            Popup.ShowPinButton = cbShowPinButton.Checked;
            Popup.ShowRefreshButton = cbShowRefreshButton.Checked;
            Popup.ShowCollapseButton = cbShowCollapseButton.Checked;
            Popup.ShowMaximizeButton = cbShowMaximizeButton.Checked;
            Popup.ShowCloseButton =  cbShowCloseButton.Checked;
        }
    }
}
