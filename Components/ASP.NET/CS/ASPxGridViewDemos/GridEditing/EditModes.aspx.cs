using System;
using DevExpress.Web;
using System.Web.UI;

public partial class GridEditing_EditModes : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            string[] names = Enum.GetNames(typeof(GridViewEditingMode));
            foreach(string name in names) {
                ddlEditMode.Items.Add(name);
            }
            ddlEditMode.Text = grid.SettingsEditing.Mode.ToString();
            grid.StartEdit(1);
        }
    }
    protected void ddlEditMode_SelectedIndexChanged(object sender, EventArgs e) {
        GridViewEditingMode mode = (GridViewEditingMode)Enum.Parse(typeof(GridViewEditingMode), ddlEditMode.Text);
        grid.SettingsEditing.Mode = mode;
        var commandColumn = grid.Columns[0] as GridViewCommandColumn;
        commandColumn.Visible = !object.Equals(mode, GridViewEditingMode.Batch);
    }
    protected void grid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        int index = -1;
        if(int.TryParse(e.Parameters, out index))
            grid.SettingsEditing.Mode = (GridViewEditingMode)index;
    }
}
