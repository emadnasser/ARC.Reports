Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class DataViewControl_Example
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/DataView/CSS/DataBinding.css")
		If IsCallback Then
			' Intentionally pauses server-side processing, 
			' to demonstrate the Loading Panel functionality.
			System.Threading.Thread.Sleep(500)
		End If
	End Sub
End Class
