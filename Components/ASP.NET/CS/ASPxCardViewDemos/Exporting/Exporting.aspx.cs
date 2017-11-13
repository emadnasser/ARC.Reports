using DemosExport;
using DevExpress.Export;
using DevExpress.XtraPrinting;

public partial class Exporting_Exporting : System.Web.UI.Page {
    protected void ToolbarExport_ItemClick(object source, ExportItemClickEventArgs e) {
        switch(e.ExportType) {
            case DemoExportFormat.Pdf:
                cardViewExport.WritePdfToResponse();
                break;
            case DemoExportFormat.Xls:
                cardViewExport.WriteXlsToResponse(new XlsExportOptionsEx() { ExportType = ExportType.DataAware });
                break;
            case DemoExportFormat.Xlsx:
                cardViewExport.WriteXlsxToResponse(new XlsxExportOptionsEx() { ExportType = ExportType.DataAware });
                break;
            case DemoExportFormat.Rtf:
                cardViewExport.WriteRtfToResponse();
                break;
        }
    }
}
