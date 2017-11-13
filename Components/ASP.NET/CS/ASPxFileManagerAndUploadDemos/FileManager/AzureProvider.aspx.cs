using System;
using System.Web.Configuration;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class FileManager_AzureProvider : Page {
    bool IsAzureAccessKeyDefined {
        get {
            return !string.IsNullOrEmpty(FileManagmentUtils.GetAzureAccessKey());
        }
    }

    protected void Page_Init(object sender, EventArgs e) {
        if(!IsAzureAccessKeyDefined) {
            MainContent.InnerHtml = string.Format(
                "To run the demo locally, register your Azure account using the AccountManager.RegisterAzure() method in the global.asax file " +
                "and set the SettingsAzure.ContainerName property to your container name value. Or you can see this demo online at <a href='{0}'>{0}</a>.",
                "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/FileManager/AzureProvider.aspx");
        }
    }

    protected void FileManager_OnCloudProviderRequest(object sender, FileManagerCloudProviderRequestEventArgs e) {
        EventMonitor.TraceEvent(sender, e, FileManager.ProviderType);
    }

    protected void fileManager_FileUploading(object sender, FileManagerFileUploadEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void fileManager_ItemRenaming(object sender, FileManagerItemRenameEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void fileManager_ItemMoving(object sender, FileManagerItemMoveEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void fileManager_ItemDeleting(object sender, FileManagerItemDeleteEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void fileManager_FolderCreating(object sender, FileManagerFolderCreateEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void fileManager_ItemCopying(object sender, FileManagerItemCopyEventArgs e) {
        ValidateSiteEdit(e);
    }

    void ValidateSiteEdit(FileManagerActionEventArgsBase e) {
        e.Cancel = Utils.IsSiteMode;
        e.ErrorText = Utils.GetReadOnlyMessageText();
    }
}
