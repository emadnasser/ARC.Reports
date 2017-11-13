using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Hosting;
using DevExpress.Pdf;

namespace DevExpress.Web.Demos {
    public class PdfDocumentCreationAPIModel : PdfModelBase {
        public Stream CreateDocument(string imagePath) {
            const float imageLocationX = 100;
            const float imageLocationY = 100;
            List<Employee> employees = new List<Employee>();
            Employee.FillWithData(employees);
            CreateEmptyDocument();
            Document.Keywords = "PDF, document, server, code, generation, creation API";
            Document.Subject = "PDF Document Processor - Document Creation API Demo";
            Document.Title = "PDF Document Creation API";
            SolidBrush black = (SolidBrush)Brushes.Black;
            foreach (Employee employee in employees) {
                using (PdfGraphics graphics = Processor.CreateGraphics()) {
                    graphics.UseKerning = true;
                    using (Bitmap image = new Bitmap(HostingEnvironment.MapPath("~/App_Data/Photo" + employee.EmployeeID + ".jpeg")))
                        graphics.DrawImage(image, new RectangleF(imageLocationX, imageLocationY, image.Width, image.Height));
                    using (Font font = new Font("Segoe UI", 32, FontStyle.Bold | FontStyle.Underline)) {
                        string name = employee.FirstName + " " + employee.LastName;
                        graphics.DrawString(name, font, black, 300, 90);
                    }
                    using (Font font = new Font("Segoe UI", 20))
                        graphics.DrawString(employee.Title, font, black, 300, 145);
                    using (Font font = new Font("Segoe UI", 14))
                        graphics.DrawString(employee.FirstName.ToLower() + "." + employee.LastName.ToLower()[0] + "@example.com", font, black, 300, 230);
                    int pageNumber = Processor.RenderNewPage(PdfPaperSize.Letter, graphics);
                    PdfDestination destination = Processor.CreateDestination(pageNumber, imageLocationX, imageLocationY);
                    Document.Bookmarks.Add(new PdfBookmark() { Title = employee.FirstName + " " + employee.LastName, Destination = destination });
                }
            }
            Processor.CloseDocument();
            return Stream;
        }
    }
}
