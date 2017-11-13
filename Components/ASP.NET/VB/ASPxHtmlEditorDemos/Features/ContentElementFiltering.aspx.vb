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

Partial Public Class Features_ContentElementFiltering
	Inherits Page
	Private Shared Tags As New List(Of String)(New String() { "div", "p", "h1", "h2", "h3", "h4", "h5", "h6", "span", "font", "br", "ol", "ul", "li", "table", "tbody", "thead", "td", "tr", "th", "img", "address", "a", "b", "strong", "i", "em" })
	Private Shared Attributes As New List(Of String)(New String() { "align", "class", "cellspacing", "cellpadding", "colspan", "id", "scope", "style", "src", "href", "rowspan", "title", "width", "height" })
	Private Shared StyleAttributes As New List(Of String)(New String() { "font-size", "font-family", "border", "padding", "margin-top", "vertical-align", "text-align", "width", "height", "color", "background-color", "box-shadow", "line-height" })

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			InitTokenBox(TagTokenBox, Tags)
			InitTokenBox(AttributeTokenBox, Attributes)
			InitTokenBox(StyleAttributeTokenBox, StyleAttributes)
			HtmlEditor.Html = GetDocumentHtml()
		End If
		HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.Tags = TagTokenBox.Tokens.ToArray()
		HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.TagFilterMode = CType(CInt(Fix(TagFilterModeComboBox.Value)), HtmlEditorFilterMode)
		HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.Attributes = AttributeTokenBox.Tokens.ToArray()
		HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.AttributeFilterMode = CType(CInt(Fix(AttributeFilterModeComboBox.Value)), HtmlEditorFilterMode)
		HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.StyleAttributes = StyleAttributeTokenBox.Tokens.ToArray()
		HtmlEditor.SettingsHtmlEditing.ContentElementFiltering.StyleAttributeFilterMode = CType(CInt(Fix(StyleAttributeFilterModeComboBox.Value)), HtmlEditorFilterMode)
	End Sub
	Private Sub InitTokenBox(ByVal tokenBox As ASPxTokenBox, ByVal itemCollection As List(Of String))
		itemCollection.Sort()
		tokenBox.Items.AddRange(itemCollection)
		tokenBox.AllowCustomTokens = False
		tokenBox.AllowMouseWheel = True
	End Sub
	Private Function GetDocumentHtml() As String
		Return HtmlEditorUtils.GetHtml(Me, "Overview/Blueberry.html", False)
	End Function
	Protected Sub HtmlEditor_CustomDataCallback(ByVal sender As Object, ByVal e As DevExpress.Web.CustomDataCallbackEventArgs)
		e.Result = GetDocumentHtml()
	End Sub
End Class
