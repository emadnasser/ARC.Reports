using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI;
using DevExpress.Web.Internal;

namespace DevExpress.Web.Demos {
    public class UploadControlDemosHelper {
        public const string UploadDirectory = "~/Content/UploadControl/UploadFolder/";
        public const string DocumentsDirectory = "~/Content/UploadControl/UploadDocuments/";
        public const string TempDirectory = "~/Content/UploadControl/Temp/";
        public const string ThumbnailFormat = "Thumbnail{0}{1}";

        static bool IsAzureAccessKeyDefined {
            get {
                return !string.IsNullOrEmpty(UploadingUtils.GetAzureAccessKey());
            }
        }
        static bool IsAmazonAccessKeyIDDefined {
            get {
                return !string.IsNullOrEmpty(UploadingUtils.GetAmazonAccessKeyID());
            }
        }
        static bool IsAmazonSecretAccessKeyDefined {
            get {
                return !string.IsNullOrEmpty(UploadingUtils.GetAmazonSecretAccessKey());
            }
        }
        static bool IsDropboxAccessTokenValueDefined {
            get {
                return !string.IsNullOrEmpty(UploadingUtils.GetDropboxAccessTokenValue());
            }
        }

        public static readonly UploadControlValidationSettings UploadValidationSettings = new UploadControlValidationSettings {
            AllowedFileExtensions = new string[] { ".jpg", ".jpeg", ".gif", ".png" },
            MaxFileSize = 4194304
        };
        public static UploadControlAzureSettings CreateUploadControlAzureSettings() {
            UploadControlAzureSettings settings = null;
            AzureConnectionInfo connInfo = GetAzureConnectionInfo();
            if(connInfo != null) {
                settings = new UploadControlAzureSettings();
                settings.AccountName = connInfo.AccountName;
                settings.ContainerName = connInfo.ContainerName;
            }
            return settings;
        }
        public static UploadControlAmazonSettings CreateUploadControlAmazonSettings() {
            UploadControlAmazonSettings settings = null;
            AmazonConnectionInfo connInfo = GetAmazonConnectionInfo();
            if(connInfo != null) {
                settings = new UploadControlAmazonSettings();
                settings.AccountName = connInfo.AccountName;
                settings.BucketName = connInfo.BucketName;
                settings.Region = connInfo.Region;
            }
            return settings;
        }
        public static UploadControlDropboxSettings CreateUploadControlDropboxSettings() {
            UploadControlDropboxSettings settings = null;
            DropboxConnectionInfo connInfo = GetDropboxConnectionInfo();
            if(connInfo != null) {
                settings = new UploadControlDropboxSettings();
                settings.AccountName = connInfo.AccountName;
            }
            return settings;
        }

        public static void ucDragAndDrop_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
            if(e.UploadedFile.IsValid) {
                string fileName = Path.ChangeExtension(Path.GetRandomFileName(), ".jpg");
                string resultFilePath = UploadDirectory + fileName;
                using(Image original = Image.FromStream(e.UploadedFile.FileContent))
                using (Image thumbnail = new ImageThumbnailCreator(original).CreateImageThumbnail(new Size(350, 350)))
                    ImageUtils.SaveToJpeg(thumbnail, HttpContext.Current.Request.MapPath(resultFilePath));
                UploadingUtils.RemoveFileWithDelay(fileName, HttpContext.Current.Request.MapPath(resultFilePath), 5);
                IUrlResolutionService urlResolver = sender as IUrlResolutionService;
                if(urlResolver != null)
                    e.CallbackData = urlResolver.ResolveClientUrl(resultFilePath);
            }
        }

        public static void ucMultiSelection_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
            string resultFileName = Path.GetRandomFileName() + "_" + e.UploadedFile.FileName;
            string resultFileUrl = UploadDirectory + resultFileName;
            string resultFilePath = HttpContext.Current.Request.MapPath(resultFileUrl);
            e.UploadedFile.SaveAs(resultFilePath);

            UploadingUtils.RemoveFileWithDelay(resultFileName, resultFilePath, 5);

            IUrlResolutionService urlResolver = sender as IUrlResolutionService;
            if(urlResolver != null) {
                string url = urlResolver.ResolveClientUrl(resultFileUrl);
                e.CallbackData = GetCallbackData(e.UploadedFile, url);
            }
        }
        public static void ucAzureUploader_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
            AzureConnectionInfo azureInfo = GetAzureConnectionInfo();
            RemoveFileFromAzureWithDelay(e.UploadedFile.FileNameInStorage, azureInfo, 5);

            string url = GetAzureImageUrl(e.UploadedFile.FileNameInStorage, azureInfo);
            e.CallbackData = GetCallbackData(e.UploadedFile, url);
        }
        public static void ucAmazonUploader_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
            AmazonConnectionInfo amazonInfo = GetAmazonConnectionInfo();
            RemoveFileFromAmazonWithDelay(e.UploadedFile.FileNameInStorage, amazonInfo, 5);

            string url = GetAmazonImageUrl(e.UploadedFile.FileNameInStorage, amazonInfo);
            e.CallbackData = GetCallbackData(e.UploadedFile, url);
        }
        public static void ucDropboxUploader_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
            DropboxConnectionInfo dropboxInfo = GetDropboxConnectionInfo();
            RemoveFileFromDropboxWithDelay(e.UploadedFile.FileNameInStorage, dropboxInfo, 5);
            
            string url = GetDropboxImageUrl(e.UploadedFile.FileNameInStorage, dropboxInfo);
            e.CallbackData = GetCallbackData(e.UploadedFile, url);
        }

        static string GetCallbackData(UploadedFile uploadedFile, string fileUrl) {
            string name = uploadedFile.FileName;
            long sizeInKilobytes = uploadedFile.ContentLength / 1024;
            string sizeText = sizeInKilobytes.ToString() + " KB";

            return name + "|" + fileUrl + "|" + sizeText;
        }

        public static AzureConnectionInfo GetAzureConnectionInfo() {
            if(!IsAzureAccessKeyDefined)
                return null;
            AzureConnectionInfo connInfo = new AzureConnectionInfo();
            connInfo.AccountName = "UploadAzureAccount";
            connInfo.ContainerName = "uploadcontroldemo";
            return connInfo;
        }
        public static AmazonConnectionInfo GetAmazonConnectionInfo() {
            if(!IsAmazonAccessKeyIDDefined || !IsAmazonSecretAccessKeyDefined)
                return null;
            AmazonConnectionInfo connInfo = new AmazonConnectionInfo();
            connInfo.AccountName = "UploadAmazonAccount";
            connInfo.BucketName = "dxuploaddemo";
            connInfo.Region = "us-east-1";
            return connInfo;
        }
        public static DropboxConnectionInfo GetDropboxConnectionInfo() {
            if(!IsDropboxAccessTokenValueDefined)
                return null;
            DropboxConnectionInfo connInfo = new DropboxConnectionInfo();
            connInfo.AccountName = "UploadDropboxAccount";
            return connInfo;
        }
        static string GetAzureImageUrl(string fileName, AzureConnectionInfo connectionInfo) {
            AzureFileSystemProvider provider = new AzureFileSystemProvider("");
            provider.AccountName = connectionInfo.AccountName;
            provider.ContainerName = connectionInfo.ContainerName;
            FileManagerFile file = new FileManagerFile(provider, fileName);
            FileManagerFile[] files = new FileManagerFile[] { file };
            return provider.GetDownloadUrl(files);
        }
        static string GetAmazonImageUrl(string fileName, AmazonConnectionInfo connectionInfo) {
            AmazonFileSystemProvider provider = new AmazonFileSystemProvider("");
            provider.AccountName = connectionInfo.AccountName;
            provider.BucketName = connectionInfo.BucketName;
            provider.Region = connectionInfo.Region;
            FileManagerFile file = new FileManagerFile(provider, fileName);
            FileManagerFile[] files = new FileManagerFile[] { file };
            return provider.GetDownloadUrl(files);
        }
        static string GetDropboxImageUrl(string fileName, DropboxConnectionInfo connectionInfo) {
            DropboxFileSystemProvider provider = new DropboxFileSystemProvider("");
            provider.AccountName = connectionInfo.AccountName;
            FileManagerFile file = new FileManagerFile(provider, fileName);
            FileManagerFile[] files = new FileManagerFile[] { file };
            return provider.GetDownloadUrl(files);
        }
        static void RemoveFileFromAzureWithDelay(string fileKeyName, AzureConnectionInfo azureInfo, int delay) {
            UploadingUtils.RemoveFileFromAzureWithDelay(fileKeyName, azureInfo.AccountName, azureInfo.ContainerName, delay);
        }
        static void RemoveFileFromAmazonWithDelay(string fileKeyName, AmazonConnectionInfo amazonInfo, int delay) {
            UploadingUtils.RemoveFileFromAmazonWithDelay(fileKeyName, amazonInfo.AccountName, amazonInfo.BucketName, amazonInfo.Region, delay);
        }
        static void RemoveFileFromDropboxWithDelay(string fileKeyName, DropboxConnectionInfo dropboxInfo, int delay) {
            UploadingUtils.RemoveFileFromDropboxWithDelay(fileKeyName, dropboxInfo.AccountName, delay);
        }
    }
}
