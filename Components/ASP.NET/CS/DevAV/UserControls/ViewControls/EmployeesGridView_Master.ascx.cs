using System;
using System.Linq;
using DevExpress.Web;

public partial class UserControls_ViewControls_EmployeesGridView_Master : MasterUserControl {
    public override long SelectedItemID {
        get {
            var employeeID = EmployeesGrid.GetRowValues(EmployeesGrid.FocusedRowIndex, EmployeesGrid.KeyFieldName);
            return employeeID != null ? (long)employeeID : DataProvider.emptyEntryID;
        }
        set {
            BindGrid();
            EmployeesGrid.FocusedRowIndex = EmployeesGrid.FindVisibleIndexByKeyValue(value);
            UpdateDetail();
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        Update();
    }

    public override void Update() {
        BindGrid();
        UpdateDetail();
    }

    protected void BindGrid() {
        EmployeesGrid.DataSource = DataProvider.Employees.ToList();
        EmployeesGrid.FilterExpression = OwnerPage.FilterBag.GetExpression(false);
        EmployeesGrid.DataBind();
    }
}
