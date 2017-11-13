using System.IO;
using DemosExport;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;

public partial class Exporting_ExportWithFormatConditions : System.Web.UI.Page {
    protected void ToolbarExport_ItemClick(object source, ExportItemClickEventArgs e) {
        switch(e.ExportType) {
            case DemoExportFormat.Pdf:
                cardViewExport.WritePdfToResponse();
                break;
            case DemoExportFormat.Xls:
                cardView.Columns["PhotoUrl"].Visible = false;
                cardViewExport.WriteXlsToResponse(new XlsExportOptionsEx() { ExportType = ExportType.DataAware });
                break;
            case DemoExportFormat.Xlsx:
                cardView.Columns["PhotoUrl"].Visible = false;
                cardViewExport.WriteXlsxToResponse(new XlsxExportOptionsEx() { ExportType = ExportType.DataAware });
                break;
            case DemoExportFormat.Rtf:
                cardViewExport.WriteRtfToResponse();
                break;
        }
    }
    protected void cardViewExport_RenderBrick(object sender, ASPxCardViewExportRenderingEventArgs e) {
        if(e.Column.FieldName == "PhotoUrl") {
            var path = MapPath(e.Value.ToString());
            if(File.Exists(path))
                e.ImageValue = File.ReadAllBytes(path);
        }
    }
}
