using System;
using System.Web.UI;

public partial class Data_Linear : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            DataBind();
            treeList.ExpandToLevel(2);
        }

        bool show = chkServiceColumns.Checked;
        treeList.Columns["ID"].Visible = show;
        treeList.Columns["ParentID"].Visible = show;
    }
}
