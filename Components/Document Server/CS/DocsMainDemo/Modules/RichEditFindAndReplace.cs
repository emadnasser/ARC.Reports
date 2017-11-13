using System;
using DevExpress.DXperience.Demos;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace DevExpress.Docs.Demos {
    public partial class RichEditFindAndReplace : TutorialControlBase {
        PrintableComponentLinkBase link;
        RichEditDocumentServer documentServer;
        List<DocumentRange> prevRanges;
        System.Drawing.Color activeTextColor = System.Drawing.Color.FromArgb(180, 201, 233);

        public RichEditFindAndReplace() {
            InitializeComponent();

            this.documentServer = new RichEditDocumentServer();
            string path = DemoUtils.GetRelativePath("Search.rtf");
            this.documentServer.LoadDocument(path, DocumentFormat.Rtf);

            this.printPreviewControl.PrintingSystem = new DevExpress.XtraPrinting.PrintingSystem();
            this.link = new DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(this.printPreviewControl.PrintingSystem);
            this.documentServer.Options.MailMerge.ViewMergedData = true;
            prevRanges = new List<DocumentRange>();
            Load += MailMerge_Load;
        }
        void MailMerge_Load(object sender, EventArgs e) {
            ProcessSelectedRows();
        }
        void ProcessSelectedRows() {
            link.Component = this.documentServer;
            link.CreateDocument();
        }

        private void findButton_Click(object sender, EventArgs e) {
            ClearPrevSelection();
            FindAll(findTE.Text);
            ProcessSelectedRows();
        }

        private void replaceButton_Click(object sender, EventArgs e) {
            ClearPrevSelection();
            ReplaceAll(findTE.Text, replaceTE.Text);
            ProcessSelectedRows();
        }

        private void ReplaceAll(string strFind, string strReplace) {
            if(!String.IsNullOrEmpty(strFind)) {
                if (strReplace == "null")
                    strReplace = String.Empty;
                DocumentRange[] ranges = documentServer.Document.FindAll(strFind, SearchOptions.None, documentServer.Document.Range);
                for(int i = 0; i < ranges.Length; i++) {
                    documentServer.Document.Replace(ranges[i], strReplace);
                };
                MarkSelection(ranges);
                SavePrevSelection(ranges);
            }
        }
        private void FindAll(string strFind) {
            if(!String.IsNullOrEmpty(strFind)) {
                DocumentRange[] ranges = documentServer.Document.FindAll(strFind, SearchOptions.None, documentServer.Document.Range);
                MarkSelection(ranges);
                SavePrevSelection(ranges);
            }
        }

        void MarkSelection(DocumentRange[] ranges) {
            ChangeSelectionBackColor(ranges, activeTextColor);
        }

        void ClearPrevSelection() {
            ChangeSelectionBackColor(prevRanges, System.Drawing.Color.Empty);
        }

        void ChangeSelectionBackColor(IEnumerable<DocumentRange> ranges, System.Drawing.Color color) {
            foreach (DocumentRange range in ranges)
                ChangeTextBackColor(range, color);
        }

        void SavePrevSelection(DocumentRange[] ranges) {
            prevRanges.Clear();
            prevRanges.AddRange(ranges);
        }

        void ChangeTextBackColor(DocumentRange range, System.Drawing.Color color) {
            CharacterProperties cp = documentServer.Document.BeginUpdateCharacters(range);
            cp.BackColor = color;
            documentServer.Document.EndUpdateCharacters(cp);
        }

        private void btnExport_Click(object sender, EventArgs e) {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|HyperText Markup Language Format (*.htm, *.html)|*.html|Web Archive, single file (*.mht)|*.mht|Word 2007 Document (*.docx)|*.docx|OpenDocument Text Document (*.odt)|*.odt|Word XML Document (*.xml)|*.xml|Electronic Publication (*.epub)|*.epub|Microsoft Word Document (*.doc)|*.doc|Portable Document Format (*.pdf)|*.pdf";
                if(saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                using(Stream stream = saveFileDialog.OpenFile()) {
                    string fileName = saveFileDialog.FileName;
                    if(!string.IsNullOrEmpty(fileName)) {
                        string ext = Path.GetExtension(fileName);
                        if(ext == ".rtf")
                            this.documentServer.SaveDocument(stream, DocumentFormat.Rtf);
                        else if(ext == ".txt")
                            this.documentServer.SaveDocument(stream, DocumentFormat.PlainText);
                        else if(ext == ".htm" || ext == ".html")
                            this.documentServer.SaveDocument(stream, DocumentFormat.Html);
                        else if(ext == ".mht")
                            this.documentServer.SaveDocument(stream, DocumentFormat.Mht);
                        else if(ext == ".docx")
                            this.documentServer.SaveDocument(stream, DocumentFormat.OpenXml);
                        else if(ext == ".odt")
                            this.documentServer.SaveDocument(stream, DocumentFormat.OpenDocument);
                        else if(ext == ".xml")
                            this.documentServer.SaveDocument(stream, DocumentFormat.WordML);
                        else if(ext == ".epub")
                            this.documentServer.SaveDocument(stream, DocumentFormat.ePub);
                        else if(ext == ".doc")
                            this.documentServer.SaveDocument(stream, DocumentFormat.Doc);
                        else if(ext == ".pdf")
                            this.documentServer.ExportToPdf(stream);
                    }
                }
            }
        }
    }
}
