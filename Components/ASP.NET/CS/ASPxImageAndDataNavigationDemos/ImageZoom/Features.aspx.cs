using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ImageZoom_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        zoom.ShowHint = chShowHint.Checked;
        zoom.EnableExpandMode = chEnableExpandMode.Checked;
        zoom.SettingsZoomMode.ZoomWindowPosition = (ZoomWindowPosition)ddlZoomWindowPosition.Value;
        zoom.SettingsZoomMode.MouseBoxOpacityMode = (MouseBoxOpacityMode)ddlMouseBoxOpacityMode.Value;
        zoom.LargeImageLoadMode = (LargeImageLoadMode)ddlLargeImageLoadMode.Value;
    }
}
