using DevExpress.Web;
using DevExpress.Web.Internal;
using System.Web.Mvc;
using System.Web.UI;
using System.IO;
using System;
using DevExpress.XtraRichEdit;

namespace DevExpress.Web.Demos {
    public partial class RichEditController : DemoController {
        public override string Name { get { return "RichEdit"; } }
        
        public ActionResult Index() {
            return RedirectToAction("Export");
        }

        ActionResult CreateFileStreamResult(Stream stream, int documentTypeIndex) {
            return CreateFileStreamResult(stream, documentTypeIndex, "export");
        }
        ActionResult CreateFileStreamResult(Stream stream, int documentTypeIndex, string fileName) {
            stream.Seek(0, SeekOrigin.Begin);
            FileStreamResult result = new FileStreamResult(stream, ConvertIndexToContentType(documentTypeIndex));
            result.FileDownloadName = Uri.EscapeDataString(String.Format("{0}.{1}",fileName, ConvertIndexToFileExtension(documentTypeIndex)));
            return result;
        }
        ActionResult CreatePreviewResult(Stream stream) {
            stream.Seek(0, SeekOrigin.Begin);
            ContentResult result = new ContentResult();
            result.ContentType = "text/html";
            result.Content = ReadStreamToEnd(stream);
            return result;
        }
        string ReadStreamToEnd(Stream stream) {
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
        DocumentFormat ConvertIndexToFormat(int value) {
            switch (value) {
                case 1:
                    return DocumentFormat.Rtf;
                case 2:
                    return DocumentFormat.Doc;
                case 3:
                    return DocumentFormat.OpenXml;
                case 5:
                    return DocumentFormat.PlainText;
                case 6:
                    return DocumentFormat.Mht;
                case 7:
                    return DocumentFormat.OpenDocument;
                case 8:
                    return DocumentFormat.WordML;
                case 9:
                    return DocumentFormat.ePub;

            }
            return DocumentFormat.Undefined;
        }
        string ConvertIndexToContentType(int value) {
            switch (value) {
                case 1:
                    return "application/msword";
                case 2:
                    return "application/msword";
                case 3:
                    return "application/msword";
                case 4:
                    return "application/msword";
                case 5:
                    return "text/plain";
                case 6:
                    return "message/rfc822";
                case 7:
                    return "application/msword";
                case 8:
                    return "text/xml";
                case 9:
                    return "application/msword";
            }
            return String.Empty;
        }
        string ConvertIndexToFileExtension(int value) {
            switch (value) {
                case 1:
                    return "rtf";
                case 2:
                    return "doc";
                case 3:
                    return "docx";
                case 4:
                    return "pdf";
                case 5:
                    return "txt";
                case 6:
                    return "mht";
                case 7:
                    return "odt";
                case 8:
                    return "xml";
                case 9:
                    return "epub";
            }
            return String.Empty;
        }
        
    }
}
