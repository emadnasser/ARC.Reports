Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ClientSideAPI_ClientSideCommands
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "ClientSideAPI/ClientSideCommands.html")
		End If
	End Sub

End Class
