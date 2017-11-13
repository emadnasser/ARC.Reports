using System;
using System.Web.UI;
using DevExpress.Web.Data;
using DevExpress.Web;

public partial class GridEditing_EditFormTemplate : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            grid.StartEdit(2);
        }
        grid.SettingsEditing.Mode = chkPopup.Checked 
            ? GridViewEditingMode.PopupEditForm 
            : GridViewEditingMode.EditFormAndDisplayRow;
    }

    protected void grid_RowUpdating(object sender, ASPxDataUpdatingEventArgs e) {
        e.NewValues["Notes"] = GetMemoText();
    }
    protected void grid_RowInserting(object sender, ASPxDataInsertingEventArgs e) {
        e.NewValues["Notes"] = GetMemoText();
    }
    protected string GetMemoText() {
        ASPxPageControl pageControl = grid.FindEditFormTemplateControl("pageControl") as ASPxPageControl;
        ASPxMemo memo = pageControl.FindControl("notesEditor") as ASPxMemo;
        return memo.Text;
    }
}
