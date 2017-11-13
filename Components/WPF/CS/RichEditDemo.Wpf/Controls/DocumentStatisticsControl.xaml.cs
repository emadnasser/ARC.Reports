using System;
using System.Linq;
using System.Windows.Controls;
using DevExpress.Xpf.Editors;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditDemo.Controls {
    public partial class DocumentStatisticsControl : UserControl {
        readonly SubDocument document;

        public DocumentStatisticsControl(SubDocument document, bool includeTextboxes) {
            InitializeComponent();
            InitializeComponent();
            this.document = document;
            this.edtIncludeTextboxes.IsChecked = includeTextboxes;
            CalculateStatistics();
        }
        public bool IncludeTextboxes { get { return edtIncludeTextboxes.IsChecked.Value; } }

        void IncludeTextboxesEditValueChanged(object sender, EditValueChangedEventArgs e) {
            CalculateStatistics();
        }
        void CalculateStatistics() {
            DocumentIterator iterator = new DocumentIterator(this.document, true);
            StaticsticsVisitor visitor = new StaticsticsVisitor(IncludeTextboxes);
            while (iterator.MoveNext())
                iterator.Current.Accept(visitor);
            this.tbNoSpacesCharactersCount.Text = String.Format("{0,5}", visitor.NoSpacesCharacterCount);
            this.tbWithSpacesCharactersCount.Text = String.Format("{0,5}", visitor.WithSpacesCharacterCount);
            this.tbWordsCount.Text = String.Format("{0,5}", visitor.WordCount);
            this.tbParagraphsCount.Text = String.Format("{0,5}", visitor.ParagraphCount);
        }
    }
    public class StaticsticsVisitor : BufferedDocumentVisitor {
        readonly bool includeTextboxes;
        int noSpacesCharacterCount;
        int withSpacesCharacterCount;
        int wordCount;
        int paragraphCount;

        public StaticsticsVisitor(bool includeTextboxes) {
            this.includeTextboxes = includeTextboxes;
        }

        public int NoSpacesCharacterCount { get { return noSpacesCharacterCount; } }
        public int WithSpacesCharacterCount { get { return withSpacesCharacterCount; } }
        public int WordCount { get { return wordCount; } }
        public int ParagraphCount { get { return paragraphCount; } }

        public override void Visit(DocumentText text) {
            Buffer.Append(text.Text);
        }
        public override void Visit(DocumentTextBox textBox) {
            if (!this.includeTextboxes) return;
            DocumentIterator iterator = textBox.GetIterator(true);
            StaticsticsVisitor visitor = new StaticsticsVisitor(false);
            while (iterator.MoveNext())
                iterator.Current.Accept(visitor);
            this.noSpacesCharacterCount += visitor.NoSpacesCharacterCount;
            this.withSpacesCharacterCount += visitor.WithSpacesCharacterCount;
            this.wordCount += visitor.WordCount;
            this.paragraphCount += visitor.ParagraphCount;
        }
        public override void Visit(DocumentParagraphEnd paragraphEnd) {
            FinishParagraph();
        }
        public override void Visit(DocumentSectionEnd sectionEnd) {
            FinishParagraph();
        }
        void FinishParagraph() {
            string text = Buffer.ToString();
            this.noSpacesCharacterCount += text.Count(c => !Char.IsWhiteSpace(c));
            this.withSpacesCharacterCount += text.Length;
            this.wordCount += text.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (!string.IsNullOrWhiteSpace(text))
                this.paragraphCount++;
            Buffer.Length = 0;
        }
    }
}
