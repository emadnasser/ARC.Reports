using System;
using DevExpress.XtraRichEdit.API.Native;
using RichEditDemo.Controls;
using DevExpress.Xpf.Core;

namespace RichEditDemo {
    public partial class DocumentIteratorModule : RichEditDemoModule {
        bool contentChanged;
        bool includeTextboxes;
        System.Timers.Timer exportTimer;

        public DocumentIteratorModule() {
            InitializeComponent();
        }

        bool ContentChanged {
            get {
                lock (this) {
                    return contentChanged;
                }
            }
            set {
                lock (this) {
                    this.contentChanged = value;
                }
            }
        }

        void ExportTimerElapsed(object sender, System.Timers.ElapsedEventArgs e) {
            if (!ContentChanged) return;
            ContentChanged = false;
            exportTimer.Stop();
            Dispatcher.BeginInvoke(new Action(() => { ExportToMarkdown(); }));
        }
        void ExportToMarkdown() {
            MarkdownVisitor visitor = new MarkdownVisitor();
            Iterate(visitor);
            markdown.Text = visitor.Text;
        }
        void Iterate(IDocumentVisitor visitor) {
            DocumentIterator iterator = new DocumentIterator(richEdit.Document, true);
            while (iterator.MoveNext())
                iterator.Current.Accept(visitor);
        }
        void OnRichEditLoaded(object sender, System.Windows.RoutedEventArgs e) {
            exportTimer = new System.Timers.Timer();
            exportTimer.Elapsed += ExportTimerElapsed;
            OpenXmlLoadHelper.Load(@"Markdown.docx", richEdit);
        }
        void OnRichEditContentChanged(object sender, EventArgs e) {
            StartTimer();
        }
        void StartTimer() {
            ContentChanged = true;
            exportTimer.Start();
        }
        void OnDocumentStatistics(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            ShowDocumentStatistics();
        }
        void ShowDocumentStatistics() {
            DocumentStatisticsControl control = new DocumentStatisticsControl(richEdit.Document, this.includeTextboxes);
            FloatingContainerParameters parameters = new FloatingContainerParameters();
            parameters.Title = "Document Statistics";
            parameters.CloseOnEscape = true;
            parameters.AllowSizing = false;
            FloatingContainer.ShowDialogContent(control, this, System.Windows.Size.Empty, parameters, true);
            this.includeTextboxes = control.IncludeTextboxes;
        }
    }
    public class MarkdownVisitor : BufferedDocumentVisitor {
        public string Text { get { return Buffer.ToString(); } }

        public override void Visit(DocumentText text) {
            string prefix = GetPrefix(text.TextProperties);
            Buffer.Append(prefix);
            Buffer.Append(text.Text);
            Buffer.Append(prefix);
        }
        public override void Visit(DocumentParagraphStart paragraphStart) {
            if (paragraphStart.ParagraphProperties.ParagraphStyle.Name == "heading 1")
                Buffer.Append("#");
        }

        public override void Visit(DocumentParagraphEnd paragraphEnd) {
            AppendLineOnNonEmptyContent();
        }
        public override void Visit(DocumentSectionEnd sectionEnd) {
            AppendLineOnNonEmptyContent();
        }
        public override void Visit(DocumentInlinePicture inlinePicture) {
            InsertImageUri(inlinePicture.Uri);
        }
        public override void Visit(DocumentPicture picture) {
            InsertImageUri(picture.Uri);
        }
        public override void Visit(DocumentHyperlinkStart hyperlinkStart) {
            if (!String.IsNullOrEmpty(hyperlinkStart.NavigateUri))
                Buffer.Append("[");
        }
        public override void Visit(DocumentHyperlinkEnd hyperlinkEnd) {
            if (!String.IsNullOrEmpty(hyperlinkEnd.NavigateUri))
                Buffer.Append(String.Format("]({0})", hyperlinkEnd.NavigateUri));
        }
        void InsertImageUri(string uri) {
            if (!string.IsNullOrEmpty(uri))
                Buffer.Append(String.Format("![]({0})", uri));
            else
                Buffer.Append("[[img src=attached-image.jpg alt=foobar]]");
        }
        string GetPrefix(ReadOnlyTextProperties properties) {
            string prefix = string.Empty;
            if (properties.FontBold)
                prefix = "**";
            if (properties.FontItalic)
                prefix += "*";
            if (properties.StrikeoutType == StrikeoutType.Single)
                prefix += "~~";
            return prefix;
        }
        void AppendLineOnNonEmptyContent() {
            if (Buffer.Length > 0)
                Buffer.AppendLine();
        }
    }
}
