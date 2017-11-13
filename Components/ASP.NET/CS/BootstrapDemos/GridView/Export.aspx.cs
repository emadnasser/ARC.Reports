using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Export;
using DevExpress.XtraPrinting;
using DevExpress.Web;
using DevExpress.Data;

public partial class GridView_Export : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            GridView2.ExpandRow(0);
    }

    /* Default Export */
    protected void ButtonPDF1_Click(object sender, EventArgs e) {
        GridViewExporter1.WritePdfToResponse();
    }

    protected void ButtonXLS1_Click(object sender, EventArgs e) {
        GridViewExporter1.WriteXlsToResponse(new XlsExportOptionsEx { ExportType = ExportType.WYSIWYG });
    }

    protected void ButtonXLSX1_Click(object sender, EventArgs e) {
        GridViewExporter1.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
    }

    protected void ButtonCSV1_Click(object sender, EventArgs e) {
        GridViewExporter1.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.WYSIWYG });
    }

    protected void ButtonRTF1_Click(object sender, EventArgs e) {
        GridViewExporter1.WriteRtfToResponse();
    }

    /* Data Aware Export */
    protected void ButtonXLS2_Click(object sender, EventArgs e) {
        GridViewExporter2.WriteXlsToResponse(new XlsExportOptionsEx() { ExportType = ExportType.DataAware });
    }

    protected void ButtonXLSX2_Click(object sender, EventArgs e) {
        GridViewExporter2.WriteXlsxToResponse(new XlsxExportOptionsEx() { ExportType = ExportType.DataAware });
    }

    protected void ButtonCSV2_Click(object sender, EventArgs e) {
        GridViewExporter2.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.DataAware });
    }

    /* Export Selected */
    protected void ButtonRTF3_Click(object sender, EventArgs e) {
        GridViewExporter3.WriteRtfToResponse();
    }

    protected void ButtonCSV3_Click(object sender, EventArgs e) {
        GridViewExporter3.WriteCsvToResponse(new CsvExportOptionsEx() { ExportType = ExportType.WYSIWYG });
    }

    protected void ButtonXLSX3_Click(object sender, EventArgs e) {
        GridViewExporter3.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
    }

    protected void ButtonXLS3_Click(object sender, EventArgs e) {
        GridViewExporter3.WriteXlsToResponse(new XlsExportOptionsEx { ExportType = ExportType.WYSIWYG });
    }

    protected void ButtonPDF3_Click(object sender, EventArgs e) {
        GridViewExporter3.WritePdfToResponse();
    }
}
