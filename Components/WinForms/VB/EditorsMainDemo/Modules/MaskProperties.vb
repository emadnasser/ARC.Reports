Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
' <icbAutoComplete>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Mask
' </icbAutoComplete>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class MaskProperties
		Inherits UserControl

		Public ReadOnly Property ActiveProperties() As RepositoryItemTextEdit
			Get
				Return textProperties
			End Get
		End Property
		Public Event PropertyValueChanged As EventHandler

		Public Sub New(ByVal textEdit As TextEdit)
			InitializeComponent()
			InitComboBoxes()
			InitMask(textEdit)
		End Sub

		Private textProperties As RepositoryItemTextEdit
		Private updateValues As Boolean = False

		Public Sub InitMask(ByVal textEdit As TextEdit)
			updateValues = True
			ceUseMaskAsDisplayFormat.Enabled = textEdit IsNot Nothing
			ceShowPlaceHolder.Enabled = ceUseMaskAsDisplayFormat.Enabled
			ceSaveLiteral.Enabled = ceShowPlaceHolder.Enabled
			ceIgnoreMaskBlank.Enabled = ceSaveLiteral.Enabled
			ceBeepOnError.Enabled = ceIgnoreMaskBlank.Enabled
			cbPlaceHolder.Enabled = ceBeepOnError.Enabled
			icbAutoComplete.Enabled = cbPlaceHolder.Enabled
			teEditMask.Enabled = icbAutoComplete.Enabled
			If textEdit IsNot Nothing Then
				Me.textProperties = textEdit.Properties
				lbName.Text = If(textEdit.Tag IsNot Nothing, textEdit.Tag.ToString(), textEdit.Text)
				lbMaskType.Text = textProperties.Mask.MaskType.ToString()
				teEditMask.EditValue = textProperties.Mask.EditMask
				icbAutoComplete.EditValue = textProperties.Mask.AutoComplete
				cbPlaceHolder.EditValue = textProperties.Mask.PlaceHolder
				ceBeepOnError.Checked = textProperties.Mask.BeepOnError
				ceIgnoreMaskBlank.Checked = textProperties.Mask.IgnoreMaskBlank
				ceSaveLiteral.Checked = textProperties.Mask.SaveLiteral
				ceShowPlaceHolder.Checked = textProperties.Mask.ShowPlaceHolders
				ceUseMaskAsDisplayFormat.Checked = textProperties.Mask.UseMaskAsDisplayFormat
			Else
				Me.textProperties = Nothing
				lbName.Text = "No Active Editor"
				lbMaskType.Text = "None"
				cbPlaceHolder.EditValue = ""
				icbAutoComplete.EditValue = cbPlaceHolder.EditValue
				teEditMask.EditValue = icbAutoComplete.EditValue
				ceUseMaskAsDisplayFormat.Checked = False
				ceShowPlaceHolder.Checked = ceUseMaskAsDisplayFormat.Checked
				ceSaveLiteral.Checked = ceShowPlaceHolder.Checked
				ceIgnoreMaskBlank.Checked = ceSaveLiteral.Checked
				ceBeepOnError.Checked = ceIgnoreMaskBlank.Checked
			End If
			updateValues = False
		End Sub
		Private Sub InitComboBoxes()
			' <icbAutoComplete>
			icbAutoComplete.Properties.Items.AddEnum(GetType(AutoCompleteType))
			' </icbAutoComplete>
		End Sub

		Private Sub RaisePropertyValueChanged(ByVal sender As Object)
			RaiseEvent PropertyValueChanged(sender, EventArgs.Empty)
		End Sub

		Private Sub teEditMask_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teEditMask.EditValueChanged
			DoUpdateProperties(sender)
		End Sub

		Private Sub icbAutoComplete_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbAutoComplete.SelectedIndexChanged
			DoUpdateProperties(sender)
		End Sub

		Private Sub cbPlaceHolder_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPlaceHolder.SelectedIndexChanged
			DoUpdateProperties(sender)
		End Sub

		Private Sub ceBeepOnError_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceBeepOnError.CheckedChanged
			DoUpdateProperties(sender)
		End Sub

		Private Sub ceIgnoreMaskBlank_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceIgnoreMaskBlank.CheckedChanged
			DoUpdateProperties(sender)
		End Sub

		Private Sub ceSaveLiteral_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceSaveLiteral.CheckedChanged
			DoUpdateProperties(sender)
		End Sub

		Private Sub ceShowPlaceHolder_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowPlaceHolder.CheckedChanged
			DoUpdateProperties(sender)
		End Sub

		Private Sub ceUseMaskAsDisplayFormat_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceUseMaskAsDisplayFormat.CheckedChanged
			DoUpdateProperties(sender)
		End Sub

		Private Sub DoUpdateProperties(ByVal sender As Object)
			If updateValues OrElse textProperties Is Nothing Then
				Return
			End If
			Try
				textProperties.Mask.EditMask = teEditMask.Text
				textProperties.Mask.AutoComplete = CType(icbAutoComplete.EditValue, AutoCompleteType)
				textProperties.Mask.PlaceHolder = Convert.ToChar(cbPlaceHolder.EditValue)
				textProperties.Mask.BeepOnError = ceBeepOnError.Checked
				textProperties.Mask.IgnoreMaskBlank = ceIgnoreMaskBlank.Checked
				textProperties.Mask.SaveLiteral = ceSaveLiteral.Checked
				textProperties.Mask.ShowPlaceHolders = ceShowPlaceHolder.Checked
			textProperties.Mask.UseMaskAsDisplayFormat = ceUseMaskAsDisplayFormat.Checked
			Catch
			End Try
			RaisePropertyValueChanged(sender)
		End Sub
	End Class
End Namespace
