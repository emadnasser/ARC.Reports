using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_ViewControls_TasksCardView : ViewUserControl {

    protected void Page_Load(object sender, EventArgs e) {
        BindCardView();
    }

    protected long SelectedTaskID {
        get {
            long taskID;
            return DemoUtils.TryGetClientStateIDValue("ID", out taskID) ? taskID : DataProvider.emptyEntryID;
        }
        set { DemoUtils.TrySetClientStateValue<long>("ID", value); }
    }

    public override long SelectedItemID {
        get { return SelectedTaskID; }
        set {
            SelectedTaskID = value;
            BindCardView(true);
        }
    }

    long GetVisibleSelectedTaskID() {
        return Convert.ToInt64(TaskCardView.GetCardValues(TaskCardView.FocusedCardIndex, "Id"));
    }

    protected List<EmployeeTask> GetTasks() {
        return DataProvider.GetEmployeeTasks(Filter.GetExpression(true)).ToList();
    }

    public bool GetCheckedState(CardViewDataItemTemplateContainer container) {
        var status = (EmployeeTaskStatus)DataBinder.Eval(container.DataItem, "Status");
        return status.Equals(EmployeeTaskStatus.Completed);
    }
    protected void TaskCardView_CustomJSProperties(object sender, DevExpress.Web.CustomJSPropertiesEventArgs e) {
        e.Properties["cpSelectedItemID"] = SelectedTaskID != DataProvider.emptyEntryID ? SelectedTaskID.ToString() : string.Empty;
    }

    protected void BindCardView(bool calcPageIndex = false) {
        var tasks = GetTasks();
        TaskCardView.DataSource = tasks;
        TaskCardView.DataBind();

        SelectedTaskID = GetVisibleSelectedTaskID();
    }

    protected void EditButton_Load(object sender, EventArgs e) {
        LoadTaskID((ASPxButton)sender);
    }
    protected void ViewButton_Load(object sender, EventArgs e) {
        LoadTaskID((ASPxButton)sender);
    }
    protected void DeleteButton_Load(object sender, EventArgs e) {
        LoadTaskID((ASPxButton)sender);
    }
    protected void LoadTaskID(ASPxButton button) {
        var container = (CardViewDataItemTemplateContainer) button.NamingContainer;
        button.JSProperties["cpTaskID"] = DataBinder.Eval(container.DataItem, "Id");
    }

    protected string HighlightSearchText(CardViewDataItemTemplateContainer container, string fieldName) {
        var text = DataBinder.Eval(container.DataItem, fieldName).ToString();
        return !string.IsNullOrWhiteSpace(text) ? DemoUtils.HighlightSearchText(text, TaskCardView.SearchPanelFilter) : text;
    }

    public override void Update() {
        BindCardView();
    }

    protected void TaskCardView_PageIndexChanged(object sender, EventArgs e) {
        SelectedTaskID = GetVisibleSelectedTaskID();
    }

    protected string GetPriorityImageUrl(CardViewDataItemTemplateContainer container) {
        var priority = (EmployeeTaskPriority) DataBinder.Eval(container.DataItem, "Priority");
        return DemoUtils.ImageLoader.GetPriorityImageUrl(priority);
    }
}
