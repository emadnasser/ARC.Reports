using System;
using System.IO;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfTextExtraction : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
        if (pdfPageViewer.DocumentData == null)
            pdfPageViewer.LoadDocument("~/App_Data/TextExtraction.pdf");
    }
    protected void OnFileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        string fileName = pdfPageViewer.LoadDocument(uploadControl);
        if (fileName != null)
            e.CallbackData = fileName;
    }

    protected void OnCallback(object source, DevExpress.Web.PopupWindowCallbackArgs e) {
        try {
            byte[] documentData = pdfPageViewer.DocumentData;
            UserControls_PdfResultsViewer viewer = Page.LoadControl("~/UserControls/PdfResultsViewer.ascx") as UserControls_PdfResultsViewer;
            if (documentData != null && viewer != null)
                using (MemoryStream documentStream = new MemoryStream(documentData))
                    using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                        documentProcessor.LoadDocument(documentStream, true);
                        viewer.SetText(documentProcessor.Text);         
                        txtPopup.Controls.Add(viewer);
                        return;
                    }
        }
        catch {
        }
    }
}
