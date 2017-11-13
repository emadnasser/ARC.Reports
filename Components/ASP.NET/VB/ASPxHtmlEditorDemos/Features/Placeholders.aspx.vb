Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.Internal
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports DevExpress.Web
Imports DevExpress.Web.ASPxHtmlEditor
Imports System.Linq

Partial Public Class Features_Placeholders
	Inherits Page
	Private Const SelectedIndex As Integer = 1
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditor.Html = HtmlEditorUtils.GetHtml(Me, "Features/TemplateHtml.html")
			HtmlEditor.Settings.AllowPreview = False
			InitListBox(ListBox)
		End If
	End Sub
	Protected Sub RoundPanel_ContentCallback(ByVal source As Object, ByVal e As RoundPanelContentCallbackEventArgs)
		Dim context = New NorthwindContext()
		Dim employee As Employee = context.Employees.First(Function(s) s.FirstName = e.Parameter)
		Dim html = ASPxHtmlEditor.ReplacePlaceholders(HtmlEditor.Html, employee)
		RoundPanel.Controls.Add(New LiteralControl(html))
	End Sub

	Private Sub InitListBox(ByVal ListBox As ASPxListBox)
		Dim context = New NorthwindContext()
		For Each employee As Employee In context.Employees
			ListBox.Items.Add(String.Format("{0}: {1}", employee.FirstName, employee.HomePhone), employee.FirstName)
		Next employee
		ListBox.ClientEnabled = False
		ListBox.SelectedIndex = SelectedIndex
	End Sub
End Class
