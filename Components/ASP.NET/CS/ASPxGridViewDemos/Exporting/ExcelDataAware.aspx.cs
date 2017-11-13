using System;
using DemosExport;
using DevExpress.Export;
using DevExpress.XtraPrinting;

public partial class Exporting_ExcelDataAware : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            Grid.ExpandRow(0);
        Exporter.ExportSelectedRowsOnly = Convert.ToBoolean(ExportRowTypeComboBox.SelectedIndex);
    }

    protected void ToolbarExport_ItemClick(object source, DemosExport.ExportItemClickEventArgs e) {
        switch(e.ExportType) {
            case DemoExportFormat.Xls:
                Exporter.WriteXlsToResponse(new XlsExportOptionsEx() { ExportType = ExportType.DataAware });
                break;
            case DemoExportFormat.Xlsx:
                Exporter.WriteXlsxToResponse(new XlsxExportOptionsEx() { ExportType = ExportType.DataAware });
                break;
            case DemoExportFormat.Csv:
                Exporter.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.DataAware });
                break;
        }
    }
}
