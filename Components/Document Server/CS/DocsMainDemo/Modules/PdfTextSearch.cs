using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;
using DevExpress.DXperience.Demos;

namespace DevExpress.Docs.Demos {
    public partial class PdfTextSearch : TutorialControlBase {
        readonly PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
        readonly PdfFileHelper fileHelper;
        PdfTextSearchResultsForm form;

        public override bool NoGap { get { return true; } }

        public PdfTextSearch() {
            InitializeComponent();
            fileHelper = new PdfFileHelper(documentProcessor, pdfViewer);
            Enabled = fileHelper.LoadDocument(DemoUtils.GetRelativePath("TextSearch.pdf"));
        }
        PdfTextSearchResultsForm GetForm() {
            if (form == null || form.IsDisposed)
                form = new PdfTextSearchResultsForm();
            return form;
        }
        void OnDocumentChanged(object sender, PdfDocumentChangedEventArgs e) {
            PdfTextSearchResultsForm form = GetForm();
            if (form.Visible)
                form.Hide();
            buttonSearch.Enabled = !String.IsNullOrEmpty(pdfViewer.DocumentFilePath);
        }
        void OnButtonOpenClick(object sender, EventArgs e) {
            fileHelper.OpenFile();
        }
        void OnButtonSearchClick(object sender, EventArgs e) {
            string textToFind = textEditTextToFind.Text;
            int wordCount = Convert.ToInt32(spinEditWordCount.Value);
            List<string> items = new List<string>();
            try {
                while (documentProcessor.FindText(textToFind).Status == PdfTextSearchStatus.Found) {
                    StringBuilder text = new StringBuilder();
                    for (int i = 0; i < wordCount; i++) {
                        PdfWord nextWord = documentProcessor.NextWord();
                        if (nextWord == null)
                            break;
                        text.Append(nextWord.Text);
                        text.Append(" ");
                    }
                    items.Add(text.ToString());
                }
            }
            catch { }
            PdfTextSearchResultsForm form = GetForm();
            if (form.Visible) {
                form.WindowState = FormWindowState.Normal;
                form.Focus();
            }
            else {
                form.SetItems(items);
                form.Show(this);
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
