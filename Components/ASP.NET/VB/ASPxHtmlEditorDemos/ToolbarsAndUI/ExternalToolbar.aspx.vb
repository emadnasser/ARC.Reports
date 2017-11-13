Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Collections.Generic
Imports System.Threading

Partial Public Class Features_ExternalToolbar
	Inherits Page
	Private Const SelectedDocumentIndex As Integer = 1
	Private Const SessionKey As String = "DocumentsDictionary"
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			For Each key As String In DocumentsDictionary.Keys
				ListBox.Items.Add(key)
			Next key
			ListBox.SelectedIndex = SelectedDocumentIndex
			HtmlEditor.Html = DocumentsDictionary(ListBox.SelectedItem.Text)
		ElseIf IsCallback Then
			' Intentionally pauses server-side processing,
			' to demonstrate the Loading Panel functionality.
			Thread.Sleep(500)
		End If
	End Sub
	Protected Sub HtmlEditor_CustomDataCallback(ByVal sender As Object, ByVal e As DevExpress.Web.CustomDataCallbackEventArgs)
		If e.Parameter = "SaveChanges" Then
			DocumentsDictionary(ListBox.SelectedItem.Text) = HtmlEditor.Html
		ElseIf e.Parameter = "CancelChanges" Then
			e.Result = DocumentsDictionary(ListBox.SelectedItem.Text)
		End If
	End Sub
	Public ReadOnly Property DocumentsDictionary() As Dictionary(Of String, String)
		Get
			If Page.Session(SessionKey) Is Nothing Then
				Page.Session(SessionKey) = CreateDocumentsDictionary()
			End If
			Return CType(Page.Session(SessionKey), Dictionary(Of String, String))
		End Get
	End Property
	Private Function CreateDocumentsDictionary() As Dictionary(Of String, String)
		Dim dictionary As New Dictionary(Of String, String)()
		dictionary.Add("Halloween", HtmlEditorUtils.GetHtml(Me, "ToolbarItems/ComboBox.html"))
		dictionary.Add("Blueberry", HtmlEditorUtils.GetHtml(Me, "Overview/Blueberry.html", False))
		dictionary.Add("Fragaria", HtmlEditorUtils.GetHtml(Me, "Features/General.html"))
		dictionary.Add("Mushroom", HtmlEditorUtils.GetHtml(Me, "Features/CustomToolbar.html"))
		Return dictionary
	End Function
End Class
