Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Web

Partial Public Class ASPxTokenBox_TokenBoxColumn
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.StartEdit(2)
		End If
	End Sub
End Class
