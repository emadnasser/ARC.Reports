using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_ViewControls_EmployeesCardView_Master : MasterUserControl {
    protected long SelectedEmployeeID {
        get {
            long employeeID;
            return DemoUtils.TryGetClientStateIDValue("ID", out employeeID) ? employeeID : DataProvider.emptyEntryID;
        }
        set { DemoUtils.TrySetClientStateValue<long>("ID", value); }
    }
    public override long SelectedItemID {
        get { return SelectedEmployeeID; }
        set {
            SelectedEmployeeID = value;
            BindCardView(true);
        }
    }
    protected List<Employee> Employees { get { return DataProvider.GetEmployees(OwnerPage.FilterBag.GetExpression(true)).ToList(); } }

    protected void Page_Load(object sender, EventArgs e) {
        Update();
    }

    protected void EditImage_Load(object sender, EventArgs e) {
        var image = (ASPxImage)sender;
        var container = (CardViewDataItemTemplateContainer)image.NamingContainer;
        var employeeId = container.KeyValue;
        image.JSProperties["cpEmployeeID"] = employeeId;
    }

    public override void Update() {
        BindCardView();
    }

    protected void BindCardView(bool calcPageIndex = false) {
        var employees = Employees;
        EmployeeCardView.DataSource = employees;
        EmployeeCardView.DataBind();

        SelectedEmployeeID = GetVisibleSelectedEmployeeID();

        UpdateDetail();
    }

    protected long GetVisibleSelectedEmployeeID() {
        return Convert.ToInt64(EmployeeCardView.GetCardValues(EmployeeCardView.FocusedCardIndex, "Id"));
    }

    protected string GetEmployeeImageUrl(long id) {
        return DemoUtils.ImageLoader.EmployeeImageVirtPath(id);
    }
    protected string HighlightSearchText(CardViewDataItemTemplateContainer container, string fieldName) {
        var text = DataBinder.Eval(container.DataItem, fieldName).ToString();
        return !string.IsNullOrWhiteSpace(text) ? DemoUtils.HighlightSearchText(text, EmployeeCardView.SearchPanelFilter) : text;
    }

    protected void EmployeeCardView_PageIndexChanged(object sender, EventArgs e) {
        SelectedEmployeeID = GetVisibleSelectedEmployeeID();
    }
}
