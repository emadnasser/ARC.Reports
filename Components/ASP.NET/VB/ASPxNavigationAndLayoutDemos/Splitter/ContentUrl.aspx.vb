Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Splitter_ContentUrl
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxSplitter1.GetPaneByName("ContentUrlPane").ContentUrl = ASPxNavBar1.SelectedItem.NavigateUrl
	End Sub
End Class
