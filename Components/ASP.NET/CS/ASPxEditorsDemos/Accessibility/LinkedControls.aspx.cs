using System;
using System.Linq;
using System.Web.UI;
using DevExpress.Web;
using System.Collections.Generic;

public partial class Accessibility_LinkedControls : Page {
    protected void Page_Load(object sender, EventArgs e) {
        FilterProductsGrid();
    }

    protected void FilterProductsGrid() {
        using (var context = new NorthwindContext()) {
            var selectedCategories = lbCategories.SelectedValues.OfType<int>();
            var filteredProducts = context.Products.Where(product => selectedCategories.Contains((int)product.CategoryID));
            gvProducts.DataSource = filteredProducts.ToList();
            gvProducts.DataBind();
            gvProducts.JSProperties["cpProductCount"] = gvProducts.VisibleRowCount;
        }
    }
}
