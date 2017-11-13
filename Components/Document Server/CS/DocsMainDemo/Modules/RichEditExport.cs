using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using System.Collections.Generic;
using DevExpress.DXperience.Demos;
using DevExpress.XtraPrintingLinks;
using System.Runtime.InteropServices;

namespace DevExpress.Docs.Demos {
    public partial class RichEditExport : TutorialControlBase {
        PrintableComponentLinkBase link;
        RichEditDocumentServer documentServer;

        public RichEditExport() {
            InitializeComponent();

            this.printPreviewControl.PrintingSystem = new DevExpress.XtraPrinting.PrintingSystem();
            this.link = new DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(this.printPreviewControl.PrintingSystem);

            this.edtFilePath.Text = DemoUtils.GetRelativePath("MovieRentals.docx");
            this.edtSaveTo.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            LoadDocument();
        }
        private void btnExport_Click(object sender, EventArgs e) {
            string format = ((DevExpress.XtraEditors.SimpleButton)(sender)).Text.ToLower();
            String filePath = edtFilePath.Text;
            String fileName = Path.GetFileNameWithoutExtension(filePath);
            string pathString = edtSaveTo.Text + fileName;
            string resultFilePath = String.Empty;
            if(format == "rtf") {
                resultFilePath = pathString + ".rtf";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.Rtf);
            } else if(format == "txt") {
                resultFilePath = pathString + ".txt";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.PlainText);
            } else if(format == "html") {
                resultFilePath = pathString + ".html";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.Html);
            } else if(format == "mht") {
                resultFilePath = pathString + ".mht";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.Mht);
            } else if(format == "docx") {
                resultFilePath = pathString + ".docx";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.OpenXml);
            } else if(format == "odt") {
                resultFilePath = pathString + ".odt";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.OpenDocument);
            } else if(format == "xml") {
                resultFilePath = pathString + ".xml";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.WordML);
            } else if(format == "epub") {
                resultFilePath = pathString + ".epub";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.ePub);
            } else if(format == "doc") {
                resultFilePath = pathString + ".doc";
                this.documentServer.SaveDocument(resultFilePath, DocumentFormat.Doc);
            } else if(format == "pdf") {
                resultFilePath = pathString + ".pdf";
                using(FileStream stream = new FileStream(resultFilePath, FileMode.Create, FileAccess.Write, FileShare.Read)) {
                    this.documentServer.ExportToPdf(stream);
                }
            }
            if(!String.IsNullOrEmpty(resultFilePath))
                DemoUtils.PreviewDocument(resultFilePath);
        }
        void LoadDocument() {
            if (this.documentServer == null) {
                this.documentServer = new RichEditDocumentServer();
                new RichEditDemoExceptionsHandler(this.documentServer).Install();
            }
            string path = this.edtFilePath.Text;
            this.documentServer.LoadDocument(path);
            this.link.Component = this.documentServer;
            this.link.CreateDocument();
        }
        private void edtFilePath_ButtonClick(object sender, XtraEditors.Controls.ButtonPressedEventArgs e) {
            ChooseFileToOpen(String.Empty);
        }
        void ChooseFileToOpen(string initialPath) {
            using(OpenFileDialog openFileDialog = new OpenFileDialog()) {
                if(!String.IsNullOrEmpty(initialPath))
                    openFileDialog.InitialDirectory = initialPath;
                if(openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                this.edtFilePath.Text = openFileDialog.FileName;
                LoadDocument();
            }
        }
        private void edtFilePath_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode != Keys.Enter)
                return;
            FileInfo fileInfo = new FileInfo(this.edtFilePath.Text);
            if(fileInfo.Exists) {
                LoadDocument();
                return;
            }
            ChooseFileToOpen(this.edtFilePath.Text);
        }
        private void ChooseFolderToSave() {
            using(FolderBrowserDialog openFileDialog = new FolderBrowserDialog()) {
                if(openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                this.edtSaveTo.Text = openFileDialog.SelectedPath;
            }
        }
        private void edtSaveTo_ButtonClick(object sender, XtraEditors.Controls.ButtonPressedEventArgs e) {
            ChooseFolderToSave();
        }
    }

    class RichEditDemoExceptionsHandler {
        readonly RichEditDocumentServer documentServer;
        public RichEditDemoExceptionsHandler(RichEditDocumentServer documentServer) {
            this.documentServer = documentServer;
        }
        public void Install() {
            if (documentServer != null)
                documentServer.UnhandledException += OnRichEditControlUnhandledException;
        }

        protected virtual void OnRichEditControlUnhandledException(object sender, RichEditUnhandledExceptionEventArgs e) {
            try {
                if (e.Exception != null)
                    throw e.Exception;
            }
            catch (RichEditUnsupportedFormatException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            catch (ExternalException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            catch (System.IO.IOException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
