using System;
using System.IO;
using DevExpress.Pdf;

namespace DevExpress.Web.Demos {
    public class PdfFileAttachmentModel : PdfModelBase {
        public Stream CreateDocument(string filePath, string attachPath) {
            Processor.LoadDocument(filePath);
            PdfFileAttachment attachment = new PdfFileAttachment();
            attachment.Data = File.ReadAllBytes(attachPath);
            attachment.FileName = "DevExpress.png";
            attachment.Description = "To open the attachment in the Attachments tab, you can either click the 'Open file in its native application' icon or double - click the attachment.";
            attachment.CreationDate = DateTime.Now;
            Processor.AttachFile(attachment);
            PdfDocument document = Processor.Document;
            document.Creator = "PDF Document Processor Demo";
            document.Author = "DevExpress Inc.";
            document.Keywords = "PDF, document, server, code, generation, file atatchment";
            document.Subject = "PDF Document Processor - File Attachment";
            document.Title = "PDF File Attachment";
            document.Producer = "Developer Express Inc., " + AssemblyInfo.Version;
            Stream stream = new MemoryStream();
            Processor.SaveDocument(stream);
            return stream;
        }
    }
}
