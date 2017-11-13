Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Threading

Partial Public Class PopupControl_LoadOnDemand
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If PopupControl.IsCallback Then
			' Intentionally pauses server-side processing, 
			' to demonstrate the Loading Panel functionality.
			Thread.Sleep(1000)
		End If
	End Sub
End Class
