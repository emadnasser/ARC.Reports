using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Pdf;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class PdfSignatureDemo : TutorialControlBase {
        class CertItem {
            public string Name { get; set; }
            public X509Certificate2 Cert { get; set; }

            public override string ToString() {
                return Name;
            }
        }

        static X509Certificate2Collection SelectCertificates() {
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
            X509Certificate2Collection collection = store.Certificates;
            collection = collection.Find(X509FindType.FindByTimeValid, DateTime.Now, true);
            collection = collection.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, true);
            return collection;
        }

        readonly PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();

        public override bool NoGap { get { return true; } }

        public PdfSignatureDemo() {
            InitializeComponent();
            try {
                string path = DemoUtils.GetRelativePath("SignDemo.pdf");
                if (PdfFileHelper.LoadDocument(pdfViewer, path)) {
                    documentProcessor.LoadDocument(path);
                    X509Certificate2 newCert = new X509Certificate2(DemoUtils.GetRelativePath("SignDemo.pfx"), "dxdemo");
                    lbCerts.Items.Add((new CertItem() { Name = newCert.Subject, Cert = newCert }));
                    lbCerts.SelectedIndex = 0;
                    foreach (X509Certificate2 cert in SelectCertificates())
                        lbCerts.Items.Add(new CertItem() { Name = cert.Subject, Cert = cert });
                    lbCerts.DisplayMember = "Subject";
                }
                else
                    Enabled = false;
            }
            catch {
                XtraMessageBox.Show(PdfFileHelper.DemoOpeningErrorMessage, "Error");
                Enabled = false;
            }
        }
        void OnButtonSignClick(object sender, EventArgs e) {
            PdfSignature signature = new PdfSignature(((CertItem)lbCerts.SelectedItem).Cert) {
                Location = teLocation.Text,
                ContactInfo = teContactInfo.Text,
                Reason = teReason.Text
            };
            PdfFileHelper.Save(documentProcessor, new PdfSaveOptions() { Signature = signature });
        }
        void OnButtonNewCertificateClick(object sender, EventArgs e) {
            using (OpenFileDialog openDialog = new OpenFileDialog()) {
                openDialog.Filter = "X.509 Certificate (*.cer; *.crt, *.pfx)|*.cer;*.crt;*.pfx";
                openDialog.RestoreDirectory = true;
                if (openDialog.ShowDialog() == DialogResult.OK)
                    try {
                        X509Certificate2 newCert = new X509Certificate2(openDialog.FileName);
                        if (newCert.HasPrivateKey)
                            AddCertificate(newCert);
                        else
                            XtraMessageBox.Show("The certificate must contain a private key.", "Invalid certificate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch {
                        try {
                            PasswordForm password = new PasswordForm(openDialog.FileName);
                            if (password.ShowDialog() == DialogResult.OK) {
                                X509Certificate2 newCert = new X509Certificate2(openDialog.FileName, password.Password);
                                AddCertificate(newCert);
                            }
                        }
                        catch {
                            XtraMessageBox.Show("The password for the certificate is incorrect.", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
        }
        void AddCertificate(X509Certificate2 newCert) {
            lbCerts.Items.Add((new CertItem() { Name = newCert.Subject, Cert = newCert }));
            lbCerts.SelectedIndex = lbCerts.Items.Count - 1;
        }
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null)
                    components.Dispose();
                documentProcessor.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
