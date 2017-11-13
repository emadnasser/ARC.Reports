using DevExpress.Pdf;
using System;
using System.Collections.Generic;
using System.IO;

namespace DevExpress.Web.Demos {
    public class PdfModelBase : List<PdfPageModel>, IDisposable {
        readonly PdfDocumentProcessor processor;
        MemoryStream stream;

        public MemoryStream Stream { get { return stream; } }
        protected PdfDocumentProcessor Processor { get { return processor; } }
        protected PdfDocument Document { get { return processor.Document; } }

        public PdfModelBase() {
            processor = new PdfDocumentProcessor();
        }
        protected void CreateEmptyDocument() {
            stream = new MemoryStream();
            Processor.CreateEmptyDocument(stream);
            Document.Creator = "PDF Document Processor Demo";
            Document.Producer = "Developer Express Inc., " + AssemblyInfo.Version;
            Document.Author = "DevExpress Inc.";
        }
        public virtual void LoadDocument(byte[] data) {
            using (MemoryStream stream = new MemoryStream(data))
                LoadDocument(stream);
        }
        protected void LoadDocument(Stream stream) {
            processor.LoadDocument(stream, true);
            for (int pageNumber = 1; pageNumber <= processor.Document.Pages.Count; pageNumber++)
                Add(new PdfPageModel(processor, pageNumber));
        }
        public void Dispose() {
            if (processor != null)
                processor.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
