using System.Linq;
using DevExpress.DevAV;

public partial class UserControls_ViewControls_EmployeesGridView_Detail : DetailUserControl {
    protected Employee SelectedEmployee { get { return DataProvider.Employees.FirstOrDefault(e => e.Id == SelectedItemID); } }

    public override void Update() {
        var employee = SelectedEmployee;
        if(employee != null) {
            DetailsPageControl.Visible = true;

            EmployeeImage.ImageUrl = DemoUtils.ImageLoader.EmployeeImageVirtPath(employee.Id);
            EditImage.JSProperties["cpEmployeeID"] = employee.Id;

            DetailsHeaderHeadLine.NavigateUrl = string.Format("javascript:ShowEmployeeEditForm('{0}')", employee.Id);
            DetailsHeaderHeadLine.HeaderText = string.Format("{0} {1}", employee.FirstName, employee.LastName);
            DetailsHeaderHeadLine.ContentText = employee.Title;

            var address = employee.Address;
            DetailsAddressText.InnerHtml = address.Line + "<br />" + address.City + ", " + address.State + ", " + address.ZipCode;
            DetailsPhoneText.InnerHtml = employee.HomePhone;
            DetailsEmailText.InnerHtml = employee.Email;
        }
        else {
            DetailsPageControl.Visible = false;
            EmployeeImage.ImageUrl = string.Empty;

            DetailsHeaderHeadLine.HeaderText = "None";
            DetailsHeaderHeadLine.ContentText = "None";

            DetailsAddressText.InnerHtml = "None";
            DetailsPhoneText.InnerHtml = "None";
            DetailsEmailText.InnerHtml = "None";
        }
        BindEvaluationGrid(employee);
        BindTaskGridView(employee);
    }

    protected void BindTaskGridView(Employee employee) {
        TasksGrid.DataSource = employee != null ? employee.AssignedTasks : null;
        TasksGrid.DataBind();
        DemoUtils.EnsureGridFocusedRowIndex(TasksGrid);
    }
    protected void BindEvaluationGrid(Employee employee) {
        EvaluationGrid.DataSource = employee != null ? employee.Evaluations : null;
        EvaluationGrid.DataBind();
        DemoUtils.EnsureGridFocusedRowIndex(EvaluationGrid);
    }
}
