using System;
using System.IO;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfFormFlattening : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
        if (pdfPageViewer.DocumentData == null)
            pdfPageViewer.LoadDocument("~/App_Data/FormDemo.pdf");
    }
    protected void OnFileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        pdfPageViewer.LoadDocument(uploadControl);
    }

    protected void OnDownloadButtonClick(object sender, EventArgs e) {
        try {
            byte[] documentData = pdfPageViewer.DocumentData;
            if (documentData != null)
                using (MemoryStream documentStream = new MemoryStream(documentData))
                    using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                        documentProcessor.LoadDocument(documentStream, true);
                        documentProcessor.FlattenForm();
                        PdfDocumentReponse.SendDocument(Response, documentProcessor, "PDF Document Processor - Form Flattening", "PDF Form Flattening");
                    }
        }
        catch {
        }
    }
}
