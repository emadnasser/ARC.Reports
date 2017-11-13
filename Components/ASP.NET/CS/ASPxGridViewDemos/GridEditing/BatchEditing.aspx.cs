using System;
using DevExpress.Web;

public partial class GridEditing_BatchEditing : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        Grid.SettingsEditing.BatchEditSettings.EditMode = (GridViewBatchEditMode)Enum.Parse(typeof(GridViewBatchEditMode), EditModeCombo.Text, true);
        Grid.SettingsEditing.BatchEditSettings.StartEditAction = (GridViewBatchStartEditAction)Enum.Parse(typeof(GridViewBatchStartEditAction), StartEditActionCombo.Text, true);
        Grid.SettingsEditing.BatchEditSettings.HighlightDeletedRows = cbHighlightDeletedRows.Checked;
    }
}
