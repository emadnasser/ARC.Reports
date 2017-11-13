Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class PopupControl_ModalWindow
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/PopupControl/CSS/ModalWindow.css")
	End Sub
End Class
