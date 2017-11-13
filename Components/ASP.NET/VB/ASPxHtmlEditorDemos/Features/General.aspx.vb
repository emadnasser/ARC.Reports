Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class Features_General
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/General.html")

			cbAllowScripts.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowScripts
			cbAllowIFrames.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowIFrames
			cbAllowFormElements.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowFormElements
			cbUpdateDeprecatedElements.Checked = DemoHtmlEditor.SettingsHtmlEditing.UpdateDeprecatedElements
			cbUpdateBoldItalic.Checked = DemoHtmlEditor.SettingsHtmlEditing.UpdateBoldItalic
			cbAllowIdAttributes.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowIdAttributes
			cbAllowStyleAttributes.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowStyleAttributes
			cbEnterMode.Value = CInt(Fix(DemoHtmlEditor.SettingsHtmlEditing.EnterMode))
			cmbAllowedDocumentType.Value = CInt(Fix(DemoHtmlEditor.SettingsHtmlEditing.AllowedDocumentType))
			cbAllowCustomColorsInColorPickers.Checked = True
			cbResourcePathMode.Value = CInt(Fix(DemoHtmlEditor.SettingsHtmlEditing.ResourcePathMode))
		Else
			DemoHtmlEditor.SettingsHtmlEditing.AllowScripts = cbAllowScripts.Checked
			DemoHtmlEditor.SettingsHtmlEditing.AllowIFrames = cbAllowIFrames.Checked
			DemoHtmlEditor.SettingsHtmlEditing.AllowFormElements = cbAllowFormElements.Checked
			DemoHtmlEditor.SettingsHtmlEditing.UpdateDeprecatedElements = cbUpdateDeprecatedElements.Checked
			DemoHtmlEditor.SettingsHtmlEditing.UpdateBoldItalic = cbUpdateBoldItalic.Checked
			DemoHtmlEditor.SettingsHtmlEditing.AllowIdAttributes = cbAllowIdAttributes.Checked
			DemoHtmlEditor.SettingsHtmlEditing.EnterMode = CType(CInt(Fix(cbEnterMode.Value)), HtmlEditorEnterMode)
			DemoHtmlEditor.SettingsHtmlEditing.AllowedDocumentType = CType(CInt(Fix(cmbAllowedDocumentType.Value)), AllowedDocumentType)
			DemoHtmlEditor.SettingsHtmlEditing.ResourcePathMode = CType(CInt(Fix(cbResourcePathMode.Value)), ResourcePathMode)

			Dim isEditFullDocumentSwitching As Boolean = DemoHtmlEditor.SettingsHtmlEditing.AllowEditFullDocument <> cbAllowEditFullDocument.Checked
			DemoHtmlEditor.SettingsHtmlEditing.AllowEditFullDocument = cbAllowEditFullDocument.Checked
			If isEditFullDocumentSwitching Then
				DemoHtmlEditor.ActiveView = HtmlEditorView.Html
			End If
		End If
		DemoHtmlEditor.Settings.AllowCustomColorsInColorPickers = cbAllowCustomColorsInColorPickers.Checked
	End Sub
End Class
