using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.XtraGrid;

public partial class GroupingSorting_IntervalGrouping : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ColumnGroupInterval intervalGroup = (ColumnGroupInterval)Enum.Parse(typeof(ColumnGroupInterval), cbGroupInterval.Value.ToString());
        SetGroupInterval(intervalGroup);
    }
    protected void grid_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName == "Total") {
            decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
            int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
            e.Value = price * quantity;
        }
    }
    protected void grid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        ColumnGroupInterval intervalGroup = (ColumnGroupInterval)Enum.Parse(typeof(ColumnGroupInterval), e.Parameters);
        SetGroupInterval(intervalGroup);
    }
    void SetGroupInterval(ColumnGroupInterval intervalGroup) {
        ((GridViewDataColumn)grid.Columns["OrderDate"]).Settings.GroupInterval = intervalGroup;
        grid.DataBind();
    }
}
