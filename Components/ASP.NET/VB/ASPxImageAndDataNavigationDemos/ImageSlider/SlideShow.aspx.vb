Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ImageSlider_SlideShow
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			ASPxImageSlider1.SettingsSlideShow.Interval = CInt(Fix(ddlInterval.SelectedItem.Value))
			ASPxImageSlider1.SettingsSlideShow.AutoPlay = chAutoPlay.Checked
			ASPxImageSlider1.SettingsSlideShow.PausePlayingWhenMouseOver = chPausePlayingWhenMouseOver.Checked
			'ASPxImageSlider1.SettingsSlideShow.PlayPauseButtonVisibility = (ElementVisibilityMode)((int)ddlPlayPauseButtonVisibility.SelectedItem.Value);
			ASPxImageSlider1.SettingsSlideShow.PlayPauseButtonVisibility = CType(ddlPlayPauseButtonVisibility.Value, ElementVisibilityMode)
			ASPxImageSlider1.SettingsSlideShow.StopPlayingWhenPaging = chStopPlayingWhenPaging.Checked
		End If
	End Sub
End Class
