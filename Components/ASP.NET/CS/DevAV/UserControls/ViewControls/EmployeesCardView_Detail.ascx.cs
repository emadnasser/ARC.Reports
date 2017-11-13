using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_ViewControls_EmployeesCardView_Detail : DetailUserControl {
    protected Employee SelectedEmployee { get { return DataProvider.Employees.FirstOrDefault(e => e.Id == SelectedItemID); } }

    public override void Update() {
        var employee = SelectedEmployee;
        if(employee == null) {
            DetailsPageControl.Visible = false;
            EmployeeNameText.InnerHtml = "";
            EmployeeDepartmentText.InnerHtml = "";
        }
        else {
            DetailsPageControl.Visible = true;
            EmployeeNameText.InnerHtml = employee.FullName;
            EmployeeDepartmentText.InnerHtml = employee.Department.ToString();
        }

        BindTaskGrid(employee);
        BindEvaluationGrid(employee);
    }

    protected void BindTaskGrid(Employee employee) {
        CVTasksGridView.DataSource = employee != null ? employee.AssignedTasks : null;
        CVTasksGridView.DataBind();
        DemoUtils.EnsureGridFocusedRowIndex(CVTasksGridView);
    }
    protected void BindEvaluationGrid(Employee employee) {
        EvaluationGridView.DataSource = employee != null ? employee.Evaluations : null;
        EvaluationGridView.DataBind();
        DemoUtils.EnsureGridFocusedRowIndex(EvaluationGridView);
    }

    protected string GetPriorityImageUrl(GridViewDataItemTemplateContainer container) {
        var priority = (EmployeeTaskPriority)container.Grid.GetRowValues(container.VisibleIndex, "Priority");
        return DemoUtils.ImageLoader.GetPriorityImageUrl(priority);
    }
}
