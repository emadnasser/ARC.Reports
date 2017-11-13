Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class GridEditing_TwoWayBinding
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.StartEdit(2)
		End If
	End Sub
End Class
