using System;
using System.IO;
using System.Security;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.Hosting;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfPasswordProtection : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
        using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
            documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/PasswordProtectionDemo.pdf"));
            using (Bitmap bitmap = documentProcessor.CreateBitmap(1, 900))
                using (MemoryStream stream = new MemoryStream()) {
                    bitmap.Save(stream, ImageFormat.Png);
                    pageImage.Src = "data:image/png;base64," + Convert.ToBase64String(stream.GetBuffer());
                }
        }
    }
    protected void OnProtectButtonClick(object source, EventArgs e) {
        using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
            documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/PasswordProtectionDemo.pdf")); 
            using (Stream stream = new MemoryStream()) {
                PdfDocument document = documentProcessor.Document;
                document.Creator = "PDF Document Processor Demo";
                document.Producer = "Developer Express Inc., " + AssemblyInfo.Version;
                document.Author = "DevExpress Inc.";
                document.Keywords = "PDF, document, server, code, generation, file atatchment";
                document.Subject = "PDF Document Processor - Password Protection";
                document.Title = "PDF Password Protection";
                SecureString ownerPassword = new SecureString();
                foreach (char c in tbOwnerPassword.Text)
                    ownerPassword.AppendChar(c);
                SecureString userPassword = new SecureString();
                foreach (char c in tbUserPassword.Text)
                    userPassword.AppendChar(c);
                PdfEncryptionOptions encryptionOptions = new PdfEncryptionOptions() {
                    OwnerPassword = ownerPassword,
                    UserPassword = userPassword,
                    PrintingPermissions = ((PdfDocumentPrintingPermissions)cbAllowPrinting.Value),
                    DataExtractionPermissions = ((PdfDocumentDataExtractionPermissions)cbAllowExtraction.Value),
                    ModificationPermissions = ((PdfDocumentModificationPermissions)cbAllowModification.Value),
                    InteractivityPermissions = ((PdfDocumentInteractivityPermissions)cbAllowInteractivity.Value)
                };
                documentProcessor.SaveDocument(stream, new PdfSaveOptions() { EncryptionOptions = encryptionOptions });
                PdfDocumentReponse.SendStream(Response, stream);
            }
        }
    }
}
