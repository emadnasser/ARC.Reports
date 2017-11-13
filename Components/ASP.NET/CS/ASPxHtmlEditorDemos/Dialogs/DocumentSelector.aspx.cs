using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class Dialogs_DocumentSelector : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Dialogs/DocumentSelector.html");
            SetEditorsState();
        }
    }

    protected void cbEnableEditing_CheckedChanged(object sender, EventArgs e) {
        bool editingEnabled = ((ASPxCheckBox)sender).Checked;
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowMove = editingEnabled;
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowDelete = editingEnabled;
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowRename = editingEnabled;
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowCreate = editingEnabled;
    }
    protected void cbEnableUpload_CheckedChanged(object sender, EventArgs e) {
        bool uploadEnabled = ((ASPxCheckBox)sender).Checked;
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.UploadSettings.Enabled = uploadEnabled;
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.FoldersSettings.ShowLockedFolderIcons = uploadEnabled;
    }
    protected void cbFileListView_ValueChanged(object sender, EventArgs e) {
        object value = ((ASPxComboBox)sender).Value;
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.FileListSettings.View = (FileListView)(int)value;
    }
    protected void cbShowToolbar_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.ToolbarSettings.Visible = ((ASPxCheckBox)sender).Checked;
    }
    protected void cbShowBreadcrumbs_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.BreadcrumbsSettings.Visible = ((ASPxCheckBox)sender).Checked;
    }

    protected void cbShowOpenInNewWindowButton_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.ShowOpenInNewWindowButton = ((ASPxCheckBox)sender).Checked;
    }
    protected void cbShowEmailAddressSection_CheckedChanged(object sender, EventArgs e) {
        DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.ShowEmailAddressSection = ((ASPxCheckBox)sender).Checked;
    }

    protected void SetEditorsState() {
        cbEnableEditing.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowMove;
        cbEnableUpload.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.UploadSettings.Enabled;
        cbShowToolbar.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.ToolbarSettings.Visible;
        cbShowBreadcrumbs.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.BreadcrumbsSettings.Visible;
        cbFileListView.Value = (int)DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.FileListSettings.View;
        cbShowOpenInNewWindowButton.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.ShowOpenInNewWindowButton;
        cbShowEmailAddressSection.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.ShowEmailAddressSection;
    }

    protected void DemoHtmlEditor_DocumentSelectorFileUploading(object source, FileManagerFileUploadEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void DemoHtmlEditor_DocumentSelectorItemRenaming(object source, FileManagerItemRenameEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void DemoHtmlEditor_DocumentSelectorItemMoving(object source, FileManagerItemMoveEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void DemoHtmlEditor_DocumentSelectorItemDeleting(object source, FileManagerItemDeleteEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void DemoHtmlEditor_DocumentSelectorFolderCreating(object source, FileManagerFolderCreateEventArgs e) {
        ValidateSiteEdit(e);
    }
    protected void ValidateSiteEdit(FileManagerActionEventArgsBase e) {
        e.Cancel = DevExpress.Web.Demos.Utils.IsSiteMode;
        e.ErrorText = DevExpress.Web.Demos.Utils.GetReadOnlyMessageText();
    }
}
