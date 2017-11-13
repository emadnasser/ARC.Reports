using DevExpress.Pdf;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace DevExpress.Web.Demos {
    public class PdfSignatureModel {
        public string Reason { get; set; }
        public string Location { get; set; }
        public string ContactInfo { get; set; }

        public Stream Sign() {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                processor.LoadDocument(HttpContext.Current.Server.MapPath("~/App_Data/Pdf/SignatureDemo.pdf"));
                X509Certificate2 certificate = new X509Certificate2(HttpContext.Current.Server.MapPath("~/App_Data/Pdf/SignDemo.pfx"), "dxdemo");
                MemoryStream stream = new MemoryStream();
                PdfSignature signature = new PdfSignature(certificate) { Location = Location, ContactInfo = ContactInfo, Reason = Reason };
                processor.SaveDocument(stream, new PdfSaveOptions() { Signature = signature });
                return stream;
            }
        }
    }
}
