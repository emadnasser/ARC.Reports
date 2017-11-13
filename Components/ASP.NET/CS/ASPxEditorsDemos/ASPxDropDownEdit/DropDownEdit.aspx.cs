using System.Collections;
using System.Web.UI;
using DevExpress.Web.ASPxTreeList;

public partial class ASPxDropDownEdit_DropDownEdit: Page {
    protected void TreeList_CustomJSProperties(object sender, TreeListCustomJSPropertiesEventArgs e) {
        ASPxTreeList treeList = sender as ASPxTreeList;
        Hashtable nameTable = new Hashtable();
        foreach(TreeListNode node in treeList.GetVisibleNodes())
            nameTable.Add(node.Key, string.Format("{0} {1}", node["FirstName"], node["LastName"]));
        e.Properties["cpEmployeeNames"] = nameTable;
    }
}
