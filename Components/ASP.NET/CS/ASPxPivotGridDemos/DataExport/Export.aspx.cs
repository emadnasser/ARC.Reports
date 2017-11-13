using System;
using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPrinting;

public partial class Features_Printing : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
    }

    void Export(bool saveAs) {
        foreach(PivotGridField field in ASPxPivotGrid1.Fields) {
            if(field.ValueFormat != null && !string.IsNullOrEmpty(field.ValueFormat.FormatString))
                field.UseNativeFormat = checkCustomFormattedValuesAsText.Checked ? DefaultBoolean.False : DefaultBoolean.True;
        }

        ASPxPivotGridExporter1.OptionsPrint.PrintHeadersOnEveryPage = checkPrintHeadersOnEveryPage.Checked;
        ASPxPivotGridExporter1.OptionsPrint.MergeColumnFieldValues = checkMergeColumnFieldValues.Checked;
        ASPxPivotGridExporter1.OptionsPrint.MergeRowFieldValues = checkMergeRowFieldValues.Checked;

        ASPxPivotGridExporter1.OptionsPrint.PrintFilterHeaders = checkPrintFilterFieldHeaders.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        ASPxPivotGridExporter1.OptionsPrint.PrintColumnHeaders = checkPrintColumnFieldHeaders.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        ASPxPivotGridExporter1.OptionsPrint.PrintRowHeaders = checkPrintRowFieldHeaders.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        ASPxPivotGridExporter1.OptionsPrint.PrintDataHeaders = checkPrintDataFieldHeaders.Checked ? DefaultBoolean.True : DefaultBoolean.False;

        const string fileName = "PivotGrid";
        XlsxExportOptionsEx options;
        switch(listExportFormat.SelectedIndex) {
            case 0:
                ASPxPivotGridExporter1.ExportPdfToResponse(fileName, saveAs);
                break;
            case 1:
                options = new XlsxExportOptionsEx() { ExportType = ExportType.WYSIWYG };
                ASPxPivotGridExporter1.ExportXlsxToResponse(fileName, options, saveAs);
                break;
            case 2:
                ASPxPivotGridExporter1.ExportMhtToResponse(fileName, "utf-8", "ASPxPivotGrid Printing Sample", true, saveAs);
                break;
            case 3:
                ASPxPivotGridExporter1.ExportRtfToResponse(fileName, saveAs);
                break;
            case 4:
                ASPxPivotGridExporter1.ExportTextToResponse(fileName, saveAs);
                break;
            case 5:
                ASPxPivotGridExporter1.ExportHtmlToResponse(fileName, "utf-8", "ASPxPivotGrid Printing Sample", true, saveAs);
                break;
            case 6:
                options = new XlsxExportOptionsEx() { 
                    ExportType = ExportType.DataAware,
                    AllowGrouping = allowGroupingCheckBox.Checked ? DefaultBoolean.True : DefaultBoolean.False,
                    TextExportMode = exportCellValuesAsText.Checked ? TextExportMode.Text : TextExportMode.Value,
                    AllowFixedColumns = allowFixedColumns.Checked ? DefaultBoolean.True : DefaultBoolean.False,
                    AllowFixedColumnHeaderPanel = allowFixedColumns.Checked ? DefaultBoolean.True : DefaultBoolean.False,
                    RawDataMode = exportRawData.Checked
                };
                ASPxPivotGridExporter1.ExportXlsxToResponse(fileName, options, saveAs);
                break;
        }
    }

    protected void buttonOpen_Click(object sender, EventArgs e) {
        Export(false);
    }
    protected void buttonSaveAs_Click(object sender, EventArgs e) {
        Export(true);
    }
}
