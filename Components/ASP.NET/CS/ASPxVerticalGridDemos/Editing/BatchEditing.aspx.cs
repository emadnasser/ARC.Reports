using System;
using System.Linq;
using DevExpress.Web;
using DevExpress.Web.Demos;


public partial class Editing_BatchEditing : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        VerticalGrid.Settings.HeaderAreaWidth = Utils.IsLargeTheme ? 170 : 150;
        VerticalGrid.SettingsEditing.BatchEditSettings.StartEditAction = (GridViewBatchStartEditAction)Enum.Parse(typeof(GridViewBatchStartEditAction), StartEditActionCombo.Text, true);
        VerticalGrid.SettingsEditing.BatchEditSettings.HighlightDeletedRecords = cbHighlightDeletedItems.Checked;
    }
}
