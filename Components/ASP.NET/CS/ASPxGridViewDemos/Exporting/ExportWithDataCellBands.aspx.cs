using System.IO;
using DemosExport;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;

public partial class Exporting_ExportWithDataCellBands : System.Web.UI.Page {
    protected void ToolbarExport_ItemClick(object source, ExportItemClickEventArgs e) {
        switch(e.ExportType) {
            case DemoExportFormat.Pdf:
                gridExporter.WritePdfToResponse();
                break;
            case DemoExportFormat.Xls:
                gridExporter.WriteXlsToResponse(new XlsExportOptionsEx { ExportType = ExportType.WYSIWYG });
                break;
            case DemoExportFormat.Xlsx:
                gridExporter.WriteXlsxToResponse(new XlsxExportOptionsEx{ ExportType = ExportType.WYSIWYG });
                break;
            case DemoExportFormat.Rtf:
                gridExporter.WriteRtfToResponse();
                break;
        }
    }

    protected void gridExporter_RenderBrick(object sender, ASPxGridViewExportRenderingEventArgs e) {
        if(!object.Equals(e.RowType, GridViewRowType.Data))
            return;
        var dataColumn = (GridViewDataColumn)e.Column;
        if(dataColumn.FieldName == "PhotoUrl") {
            var path = MapPath(e.Value.ToString());
            if(File.Exists(path))
                e.ImageValue = File.ReadAllBytes(path);
        }
    }
}
