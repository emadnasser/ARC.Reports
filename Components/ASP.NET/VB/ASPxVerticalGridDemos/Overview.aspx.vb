Imports Microsoft.VisualBasic
Imports DevExpress.Web.Demos
Imports System

Partial Public Class Overview
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			VerticalGrid.Settings.HeaderAreaWidth = If(Utils.IsLargeTheme, 220, 150)
			VerticalGrid.Settings.RecordWidth = If(Utils.IsLargeTheme, 200, 170)
	End Sub
End Class
