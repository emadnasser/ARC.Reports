using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Web;

public partial class ASPxFilterControl_FilterBuilder : Page {

    List<string> columnsToRemove = new List<string>() { 
        "CategoryID",
        "ProductID",
        "SupplierID",
        "Supplier.SupplierID",
        "Supplier.HomePage",
        "Category.CategoryID",
        "Category.CategoryName",
        "EAN13"
    };

    protected void Page_Load(object sender, EventArgs e) {
        filter.ViewMode = cbEnableTextTab.Checked ? FilterControlViewMode.VisualAndText : FilterControlViewMode.Visual;
        if(!IsPostBack) {
            CreateFilterColumns();
            filter.FilterExpression = grid.FilterExpression = "[Category.CategoryName] = 'Beverages'";
        }
    }

    void CreateFilterColumns() {
        int maxHierarchyDepth = 1;
        filter.BindToSource(typeof(Product), cbAllowHierarchicalColumns.Checked, maxHierarchyDepth);

        foreach(string col in columnsToRemove)
            filter.Columns.Remove(col);

        if(cbAllowHierarchicalColumns.Checked) { 
            var categoryColumn = (FilterControlComplexTypeColumn)filter.Columns["Category"];
            categoryColumn.Columns.Insert(0, CreateComboBoxColumn());
        }
    }

    FilterControlColumn CreateComboBoxColumn() {
        var column = new FilterControlComboBoxColumn();
        column.PropertyName = "CategoryName";
        var comboBoxProperties = column.PropertiesEdit as ComboBoxProperties;
        comboBoxProperties.DataSourceID = "CategoriesDataSource";
        comboBoxProperties.TextField = "CategoryName";
        comboBoxProperties.ValueField = "CategoryName";
        comboBoxProperties.ValueType = typeof(string);
        return column;
    }
    protected void cbAllowHierarchycalColumns_CheckedChanged(object sender, EventArgs e) {
        CreateFilterColumns();
    }
}
