using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using DevExpress.Pdf;

namespace DevExpress.Web.Demos {
    public class PdfPageModel {
        const int viewerWidth = 900;
        readonly PdfDocumentProcessor documentProcessor;
        readonly int pageNumber;

        public PdfPageModel(PdfDocumentProcessor documentProcessor, int pageNumber) {
            this.documentProcessor = documentProcessor;
            this.pageNumber = pageNumber;
        }
        public byte[] GetPageImageBytes() {
            try {
                PdfRectangle pageCropBox = documentProcessor.Document.Pages[pageNumber - 1].CropBox;
                int lagestEdgeLength = pageCropBox.Height > pageCropBox.Width ? Convert.ToInt32(viewerWidth * Math.Min(pageCropBox.Height / pageCropBox.Width, 10)) : viewerWidth;
                using (Bitmap bitmap = documentProcessor.CreateBitmap(pageNumber, lagestEdgeLength))
                    using (MemoryStream stream = new MemoryStream()) {
                        bitmap.Save(stream, ImageFormat.Png);
                        return stream.ToArray();
                    }
            }
            catch {
                return new byte[0];
            }
        }
    }
}
