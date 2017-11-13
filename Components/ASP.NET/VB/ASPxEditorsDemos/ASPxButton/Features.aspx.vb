Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ASPxButton_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			ASPxButton5.ClientEnabled = Not ASPxButton4.Checked
		End If
	End Sub
End Class
