using System;
using DevExpress.Web.ASPxTreeList;
using System.Web.UI;

public partial class Presentation_FocusedNode : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            treeList.DataBind();
            TreeListNode firstUnread = treeList.FindNodeByFieldValue("IsNew", true);
            firstUnread.Focus();
            treeList.ExpandToLevel(2);
            messageLiteral.Text = GetEntryText(firstUnread);
        }
    }

    protected void treeList_CustomDataCallback(object sender, TreeListCustomDataCallbackEventArgs e) {
        string key = e.Argument.ToString();
        TreeListNode node = treeList.FindNodeByKeyValue(key);
        e.Result = GetEntryText(node);
    }

    protected string GetEntryText(TreeListNode node) {
        if(node != null) {
            string text = node["Text"].ToString();
            return text.Trim().Replace("\r\n", "<br />");
        }
        return string.Empty;
    }

    protected void treeList_HtmlDataCellPrepared(object sender, TreeListHtmlDataCellEventArgs e) {
        if(Object.Equals(e.GetValue("IsNew"), true))
            e.Cell.Font.Bold = true;
    }
}
