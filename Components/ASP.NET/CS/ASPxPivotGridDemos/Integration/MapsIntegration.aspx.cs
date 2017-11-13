using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class MapsIntegration : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack && !IsCallback)
            pivotGrid.DataBind();
    }
    protected void pivotGrid_CustomJsProperties(object sender, DevExpress.Web.CustomJSPropertiesEventArgs e) {
        e.Properties.Add("cpCountrySales", GetCountrySales());
    }
    Dictionary<string, decimal> GetCountrySales() {
        Dictionary<string, decimal> res = new Dictionary<string, decimal>();
        bool isColumn = fieldCountry.IsColumn;
        int count = isColumn ? pivotGrid.ColumnCount : pivotGrid.RowCount;
        for(int i = 0; i < count; i++) {
            string country = (string)pivotGrid.GetFieldValue(fieldCountry, i);
            if(string.IsNullOrEmpty(country)) continue;
            decimal value = Convert.ToDecimal(
                pivotGrid.GetCellValue(isColumn ? i : pivotGrid.ColumnCount - 1,
                    isColumn ? pivotGrid.RowCount - 1 : i));
            res.Add(country, value);
        }
        return res;
    }
}
