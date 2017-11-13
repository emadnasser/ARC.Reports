using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class Dialogs_ImageSelector : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Dialogs/ImageSelector.html");
            SetEditorsState();
        }
    }

    protected void cbEnableEditing_CheckedChanged(object sender, EventArgs e) {
        bool editingEnabled = ((ASPxCheckBox)sender).Checked;
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowMove = editingEnabled;
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowDelete = editingEnabled;
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowRename = editingEnabled;
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowCreate = editingEnabled;
    }
    protected void cbEnableUpload_CheckedChanged(object sender, EventArgs e) {
        bool uploadEnabled = ((ASPxCheckBox)sender).Checked;
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.UploadSettings.Enabled = uploadEnabled;
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FoldersSettings.ShowLockedFolderIcons = uploadEnabled;
    }
    protected void cbMoreOptions_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.ShowMoreOptionsButton = ((ASPxCheckBox)sender).Checked;
    }
    protected void cbShowToolbar_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.ToolbarSettings.Visible = ((ASPxCheckBox)sender).Checked;
    }
    protected void cbShowFoldersArea_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FoldersSettings.Visible = ((ASPxCheckBox)sender).Checked;
    }
    protected void cbFileListView_ValueChanged(object sender, EventArgs e) {
        object value = ((ASPxComboBox)sender).Value;
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FileListSettings.View = (FileListView)(int)value;
    }
    protected void cbShowBreadcrumbs_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.BreadcrumbsSettings.Visible = ((ASPxCheckBox)sender).Checked;
    }

    protected void SetEditorsState() {
        cbEnableEditing.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowMove;
        cbEnableUpload.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.UploadSettings.Enabled;
        cbMoreOptions.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.ShowMoreOptionsButton;
        cbShowToolbar.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.ToolbarSettings.Visible;
        cbShowFoldersArea.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FoldersSettings.Visible;
        cbFileListView.Value = (int)DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FileListSettings.View;
        cbShowBreadcrumbs.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.BreadcrumbsSettings.Visible;
    }

    protected void DemoHtmlEditor_ImageSelectorFileUploading(object source, FileManagerFileUploadEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void DemoHtmlEditor_ImageSelectorItemRenaming(object source, FileManagerItemRenameEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void DemoHtmlEditor_ImageSelectorItemMoving(object source, FileManagerItemMoveEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void DemoHtmlEditor_ImageSelectorItemDeleting(object source, FileManagerItemDeleteEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void DemoHtmlEditor_ImageSelectorFolderCreating(object source, FileManagerFolderCreateEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void ValidateSiteEdit(FileManagerActionEventArgsBase e) {
        e.Cancel = DevExpress.Web.Demos.Utils.IsSiteMode;
        e.ErrorText = DevExpress.Web.Demos.Utils.GetReadOnlyMessageText();
    }
}
