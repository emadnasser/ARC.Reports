Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class Panel_AdaptiveLayoutPage
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			CType(ASPxGridView1.Columns("CategoryID"), GridViewDataColumn).GroupBy()
			ASPxGridView1.ExpandRow(0)
		End If
	End Sub
	Protected Overrides Sub FrameworkInitialize()
		MyBase.FrameworkInitialize()
		DevExpress.Web.ASPxWebControl.GlobalTheme = "Moderno"
		Utils.ResetThemeParameters()
	End Sub
End Class
