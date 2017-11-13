Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class ASPxBinaryImage_Editing
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		PopulateWithEnumValues(Of ElementVisibilityMode)(ButtonPanelVisibility)
		PopulateWithEnumValues(Of BinaryImageButtonPanelPosition)(ButtonPanelPos)
		PopulateWithEnumValues(Of BinaryImageButtonPosition)(ButtonPosition)
		If IsPostBack AndAlso (Not String.IsNullOrEmpty(Request.Params.Get("__EVENTTARGET"))) Then
			BinaryImage.EditingSettings.AllowDropOnPreview = AllowDropOnPreview.Checked
			BinaryImage.EditingSettings.ButtonPanelSettings.Position = GetComboBoxEnumValue(Of BinaryImageButtonPanelPosition)(ButtonPanelPos)
			BinaryImage.EditingSettings.ButtonPanelSettings.Visibility = GetComboBoxEnumValue(Of ElementVisibilityMode)(ButtonPanelVisibility)
			BinaryImage.EditingSettings.ButtonPanelSettings.ButtonPosition = GetComboBoxEnumValue(Of BinaryImageButtonPosition)(ButtonPosition)
		End If
		EnsureSettingsEditors()
	End Sub
	Private Sub EnsureSettingsEditors()
		ButtonPanelVisibility.SelectedIndex = CInt(Fix(BinaryImage.EditingSettings.ButtonPanelSettings.Visibility))
		ButtonPanelPos.SelectedIndex = CInt(Fix(BinaryImage.EditingSettings.ButtonPanelSettings.Position))
		ButtonPanelPos.Enabled = BinaryImage.EditingSettings.ButtonPanelSettings.Visibility <> ElementVisibilityMode.None
		ButtonPosition.SelectedIndex = CInt(Fix(BinaryImage.EditingSettings.ButtonPanelSettings.ButtonPosition))
		ButtonPosition.Enabled = BinaryImage.EditingSettings.ButtonPanelSettings.Visibility <> ElementVisibilityMode.None
		AllowDropOnPreview.Value = BinaryImage.EditingSettings.AllowDropOnPreview
	End Sub
	Private Shared Function GetComboBoxEnumValue(Of T)(ByVal comboBox As ASPxComboBox) As T
		If comboBox.SelectedIndex < 0 Then
			comboBox.SelectedIndex = 1
		End If
		Dim value = CStr(comboBox.Value)
		Return CType(System.Enum.Parse(GetType(T), value), T)
	End Function
	Private Shared Sub PopulateWithEnumValues(Of T)(ByVal comboBox As ASPxComboBox)
		comboBox.DataSource = System.Enum.GetValues(GetType(T))
		comboBox.DataBind()
	End Sub
End Class
