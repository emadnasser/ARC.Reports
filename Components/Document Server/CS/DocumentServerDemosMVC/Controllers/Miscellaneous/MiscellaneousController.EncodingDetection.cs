using System;
using System.IO;
using System.Text;
using System.Web.Mvc;
using DevExpress.Docs.Text;
using DevExpress.Web;
using DevExpress.Web.Internal;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MiscellaneousController : DemoController {
        public ActionResult EncodingDetection() {
            MiscellaneousEncodingDetectionModel model = null;
            using (Stream stream = OpenPredefinedFile(MiscellaneousEncodingDetectionModel.DefaultFileName)) { 
                model = CreateModel(MiscellaneousEncodingDetectionModel.DefaultFileName, String.Empty, stream);
            }
            return DemoView("EncodingDetection", model);
        }
        public ActionResult EncodingDetectionUseDefaultFile(MiscellaneousEncodingDetectionModel model) {
            MiscellaneousEncodingDetectionModel responseModel = null;
            using (Stream stream = OpenPredefinedFile(model.ActivePredefinedFileName)) {
                responseModel = CreateModel(model.ActivePredefinedFileName, String.Empty, stream);
            }
            return Json(responseModel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult EncodingDetectionUploadFile() {
            UploadControlExtension.GetUploadedFiles("uploader", new UploadControlValidationSettings(), EncodingDetectionUploadComplete);
            return null;
        }        
        void EncodingDetectionUploadComplete(object sender, FileUploadCompleteEventArgs e) {
            UploadedFile uploadedFile = e.UploadedFile;
            using (Stream stream = uploadedFile.FileContent) {
                MiscellaneousEncodingDetectionModel model = CreateModel(String.Empty, uploadedFile.FileName, stream);
                string jsonString = HtmlConvertor.ToJSON(model);
                e.CallbackData = jsonString;
            }
        }
        MiscellaneousEncodingDetectionModel CreateModel(string defaultFileName, string userFileName, Stream stream) {
            MiscellaneousEncodingDetectionModel model = new MiscellaneousEncodingDetectionModel();
            model.ActivePredefinedFileName = Path.GetFileName(defaultFileName);
            model.ActiveFileName = Path.GetFileName(userFileName);
            model.TextWithoutEncodingDetection = ReadFileContent(stream);
            model.TextWithEncodingDetection = ReadFileContentWithEncodingDetection(stream);
            Encoding encoding = DetectEncoding(stream);
            if (encoding == null)
                encoding = Encoding.Default;
            model.EncodingName = encoding.EncodingName + " [" + encoding.BodyName + "]";
            return model;
        }
        string ReadFileContent(Stream stream) {
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
        string ReadFileContentWithEncodingDetection(Stream stream) {
            stream.Seek(0, SeekOrigin.Begin);
            Encoding encoding = DetectEncoding(stream);
            if (encoding == null)
                encoding = Encoding.Default;
            StreamReader reader = new StreamReader(stream, encoding);
            return reader.ReadToEnd();
        }
        Encoding DetectEncoding(Stream stream) {
            stream.Seek(0, SeekOrigin.Begin);
            EncodingDetector detector = new EncodingDetector();
            return detector.Detect(stream);
        }
        Stream OpenPredefinedFile(string predefinedFileName) {
            string filePath = Server.MapPath("~/App_Data/EncodingFiles/") + predefinedFileName;
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
                return null;
            return fileInfo.OpenRead();
        }
    }
}
