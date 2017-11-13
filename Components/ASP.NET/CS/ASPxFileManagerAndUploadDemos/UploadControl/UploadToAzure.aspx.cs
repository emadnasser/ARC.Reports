using System;
using System.Web.Configuration;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class UploadControl_UploadToAzure : Page {
    bool IsAzureAccessKeyDefined {
        get {
            return !string.IsNullOrEmpty(UploadingUtils.GetAzureAccessKey());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsAzureAccessKeyDefined) {
            MainContainer.InnerHtml = string.Format(
                "To run the demo locally, register your Azure account using the AccountManager.RegisterAzure() method in the global.asax file " +
                "and set the AzureSettings.ContainerName property to your container name value. Or you can see this demo online at <a href='{0}'>{0}</a>.",
                "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/UploadControl/UploadToAzure.aspx");
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
        AzureFileSystemProvider provider = new AzureFileSystemProvider("");
        provider.AccountName = UploadControl.AzureSettings.AccountName;
        provider.ContainerName = UploadControl.AzureSettings.ContainerName;
        FileManagerFile file = new FileManagerFile(provider, fileName);
        FileManagerFile[] files = new FileManagerFile[] { file };
        return provider.GetDownloadUrl(files);
    }

    void RemoveFileWithDelay(string keyFileName, int delay) {
        UploadingUtils.RemoveFileFromAzureWithDelay(keyFileName, UploadControl.AzureSettings.AccountName,
            UploadControl.AzureSettings.ContainerName, delay);
    }
}
