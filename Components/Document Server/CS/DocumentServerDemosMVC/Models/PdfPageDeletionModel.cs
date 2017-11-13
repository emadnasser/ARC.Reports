using System.IO;

namespace DevExpress.Web.Demos {
    public class PdfPageDeletionModel : PdfModelBase {
        public byte[] DeletePage(int pageNumber) {
            if (Processor.Document.Pages.Count > 0)
                Processor.DeletePage(pageNumber);
            using (MemoryStream stream = new MemoryStream()) {
                Processor.SaveDocument(stream);
                stream.Position = 0;
                Clear();
                LoadDocument(stream);
                return stream.GetBuffer();
            }
        }
    }
}
