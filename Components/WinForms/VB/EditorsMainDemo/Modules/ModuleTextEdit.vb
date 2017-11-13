Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Tutorials
' <comboNumericFormat>
' <comboDateFormat>
Imports DevExpress.Utils
' </comboDateFormat>
' </comboNumericFormat>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTextEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleTextEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "textEdit.xml"
		End Sub

		Private rnd As Random
		Private updateValues As Boolean = False

		' <checkEditHideSelection>
		Private Sub checkEditHideSelection_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditHideSelection.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			textEditSample.Properties.HideSelection = checkEditHideSelection.Checked
		End Sub
		' </checkEditHideSelection>

		' <comboBoxSelectCase>
		Private Sub comboBoxSelectCase_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxSelectCase.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim caseStyles() As CharacterCasing = { CharacterCasing.Normal, CharacterCasing.Upper, CharacterCasing.Lower }
			Dim selectedIndex As Integer = comboBoxSelectCase.SelectedIndex
			textEditSample.Properties.CharacterCasing = caseStyles(selectedIndex)
		End Sub
		' </comboBoxSelectCase>

		' <comboBoxPasswordChar>
		Private Sub comboBoxPasswordChar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxPasswordChar.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim passwordChars() As Char = { Char.MinValue, "*"c, "#"c }
			Dim selectedIndex As Integer = comboBoxPasswordChar.SelectedIndex
			textEditSample.Properties.PasswordChar = passwordChars(selectedIndex)
		End Sub
		' </comboBoxPasswordChar>

		' <comboNumericFormat>
		Private Sub comboNumericFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboNumericFormat.SelectedIndexChanged
			UpdateNumericTextEditFormat()
		End Sub
		' </comboNumericFormat>
		' <spinEditDecimalPlaces>
		Private Sub spinEditDecimalPlaces_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEditDecimalPlaces.EditValueChanged
			UpdateNumericTextEditFormat()
		End Sub
		' <comboNumericFormat>
		Private Sub UpdateNumericTextEditFormat()
            Dim formatSpecifiers() As String = {String.Empty, "c", "f", "e", "p", "X"}
			Dim selectedFormat As Integer = comboNumericFormat.SelectedIndex
			If selectedFormat = 0 Then
				textEditNumeric.Properties.DisplayFormat.FormatType = FormatType.None
				textEditNumeric.Properties.DisplayFormat.FormatString = String.Empty
				Return
			End If
			Dim formatString As String = formatSpecifiers(selectedFormat) & spinEditDecimalPlaces.EditValue.ToString()
			textEditNumeric.Properties.DisplayFormat.FormatType = FormatType.Numeric
			textEditNumeric.Properties.DisplayFormat.FormatString = formatString
		End Sub
		' </spinEditDecimalPlaces>
		' </comboNumericFormat>

		' <comboNumericEditValue>
		Private Sub comboNumericEditValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboNumericEditValue.SelectedIndexChanged
			Dim values() As Double = { 0.5, 1, 123.45, -12.34, 100 }
			Dim valueIndex As Integer = comboNumericEditValue.SelectedIndex
			If Math.Floor(values(valueIndex)) - values(valueIndex) = 0 Then
				textEditNumeric.EditValue = Convert.ToInt32(values(valueIndex))
			Else
				textEditNumeric.EditValue = values(valueIndex)
			End If
		End Sub
		' </comboNumericEditValue>

		' <dateEdit>
		Private Sub dateEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateEdit.EditValueChanged
			textEditDate.EditValue = dateEdit.EditValue
		End Sub
		' </dateEdit>

		' <comboDateFormat>
		Private Sub comboDateFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboDateFormat.SelectedIndexChanged
			Dim formatStrings() As String = { "", "d", "D", "t", "T", "f", "g", "s" }
			Dim stringIndex As Integer = comboDateFormat.SelectedIndex
			If formatStrings(stringIndex) = "" Then
				textEditDate.Properties.DisplayFormat.FormatType = FormatType.None
				textEditDate.Properties.DisplayFormat.FormatString = String.Empty
				Return
			End If
			textEditDate.Properties.DisplayFormat.FormatType = FormatType.DateTime
			textEditDate.Properties.DisplayFormat.FormatString = formatStrings(stringIndex)
		End Sub
		' </comboDateFormat>

		Private Sub ModuleTextEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			textEditDate.EditValue = New Date(2005, 3, 30, 14, 54, 32)
			dateEdit.EditValue = textEditDate.EditValue
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(textEditNumeric)
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(textEditDate)
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(textEditSample)
			InitValues()
		End Sub


		Private Sub InitValues()
			updateValues = True
			checkEditHideSelection.Checked = textEditSample.Properties.HideSelection
			comboBoxSelectCase.EditValue = textEditSample.Properties.CharacterCasing.ToString()
			comboBoxPasswordChar.EditValue = textEditSample.Properties.PasswordChar
			updateValues = False
		End Sub

		' <buttonsSelection>
		Private Sub buttonsSelection_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonsSelection.ButtonClick
			If e.Button.Caption = "All" Then
				textEditSample.SelectAll()
			End If
			If e.Button.Caption = "Random" Then
				SetRandomSelection()
			End If
			If e.Button.Caption = "Clear" Then
				textEditSample.SelectionLength = 0
			End If
		End Sub
		Private Sub SetRandomSelection()
			If rnd Is Nothing Then
				rnd = New Random()
			End If
			Dim pos1 As Integer = rnd.Next(textEditSample.Text.Length)
			Dim pos2 As Integer = rnd.Next(textEditSample.Text.Length)
			textEditSample.Select(Math.Min(pos1, pos2), Math.Abs(pos1 - pos2))
		End Sub
		' </buttonsSelection>
	End Class
End Namespace

