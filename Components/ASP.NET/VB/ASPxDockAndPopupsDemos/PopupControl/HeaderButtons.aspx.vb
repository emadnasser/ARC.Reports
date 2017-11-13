Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class PopupControl_HeaderButtons
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			Popup.ShowPinButton = cbShowPinButton.Checked
			Popup.ShowRefreshButton = cbShowRefreshButton.Checked
			Popup.ShowCollapseButton = cbShowCollapseButton.Checked
			Popup.ShowMaximizeButton = cbShowMaximizeButton.Checked
			Popup.ShowCloseButton = cbShowCloseButton.Checked
		End If
	End Sub
End Class
