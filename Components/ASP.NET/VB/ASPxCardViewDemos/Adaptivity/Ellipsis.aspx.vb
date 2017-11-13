Imports Microsoft.VisualBasic
Imports System

Partial Public Class Ellipsis
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		CardView.SettingsBehavior.AllowEllipsisInText = EnableEllipsisCheckBox.Checked
	End Sub
End Class
