using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Accessibility_ComplianceEditing : Page {
    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void rblEditMode_SelectedIndexChanged(object sender, EventArgs e) {
        grid.SettingsEditing.Mode = (GridViewEditingMode)Enum.Parse(typeof(GridViewEditingMode), rblEditMode.SelectedItem.Text);
    }

    protected override void OnPreRender(EventArgs e) {
        base.OnPreRender(e);
        var commandColumn = grid.Columns[0] as GridViewCommandColumn;
        commandColumn.Visible = !object.Equals(grid.SettingsEditing.Mode, GridViewEditingMode.Batch);
        grid.StartEdit(1);
    }
}
