using System.Web.Mvc;
using DevExpress.XtraRichEdit;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Web.Office;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MailMergeController : DemoController {
        public ActionResult MailMergeViaDocumentServer() {
            Session["city"] = "London";
            return DemoView("MailMergeViaDocumentServer");
        }

        [HttpPost]
        public ActionResult OpenMergedFile(string city = "London") {
            string documentId = "mailMergeDocId";
            Session["city"] = city;

            RichEditDocumentServer documentServer = new RichEditDocumentServer();
            documentServer.LoadDocument(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"MailMergeTemplate.docx"));
            documentServer.Options.MailMerge.DataSource = GetData(city);

            using(MemoryStream stream = new MemoryStream()) {
                documentServer.MailMerge(stream, DocumentFormat.OpenXml);
                stream.Position = 0;
                DocumentManager.CloseDocument(documentId);
                return RichEditExtension.Open("RichEdit", documentId, DocumentFormat.OpenXml, () => { return stream; });
            }
        }

        public ActionResult MailMergeViaDocumentServerPartial() {
            return DemoView("MailMergeViaDocumentServerPartial");
        }

        IEnumerable<Employees> GetData(string city) {
            var context = new NorthwindDataContextExt();
            return context.Employees.Where(employee => employee.City == city);
        }
    }
}
