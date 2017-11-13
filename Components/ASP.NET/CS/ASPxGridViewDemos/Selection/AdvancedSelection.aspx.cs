using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Selection_AdvancedSelection : Page {
    GridViewCommandColumn ComandColumn { get { return (GridViewCommandColumn)grid.Columns[0]; } }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            selectAllMode.DataSource = Enum.GetValues(typeof(GridViewSelectAllCheckBoxMode));
            selectAllMode.DataBind();
            selectAllMode.SelectedIndex = 1;
        }
    }
    protected void GridView_CustomJSProperties(object sender, ASPxGridViewClientJSPropertiesEventArgs e) {
        e.Properties["cpVisibleRowCount"] = grid.VisibleRowCount;
        e.Properties["cpFilteredRowCountWithoutPage"] = GetFilteredRowCountWithoutPage();
    }
    protected void SelectAllMode_SelectedIndexChanged(object sender, EventArgs e) {
        grid.Selection.UnselectAll();
        ComandColumn.SelectAllCheckboxMode = (GridViewSelectAllCheckBoxMode)Enum.Parse(typeof(GridViewSelectAllCheckBoxMode), selectAllMode.Text);
    }
    protected void lnkSelectAllRows_Load(object sender, EventArgs e) {
        ((ASPxHyperLink)sender).Visible = ComandColumn.SelectAllCheckboxMode != GridViewSelectAllCheckBoxMode.AllPages;
    }
    protected void lnkClearSelection_Load(object sender, EventArgs e) {
        ((ASPxHyperLink)sender).Visible = ComandColumn.SelectAllCheckboxMode != GridViewSelectAllCheckBoxMode.AllPages;
    }

    protected int GetFilteredRowCountWithoutPage() {
        int selectedRowsOnPage = 0;
        foreach(var key in grid.GetCurrentPageRowValues("CustomerID")) {
            if(grid.Selection.IsRowSelectedByKey(key))
                selectedRowsOnPage++;
        }
        return grid.Selection.FilteredCount - selectedRowsOnPage;
    }
}
