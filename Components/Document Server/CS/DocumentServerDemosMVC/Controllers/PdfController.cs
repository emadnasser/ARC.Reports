using DevExpress.Web.Mvc;
using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController : DemoController {
        public static UploadControlValidationSettings ValidationSettings = new UploadControlValidationSettings() {
            AllowedFileExtensions = new string[] { ".pdf" },
            MaxFileSize = 10485760
        };

        string sessionKey;
        string defaultErrorFile = "~/App_Data/Pdf/Error.pdf";
        PdfModelBase model;

        protected PdfModelBase Model { get { return model; } set { model = value; } }

        public ActionResult Index() {
            return RedirectToAction("PdfTextExtraction");
        }
        public override string Name {
            get { return "Pdf"; }
        }
        public ActionResult DocumentViewPartial(string sessionKey) {
            if(model == null)
                model = new PdfModelBase();
            try {
                model.LoadDocument((byte[])Session[sessionKey]);
            }
            catch {
                byte[] data = LoadDocument(defaultErrorFile);
                model.LoadDocument(data);
                Session[sessionKey] = data;
            }
            ViewBag.CurrentSessionKey = sessionKey;
            return PartialView("PdfFileView", model);
        }
        protected ActionResult DownloadResult(Stream stream) {
            stream.Position = 0;
            Response.AddHeader("content-disposition", "attachment; filename=Result.pdf");
            return new FileStreamResult(stream, "application/pdf");
        }
        T GetModel<T>(string sessionKey, string defaultFileName) where T : PdfModelBase, new() {
            byte[] data;
            if (Session[sessionKey] != null)
                data = (byte[])Session[sessionKey];
            else
                data = LoadDocument(defaultFileName);
            ViewBag.CurrentSessionKey = sessionKey;
            Session[sessionKey] = data;
            T model = new T();
            model.LoadDocument(data);
            return model;
        }
        ActionResult GetDemoView<T>(string methodName, string sessionKey, string defaultFileName) where T : PdfModelBase, new() {
            return DemoView(methodName, GetModel<T>(sessionKey, defaultFileName));
        }
        ActionResult GetPartialView<T>(string methodName, string sessionKey, string defaultFileName) where T : PdfModelBase, new() {
            return PartialView(methodName, GetModel<T>(sessionKey, defaultFileName));
        }
        void UploadFile(string sessionKey) {
            this.sessionKey = sessionKey;
            UploadControlExtension.GetUploadedFiles("uploader", ValidationSettings, UploadComplete);
            ViewBag.CurrentSessionKey = sessionKey;
        }
        void UploadComplete(object sender, FileUploadCompleteEventArgs e) {
            if (e.UploadedFile.IsValid)
                Session[sessionKey] = e.UploadedFile.FileBytes;
        }
        byte[] LoadDocument(string fileName) {
            using (FileStream stream = new FileStream(Server.MapPath(fileName), FileMode.Open, FileAccess.Read)) {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                return bytes;
            }
        }
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
            if (disposing && model != null)
                model.Dispose();
        }
    }
}
