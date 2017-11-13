using DevExpress.Pdf;
using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        const string formFlatteningSessionKey = "FormFlatteningFile";
        const string formFlatteningDefaultFile = "~/App_Data/Pdf/FormDemo.pdf";

        public ActionResult FormFlattening() {
            return GetDemoView<PdfFormFlatteningModel>("FormFlattening", formFlatteningSessionKey, formFlatteningDefaultFile);
        }
        public ActionResult FormFlatteningUploadFile() {
            UploadFile(formFlatteningSessionKey);
            return null;
        }
        public ActionResult FlattenFormFields() {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
            using (Stream stream = new MemoryStream((byte[])Session[formFlatteningSessionKey])) {
                processor.LoadDocument(stream);
                processor.FlattenForm();
                Stream outStream = new MemoryStream();
                processor.SaveDocument(outStream);
                return DownloadResult(outStream);
            }
        }
    }
}
