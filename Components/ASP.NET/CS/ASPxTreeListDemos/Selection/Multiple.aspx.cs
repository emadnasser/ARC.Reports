using System;
using DevExpress.Web.ASPxTreeList;
using System.Web.UI;

public partial class Selection_Multiple : Page {
	protected void Page_Load(object sender, EventArgs e) {
		if(!IsPostBack) {
			treeList.DataBind();
			treeList.ExpandToLevel(2);
		}
        if(treeList.SettingsSelection.Recursive != chkRecursive.Checked) {
            treeList.SettingsSelection.Recursive = chkRecursive.Checked;
            treeList.UnselectAll();
        }
		treeList.SettingsSelection.Recursive = chkRecursive.Checked;
		treeList.SettingsSelection.AllowSelectAll = chkAllowAll.Checked;
		countLiteral.Text = treeList.SelectionCount.ToString();
	}

	protected void treeList_CustomDataCallback(object sender, DevExpress.Web.ASPxTreeList.TreeListCustomDataCallbackEventArgs e) {
		e.Result = treeList.SelectionCount.ToString();
	}
	protected void cmbMode_SelectedIndexChanged(object sender, EventArgs e) {		
		if(cmbMode.SelectedIndex > 0)			
			treeList.UnselectAll();
		SetNodeSelectionSettings();
	}
	protected void treeList_DataBound(object sender, EventArgs e) {
		SetNodeSelectionSettings();
	}

	void SetNodeSelectionSettings() {
		TreeListNodeIterator iterator = treeList.CreateNodeIterator();
		TreeListNode node;
		while(true) {
			node = iterator.GetNext();
			if(node == null) break;
			switch(cmbMode.SelectedIndex) {
				case 1:
					node.AllowSelect = !node.HasChildren;
					break;
				case 2:
					node.AllowSelect = node.HasChildren;
					break;
				case 3:
					node.AllowSelect = node.Level > 2;
					break;
			}
		}
	}
}
