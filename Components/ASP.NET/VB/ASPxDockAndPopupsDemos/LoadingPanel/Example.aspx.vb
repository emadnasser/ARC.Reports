Imports Microsoft.VisualBasic
Imports System
Imports System.Threading
Imports System.Web.UI

Partial Public Class ASPxLoadingPanel_Example
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsCallback Then
			' Intentionally pauses server-side processing, 
			' to demonstrate the Loading Panel functionality.
			Thread.Sleep(500)
		End If
		LoadingPanel.ContainerElementID = If(ASPxCheckBox1.Checked, "Panel", "")
	End Sub
End Class
