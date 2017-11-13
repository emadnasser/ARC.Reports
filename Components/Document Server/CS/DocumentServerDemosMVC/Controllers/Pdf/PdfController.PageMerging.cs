using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        const string mergeSessionKey = "PdfMergeFiles";
        public static UploadControlValidationSettings MergeValidationSettings = new UploadControlValidationSettings() {
            AllowedFileExtensions = new string[] { ".pdf" },
            MaxFileSize = 4194304
        };
        static string GetCallbackData(string fileName, string url) {
            return String.Format("{0}|{1}", DocumentServerDemoUtils.UploadDirectory + fileName, url);
        }

        List<UploadFileInfo> Files { get { return (List<UploadFileInfo>)Session[mergeSessionKey]; } }

        public ActionResult PageMerging() {
            PdfPageMergingModel model = new PdfPageMergingModel();
            AddFileList();
            return DemoView("PageMerging", model);
        }
        public ActionResult MergeUploadFiles() {
            Session[mergeSessionKey] = new List<UploadFileInfo>();
            UploadControlExtension.GetUploadedFiles("uploader", MergeValidationSettings, UploadMergeComplete);
            AddFileList();
            return null;
        }
        void UploadMergeComplete(object sender, FileUploadCompleteEventArgs e) {
            if (e.UploadedFile.IsValid) {
                UploadedFile uploadedFile = e.UploadedFile;
                string relativeFilePath = DocumentServerDemoUtils.UploadDirectory + uploadedFile.FileName;
                string filePath = MapPath(relativeFilePath);
                string url = (sender as IUrlResolutionService).ResolveClientUrl(relativeFilePath);
                FileInfo info = new FileInfo(filePath);
                using (FileStream streamToWrite = info.OpenWrite())
                    uploadedFile.FileContent.CopyTo(streamToWrite);
                UploadingUtils.RemoveFileWithDelay(e.UploadedFile.FileName, filePath, 5);
                Files.Add(new UploadFileInfo(e.UploadedFile.FileName, filePath, url));
                e.CallbackData = GetCallbackData(uploadedFile.FileName, url);
            }
        }
        public ActionResult MergeAndDownload() {
            Stream stream = new PdfPageMergingModel().GetMergedDocument(Files);
            if (stream != null && stream.Length > 0)
                return DownloadResult(stream);
            return PageMerging();
        }
        void AddFileList() {
            List<UploadFileInfo> fis = Session[mergeSessionKey] as List<UploadFileInfo>;
            if (fis != null) {
                List<string> files = new List<string>();
                foreach (UploadFileInfo fi in fis)
                    files.Add(GetCallbackData(fi.Name, fi.Url));
                ViewBag.FileList = files;
            }
        }
    }
}
