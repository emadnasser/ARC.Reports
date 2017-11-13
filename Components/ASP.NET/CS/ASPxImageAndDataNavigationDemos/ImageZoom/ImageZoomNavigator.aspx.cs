using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ImageZoom_ImageZoomNavigator : Page {
    protected void Page_Load(object sender, EventArgs e) {
        zoomNavigator.ActiveItemChangeAction = (ActiveItemChangeAction)ddlActiveItemChangeAction.Value;
        zoomNavigator.NavigationButtonVisibility = (NavigationButtonVisibilityMode)ddlNavigationButtonVisibilityMode.Value;
    }
}
