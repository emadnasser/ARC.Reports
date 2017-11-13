using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class FileManager_Overview : System.Web.UI.Page
{
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
