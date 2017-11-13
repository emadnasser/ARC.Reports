using System;
using System.Linq;
using DevExpress.Web;

public partial class UserControls_ViewControls_Products_Master : MasterUserControl {
    public override long SelectedItemID {
        get {
            var productID = ProductGrid.GetRowValues(ProductGrid.FocusedRowIndex, ProductGrid.KeyFieldName);
            return productID != null ? (long)productID : DataProvider.emptyEntryID;
        }
        set {
            BindGrid();
            ProductGrid.FocusedRowIndex = ProductGrid.FindVisibleIndexByKeyValue(value);
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
        ProductGrid.DataSource = DataProvider.Products.ToList();
        ProductGrid.FilterExpression = OwnerPage.FilterBag.GetExpression(false);
        ProductGrid.SearchPanelFilter = OwnerPage.FilterBag.SearchText;
        ProductGrid.DataBind();
    }
}
