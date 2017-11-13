using System;
using System.Web.UI;

public partial class ImageSlider_NavigationBarMode : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ImageSlider.SettingsNavigationBar.VisibleItemsCount = Convert.ToInt32(ddlItemCount.Value);
    }
}
