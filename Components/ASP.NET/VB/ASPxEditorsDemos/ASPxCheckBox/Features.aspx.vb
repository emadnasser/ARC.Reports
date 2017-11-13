Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ASPxComboBox_Features
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxCheckBox.AllowGrayed = AllowGrayedCheckBox.Checked
		ASPxCheckBox.Native = NativeCheckBox.Checked
		ASPxCheckBox.AllowGrayedByClick = AllowGrayedByClickCheckBox.Checked

		If NativeCheckBox.Checked Then
			CustomImagesCheckBox.Enabled = False
			AllowGrayedCheckBox.Enabled = CustomImagesCheckBox.Enabled
			AllowGrayedByClickCheckBox.Enabled = AllowGrayedCheckBox.Enabled
		ElseIf (Not AllowGrayedCheckBox.Checked) Then
			AllowGrayedByClickCheckBox.Enabled = False
		End If

		If CustomImagesCheckBox.Checked Then
			ASPxCheckBox.CheckedImage.Url = "Images/Checked.png"
			ASPxCheckBox.CheckedImage.AlternateText = "Checked"
			ASPxCheckBox.CheckedImage.ToolTip = ASPxCheckBox.CheckedImage.AlternateText
			ASPxCheckBox.UncheckedImage.Url = "Images/Unchecked.png"
			ASPxCheckBox.UncheckedImage.AlternateText = "Unchecked"
			ASPxCheckBox.UncheckedImage.ToolTip = ASPxCheckBox.UncheckedImage.AlternateText
			ASPxCheckBox.GrayedImage.Url = "Images/Grayed.png"
			ASPxCheckBox.GrayedImage.AlternateText = "Indeterminate"
			ASPxCheckBox.GrayedImage.ToolTip = ASPxCheckBox.GrayedImage.AlternateText

			ASPxCheckBox.GrayedImage.Width = 50
			ASPxCheckBox.UncheckedImage.Width = ASPxCheckBox.GrayedImage.Width
			ASPxCheckBox.CheckedImage.Width = ASPxCheckBox.UncheckedImage.Width
			ASPxCheckBox.GrayedImage.Height = 50
			ASPxCheckBox.UncheckedImage.Height = ASPxCheckBox.GrayedImage.Height
			ASPxCheckBox.CheckedImage.Height = ASPxCheckBox.UncheckedImage.Height
			ASPxCheckBox.CssPostfix = "CustomImage"
		End If
	End Sub
	Protected Sub OnSwitchButtonClick(ByVal sender As Object, ByVal e As EventArgs)
		Select Case ASPxCheckBox.CheckState
			Case CheckState.Checked
				ASPxCheckBox.CheckState = CheckState.Unchecked
				Return
			Case CheckState.Unchecked
				ASPxCheckBox.CheckState = If((ASPxCheckBox.AllowGrayed AndAlso (Not ASPxCheckBox.Native)), CheckState.Indeterminate, CheckState.Checked)
				Return
			Case CheckState.Indeterminate
				ASPxCheckBox.CheckState = CheckState.Checked
				Return
		End Select
	End Sub
End Class
