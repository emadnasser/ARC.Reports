using System;
using System.IO;
using DevExpress.DXperience.Demos;
using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;

namespace DevExpress.Docs.Demos {
    public partial class PdfFormFlattening : TutorialControlBase {
        static readonly string path = DemoUtils.GetRelativePath("FormDemo.pdf");

        PdfDocumentProcessor documentProcessor;
        PdfFileHelper fileHelper;

        public override bool NoGap { get { return true; } }

        public PdfFormFlattening() {
            InitializeComponent();
            documentProcessor = new PdfDocumentProcessor();
            fileHelper = new PdfFileHelper(documentProcessor, pdfViewer);
            Enabled = fileHelper.LoadDocument(path, true);
        }
        void FlattenFormFieldsClick(object sender, EventArgs e) {
            using (Stream sourceStream = new MemoryStream()) {
                pdfViewer.SaveDocument(sourceStream);
                documentProcessor.LoadDocument(sourceStream);
                documentProcessor.FlattenForm();
                using (Stream stream = new MemoryStream()) {
                    documentProcessor.SaveDocument(stream, true);
                    stream.Position = 0;
                    pdfViewer.LoadDocument(stream);
                }
            }
        }
        void DocumentClosing(object sender, PdfDocumentClosingEventArgs e) {
        }
        void OpenClick(object sender, EventArgs e) {
            fileHelper.OpenFile();
        }
        void SaveClick(object sender, EventArgs e) {
            PdfFileHelper.Save(documentProcessor);
        }
        void LoadDemoDocumentClick(object sender, EventArgs e) {
            Enabled = PdfFileHelper.LoadDocument(pdfViewer, path);
        }
    }
}
