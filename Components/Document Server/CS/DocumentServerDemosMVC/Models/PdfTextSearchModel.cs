using System;
using System.Text;
using DevExpress.Pdf;

namespace DevExpress.Web.Demos {
    public class PdfTextSearchModel : PdfModelBase {
        public string SearchResult { get; private set; }

        public void Search(int wordCount, string findText) {
            StringBuilder text = new StringBuilder();
            try {
                while (Processor.FindText(findText).Status == PdfTextSearchStatus.Found) {
                    for (int i = 0; i < wordCount; i++) {
                        PdfWord nextWord = Processor.NextWord();
                        if (nextWord == null)
                            break;
                        text.Append(nextWord.Text);
                        text.Append(" ");
                    }
                    text.Append(Environment.NewLine);
                }
            }
            catch { }
            SearchResult = text.ToString();
        }
    }
}
