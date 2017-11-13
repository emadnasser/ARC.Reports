using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Spreadsheet;
using System.Net;
using DevExpress.Web;
using System.Web.UI.HtmlControls;
using DevExpress.Spreadsheet.Demos;
using System.Globalization;

public partial class Spreadsheet_EmployeeInformation : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        IWorkbook book = GenerateBook();
        previewControl.Workbook = book;
        if(previewControl.RenderSpreadsheetPreview())
            return;
    }
    IWorkbook GenerateBook() {
        EmployeeInformationDocumentGenerator generator = new EmployeeInformationDocumentGenerator(new CultureInfo("en-US"));
        string path = Page.MapPath("~/App_Data/EmployeeInformation_template.xlsx");
        return generator.Generate(path);
    }
    protected void OnDocumentDownloaderRequestWorkbook(object sender, RequestWorkbookEventArgs args) {
        args.Workbook = GenerateBook();
    }
}
