using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.Hosting;
using System.Web.UI;
using System.Security.Cryptography.X509Certificates;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfSignature : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
        using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
            documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/SignatureDemo.pdf"));
            using (Bitmap bitmap = documentProcessor.CreateBitmap(1, 900))
                using (MemoryStream stream = new MemoryStream()) {
                    bitmap.Save(stream, ImageFormat.Png);
                    pageImage.Src = "data:image/png;base64," + Convert.ToBase64String(stream.GetBuffer());
                }
        }
    }
    protected void OnSignButtonClick(object source, EventArgs e) {
        using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
            documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/SignatureDemo.pdf"));
            using (Stream stream = new MemoryStream()) {
                PdfDocument document = documentProcessor.Document;
                document.Creator = "PDF Document Processor Demo";
                document.Producer = "Developer Express Inc., " + AssemblyInfo.Version;
                document.Author = "DevExpress Inc.";
                document.Keywords = "PDF, document, server, code, generation, file atatchment";
                document.Subject = "PDF Document Processor - Signature";
                document.Title = "PDF Signature";
                DevExpress.Pdf.PdfSignature signature = new DevExpress.Pdf.PdfSignature(new X509Certificate2(HostingEnvironment.MapPath("~/App_Data/SignDemo.pfx"), "dxdemo")) {
                    Location = tbLocation.Text,
                    ContactInfo = tbContactInfo.Text,
                    Reason = tbReason.Text
                };
                documentProcessor.SaveDocument(stream, new PdfSaveOptions() { Signature = signature });
                PdfDocumentReponse.SendStream(Response, stream);
            }
        }
    }
}
