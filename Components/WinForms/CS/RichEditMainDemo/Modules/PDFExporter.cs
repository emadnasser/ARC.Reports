using System;
using System.IO;
using DevExpress.XtraRichEdit.Internal;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class PDFExporterModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public PDFExporterModule() {
            InitializeComponent();

            pdfViewer.DetachStreamAfterLoadComplete = true;
            OpenXmlLoadHelper.Load("pdfExample.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }

        void richEditControl_DocumentLoaded(object sender, EventArgs e) {
            ExportToPdf();
        }

        void richEditControl_EmptyDocumentCreated(object sender, EventArgs e) {
            pdfViewer.DocumentFilePath = string.Empty;
        }

        private void exportToPdfBarButtonItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            ExportToPdf();
        }

        void ExportToPdf() {
            using(MemoryStream pdfStream = new MemoryStream()) {
                richEditControl.ExportToPdf(pdfStream);
                pdfStream.Position = 0;
                pdfViewer.LoadDocument(pdfStream);
            }
        }
    }
}
