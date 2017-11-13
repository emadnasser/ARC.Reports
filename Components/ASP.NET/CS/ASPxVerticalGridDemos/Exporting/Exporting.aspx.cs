using DemosExport;
using DevExpress.Export;
using DevExpress.XtraPrinting;

public partial class Exporting_Exporting : System.Web.UI.Page {
    protected void ToolbarExport_ItemClick(object source, ExportItemClickEventArgs e) {
        switch(e.ExportType) {
            case DemoExportFormat.Pdf:
                verticalGridExport.WritePdfToResponse();
                break;
            case DemoExportFormat.Xls:
                verticalGridExport.WriteXlsToResponse();
                break;
            case DemoExportFormat.Xlsx:
                verticalGridExport.WriteXlsxToResponse();
                break;
            case DemoExportFormat.Rtf:
                verticalGridExport.WriteRtfToResponse();
                break;
        }
    }
}
