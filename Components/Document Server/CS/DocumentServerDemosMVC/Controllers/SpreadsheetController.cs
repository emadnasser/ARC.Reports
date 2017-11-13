using DevExpress.Web;
using DevExpress.Web.Internal;
using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Spreadsheet;
using System.IO;
using System;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        public override string Name { get { return "Spreadsheet"; } }

        public ActionResult Index() {
            return RedirectToAction("Api");
        }
        FileStreamResult GenerateFile(IWorkbook workbook, SpreadsheetModelBase model) {
            DocumentFormat documentFormat = ConvertIndexToFormat(model.ExportToDocumentType);
            MemoryStream stream = new MemoryStream();
            if (documentFormat == DocumentFormat.Undefined)
                workbook.ExportToPdf(stream);
            else
                workbook.SaveDocument(stream, documentFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(stream, ConvertIndexToContentType(model.ExportToDocumentType));
        }
        DocumentFormat ConvertIndexToFormat(int value) {
            switch (value) {
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
            switch (value) {
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
        ContentResult GenerateHtmlPreview(SpreadsheetPreviewModel previewModel) {
            ContentResult result = new ContentResult();
            result.ContentType = "text/html";
            result.Content = GenerateHtmlContentForWorkbook(previewModel);
            return result;
        }
        string GenerateHtmlContentForWorkbook(SpreadsheetPreviewModel previewModel) {
            MemoryStream stream = new MemoryStream();
            HtmlContentGenerator htmlGenerator = new HtmlContentGenerator(stream);
            htmlGenerator.Generate(previewModel.Workbook, previewModel.PreviewSheetIndex);
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
