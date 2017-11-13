using System;
using System.Security;
using DevExpress.Pdf;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.Docs.Demos {
    public partial class PdfPasswordProtection : TutorialControlBase {
        static readonly string path = DemoUtils.GetRelativePath("EncryptDemo.pdf");

        public override bool NoGap { get { return true; } }

        public PdfPasswordProtection() {
            InitializeComponent();
            imageComboBoxPrinting.Properties.Items.Add(new ImageComboBoxItem("Not allowed", PdfDocumentPrintingPermissions.NotAllowed, 0));
            imageComboBoxPrinting.Properties.Items.Add(new ImageComboBoxItem("Low quality", PdfDocumentPrintingPermissions.LowQuality, 0));
            imageComboBoxPrinting.Properties.Items.Add(new ImageComboBoxItem("Allowed", PdfDocumentPrintingPermissions.Allowed, 0));
            imageComboBoxPrinting.SelectedIndex = 2;
            imageComboBoxDataExtraction.Properties.Items.Add(new ImageComboBoxItem("Not allowed", PdfDocumentDataExtractionPermissions.NotAllowed, 0));
            imageComboBoxDataExtraction.Properties.Items.Add(new ImageComboBoxItem("Accessibility", PdfDocumentDataExtractionPermissions.Accessibility, 0));
            imageComboBoxDataExtraction.Properties.Items.Add(new ImageComboBoxItem("Allowed", PdfDocumentDataExtractionPermissions.Allowed, 0));
            imageComboBoxDataExtraction.SelectedIndex = 2;
            imageComboBoxModifying.Properties.Items.Add(new ImageComboBoxItem("Not allowed", PdfDocumentModificationPermissions.NotAllowed, 0));
            imageComboBoxModifying.Properties.Items.Add(new ImageComboBoxItem("Document assembling", PdfDocumentModificationPermissions.DocumentAssembling, 0));
            imageComboBoxModifying.Properties.Items.Add(new ImageComboBoxItem("Allowed", PdfDocumentModificationPermissions.Allowed, 0));
            imageComboBoxModifying.SelectedIndex = 2;
            imageComboBoxInteractivity.Properties.Items.Add(new ImageComboBoxItem("Not allowed", PdfDocumentInteractivityPermissions.NotAllowed, 0));
            imageComboBoxInteractivity.Properties.Items.Add(new ImageComboBoxItem("Form filling and signing", PdfDocumentInteractivityPermissions.FormFillingAndSigning, 0));
            imageComboBoxInteractivity.Properties.Items.Add(new ImageComboBoxItem("Allowed", PdfDocumentInteractivityPermissions.Allowed, 0));
            imageComboBoxInteractivity.SelectedIndex = 2;
            Enabled = PdfFileHelper.LoadDocument(pdfViewer, path);
        }
        void OnButtonEncryptClick(object sender, EventArgs e) {
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(path);
                using (SecureString ownerPassword = new SecureString()) {
                    foreach (char c in teOwnerPassword.Text)
                        ownerPassword.AppendChar(c);
                    using (SecureString userPassword = new SecureString()) {
                        foreach (char c in teUserPassword.Text)
                            userPassword.AppendChar(c);
                        PdfEncryptionOptions encryptionOptions = new PdfEncryptionOptions();
                        encryptionOptions.PrintingPermissions = (PdfDocumentPrintingPermissions)imageComboBoxPrinting.EditValue;
                        encryptionOptions.DataExtractionPermissions = (PdfDocumentDataExtractionPermissions)imageComboBoxDataExtraction.EditValue;
                        encryptionOptions.ModificationPermissions = (PdfDocumentModificationPermissions)imageComboBoxModifying.EditValue;
                        encryptionOptions.InteractivityPermissions = (PdfDocumentInteractivityPermissions)imageComboBoxInteractivity.EditValue;
                        encryptionOptions.OwnerPassword = ownerPassword;
                        encryptionOptions.UserPassword = userPassword;
                        PdfFileHelper.Save(documentProcessor, new PdfSaveOptions() { EncryptionOptions = encryptionOptions });
                    }
                }
            }
        }
    }
}
