using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Web.Data;

public partial class Editing_EditFormTemplate : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            NewsGroupDataProvider.Restore();
            treeList.DataBind();
            treeList.ExpandToLevel(3);
            treeList.StartEdit("1");
        }
        treeList.SettingsEditing.Mode = chkPopEditForm.Checked ? TreeListEditMode.PopupEditForm : TreeListEditMode.EditFormAndDisplayNode;
    }
    protected void treeList_NodeUpdating(object sender, ASPxDataUpdatingEventArgs e) {
        e.NewValues["Text"] = ExtractMemoValue();
    }
    protected void treeList_NodeInserting(object sender, ASPxDataInsertingEventArgs e) {
        e.NewValues["Text"] = ExtractMemoValue();
    }
    string ExtractMemoValue() {
        ASPxPageControl pageControl = treeList.FindEditFormTemplateControl("tabs") as ASPxPageControl;
        ASPxMemo memo = pageControl.TabPages[1].FindControl("message") as ASPxMemo;
        return memo.Text;
    }
}
