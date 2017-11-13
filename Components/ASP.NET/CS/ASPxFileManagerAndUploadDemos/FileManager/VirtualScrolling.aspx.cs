using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class FileManager_VirtualScrolling : System.Web.UI.Page {
    protected void Page_PreInit(object sender, EventArgs e) {
        FileManagmentUtils.EnsureDemoFilesCreated();
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack)
            ApplyFileManagerSettings();
    }

    protected void FileManager_FileUploading(object sender, FileManagerFileUploadEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void FileManager_ItemRenaming(object sender, FileManagerItemRenameEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void FileManager_ItemMoving(object sender, FileManagerItemMoveEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void FileManager_ItemDeleting(object sender, FileManagerItemDeleteEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void FileManager_FolderCreating(object sender, FileManagerFolderCreateEventArgs e) {
        ValidateSiteEdit(e);
    }

    protected void FileManager_ItemCopying(object sender, FileManagerItemCopyEventArgs e) {
        ValidateSiteEdit(e);
    }

    void ValidateSiteEdit(FileManagerActionEventArgsBase e) {
        e.Cancel = Utils.IsSiteMode;
        e.ErrorText = Utils.GetReadOnlyMessageText();
    }

    void ApplyFileManagerSettings() {
        FileManager.SettingsFileList.PageSize = int.Parse(PageSizeComboBox.SelectedItem.Value.ToString());
        FileManager.SettingsFileList.View = (FileListView)Enum.Parse(typeof(FileListView), ViewModeComboBox.SelectedItem.Value.ToString());
    }
}
