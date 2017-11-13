using DevExpress.Pdf;
using System.IO;
using System.Security;

namespace DevExpress.Web.Demos {
    public class PdfPasswordProtectionModel {
        public string UserPassword { get; set; }
        public string OwnerPassword { get; set; }
        public PdfDocumentInteractivityPermissions AllowInteractivity { get; set; }
        public PdfDocumentModificationPermissions AllowModification { get; set; }
        public PdfDocumentDataExtractionPermissions AllowExtraction { get; set; }
        public PdfDocumentPrintingPermissions AllowPrinting { get; set; }

        public Stream PasswordProtect(string file) {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                processor.LoadDocument(file);
                SecureString owner = new SecureString();
                foreach (char c in OwnerPassword ?? "")
                    owner.AppendChar(c);
                SecureString user = new SecureString();
                foreach (char c in UserPassword ?? "")
                    user.AppendChar(c);
                PdfEncryptionOptions encryptionOptions = new PdfEncryptionOptions();
                encryptionOptions.DataExtractionPermissions = AllowExtraction;
                encryptionOptions.PrintingPermissions = AllowPrinting;
                encryptionOptions.ModificationPermissions = AllowModification;
                encryptionOptions.InteractivityPermissions = AllowInteractivity;
                encryptionOptions.OwnerPassword = owner;
                encryptionOptions.UserPassword = user;
                MemoryStream stream = new MemoryStream();
                processor.SaveDocument(stream, new PdfSaveOptions() { EncryptionOptions = encryptionOptions });
                return stream;
            }
        }
    }
}
