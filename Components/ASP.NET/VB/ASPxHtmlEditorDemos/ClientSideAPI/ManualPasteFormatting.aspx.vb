Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class ClientSideAPI_ManualPasteFormatting
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "ClientSideAPI/MobileApp.html")
			DemoHtmlEditor.ClientSideEvents.BeforePaste = "BeforePasteHandler"
		End If
	End Sub
End Class
