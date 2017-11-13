Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Threading

Partial Public Class TabControl_EnableCallBacks
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		' Intentionally pauses server-side processing, 
		' to demonstrate the Loading Panel functionality.
		If IsCallback Then
			Thread.Sleep(1000)
		End If
	End Sub
End Class
