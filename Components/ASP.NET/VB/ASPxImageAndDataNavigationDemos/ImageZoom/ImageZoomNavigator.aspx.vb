Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ImageZoom_ImageZoomNavigator
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		zoomNavigator.ActiveItemChangeAction = CType(ddlActiveItemChangeAction.Value, ActiveItemChangeAction)
		zoomNavigator.NavigationButtonVisibility = CType(ddlNavigationButtonVisibilityMode.Value, NavigationButtonVisibilityMode)
	End Sub
End Class
