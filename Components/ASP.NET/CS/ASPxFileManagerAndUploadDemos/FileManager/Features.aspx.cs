using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class FileManager_Features : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            SetEditorsInitialState();
            UpdateLinkedProperties();
        }
        else {
            ApplyFileManagerSettings();
            UpdateLinkedProperties();
        }
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

    void ApplyFileManagerSettings() {
        fileManager.SettingsEditing.AllowMove = cbAllowMove.Checked;
        fileManager.SettingsEditing.AllowDelete = cbAllowDelete.Checked;
        fileManager.SettingsEditing.AllowRename = cbAllowRename.Checked;
        fileManager.SettingsEditing.AllowCreate = cbAllowCreate.Checked;
        fileManager.SettingsEditing.AllowCopy = cbAllowCopy.Checked;
        fileManager.SettingsEditing.AllowDownload = cbAllowDownload.Checked;
        fileManager.SettingsToolbar.ShowPath = cbShowPath.Checked;
        fileManager.SettingsToolbar.ShowFilterBox = cbShowFilterBox.Checked;
        fileManager.SettingsFolders.ShowLockedFolderIcons = cbShowLockedFolderIcons.Checked;
        fileManager.SettingsFolders.ShowFolderIcons = cbShowFolderIcons.Checked;
        fileManager.SettingsFolders.EnableCallBacks = cbFoldersEnableCallBacks.Checked;
        fileManager.SettingsFolders.Visible = cbFoldersVisible.Checked;
        fileManager.SettingsUpload.Enabled = cbUploadEnabled.Checked;
        fileManager.SettingsFileList.ShowFolders = cbFileListShowFolders.Checked;
        fileManager.SettingsFileList.ShowParentFolder = cbFileListShowParentFolder.Checked;
        fileManager.SettingsBreadcrumbs.Visible = cbBreadcrumbsVisible.Checked;
        fileManager.SettingsBreadcrumbs.ShowParentFolderButton = cbBreadcrumbsShowParentFolderButton.Checked;
        fileManager.SettingsBreadcrumbs.Position = (BreadcrumbsPosition)Enum.Parse(typeof(BreadcrumbsPosition),
                                                            cmbBreadcrumbsPosition.SelectedItem.Value.ToString());

        fileManager.SettingsUpload.UseAdvancedUploadMode = cbUploadMultiSelect.Checked;
        fileManager.SettingsUpload.AdvancedModeSettings.EnableMultiSelect = cbUploadMultiSelect.Checked;
    }

    void UpdateLinkedProperties() {
        cbAllowCreate.Enabled = fileManager.SettingsFolders.Visible || fileManager.SettingsFileList.ShowFolders;
        cbAllowMove.Enabled = fileManager.SettingsFolders.Visible || fileManager.SettingsFileList.ShowFolders;
    }

    void SetEditorsInitialState() {
        cbAllowCreate.Checked = fileManager.SettingsEditing.AllowCreate;
        cbAllowDelete.Checked = fileManager.SettingsEditing.AllowDelete;
        cbAllowMove.Checked = fileManager.SettingsEditing.AllowMove;
        cbAllowRename.Checked = fileManager.SettingsEditing.AllowRename;
        cbAllowCopy.Checked = fileManager.SettingsEditing.AllowCopy;
        cbAllowDownload.Checked = fileManager.SettingsEditing.AllowDownload;

        cbShowPath.Checked = fileManager.SettingsToolbar.ShowPath;
        cbShowFilterBox.Checked = fileManager.SettingsToolbar.ShowFilterBox;
        cbShowLockedFolderIcons.Checked = fileManager.SettingsFolders.ShowLockedFolderIcons;
        cbShowFolderIcons.Checked = fileManager.SettingsFolders.ShowFolderIcons;
        cbFoldersEnableCallBacks.Checked = fileManager.SettingsFolders.EnableCallBacks;
        cbFoldersVisible.Checked = fileManager.SettingsFolders.Visible;
        cbUploadEnabled.Checked = fileManager.SettingsUpload.Enabled;
        cbUploadMultiSelect.Checked = fileManager.SettingsUpload.UseAdvancedUploadMode && 
            fileManager.SettingsUpload.AdvancedModeSettings.EnableMultiSelect;
        cbBreadcrumbsVisible.Checked = fileManager.SettingsBreadcrumbs.Visible;
        cbBreadcrumbsShowParentFolderButton.Checked = fileManager.SettingsBreadcrumbs.ShowParentFolderButton;
        cbFileListShowFolders.Checked = fileManager.SettingsFileList.ShowFolders;
        cbFileListShowParentFolder.Checked = fileManager.SettingsFileList.ShowParentFolder;
    }

    void ValidateSiteEdit(FileManagerActionEventArgsBase e) {
        e.Cancel = Utils.IsSiteMode;
        e.ErrorText = Utils.GetReadOnlyMessageText();
    }

}
