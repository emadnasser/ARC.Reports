using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class Products : MasterDetailPage {
    public override FilterBag FilterBag { get { return DemoUtils.ProductFilter; } }
    public override string PageName { get { return "Products"; } }
    public override MasterUserControl MasterUC { get { return Products_Master as MasterUserControl; } }
    public override DetailUserControl DetailUC { get { return Products_Detail as DetailUserControl; } }

    protected Product SelectedProduct { get { return DataProvider.Products.FirstOrDefault(p => p.Id == SelectedItemID); } }

    protected void ProductPopup_WindowCallback(object source, PopupWindowCallbackArgs e) {
        ProductPopupImageSlider.ImageSourceFolder = DemoUtils.ImageLoader.ProductImagesVirtPath(SelectedProduct.Id);
        ProductPopupImageSlider.ActiveItemIndex = int.Parse(e.Parameter);
    }

    public override void OnFilterChanged() {
        Update();
    }

    public override IEnumerable<FilterControlColumn> GetFilterColumns() {
        var result = new List<FilterControlColumn>();
        result.Add(new FilterControlTextColumn() { PropertyName = "Name", DisplayName = "Product Name" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Cost" });
        result.Add(new FilterControlTextColumn() { PropertyName = "SalePrice" });
        result.Add(new FilterControlTextColumn() { PropertyName = "RetailPrice" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Inventory" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Manufacturing" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Backordered" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Category" });
        result.Add(new FilterControlDateColumn() { PropertyName = "ProductionStart" });
        result.Add(new FilterControlCheckColumn() { PropertyName = "Available" });
        result.Add(new FilterControlTextColumn() { PropertyName = "Support.FullName", DisplayName = "Support Name" });
        return result;
    }


}
