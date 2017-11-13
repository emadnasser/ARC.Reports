using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Spreadsheet;
using System.IO;
using System.Net;

public partial class UserControls_SpreadsheetDocumentDownloader : System.Web.UI.UserControl {

    public UserControls_SpreadsheetDocumentDownloader() {
        Inline = true;
    }

    public bool Inline { get; set; }

    public event RequestWorkbookEventHandler RequestWorkbook;

    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void btnDownload_Click(object sender, EventArgs e) {
        IWorkbook book = RaiseRequestWorkbook();
        if(book == null)
            return;
        MemoryStream stream = new MemoryStream();
        int value = (int)cbDownloadType.Value;
        if(value == 4) {
            book.ExportToPdf(stream);
        } else {
            DocumentFormat format = ConvertIndexToFormat(value);
            book.SaveDocument(stream, format);
        }
        stream.Seek(0, SeekOrigin.Begin);
        stream.CopyTo(Response.OutputStream);

        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = ConvertIndexToContentType(value);
        Response.AddHeader("Content-Disposition", String.Format("attachment; filename=ExpenseReport.{0}", ConvertIndexToFileExtension(value)));
        Response.End();
    }

    private IWorkbook RaiseRequestWorkbook() {
        if(RequestWorkbook == null)
            return null;
        RequestWorkbookEventArgs args = new RequestWorkbookEventArgs();
        RequestWorkbook(this, args);
        return args.Workbook;
    }
    DocumentFormat ConvertIndexToFormat(int value) {
        switch(value) {
            case 1:
                return DocumentFormat.OpenXml;
            case 2:
                return DocumentFormat.Xls;
            case 3:
                return DocumentFormat.Csv;
        }
        return DocumentFormat.Undefined;
    }
    string ConvertIndexToContentType(int value) {
        switch(value) {
            case 1:
                return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            case 2:
                return "application/vnd.ms-excel";
            case 3:
                return "text/comma-separated-values";
            case 4:
                return "application/pdf";
        }
        return String.Empty;
    }
    string ConvertIndexToFileExtension(int value) {
        switch(value) {
            case 1:
                return "xlsx";
            case 2:
                return "xls";
            case 3:
                return "csv";
            case 4:
                return "pdf";
        }
        return String.Empty;
    }
}

public class RequestWorkbookEventArgs {
    public IWorkbook Workbook { get; set; }
}
public delegate void RequestWorkbookEventHandler(object sender, RequestWorkbookEventArgs args);
