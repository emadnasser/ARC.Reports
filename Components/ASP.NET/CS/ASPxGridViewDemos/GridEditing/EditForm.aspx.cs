using System;
using DevExpress.Web;
using System.Web.UI;

public partial class GridEditing_EditForm : Page {
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
    }
    protected void chkNewRowLocation_CheckedChanged(object sender, EventArgs e) {
        grid.SettingsEditing.NewItemRowPosition = chkNewRowLocation.Checked ? GridViewNewItemRowPosition.Bottom : GridViewNewItemRowPosition.Top;
    }
}
