using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ImageSlider_SlideShow : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack) {
            ASPxImageSlider1.SettingsSlideShow.Interval = (int)ddlInterval.SelectedItem.Value;
            ASPxImageSlider1.SettingsSlideShow.AutoPlay = chAutoPlay.Checked;
            ASPxImageSlider1.SettingsSlideShow.PausePlayingWhenMouseOver = chPausePlayingWhenMouseOver.Checked;
            //ASPxImageSlider1.SettingsSlideShow.PlayPauseButtonVisibility = (ElementVisibilityMode)((int)ddlPlayPauseButtonVisibility.SelectedItem.Value);
            ASPxImageSlider1.SettingsSlideShow.PlayPauseButtonVisibility = (ElementVisibilityMode)ddlPlayPauseButtonVisibility.Value;
            ASPxImageSlider1.SettingsSlideShow.StopPlayingWhenPaging = chStopPlayingWhenPaging.Checked;
        }
    }
}
