Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class PopupControl_Templates
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/PopupControl/CSS/Templates.css")
		Utils.RegisterCssLink(Me, "~/PopupControl/CSS/Colors/GrayColor.css", "lColorCSS")
	End Sub
End Class
