using System;
using System.Web.Configuration;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class UploadControl_UploadToDropbox : System.Web.UI.Page {
    bool IsDropboxAccessTokenValueDefined {
        get {
            return !string.IsNullOrEmpty(UploadingUtils.GetDropboxAccessTokenValue());
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsDropboxAccessTokenValueDefined) {
            MainContainer.InnerHtml = string.Format(
                "To run the demo locally, register your Dropbox account using the AccountManager.RegisterDropbox() method in the global.asax file. " +
                "Or you can see this demo online at <a href='{0}'>{0}</a>.",
                "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/UploadControl/UploadToDropbox.aspx");
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
        DropboxFileSystemProvider provider = new DropboxFileSystemProvider("");
        provider.AccountName = UploadControl.DropboxSettings.AccountName;
        FileManagerFile file = new FileManagerFile(provider, fileName);
        FileManagerFile[] files = new FileManagerFile[] { file };
        return provider.GetDownloadUrl(files);
    }

    void RemoveFileWithDelay(string keyFileName, int delay) {
        UploadingUtils.RemoveFileFromDropboxWithDelay(keyFileName, UploadControl.DropboxSettings.AccountName, delay);
    }
}
