Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class UserControls_TabTemplate
	Inherits System.Web.UI.UserControl
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (TryCast(Parent, TabControlTemplateContainer)) IsNot Nothing Then
			lblTabText.Text = (TryCast(Parent, TabControlTemplateContainer)).Tab.Text
		Else
			lblTabText.Text = (TryCast(Parent, PageControlTemplateContainer)).TabPage.Text
		End If
	End Sub
End Class
