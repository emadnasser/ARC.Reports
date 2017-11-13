Imports System.Collections
Imports System.ComponentModel
' <comboSpinStyle> <checkEditAdditionalButtons>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials
' </comboSpinStyle> </checkEditAdditionalButtons>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleSpinEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleSpinEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "spinedit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleSpinEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(spinEditSample1)
			ControlUtils.CenterControlInParent(spinEditSample2)
			InitValues()
		End Sub


		Private Sub InitValues()
			updateValues = True
			checkEditFloatValue.Checked = spinEditSample1.Properties.IsFloatValue
			spinEditButtonPos.Value = spinEditSample1.Properties.SpinButtonIndex
			comboSpinStyle.EditValue = spinEditSample1.Properties.SpinStyle.ToString()
			comboFiringMode.EditValue = spinEditSample2.Properties.EditValueChangedFiringMode.ToString()
			checkEditValidate.Checked = spinEditSample2.Properties.ValidateOnEnterKey
			updateValues = False
		End Sub

		' <comboSpinStyle>
		Private Sub comboSpinStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboSpinStyle.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim styles() As SpinStyles = { SpinStyles.Vertical, SpinStyles.Horizontal }
			spinEditSample1.Properties.SpinStyle = styles(comboSpinStyle.SelectedIndex)
		End Sub
		' </comboSpinStyle>

		' <checkEditAdditionalButtons>
		Private Sub checkEditAdditionalButtons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditAdditionalButtons.CheckedChanged
			spinEditButtonPos.Enabled = checkEditAdditionalButtons.Checked
			Dim buttons As EditorButtonCollection = spinEditSample1.Properties.Buttons
			If checkEditAdditionalButtons.Checked Then
				buttons.Add(CreateButton(False, "1"))
				buttons.Add(CreateButton(True, "2"))
				buttons.Add(CreateButton(True, "3"))
			Else
				Do While buttons.Count > 1
					buttons.RemoveAt(buttons.Count - 1)
				Loop
				spinEditSample1.Properties.SpinButtonIndex = 0
				spinEditButtonPos.Value = 0
			End If
		End Sub
		Private Function CreateButton(ByVal isLeft As Boolean, ByVal caption As String) As EditorButton
			Dim button As New EditorButton(ButtonPredefines.Glyph)
			button.Caption = caption
			button.IsLeft = isLeft
			Return button
		End Function
		' </checkEditAdditionalButtons>

		' <spinEditButtonPos>
		Private Sub spinEditButtonPos_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEditButtonPos.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			spinEditSample1.Properties.SpinButtonIndex = CInt(Fix(spinEditButtonPos.Value))
		End Sub
		' </spinEditButtonPos>

		' <comboMaxMin>
		Private Sub comboMaxMin_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboMaxMin.SelectedIndexChanged
			Dim minValues() As Decimal = { -1000, 10, 0 }
			Dim maxValues() As Decimal = { 1000, 99, 12.5D }
			Dim index As Integer = comboMaxMin.SelectedIndex
			spinEditSample1.Properties.MinValue = minValues(index)
			spinEditSample1.Properties.MaxValue = maxValues(index)
		End Sub
		' </comboMaxMin>

		' <comboIncrementValue>
		Private Sub comboIncrementValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboIncrementValue.SelectedIndexChanged
			Dim increments() As Decimal = { 10, 1, 0.5D, 0.1D }
			Dim index As Integer = comboIncrementValue.SelectedIndex
			spinEditSample1.Properties.Increment = increments(index)
		End Sub
		' </comboIncrementValue>

		' <checkEditFloatValue>
		Private Sub checkEditFloatValue_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditFloatValue.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			spinEditSample1.Properties.IsFloatValue = checkEditFloatValue.Checked
		End Sub
		' </checkEditFloatValue>

		' <comboFiringMode>
		Private Sub comboFiringMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboFiringMode.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim mode() As EditValueChangedFiringMode = { EditValueChangedFiringMode.Buffered, EditValueChangedFiringMode.Default }
			Dim index As Integer = comboFiringMode.SelectedIndex
			spinEditSample2.Properties.EditValueChangedFiringMode = mode(index)
		End Sub
		' </comboFiringMode>

		' <checkEditValidate>
		Private Sub checkEditValidate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditValidate.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			spinEditSample2.Properties.ValidateOnEnterKey = checkEditValidate.Checked
		End Sub
		' </checkEditValidate>

		' <spinEditSample2>
		Private Sub spinEditSample2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEditSample2.EditValueChanged
			meFiringEvents.Text = String.Format("EditValueChanged: {0}", spinEditSample2.EditValue)
		End Sub
		' </spinEditSample2>

		' <checkEditValidate>
		Private Sub spinEditSample2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEditSample2.Validated
			meFiringEvents.Text = String.Format("Validated: {0}", spinEditSample2.EditValue)
		End Sub
		' </checkEditValidate>
	End Class
End Namespace

