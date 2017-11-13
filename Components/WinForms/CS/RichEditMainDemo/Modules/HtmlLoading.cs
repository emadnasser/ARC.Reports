using System;
using System.IO;
using DevExpress.XtraRichEdit.Internal;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class HtmlLoadingModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public HtmlLoadingModule() {
            InitializeComponent();

            IDocumentImportManagerService service = richEditControl.GetService<IDocumentImportManagerService>();
            if (service != null) {
                service.UnregisterImporter(service.GetImporter(DocumentFormat.PlainText));
                service.UnregisterImporter(service.GetImporter(DocumentFormat.Rtf));
                service.UnregisterImporter(service.GetImporter(DocumentFormat.Mht));
                service.UnregisterImporter(service.GetImporter(DocumentFormat.OpenXml));
            }

            HtmlLoadHelper.Load("html_sample.htm", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }

        void richEditControl_DocumentLoaded(object sender, EventArgs e) {
            try {
                string fileName = richEditControl.Options.DocumentSaveOptions.CurrentFileName;
                if (!String.IsNullOrEmpty(fileName)) {
                    webBrowser.Url = new Uri("file://" + fileName);
                    using (StreamReader reader = new StreamReader(fileName)) {
                        edtPlainHtml.Text = reader.ReadToEnd();
                    }
                }
            }
            catch {
            }
        }

        void richEditControl_EmptyDocumentCreated(object sender, EventArgs e) {
            webBrowser.Url = null;
            edtPlainHtml.Text = String.Empty;
        }
    }
}
