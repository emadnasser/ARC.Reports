Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class PopupControl_ClientSideAPI
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/PopupControl/CSS/ClientSideAPI.css")
		For Each window As PopupWindow In pcHint.Windows
			window.ShowOnPageLoad = False
		Next window
		pcError.ShowOnPageLoad = False
	End Sub

End Class
