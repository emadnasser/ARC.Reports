using System;
using System.Linq;
using DevExpress.Web;

public partial class UserControls_ViewControls_TasksGridView : ViewUserControl {
    protected void Page_Load(object sender, EventArgs e) {
        BindGrid();
    }

    public override long SelectedItemID {
        get {
            var taskID = TaskGrid.GetRowValues(TaskGrid.FocusedRowIndex, TaskGrid.KeyFieldName);
            return taskID != null ? (long)taskID : DataProvider.emptyEntryID;
        }
        set {
            BindGrid();
            TaskGrid.FocusedRowIndex = TaskGrid.FindVisibleIndexByKeyValue(value);
        }
    }

    protected void BindGrid() {
        TaskGrid.DataSource = DataProvider.EmployeeTasks.ToList();
        TaskGrid.FilterExpression = OwnerPage.FilterBag.GetExpression(false);
        TaskGrid.SearchPanelFilter = OwnerPage.FilterBag.SearchText;
        TaskGrid.DataBind();
    }

    protected string GetDescription(GridViewPreviewRowTemplateContainer container) {
        return OwnerPage.HighlightSearchText(container.Text).Replace("&", "&amp;");
    }

    public override void Update() {
        BindGrid();
    }
}
