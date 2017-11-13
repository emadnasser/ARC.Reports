using System;
using System.IO;
using System.Web.Hosting;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfFileAttachment : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
    }
    protected void OnDownloadButtonClick(object source, EventArgs e) {
        using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
            documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/FileAttachment.pdf"));
            DevExpress.Pdf.PdfFileAttachment attachment = new DevExpress.Pdf.PdfFileAttachment() {
                FileName = "DevExpress.png",
                Data = File.ReadAllBytes(HostingEnvironment.MapPath("~/App_Data/DevExpress.png")),
                Description = "To open the attachment in the Attachments tab, you can either click the 'Open file in its native application' icon or double - click the attachment.",
                CreationDate = DateTime.Now
            };
            documentProcessor.AttachFile(attachment);
            PdfDocumentReponse.SendDocument(Response, documentProcessor, "PDF Document Processor - File Attachment", "PDF File Attachment");
        }
    }
}
