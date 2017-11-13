using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Rows_CellMerging : Page {
    protected void Grid_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e) {
        if(e.DataColumn.FieldName != "ContactTitle")
            return;
        string position = Convert.ToString(e.CellValue);
        ASPxImage positionIcon = (ASPxImage)Grid.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "PositionIcon");
        positionIcon.Caption = position;
        positionIcon.EmptyImage.IconID = GetIconIDByPosition(position);
    }
    string GetIconIDByPosition(string position) {
        if(position == "Sales Representative")
            return "businessobjects_boorder_16x16";
        if(position == "Sales Manager" || position == "Assistant Sales Agent")
            return "businessobjects_boposition_16x16";
        if(position == "Sales Associate")
            return "businessobjects_bodepartment_16x16";
        if(position == "Sales Agent")
            return "businessobjects_boperson_16x16";
        if(position.Contains("Owner") || position == "Order Administrator")
            return "businessobjects_boposition2_16x16";
        if(position == "Marketing Manager")
            return "businessobjects_borole_16x16";
        if(position == "Marketing Assistant")
            return "businessobjects_boemployee_16x16";
        if(position == "Assistant Sales Representative")
            return "businessobjects_boorderitem_16x16";
        if(position == "Accounting Manager")
            return "businessobjects_bouser_16x16";
        return string.Empty;
    }
}
