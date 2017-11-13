using System;
using DevExpress.Web;
using System.Web.UI;
using System.Collections.Generic;

public partial class Filtering_FilterBuilder : Page {

    List<string> columnsToRemove = new List<string>() { 
        "CategoryID",
        "ProductID",
        "SupplierID",
        "Supplier.SupplierID",
        "Supplier.HomePage",
        "Category.CategoryID",
        "EAN13"
    };

    protected void Page_Load(object sender, EventArgs e) {
        grid.SettingsFilterControl.ViewMode = cbEnableTextTab.Checked ? FilterControlViewMode.VisualAndText : FilterControlViewMode.Visual;
        grid.SettingsFilterControl.AllowHierarchicalColumns = cbAllowHierarchicalColumns.Checked;
        grid.SettingsFilterControl.ShowAllDataSourceColumns = cbShowAddDataSourceColumns.Checked;

        if(!IsPostBack) {
            grid.FilterExpression = "Category.CategoryName = 'Beverages'";
        }
    }
    
    protected void grid_FilterControlColumnsCreated(object source, FilterControlColumnsCreatedEventArgs e) {
        foreach(string col in columnsToRemove)
            e.Columns.Remove(col);
    }
}
