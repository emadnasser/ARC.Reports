Imports Microsoft.VisualBasic
Imports System

Partial Public Class Records_Selection
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			VerticalGrid.DataBind()
			VerticalGrid.Selection.SelectRecord(1)
			VerticalGrid.Selection.SelectRecord(5)
		End If
	End Sub
End Class
