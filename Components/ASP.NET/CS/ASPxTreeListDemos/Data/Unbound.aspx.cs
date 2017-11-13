using System;
using System.Web.UI;
using DevExpress.Web.ASPxTreeList;

public partial class Data_Unbound : Page {	
	protected void Page_Load(object sender, EventArgs e) {
		CreateNodes();		
	}

	void CreateNodes() {
		TreeListNode localFolders = CreateNodeCore(1, "Folder", "<b>Local Folders</b>", null);
		localFolders.Expanded = true;
		CreateNodeCore(2, "Inbox", "Inbox", localFolders);
		CreateNodeCore(3, "Outbox", "Outbox", localFolders);
		CreateNodeCore(4, "SentItems", "Sent Items", localFolders);
		CreateNodeCore(5, "DeletedItems", "Deleted Items", localFolders);
		CreateNodeCore(6, "Drafts", "Drafts", localFolders);
		TreeListNode communityNode = CreateNodeCore(7, "Folder", "<b>community.devexpress.com</b>", null);
		CreateNodeCore(8, "Folder", "general.announcements", communityNode);
		CreateNodeCore(9, "Folder", "general.discussion", communityNode);
		CreateNodeCore(10, "Folder", "general.ordering", communityNode);
	}

	TreeListNode CreateNodeCore(object key, string iconName, string text, TreeListNode parentNode) {
		TreeListNode node = treeList.AppendNode(key, parentNode);
		node["IconName"] = iconName;
		node["Name"] = text;
		return node;
	}
	protected string GetIconUrl(TreeListDataCellTemplateContainer container) {
		return string.Format("~/Data/Images/{0}.png", container.GetValue("IconName"));
	}
}
