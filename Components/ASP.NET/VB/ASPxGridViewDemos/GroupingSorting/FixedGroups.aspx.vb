Imports Microsoft.VisualBasic
Imports System

Partial Public Class GroupingSorting_FixedGroups
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Grid.ExpandAll()
		End If
	End Sub
End Class
