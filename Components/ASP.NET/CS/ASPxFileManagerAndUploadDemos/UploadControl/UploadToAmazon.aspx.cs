using System;
using System.Web.Configuration;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class UploadControl_UploadToAmazon : Page {
    bool IsAmazonAccessKeyIDDefined {
        get {
            return !string.IsNullOrEmpty(UploadingUtils.GetAmazonAccessKeyID());
        }
    }
    bool IsAmazonSecretAccessKeyDefined {
        get {
            return !string.IsNullOrEmpty(UploadingUtils.GetAmazonSecretAccessKey());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsAmazonAccessKeyIDDefined || !IsAmazonSecretAccessKeyDefined) {
            MainContainer.InnerHtml = string.Format(
                "To run the demo locally, register your Amazon account using the AccountManager.RegisterAmazon() method in the global.asax file " +
                "and set the AmazonSettings.BucketName property to your bucket name value. Or you can see this demo online at <a href='{0}'>{0}</a>.",
                "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/UploadControl/UploadToAmazon.aspx");
        }
    }

    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        RemoveFileWithDelay(e.UploadedFile.FileNameInStorage, 5);
        
        string name = e.UploadedFile.FileName;
        string url = GetImageUrl(e.UploadedFile.FileNameInStorage);
        long sizeInKilobytes = e.UploadedFile.ContentLength / 1024;
        string sizeText = sizeInKilobytes.ToString() + " KB";
        e.CallbackData = name + "|" + url + "|" + sizeText;
    }

    string GetImageUrl(string fileName) {
        AmazonFileSystemProvider provider = new AmazonFileSystemProvider("");
        provider.AccountName = UploadControl.AmazonSettings.AccountName;
        provider.BucketName = UploadControl.AmazonSettings.BucketName;
        provider.Region = UploadControl.AmazonSettings.Region;
        FileManagerFile file = new FileManagerFile(provider, fileName);
        FileManagerFile[] files = new FileManagerFile[] { file };
        return provider.GetDownloadUrl(files);
    }

    void RemoveFileWithDelay(string keyFileName, int delay) {
        UploadControlAmazonSettings settings = UploadControl.AmazonSettings;
        UploadingUtils.RemoveFileFromAmazonWithDelay(keyFileName, settings.AccountName,
            settings.BucketName, settings.Region, delay);
    }
}
