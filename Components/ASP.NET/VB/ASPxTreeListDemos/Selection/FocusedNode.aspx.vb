Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxTreeList
Imports System.Web.UI

Partial Public Class Presentation_FocusedNode
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			treeList.DataBind()
			Dim firstUnread As TreeListNode = treeList.FindNodeByFieldValue("IsNew", True)
			firstUnread.Focus()
			treeList.ExpandToLevel(2)
			messageLiteral.Text = GetEntryText(firstUnread)
		End If
	End Sub

	Protected Sub treeList_CustomDataCallback(ByVal sender As Object, ByVal e As TreeListCustomDataCallbackEventArgs)
		Dim key As String = e.Argument.ToString()
		Dim node As TreeListNode = treeList.FindNodeByKeyValue(key)
		e.Result = GetEntryText(node)
	End Sub

	Protected Function GetEntryText(ByVal node As TreeListNode) As String
		If node IsNot Nothing Then
			Dim text As String = node("Text").ToString()
			Return text.Trim().Replace(Constants.vbCrLf, "<br />")
		End If
		Return String.Empty
	End Function

	Protected Sub treeList_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As TreeListHtmlDataCellEventArgs)
		If Object.Equals(e.GetValue("IsNew"), True) Then
			e.Cell.Font.Bold = True
		End If
	End Sub
End Class
