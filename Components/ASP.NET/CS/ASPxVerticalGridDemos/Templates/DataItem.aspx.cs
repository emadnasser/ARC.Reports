using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Web;


public partial class Templates_DataItem : System.Web.UI.Page {

    const string ProductTagFormat = "<span class='categoryProduct'>{0}</span>";

    protected string GetProductsHtml(VerticalGridDataItemTemplateContainer container) {
        int categoryID = Convert.ToInt32(container.KeyValue);
        var productNames = GetProductNames(categoryID);
        return string.Join(string.Empty, productNames.Select(p => string.Format(ProductTagFormat, p)));
    }

    protected List<string> GetProductNames(int categoryID) {
        using(var context = new NorthwindContext()) {
            return context.Products
             .Where(p => p.CategoryID == categoryID)
             .Select(p => p.ProductName)
             .ToList();
        }
    }
}
