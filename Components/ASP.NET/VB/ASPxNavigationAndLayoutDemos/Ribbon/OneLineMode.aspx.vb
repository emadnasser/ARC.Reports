Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Ribbon_OneLineMode
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			ASPxRibbon.OneLineMode = cbOneLineMode.Checked
		Else
			cbOneLineMode.Checked = ASPxRibbon.OneLineMode
		End If
	End Sub
End Class
