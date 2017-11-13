using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class FileManager_AccessControl : Page
{
    public void fileManager_CustomThumbnail(object sender, FileManagerThumbnailCreateEventArgs e) {
        if(((FileManagerFile)e.Item).Extension == ".xml")
            e.ThumbnailImage.Url = "Images/code.png";
    }
    protected void rblRole_ValueChanged(object sender, EventArgs e) {
        FileManager.SettingsPermissions.Role = (string)rblRole.Value;
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
    void ValidateSiteEdit(FileManagerActionEventArgsBase e) {
        e.Cancel = Utils.IsSiteMode;
        e.ErrorText = Utils.GetReadOnlyMessageText();
    }
}
