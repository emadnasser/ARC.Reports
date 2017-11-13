Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ImageZoom_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		zoom.ShowHint = chShowHint.Checked
		zoom.EnableExpandMode = chEnableExpandMode.Checked
		zoom.SettingsZoomMode.ZoomWindowPosition = CType(ddlZoomWindowPosition.Value, ZoomWindowPosition)
		zoom.SettingsZoomMode.MouseBoxOpacityMode = CType(ddlMouseBoxOpacityMode.Value, MouseBoxOpacityMode)
		zoom.LargeImageLoadMode = CType(ddlLargeImageLoadMode.Value, LargeImageLoadMode)
	End Sub
End Class
