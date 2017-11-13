using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.Pdf;
using DevExpress.XtraEditors;
using DevExpress.XtraPdfViewer;
using DevExpress.DXperience.Demos;

namespace DevExpress.Docs.Demos {
    public partial class PdfFileAttachmentDemo : TutorialControlBase {
        const string errorMessage = "The operation can't be completed. Please check if the file attachment is available.";
        const string largeAttachmentMessage = "Not enough memory to attach a file.";

        readonly PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
        string tempFileName;

        public override bool NoGap { get { return true; } }

        public PdfFileAttachmentDemo() {
            InitializeComponent();
            try {
                tempFileName = Path.GetTempFileName();
                File.Copy(DemoUtils.GetRelativePath("FileAttachmentDemo.pdf"), tempFileName, true);
                new FileInfo(tempFileName).IsReadOnly = false;
                ReloadDocument();
            }
            catch {
                XtraMessageBox.Show(PdfFileHelper.DemoOpeningErrorMessage, "Error");
                Enabled = false;
            }
        }
        void ReloadDocument() {
            bool navigationPaneVisible = pdfViewer.NavigationPaneVisibility == PdfNavigationPaneVisibility.Visible;
            if (documentProcessor.Document != null) {
                pdfViewer.CloseDocument();
                try {
                    documentProcessor.SaveDocument(tempFileName);
                }
                catch (OutOfMemoryException) {
                    XtraMessageBox.Show(largeAttachmentMessage, "Error");
                }
            }
            pdfViewer.LoadDocument(tempFileName);
            documentProcessor.LoadDocument(tempFileName);
            lbFileAttachments.DataSource = documentProcessor.Document.FileAttachments;
            lbFileAttachments.SelectedIndex = 0;
            if (navigationPaneVisible)
                pdfViewer.NavigationPaneVisibility = PdfNavigationPaneVisibility.Visible;
        }

        void ReloadDocument(Func<bool> action) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                if (action())
                    ReloadDocument();
            }
            catch {
                XtraMessageBox.Show(errorMessage);
            }
            finally {
                Cursor.Current = Cursors.Arrow;
            }
        }
        void OnAttachFile(object sender, EventArgs e) {
            ReloadDocument(AttachFile);
        }
        bool AttachFile() {
            using (OpenFileDialog openDialog = new OpenFileDialog())
                if (openDialog.ShowDialog() == DialogResult.OK) {
                    Cursor.Current = Cursors.WaitCursor;
                    string fileName = openDialog.FileName;
                    byte[] data;
                    try {
                        data = File.ReadAllBytes(fileName);
                    }
                    catch (OutOfMemoryException) {
                        XtraMessageBox.Show(largeAttachmentMessage, "Error");
                        return false;
                    }
                    PdfFileAttachment fileAttachment = new PdfFileAttachment() {
                        FileName = Path.GetFileName(fileName),
                        Data = data,
                        CreationDate = DateTime.Now,
                        Description = "To open the attachment in the Attachments tab, you can either click the 'Open file in its native application' icon or double-click the attachment."
                    };
                    documentProcessor.AttachFile(fileAttachment);
                    return true;
                }
            return false;
        }
        void OnDeleteFile(object sender, EventArgs e) {
            ReloadDocument(DeleteAttachment);
        }
        bool DeleteAttachment() {
            documentProcessor.DeleteAttachment((PdfFileAttachment)lbFileAttachments.SelectedItem);
            return true;
        }
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null)
                    components.Dispose();
                documentProcessor.Dispose();
                pdfViewer.CloseDocument();
                try {
                    File.Delete(tempFileName);
                }
                catch {
                }
            }
            base.Dispose(disposing);
        }

    }
}
