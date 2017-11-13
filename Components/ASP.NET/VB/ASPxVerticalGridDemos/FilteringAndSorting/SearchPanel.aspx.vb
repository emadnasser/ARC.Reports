Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.Demos

Partial Public Class Filtering_SearchPanel
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		VerticalGrid.Settings.HeaderAreaWidth = If(Utils.IsLargeTheme, 210, 150)
		If (Not IsPostBack) Then
			VerticalGrid.SearchPanelFilter = "an"
		End If
	End Sub
End Class
