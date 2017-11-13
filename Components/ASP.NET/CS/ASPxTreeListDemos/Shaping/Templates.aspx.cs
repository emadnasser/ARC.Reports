using System;
using System.Web.UI;
using DevExpress.Web.ASPxTreeList;

public partial class Shaping_Templates : Page {
    protected void treList_CustomDataCallback(object sender, TreeListCustomDataCallbackEventArgs e) {
        TreeListNode node = treeList.FindNodeByFieldValue("ID", Int32.Parse(e.Argument));
        if(node != null)
            e.Result = node["Notes"].ToString();
    }
}
