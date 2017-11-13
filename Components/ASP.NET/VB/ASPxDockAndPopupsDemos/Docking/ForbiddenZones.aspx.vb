Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports System.Drawing

Partial Public Class Docking_ForbiddenZones
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		For Each panel As ASPxDockPanel In ASPxDockManager.Panels
			panel.ShowCloseButton = False
			panel.Height = 230
			panel.Width = 240
			panel.Styles.Content.HorizontalAlign = HorizontalAlign.Center
			panel.Styles.Content.Paddings.PaddingLeft = 31
			panel.Styles.Content.Paddings.PaddingRight = 31
			panel.Styles.Content.Paddings.PaddingTop = 24
		Next panel

		For Each zone As ASPxDockZone In ASPxDockManager.Zones
			zone.BackColor = ColorTranslator.FromHtml("#F4F4F4")
			zone.Border.BorderColor = ColorTranslator.FromHtml("#D9D9D9")
			zone.Border.BorderStyle = BorderStyle.Solid
			zone.Border.BorderWidth = 1
			zone.Paddings.Padding = 3
		Next zone
	End Sub
End Class
