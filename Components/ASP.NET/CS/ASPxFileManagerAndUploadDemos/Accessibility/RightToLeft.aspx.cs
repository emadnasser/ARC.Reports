using System;
using System.Web.UI;
using DevExpress.Web.Demos;
using DevExpress.Web;

public partial class Common_RightToLeft : Page {

    protected decimal GetRatingValue(object value) {
        return value != null ? Decimal.Parse((string)value) : 0;
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
