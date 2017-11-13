using System;
using System.IO;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfPageDeletion : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
        if (pdfPageViewer.DocumentData == null)
            pdfPageViewer.LoadDocument("~/App_Data/PageDeletion.pdf");
    }
    protected void OnCallback(object source, CallbackEventArgsBase e) {
        using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor())
            using (MemoryStream dataStream = new MemoryStream(pdfPageViewer.DocumentData)) {
                documentProcessor.LoadDocument(dataStream);
                IList<PdfPage> pages = documentProcessor.Document.Pages;
                int pageNumber = (int)pdfPageViewer.PageIndex + 1;
                if (pages.Count > 0)
                    documentProcessor.DeletePage(pageNumber);
                using (MemoryStream stream = new MemoryStream()) {
                    documentProcessor.SaveDocument(stream);
                    stream.Position = 0;
                    pdfPageViewer.UpdateDocument(stream, "PN" + (Math.Max(0, Math.Min(pageNumber, pages.Count) - 1)).ToString());
                }
            }
    }
}
