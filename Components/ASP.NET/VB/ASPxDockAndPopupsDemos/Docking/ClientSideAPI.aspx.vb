Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Web.UI.WebControls

Partial Public Class Docking_ClientSideAPI
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		For Each panel As ASPxDockPanel In dockManager.Panels
			panel.Height = 100
			panel.Width = 250
			panel.Styles.Content.HorizontalAlign = HorizontalAlign.Center
			panel.ShowFooter = True
		Next panel

		For Each zone As ASPxDockZone In dockManager.Zones
			zone.PanelSpacing = 11
			zone.Width = 250
			zone.Height = 385
		Next zone
	End Sub
End Class
