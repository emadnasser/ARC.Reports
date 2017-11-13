using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Compression;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CompressionController : DemoController {
        public ActionResult Compress() {
            ObtainFileList().Clear();
            return DemoView("Compress");
        }
        public ActionResult CompressUploadFiles() {
            ObtainFileList().Clear();
            UploadControlExtension.GetUploadedFiles("uploader", new UploadControlValidationSettings(), UploadComplete);
            return null;
        }
        void UploadComplete(object sender, FileUploadCompleteEventArgs e) {
            if (!e.IsValid)
                return;
            UploadedFile uploadedFile = e.UploadedFile;
            string relativeFilePath = DocumentServerDemoUtils.UploadDirectory + uploadedFile.FileName;
            string filePath = MapPath(relativeFilePath);
            FileInfo info = new FileInfo(filePath);
            using (FileStream streamToWrite = info.OpenWrite())
                uploadedFile.FileContent.CopyTo(streamToWrite);
            IUrlResolutionService urlResolver = sender as IUrlResolutionService;
            e.CallbackData = String.Format("{0}|{1}", relativeFilePath, urlResolver.ResolveClientUrl(relativeFilePath));
            ObtainFileList().Add(filePath);
        }
        public ActionResult CompressDownloadArchive() {
            List<string> files = ObtainFileList();
            if (files == null)
                return null;
            ZipArchive archive = new ZipArchive();
            foreach (string file in files) {
                archive.AddFile(file, "/");
            }
            Stream stream = new MemoryStream();
            archive.Save(stream);
            stream.Seek(0, SeekOrigin.Begin);
            FileStreamResult result = new FileStreamResult(stream, "application/x-compress");
            result.FileDownloadName = "DocumentServerCompressionDemo.zip";
            return result;
        }
        List<string> ObtainFileList() {
            if (HttpContext.Session["CompressionCompressDemo"] == null) {
                HttpContext.Session["CompressionCompressDemo"] = new List<string>();
            }
            return HttpContext.Session["CompressionCompressDemo"] as List<string>;
        }
        
    }
}
