using System;
using System.Linq;
using DevExpress.Web;

public partial class UserControls_ViewControls_Customers_Master : MasterUserControl {
    public override long SelectedItemID {
        get {
            var customerID = CustomerGrid.GetRowValues(CustomerGrid.FocusedRowIndex, CustomerGrid.KeyFieldName);
            return customerID != null ? (long)customerID : DataProvider.emptyEntryID;
        }
        set {
            throw new NotImplementedException();
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        Update();
    }

    public override void Update() {
        BindGrid();
        UpdateDetail();
    }

    protected void BindGrid() { // TODO try use cache in all gridviews
        CustomerGrid.DataSource = DataProvider.Customers.ToList();
        CustomerGrid.FilterExpression = OwnerPage.FilterBag.GetExpression(false);
        CustomerGrid.SearchPanelFilter = OwnerPage.FilterBag.SearchText;
        CustomerGrid.DataBind();
    }
}
