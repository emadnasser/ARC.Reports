using System.IO;
using System.Net;
using System.Web;
using DevExpress.Pdf;

namespace DevExpress.Web.Demos {
    public static class PdfDocumentReponse  {
        public static void SendStream(HttpResponse response, Stream stream) {
            stream.Position = 0;
            stream.CopyTo(response.OutputStream);
            response.StatusCode = (int)HttpStatusCode.OK;
            response.ContentType = "application/pdf";
            response.AddHeader("Content-Disposition", "attachment; filename=Result.pdf");
            response.End();
        }
        public static void SendDocument(HttpResponse response, PdfDocumentProcessor documentProcessor, string subject, string title) {
            PdfDocument document = documentProcessor.Document;
            document.Creator = "PDF Document Processor Demo";
            document.Author = "DevExpress Inc.";
            document.Keywords = "PDF, document, server, code";
            document.Producer = "Developer Express Inc.";
            document.Subject = subject;
            document.Title = title;
            using (MemoryStream stream = new MemoryStream()) {
                documentProcessor.SaveDocument(stream);
                SendStream(response, stream);
            }
        }
    }
}
