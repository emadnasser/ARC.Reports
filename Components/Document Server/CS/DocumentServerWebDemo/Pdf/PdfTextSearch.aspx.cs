using System;
using System.IO;
using System.Text;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfTextSearch : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
        if (pdfPageViewer.DocumentData == null)
            pdfPageViewer.LoadDocument("~/App_Data/TextSearch.pdf");
    }
    protected void OnFileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        string fileName = pdfPageViewer.LoadDocument(uploadControl);
        if (fileName != null)
            e.CallbackData = fileName;
    }
    protected void OnCallback(object source, PopupWindowCallbackArgs e) {
        try {
            byte[] documentData = pdfPageViewer.DocumentData;
            UserControls_PdfResultsViewer viewer = Page.LoadControl("~/UserControls/PdfResultsViewer.ascx") as UserControls_PdfResultsViewer;
            if (documentData != null && viewer != null)
                using (MemoryStream documentStream = new MemoryStream(documentData))
                    using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                        documentProcessor.LoadDocument(documentStream, true);
                        int wordCount = Convert.ToInt32(spinEditWordCount.Value);
                        StringBuilder text = new StringBuilder();
                        while (documentProcessor.FindText(textBoxTextToFind.Text).Status == PdfTextSearchStatus.Found) {
                            for (int i = 0; i < wordCount; i++) {
                                PdfWord nextWord = documentProcessor.NextWord();
                                if (nextWord == null)
                                    break;
                                text.Append(nextWord.Text);
                                text.Append(" ");
                            }
                            text.Append(Environment.NewLine);
                        }
                        viewer.SetText(text.ToString());
                        txtPopup.Controls.Add(viewer);
                        return;
                    }
        }
        catch {
        }
    }
}
