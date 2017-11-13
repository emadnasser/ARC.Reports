using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Docs.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;
using DevExpress.XtraReports.UI;
using System.Globalization;

public partial class Spreadsheet_CustomFunction : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(this.previewControl.CanShowPreview()) {
            RefreshPreview();
            return;
        }
        this.previewControl.Workbook = CreateWorkbook();
    }
    IWorkbook CreateWorkbook() {
        CustomFunctionDocumentGenerator example = new CustomFunctionDocumentGenerator(new CultureInfo("en-US"));
        return example.Generate();
    }
    void RefreshPreview() {
        IWorkbook book = CreateWorkbook();
        this.previewControl.Workbook = book;
        this.previewControl.RenderSpreadsheetPreview();
    }
    protected void OnDocumentDownloaderRequestWorkbook(object sender, RequestWorkbookEventArgs args) {
        args.Workbook = CreateWorkbook();
    }
}
