Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ASPxGridLookup_MultiSelect
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		GridLookup.GridView.Width = GridLookup.Width
	End Sub
End Class
