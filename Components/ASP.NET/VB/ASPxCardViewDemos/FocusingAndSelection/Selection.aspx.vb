Imports Microsoft.VisualBasic
Imports System

Partial Public Class Cards_Selection
	Inherits System.Web.UI.Page
	Protected Sub CardView_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		CardView.Selection.SelectCard(1)
		CardView.Selection.SelectCard(2)
	End Sub
End Class
