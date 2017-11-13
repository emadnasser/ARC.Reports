using System;
using System.IO;
using DevExpress.DXperience.Demos;
using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;

namespace DevExpress.Docs.Demos {
    public partial class PdfPageDeletion : TutorialControlBase {
        readonly PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
        readonly PdfFileHelper fileHelper;

        public override bool NoGap { get { return true; } }

        public PdfPageDeletion() {
            InitializeComponent();
            fileHelper = new PdfFileHelper(documentProcessor, pdfViewer);
        }
        protected override void DoShow() {
            base.DoShow();
            Enabled = fileHelper.LoadDocument(DemoUtils.GetRelativePath("PageDeletion.pdf"), true);
            UpdateButtons();
        }
        void PdfViewerCurrentPageChanged(object sender, PdfCurrentPageChangedEventArgs e) {
            spinEditPageNumber.Value = e.PageNumber;
        }
        void OnButtonDeletePageClick(object sender, EventArgs e) {
            try {
                int page = (int)spinEditPageNumber.Value;
                documentProcessor.DeletePage(page);
                using (Stream stream = new MemoryStream()) {
                    documentProcessor.SaveDocument(stream, true);
                    stream.Position = 0;
                    pdfViewer.LoadDocument(stream);
                    pdfViewer.CurrentPageNumber = page;
                }
                UpdateButtons();
            }
            catch { }
        }
        void OnButtonOpenClick(object sender, EventArgs e) {
            fileHelper.OpenFile();
            UpdateButtons();
        }
        void OnButtonSaveClick(object sender, EventArgs e) {
            PdfFileHelper.Save(documentProcessor);
        }
        void UpdateButtons() {
            int count = documentProcessor.Document.Pages.Count;
            if (count > 0) {
                spinEditPageNumber.Properties.MaxValue = count;
                spinEditPageNumber.Enabled = true;
                buttonDeletePage.Enabled = true;
            }
            else {
                spinEditPageNumber.Enabled = false;
                buttonDeletePage.Enabled = false;
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
