using DevExpress.Web;
using System;
using System.Web.UI;

public partial class Editing_BatchEditing : Page {
    protected void Page_Load(object sender, EventArgs e) {
        CardView.SettingsEditing.BatchEditSettings.EditMode = (CardViewBatchEditMode)Enum.Parse(typeof(CardViewBatchEditMode), EditModeCombo.Text, true);
        CardView.SettingsEditing.BatchEditSettings.StartEditAction = (GridViewBatchStartEditAction)Enum.Parse(typeof(GridViewBatchStartEditAction), StartEditActionCombo.Text, true);
        CardView.SettingsEditing.BatchEditSettings.HighlightDeletedCards = cbHighlightDeletedCards.Checked;
    }
}

