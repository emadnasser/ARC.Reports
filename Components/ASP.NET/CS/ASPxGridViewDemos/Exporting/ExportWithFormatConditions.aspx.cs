using System;
using DemosExport;

public partial class Exporting_ExportWithFormatConditions : System.Web.UI.Page {
    protected void ToolbarExport_ItemClick(object source, ExportItemClickEventArgs e) {
        switch(e.ExportType) {
            case DemoExportFormat.Pdf:
                Exporter.WritePdfToResponse();
                break;
            case DemoExportFormat.Xls:
                Exporter.WriteXlsToResponse();
                break;
            case DemoExportFormat.Xlsx:
                Exporter.WriteXlsxToResponse();
                break;
            case DemoExportFormat.Rtf:
                Exporter.WriteRtfToResponse();
                break;
        }
    }
}
