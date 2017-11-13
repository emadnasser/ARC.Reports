Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxTreeList

Partial Public Class Data_Unbound
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		CreateNodes()
	End Sub

	Private Sub CreateNodes()
		Dim localFolders As TreeListNode = CreateNodeCore(1, "Folder", "<b>Local Folders</b>", Nothing)
		localFolders.Expanded = True
		CreateNodeCore(2, "Inbox", "Inbox", localFolders)
		CreateNodeCore(3, "Outbox", "Outbox", localFolders)
		CreateNodeCore(4, "SentItems", "Sent Items", localFolders)
		CreateNodeCore(5, "DeletedItems", "Deleted Items", localFolders)
		CreateNodeCore(6, "Drafts", "Drafts", localFolders)
		Dim communityNode As TreeListNode = CreateNodeCore(7, "Folder", "<b>community.devexpress.com</b>", Nothing)
		CreateNodeCore(8, "Folder", "general.announcements", communityNode)
		CreateNodeCore(9, "Folder", "general.discussion", communityNode)
		CreateNodeCore(10, "Folder", "general.ordering", communityNode)
	End Sub

	Private Function CreateNodeCore(ByVal key As Object, ByVal iconName As String, ByVal text As String, ByVal parentNode As TreeListNode) As TreeListNode
		Dim node As TreeListNode = treeList.AppendNode(key, parentNode)
		node("IconName") = iconName
		node("Name") = text
		Return node
	End Function
	Protected Function GetIconUrl(ByVal container As TreeListDataCellTemplateContainer) As String
		Return String.Format("~/Data/Images/{0}.png", container.GetValue("IconName"))
	End Function
End Class
