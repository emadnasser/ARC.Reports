Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class Panel_ResponsiveLayoutPage
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Overrides Sub FrameworkInitialize()
		MyBase.FrameworkInitialize()
		DevExpress.Web.ASPxWebControl.GlobalTheme = "Moderno"
		Utils.ResetThemeParameters()
	End Sub
End Class