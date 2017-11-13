Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class ClientSideAPI_ClientSideSelection
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "ClientSideAPI/ClientSideSelection.html")

			Dim changeCaseItem As HtmlEditorToolbarItem = DemoHtmlEditor.Toolbars(0).Items.FindByCommandName("ChangeCase")
			changeCaseItem.Image.Url = If(HtmlEditorUtils.IsDarkTheme(Theme), "../Content/Demo/Toolbar/case-dark.png", "../Content/Demo/Toolbar/case.png")
		End If
	End Sub

End Class
