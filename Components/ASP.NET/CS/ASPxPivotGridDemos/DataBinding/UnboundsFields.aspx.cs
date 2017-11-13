using System;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;

public partial class UnboundFieldsDemo : Page {

    protected void Page_Load(object sender, EventArgs e) {
        
    }
    protected void pivotGrid_CustomUnboundFieldData(object sender, CustomFieldDataEventArgs e) {
        if(object.ReferenceEquals(e.Field, fieldSalesPerson))
            e.Value = string.Format(salesPersonFormat.SelectedItem.Value.ToString(), e.GetListSourceColumnValue("FirstName"), e.GetListSourceColumnValue("LastName"));
        if(object.ReferenceEquals(e.Field, fieldOrderAmount)) {
            double discount = orderAmountRule.SelectedItem.Value.ToString() == "1"  ? Convert.ToDouble(e.GetListSourceColumnValue("Discount")) : 0;
            e.Value = Convert.ToDouble(e.GetListSourceColumnValue("UnitPrice")) * Convert.ToDouble(e.GetListSourceColumnValue("Quantity")) * (1 - discount);
        }
    }
    protected void pivotGrid_CustomCellDisplayText(object sender, PivotCellDisplayTextEventArgs e) {
        if(object.ReferenceEquals(e.DataField, fieldPercent)) {
            PivotGridField orderAmountField = fieldOrderAmount;
            object orderAmount = e.GetCellValue(orderAmountField);
            if(orderAmount == null) return;
            decimal grandTotalOrderAmount = (decimal)e.GetRowGrandTotal(orderAmountField);
            if(grandTotalOrderAmount == 0) return;
            decimal perc = (decimal)orderAmount / grandTotalOrderAmount;
            e.DisplayText = string.Format("{0:p}", perc);
        }
        //The Bonus Amount field displays 15% if the order amount is greater than $50,000, or 10% of the amount is less.
        if(object.ReferenceEquals(e.DataField, fieldBonusAmount)) {
            PivotGridField orderAmountField = fieldOrderAmount;
            object orderAmount = e.GetCellValue(orderAmountField);
            double perc = orderAmount != null && (decimal)orderAmount > 50000 ? 0.15 : 0.1;
            e.DisplayText = e.RowValueType == DevExpress.XtraPivotGrid.PivotGridValueType.Value ? string.Format("{0:p}", perc) : "";
        }

    }
    protected void salesPersonFormat_SelectedIndexChanged(object sender, EventArgs e) {
        pivotGrid.DataBind();
    }
}
