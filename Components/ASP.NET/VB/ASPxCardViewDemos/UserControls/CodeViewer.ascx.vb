﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.Demos

Partial Public Class UserControls_CodeViewer
	Inherits CodeViewerControl
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Protected Function EncodeScriptForAttribute(ByVal content As Object) As String
		Return HttpUtility.HtmlEncode(DevExpress.Web.Internal.HtmlConvertor.ToScript(content))
	End Function

	Protected Function GetClassName() As String
		Dim className As String = "CodeBlock"
		Dim title As String = SourceCodePage.Title

		Dim index As Integer = title.LastIndexOf("."c)
		Dim extension As String = String.Empty

		If index <> -1 Then
			extension = title.Substring(index, title.Length - index)
		End If
		If SourceCodePage.Title = "ASPX" OrElse extension = ".aspx" OrElse extension = ".ascx" Then
			className &= " ASPX"
		End If

		Return className
	End Function
End Class
