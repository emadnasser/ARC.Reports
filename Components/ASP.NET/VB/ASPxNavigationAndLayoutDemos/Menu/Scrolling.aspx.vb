Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Menu_Scrolling
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		' Store in Session for use in ScrollingPage.aspx
		Session("DXEnableScrolling") = enableScrolling.Checked
	End Sub
End Class
