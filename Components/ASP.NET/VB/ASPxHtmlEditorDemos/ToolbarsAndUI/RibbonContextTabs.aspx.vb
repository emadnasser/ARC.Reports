Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Utils
Imports DevExpress.Web.Internal
Imports DevExpress.Web

Partial Public Class Features_RibbonContextTabs
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/RibbonContextTabs.html")
		End If
	End Sub
End Class
