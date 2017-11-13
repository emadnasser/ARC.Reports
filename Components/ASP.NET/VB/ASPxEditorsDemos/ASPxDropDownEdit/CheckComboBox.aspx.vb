Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ASPxDropDownEdit_CheckComboBox
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxDropDownEdit1.Text = "Chrome;Safari"
		End If
	End Sub
End Class
