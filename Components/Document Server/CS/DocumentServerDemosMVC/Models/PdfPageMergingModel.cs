using System.Collections.Generic;
using System.IO;
using DevExpress.Pdf;

namespace DevExpress.Web.Demos {
    public class PdfPageMergingModel {
        public PdfPageMergingModel() {
        }
        public Stream GetMergedDocument(List<UploadFileInfo> files) {
            MemoryStream stream = new MemoryStream();
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                processor.CreateEmptyDocument(stream);
                foreach (UploadFileInfo file in files)
                    processor.AppendDocument(file.Path);
                processor.Document.Creator = "PDF Document Processor Demo";
                processor.Document.Producer = "Developer Express Inc., " + AssemblyInfo.Version;
                return stream;
            }
        }
    }
}
