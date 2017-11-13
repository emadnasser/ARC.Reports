﻿Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.Demos

Partial Public Class RichEditDemoHeadersAndFooters
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			RichEditDemoUtils.HideFileTab(DemoRichEdit)
			DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "HeadersFooters.docx"))
		End If
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub
End Class