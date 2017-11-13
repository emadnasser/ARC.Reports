Imports Microsoft.VisualBasic
Imports System

Partial Public Class Filtering_SearchPanel
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			CardView.SearchPanelFilter = "an"
		End If
	End Sub
End Class
