Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Panel_AdaptiveLayoutPage
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Overrides Sub FrameworkInitialize()
		MyBase.FrameworkInitialize()
		DevExpress.Web.ASPxWebControl.GlobalTheme = "Moderno"
		DevExpress.Web.Demos.Utils.ResetThemeParameters()
	End Sub
End Class
