using System;

namespace DevExpress.Web.Demos {
    public class PdfTextExtractionModel : PdfModelBase {
        public string ExtractText() {
            string text;
            try {
                text = Processor.Text;
            }
            catch {
                text = String.Empty;
            }
            return text;
        }
    }
}
