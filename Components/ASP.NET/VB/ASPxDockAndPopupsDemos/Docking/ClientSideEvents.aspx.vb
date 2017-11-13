Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Docking_ClientSideEvents
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	   For Each panel As ASPxDockPanel In DockManager.Panels
		   panel.Height = 200
		   panel.Styles.Content.Paddings.PaddingTop = 13
		   panel.Styles.Content.Paddings.PaddingBottom = 0
		   panel.Styles.Content.Paddings.PaddingLeft = 13
		   panel.Styles.Content.Paddings.PaddingRight = 13
	   Next panel
	End Sub
End Class
