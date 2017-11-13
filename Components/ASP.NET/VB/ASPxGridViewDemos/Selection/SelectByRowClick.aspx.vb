Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Selection_SelectByRowClick
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.DataBind()
			For i As Integer = 0 To 5
				grid.Selection.SelectRow(i)
			Next i
		End If
	End Sub

End Class
