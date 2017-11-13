Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class RoundPanel_LoadOnDemand
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		' Intentionally pauses server-side processing, 
		' to demonstrate the Loading Panel functionality.
		If ASPxRoundPanel1.IsCallback Then
			System.Threading.Thread.Sleep(2000)
		End If
	End Sub
End Class
