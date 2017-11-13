using DevExpress.Web;
using System.Collections.Generic;

public partial class Dashboard : BasePage {
    public override FilterBag FilterBag { get { return DemoUtils.DashboardFilter; } }
    public override string PageName { get { return "Dashboard"; } }
    public override bool ContentHasScroll { get { return true; } }
    public override bool ContentHasBorder { get { return false; } }
    public override bool HasSearchPanel { get { return false; } }

    protected ViewUserControl ViewControl { get { return ProductsPivotGrid as ViewUserControl; } }

    public override IEnumerable<FilterControlColumn> GetFilterColumns() {
        var result = new List<FilterControlColumn>();
        result.Add(new FilterControlTextColumn() { DisplayName = "Category", PropertyName = "Product.Category" });
        result.Add(new FilterControlTextColumn() { DisplayName = "Name", PropertyName = "Product.Name" });
        result.Add(new FilterControlTextColumn() { DisplayName = "State", PropertyName = "Order.Store.Address.State" });
        result.Add(new FilterControlTextColumn() { DisplayName = "City", PropertyName = "Order.Store.Address.City" });
        return result;
    }

    public override void OnFilterChanged() {
        ViewControl.Update();
    }
}
