using System;
using DemosExport;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;

public partial class Exporting_ExportDetails : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            ddlExportMode.Items.AddRange(Enum.GetNames(typeof(GridViewDetailExportMode)));
            ddlExportMode.Text = GridViewDetailExportMode.Expanded.ToString();
            grid.DataBind();
            grid.DetailRows.ExpandRow(0);
        }
    }
    protected void detailGrid_BeforePerformDataSelect(object sender, EventArgs e) {
        Session["CategoryID"] = (sender as ASPxGridView).GetMasterRowKeyValue();
    }
    protected void UpdateExportMode() {
        grid.SettingsDetail.ExportMode = (GridViewDetailExportMode)Enum.Parse(typeof(GridViewDetailExportMode), ddlExportMode.Text);
    }
    protected void ToolbarExport_ItemClick(object source, ExportItemClickEventArgs e) {
        UpdateExportMode();
        switch(e.ExportType) {
            case DemoExportFormat.Pdf:
                exporter.WritePdfToResponse();
                break;
            case DemoExportFormat.Xls:
                exporter.WriteXlsToResponse(new XlsExportOptionsEx() { ExportType = ExportType.WYSIWYG });
                break;
            case DemoExportFormat.Xlsx:
                exporter.WriteXlsxToResponse(new XlsxExportOptionsEx() { ExportType = ExportType.WYSIWYG });
                break;
            case DemoExportFormat.Rtf:
                exporter.WriteRtfToResponse();
                break;
            case DemoExportFormat.Csv:
                exporter.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.WYSIWYG });
                break;
        }
    }
}
