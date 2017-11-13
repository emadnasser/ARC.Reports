using System;
using DemosExport;
using DevExpress.Data;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;

public partial class Exporting_ExportSelected: System.Web.UI.Page {
    protected void ToolbarExport_ItemClick(object source, ExportItemClickEventArgs e) {
        switch(e.ExportType) {
            case DemoExportFormat.Pdf:
                gridExport.WritePdfToResponse();
                break;
            case DemoExportFormat.Xls:
                gridExport.WriteXlsToResponse(new XlsExportOptionsEx { ExportType = ExportType.WYSIWYG });
                break;
            case DemoExportFormat.Xlsx:
                gridExport.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
                break;
            case DemoExportFormat.Rtf:
                gridExport.WriteRtfToResponse();
                break;
            case DemoExportFormat.Csv:
                gridExport.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.WYSIWYG });
                break;
        }
    }
    protected void grid_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
        if(e.Column.FieldName != "Total") return;
        decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
        int quantity = Convert.ToInt32(e.GetListSourceFieldValue("UnitsInStock"));
        e.Value = price * quantity;
    }
    protected void grid_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e) {
        if(object.Equals(e.Item, grid.TotalSummary["ProductName"])) {
            e.TotalValue = grid.Selection.Count;
            e.TotalValueReady = true;
        }
        if(object.Equals(e.Item, grid.TotalSummary["Total"])) {
            if(e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start) {
                e.TotalValue = 0;
            }
            if(e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate) {
                object keyValue = e.GetValue("ProductID");
                if(grid.Selection.IsRowSelectedByKey(keyValue)) {
                    e.TotalValue = Convert.ToDecimal(e.TotalValue) + Convert.ToDecimal(e.FieldValue);
                }
            }
        }
    }
    protected void grid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        if(e.Parameters == "Refresh")
            grid.DataBind();
    }
}
