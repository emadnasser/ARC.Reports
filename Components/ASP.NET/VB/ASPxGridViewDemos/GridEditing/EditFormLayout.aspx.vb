Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Specialized
Imports DevExpress.Web
Imports DevExpress.Web.Data

Partial Public Class GridEditing_EditFormLayout
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.StartEdit(2)
		End If
	End Sub
End Class
