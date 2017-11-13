using System;
using System.IO;
using System.Text;
using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Compression;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CompressionController : DemoController {
        public ActionResult Decompress() {
            return DemoView("Decompress");
        }
        public ActionResult DecompressUploadFiles() {
            ObtainFileList().Clear();
            UploadControlExtension.GetUploadedFiles("uploader", new UploadControlValidationSettings(), DecompressUploadComplete);
            return null;
        }
        void DecompressUploadComplete(object sender, FileUploadCompleteEventArgs e) {
            UploadedFile uploadedFile = e.UploadedFile;
            string relativeFilePath = DocumentServerDemoUtils.UploadDirectory + uploadedFile.FileName;
            string filePath = MapPath(relativeFilePath);
            FileInfo info = new FileInfo(filePath);
            using (FileStream streamToWrite = info.OpenWrite()) { 
                uploadedFile.FileContent.CopyTo(streamToWrite);
                streamToWrite.Flush();
            }
            uploadedFile.FileContent.Seek(0, SeekOrigin.Begin);
            IUrlResolutionService urlResolver = sender as IUrlResolutionService;
            string urlPath = urlResolver.ResolveClientUrl(DocumentServerDemoUtils.UploadDirectory);
            ZipArchive zipArchive = new ZipArchive();
            zipArchive = ZipArchive.Read(e.UploadedFile.FileContent);
            
            foreach (ZipItem item in zipArchive) {
                if ((item.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    continue;
                if (item.EncryptionType != EncryptionType.None) {
                    e.ErrorText = "Encrypted archives are not processed.";
                    e.IsValid = false;
                    return;
                }
                string file = string.Format("{0} ({1}KB)", item.Name, item.UncompressedSize / 1024);
                string fileUri = String.Format("{0}?zipFileName={1}&itemName={2}", Url.Action("DecompressItem", "Compression"), Uri.EscapeDataString(e.UploadedFile.FileName), Uri.EscapeDataString(item.Name));
                e.CallbackData += "#" + file + "|" + fileUri;
            } 
        }
        public ActionResult DecompressItem(string zipFileName, string itemName) {
            string fullZipFilePath = Path.Combine(MapPath(DocumentServerDemoUtils.UploadDirectory), zipFileName);
            ZipArchive zipArchive = ZipArchive.Read(fullZipFilePath);
            UnzipItem unzipItem = zipArchive[itemName] as UnzipItem;
            if (unzipItem == null)
                return new EmptyResult();


            Stream stream = new MemoryStream();
            if (unzipItem.UncompressedSize > 10 * 1024 * 1024) {
                byte[] buf = Encoding.ASCII.GetBytes("Uncompressed file size exceeds the limit (10 MB)");
                stream.Write(buf, 0, buf.Length);
            }
            else { 
                 try {
                     unzipItem.Extract(stream);
                 }
                 catch (Exception ex) {
                     string error = String.Format("Can't decompress file.\n{0}", ex.Message);
                     byte[] buf = Encoding.ASCII.GetBytes(error);
                     stream.Write(buf, 0, buf.Length);
                 }
            }
            if (stream == null)
                return new EmptyResult();
            stream.Seek(0, SeekOrigin.Begin);
            FileStreamResult result = new FileStreamResult(stream, "application/octet-stream");
            result.FileDownloadName = GetFileName(itemName);
            return result;
        }
        string GetFileName(string itemName) {
            int indx = itemName.LastIndexOf('/');
            if (indx < 0)
                return itemName;
            return itemName.Substring(indx + 1);
        }
    }
}
