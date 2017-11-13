using DemosExport;
using DevExpress.Export;
using DevExpress.XtraPrinting;

public partial class Exporting_Exporting : System.Web.UI.Page {
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
}
