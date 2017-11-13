using System;
using System.Windows.Forms;
using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraSplashScreen;
using DevExpress.DXperience.Demos;

namespace DevExpress.Docs.Demos {
    public partial class PdfTextExtraction : TutorialControlBase {
        readonly PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
        readonly PdfFileHelper fileHelper;
        PdfTextExtractionResultsForm form;

        public override bool NoGap { get { return true; } }

        public PdfTextExtraction() {
            InitializeComponent();
            fileHelper = new PdfFileHelper(documentProcessor, pdfViewer);
            fileHelper.LoadDocument(DemoUtils.GetRelativePath("TextExtraction.pdf"));
        }
        PdfTextExtractionResultsForm GetForm() {
            if (form == null || form.IsDisposed)
                form = new PdfTextExtractionResultsForm();
            return form;
        }
        void OnDocumentChanged(object sender, PdfDocumentChangedEventArgs e) {
            buttonExtractText.Enabled = !String.IsNullOrEmpty(pdfViewer.DocumentFilePath);
            PdfTextExtractionResultsForm form = GetForm();
            if (form.Visible)
                form.Hide();
        }
        void OnButtonOpenClick(object sender, EventArgs e) {
            fileHelper.OpenFile();
        }
        void OnButtonExtractClick(object sender, EventArgs e) {
            SplashScreenManager.ShowDefaultWaitForm("Please wait while", "The text is being extracted");
            string text = String.Empty;
            try {
                text = documentProcessor.Text;
            }
            catch {
            }
            SplashScreenManager.CloseDefaultWaitForm();
            PdfTextExtractionResultsForm form = GetForm();
            if (form.Visible) {
                form.WindowState = FormWindowState.Normal;
                form.Focus();
            }
            else {
                form.SetText(text);
                form.Show();
            }
        }
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null)
                    components.Dispose();
                documentProcessor.Dispose();
                fileHelper.Dispose();
                if (form != null)
                    form.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
