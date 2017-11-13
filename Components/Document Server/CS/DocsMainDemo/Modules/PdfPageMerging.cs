using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.Pdf;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class PdfPageMerging : TutorialControlBase {
        const string largeFileMessage = "Not enough memory to append a file.";

        readonly PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
        readonly PdfFileHelper fileHelper;

        public override bool NoGap { get { return true; } }

        public PdfPageMerging() {
            InitializeComponent();
            fileHelper = new PdfFileHelper(documentProcessor, pdfViewer);
            Enabled = PdfFileHelper.LoadDocument(pdfViewer, DemoUtils.GetRelativePath("PageMerging.pdf"));
        }
        void OnButtonAppendClick(object sender, EventArgs e) {
            try {
                using (MemoryStream stream = new MemoryStream()) {
                    using (MemoryStream saveStream = new MemoryStream()) {
                        pdfViewer.SaveDocument(saveStream);
                        documentProcessor.LoadDocument(saveStream, true);
                        fileHelper.MergeFile();
                        documentProcessor.SaveDocument(stream);
                        stream.Position = 0;
                        pdfViewer.LoadDocument(stream);
                    }
                    pdfViewer.ScrollVertical(Int32.MaxValue);
                    saveButton.Enabled = true;
                }
            } catch (OutOfMemoryException) {
                XtraMessageBox.Show("Not enough memory to append a document.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            catch { 
            }
        }
        void OnButtonOpenClick(object sender, EventArgs e) {
            fileHelper.OpenFile();
            saveButton.Enabled = true;
        }
        void OnSaveButtonClick(object sender, EventArgs e) {
            PdfFileHelper.Save(documentProcessor);
        }
        void OnNewButtonClick(object sender, EventArgs e) {
            using (MemoryStream stream = new MemoryStream()) {
                documentProcessor.CreateEmptyDocument(stream);
                documentProcessor.CloseDocument();
                stream.Position = 0;
                pdfViewer.LoadDocument(stream);
                saveButton.Enabled = false;
            }
        }
		protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null)
                    components.Dispose();
                documentProcessor.Dispose();
                fileHelper.Dispose();
            }
			base.Dispose(disposing);
		}
    }
}
