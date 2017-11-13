using System;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;

public partial class Features_General : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/General.html");
            
            cbAllowScripts.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowScripts;
            cbAllowIFrames.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowIFrames;
            cbAllowFormElements.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowFormElements;
            cbUpdateDeprecatedElements.Checked = DemoHtmlEditor.SettingsHtmlEditing.UpdateDeprecatedElements;
            cbUpdateBoldItalic.Checked = DemoHtmlEditor.SettingsHtmlEditing.UpdateBoldItalic;
            cbAllowIdAttributes.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowIdAttributes;
            cbAllowStyleAttributes.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowStyleAttributes;
            cbEnterMode.Value = (int)DemoHtmlEditor.SettingsHtmlEditing.EnterMode;
            cmbAllowedDocumentType.Value = (int)DemoHtmlEditor.SettingsHtmlEditing.AllowedDocumentType;
            cbAllowCustomColorsInColorPickers.Checked = true;
            cbResourcePathMode.Value = (int)DemoHtmlEditor.SettingsHtmlEditing.ResourcePathMode;
        } else {
            DemoHtmlEditor.SettingsHtmlEditing.AllowScripts = cbAllowScripts.Checked;
            DemoHtmlEditor.SettingsHtmlEditing.AllowIFrames = cbAllowIFrames.Checked;
            DemoHtmlEditor.SettingsHtmlEditing.AllowFormElements = cbAllowFormElements.Checked;
            DemoHtmlEditor.SettingsHtmlEditing.UpdateDeprecatedElements = cbUpdateDeprecatedElements.Checked;
            DemoHtmlEditor.SettingsHtmlEditing.UpdateBoldItalic = cbUpdateBoldItalic.Checked;
            DemoHtmlEditor.SettingsHtmlEditing.AllowIdAttributes = cbAllowIdAttributes.Checked;
            DemoHtmlEditor.SettingsHtmlEditing.EnterMode = (HtmlEditorEnterMode)(int)cbEnterMode.Value;
            DemoHtmlEditor.SettingsHtmlEditing.AllowedDocumentType = (AllowedDocumentType)(int)cmbAllowedDocumentType.Value;
            DemoHtmlEditor.SettingsHtmlEditing.ResourcePathMode = (ResourcePathMode)(int)cbResourcePathMode.Value;
            
            bool isEditFullDocumentSwitching = DemoHtmlEditor.SettingsHtmlEditing.AllowEditFullDocument != cbAllowEditFullDocument.Checked;
            DemoHtmlEditor.SettingsHtmlEditing.AllowEditFullDocument = cbAllowEditFullDocument.Checked;
            if(isEditFullDocumentSwitching) {
                DemoHtmlEditor.ActiveView = HtmlEditorView.Html;
            }
        }
        DemoHtmlEditor.Settings.AllowCustomColorsInColorPickers = cbAllowCustomColorsInColorPickers.Checked;
    }
}
