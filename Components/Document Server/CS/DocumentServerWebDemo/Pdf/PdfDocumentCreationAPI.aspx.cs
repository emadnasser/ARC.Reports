using System;
using System.Drawing;
using System.Collections.Generic;
using System.Web.Hosting;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfDocumentCreationAPI : Page {
    const float photoLocationX = 100;
    const float photoLocationY = 100;
    const string fontName = "Segoe UI";

    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/Content/PdfDemos.css");
        ASPxWebControl.SetIECompatibilityModeEdge();
    }
    protected void OnDownloadButtonClick(object source, EventArgs e) {
        using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
            documentProcessor.CreateEmptyDocument();
            IList<PdfBookmark> bookmarks = documentProcessor.Document.Bookmarks;
            SolidBrush black = (SolidBrush)Brushes.Black;
            List<Employee> employees = new List<Employee>();
            Employee.FillWithData(employees);
            int photoNumber = 1;
            foreach (Employee employee in employees)
                using (PdfGraphics graphics = documentProcessor.CreateGraphics()) {
                    graphics.UseKerning = true;
                    using (Bitmap photo = new Bitmap(HostingEnvironment.MapPath("~/App_Data/Photo" + photoNumber + ".jpeg")))
                        graphics.DrawImage(photo, new RectangleF(photoLocationX, photoLocationY, photo.Width, photo.Height));
                    photoNumber++;
                    using (Font font = new Font(fontName, 32, FontStyle.Bold | FontStyle.Underline))
                        graphics.DrawString(employee.FirstName + " " + employee.LastName, font, black, 300, 90);
                    using (Font font = new Font(fontName, 20))
                        graphics.DrawString(employee.Title, font, black, 300, 145);
                    using (Font font = new Font(fontName, 14))
                        graphics.DrawString(employee.FirstName.ToLower() + "." + employee.LastName.ToLower()[0] + "@example.com", font, black, 300, 230);
                    PdfBookmark bookmark = new PdfBookmark() { 
                        Title = employee.FirstName + " " + employee.LastName, 
                        Destination = documentProcessor.CreateDestination(documentProcessor.RenderNewPage(PdfPaperSize.Letter, graphics), photoLocationX, photoLocationY) 
                    };
                    bookmarks.Add(bookmark);
                }
            PdfDocumentReponse.SendDocument(Response, documentProcessor, "PDF Document Processor - Document Creation API Demo", "PDF Document Creation API");
        }
    }
}
