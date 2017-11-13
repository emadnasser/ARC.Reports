Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class Overview
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			RichEditDemoUtils.HideFileTab(DemoRichEdit)
			DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "Overview.rtf"))
		End If
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub
End Class
