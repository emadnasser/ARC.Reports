using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using DevExpress.Spreadsheet;
using DevExpress.Docs.Demos;
using System.IO;

public partial class Spreadsheet_ExpenseReport : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        this.previewControl.Workbook = CreateWorkbook();
        if(this.previewControl.CanShowPreview()) 
            this.previewControl.RenderSpreadsheetPreview();
    }
    IWorkbook CreateWorkbook() {
        ExpenseReportDocumentGenerator example = new ExpenseReportDocumentGenerator();
        return example.Generate();
    }
    protected void OnDocumentDownloaderRequestWorkbook(object sender, RequestWorkbookEventArgs args) {
        args.Workbook = CreateWorkbook();
    }    
}
