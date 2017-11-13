using System;
using DevExpress.Web.ASPxTreeList;
using System.Web.UI;

public partial class Editing_Modes : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            Array values = Enum.GetValues(typeof(TreeListEditMode));
            foreach(object value in values)
                cmbMode.Items.Add(Enum.GetName(typeof(TreeListEditMode), value), (int)value);
            cmbMode.Value = treeList.SettingsEditing.Mode.ToString();
            NewsGroupDataProvider.Restore();
            treeList.DataBind();
            treeList.ExpandToLevel(3);
            treeList.StartEdit("2");
        }
        treeList.SettingsEditing.AllowNodeDragDrop = chkDragging.Checked;
    }
    protected void cmbMode_SelectedIndexChanged(object sender, EventArgs e) {
        treeList.SettingsEditing.Mode = (TreeListEditMode)cmbMode.SelectedItem.Value;
    }
}
