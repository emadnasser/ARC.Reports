using System;
using System.Web.UI;
using DevExpress.Web;

public partial class GridEditing_PopupEditForm : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            grid.StartEdit(2);
        }
    }
    protected void chkMemoLocation_CheckedChanged(object sender, EventArgs e) {
        GridViewDataColumn column = grid.Columns["Notes"] as GridViewDataColumn;
        if(column == null) return;
        if(chkMemoLocation.Checked) {
            column.EditFormSettings.VisibleIndex = 100;
            column.EditFormSettings.ColumnSpan = 3;
            column.EditFormSettings.RowSpan = 1;
        } else {
            column.EditFormSettings.VisibleIndex = 2;
            column.EditFormSettings.RowSpan = 4;
            column.EditFormSettings.ColumnSpan = 1;
        }
        if(grid.IsEditing) {
            int prevIndex = grid.EditingRowVisibleIndex;
            grid.CancelEdit();
            grid.StartEdit(prevIndex < 0 ? 0 : prevIndex);
        }
    }
    protected void chkShowAsModal_CheckedChanged(object sender, EventArgs e) {
        grid.SettingsPopup.EditForm.Modal = chkShowAsModal.Checked;
    }
}
