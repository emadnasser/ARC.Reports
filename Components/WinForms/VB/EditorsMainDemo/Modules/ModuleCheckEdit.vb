Imports System.Collections
Imports System.ComponentModel
'using System.Drawing;
Imports DevExpress.Tutorials
' <comboAlign>
Imports DevExpress.Utils
' </comboAlign>
' <checkEditRadioGroup>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Text
' </checkEditRadioGroup>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleCheckEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			UpdateCheckStates()
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleCheckEdit.vb"
            TutorialInfo.WhatsThisXMLFile = "checkEdit.xml"
		End Sub

		Private updateValues As Boolean = False

		' <btnToggleState>
		Private Sub btnToggleState_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnToggleState.Click
			checkEditSample.Checked = Not checkEditSample.Checked
		End Sub
		' </btnToggleState>

		' <checkEditAllowGrayed>
		Private Sub checkEditAllowGrayed_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditAllowGrayed.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			checkEditSample.Properties.AllowGrayed = checkEditAllowGrayed.Checked
			UpdateCheckStates()
		End Sub
		' </checkEditAllowGrayed>

		' <comboCheckState>
		Private Sub comboCheckState_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboCheckState.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim states() As CheckState = { CheckState.Checked, CheckState.Unchecked, CheckState.Indeterminate }
			checkEditSample.CheckState = states(comboCheckState.SelectedIndex)
		End Sub
		' </comboCheckState>

		' <comboAlign>
		Private Sub comboAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboAlign.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim alignments() As HorzAlignment = { HorzAlignment.Near, HorzAlignment.Center, HorzAlignment.Far }
			Dim selectedIndex As Integer = comboAlign.SelectedIndex
			checkEditSample.Properties.GlyphAlignment = alignments(selectedIndex)
			checkEditSample.Properties.Appearance.TextOptions.HAlignment = alignments(selectedIndex)
		End Sub
		' </comboAlign>

		Private Sub CreateEditors()
			Dim checkEditCount As Integer = 10
			Dim checkEditDistance As Integer = checkEditSample.Font.Height + 10
			For i As Integer = 0 To checkEditCount - 1
				Dim newCheckEdit As New DevExpress.XtraEditors.CheckEdit()
				newCheckEdit.Text = "Check edit " & (i + 1).ToString()
				newCheckEdit.Parent = gcRadioCheckEdits
				newCheckEdit.Top = i * checkEditDistance + gcRadioCheckEdits.DisplayRectangle.Y + 10
				newCheckEdit.Width = gcRadioCheckEdits.Width - 40
				DevExpress.Tutorials.ControlUtils.CenterControlInParentCustom(newCheckEdit, True, False)
			Next i
		End Sub

		' <checkEditRadioGroup>
		Private Sub checkEditRadioGroup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditRadioGroup.CheckedChanged
			If checkEditRadioGroup.Checked Then
				SetCheckEditsRadioIndex(0)
			Else
				SetCheckEditsRadioIndex(-1)
			End If
			checkEditApplyRadioStyle.Checked = checkEditRadioGroup.Checked
		End Sub
		Private Sub SetCheckEditsRadioIndex(ByVal radioIndex As Integer)
			Dim checkEdits As ArrayList = GetCheckEditControls()
			For Each editor As DevExpress.XtraEditors.CheckEdit In checkEdits
				editor.Checked = False
				editor.Properties.RadioGroupIndex = radioIndex
			Next editor
		End Sub
		' </checkEditRadioGroup>

		' <checkEditApplyRadioStyle>
		Private Sub checkEditApplyRadioStyle_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditApplyRadioStyle.CheckedChanged
			If checkEditApplyRadioStyle.Checked Then
				SetCheckEditsStyle(CheckStyles.Radio)
			Else
				SetCheckEditsStyle(CheckStyles.Standard)
			End If
		End Sub
		Private Sub SetCheckEditsStyle(ByVal style As CheckStyles)
			Dim checkEdits As ArrayList = GetCheckEditControls()
			For Each editor As DevExpress.XtraEditors.CheckEdit In checkEdits
				editor.Properties.CheckStyle = style
			Next editor
		End Sub
		' </checkEditApplyRadioStyle>


		' <btnRemoveEditors> <checkEditRadioGroup> <checkEditApplyRadioStyle>
		Private Function GetCheckEditControls() As ArrayList
			Dim checkEdits As New ArrayList()
			For Each control As Control In gcRadioCheckEdits.Controls
				If TypeOf control Is DevExpress.XtraEditors.CheckEdit Then
					checkEdits.Add(control)
				End If
			Next control
			Return checkEdits
		End Function
		' </btnRemoveEditors> </checkEditRadioGroup> </checkEditApplyRadioStyle>

		Private Sub TutorialModuleCheckEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(checkEditSample)
			CreateEditors()
			InitValues()
			SetCheckBoxText()
		End Sub


		Private Sub InitValues()
			updateValues = True
			checkEditAllowGrayed.Checked = checkEditSample.Properties.AllowGrayed
			comboCheckState.EditValue = checkEditSample.CheckState.ToString()
			checkEditSample.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near
			comboAlign.EditValue = checkEditSample.Properties.Appearance.TextOptions.HAlignment.ToString()
			ceAllowHTMLString.Checked = checkEditSample.Properties.AllowHtmlDraw = DefaultBoolean.True
			updateValues = False
		End Sub

		' <popupCustomImages>
		Private Sub btnApplyImagesOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnApplyImagesOK.Click
			checkEditSample.Properties.PictureChecked = pictureChecked.Image
			checkEditSample.Properties.PictureGrayed = pictureGrayed.Image
			checkEditSample.Properties.PictureUnchecked = pictureUnchecked.Image
			checkEditSample.Properties.CheckStyle = CheckStyles.UserDefined
			editorStyleSwitcher.Text = checkEditSample.Properties.CheckStyle.ToString()
			popupCustomImages.ClosePopup()
		End Sub

		Private Sub btnApplyImagesCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnApplyImagesCancel.Click
			popupCustomImages.ClosePopup()
		End Sub
		' </popupCustomImages>

		' <editorStyleSwitcher>
		Private Sub editorStyleSwitcher_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles editorStyleSwitcher.ButtonClick
            Dim checkStyles As ArrayList = New ArrayList()
            checkStyles.AddRange(New CheckStyles() {DevExpress.XtraEditors.Controls.CheckStyles.Standard, DevExpress.XtraEditors.Controls.CheckStyles.Radio, DevExpress.XtraEditors.Controls.CheckStyles.Style1, DevExpress.XtraEditors.Controls.CheckStyles.Style2, DevExpress.XtraEditors.Controls.CheckStyles.Style3, DevExpress.XtraEditors.Controls.CheckStyles.Style4, DevExpress.XtraEditors.Controls.CheckStyles.Style5, DevExpress.XtraEditors.Controls.CheckStyles.Style6, DevExpress.XtraEditors.Controls.CheckStyles.Style7, DevExpress.XtraEditors.Controls.CheckStyles.Style8, DevExpress.XtraEditors.Controls.CheckStyles.Style9, DevExpress.XtraEditors.Controls.CheckStyles.Style10, DevExpress.XtraEditors.Controls.CheckStyles.Style11, DevExpress.XtraEditors.Controls.CheckStyles.Style12, DevExpress.XtraEditors.Controls.CheckStyles.Style13, DevExpress.XtraEditors.Controls.CheckStyles.Style14, DevExpress.XtraEditors.Controls.CheckStyles.Style15, DevExpress.XtraEditors.Controls.CheckStyles.Style16})
			Dim currentStyleIndex As Integer = checkStyles.IndexOf(checkEditSample.Properties.CheckStyle)
			currentStyleIndex += 1
			If currentStyleIndex = checkStyles.Count Then
				currentStyleIndex = 0
			End If
			checkEditSample.Properties.CheckStyle = CType(checkStyles(currentStyleIndex), CheckStyles)
			editorStyleSwitcher.Text = checkEditSample.Properties.CheckStyle.ToString()
		End Sub
		' </editorStyleSwitcher>

		Private Sub checkEditSample_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditSample.CheckStateChanged
			For Each item As String In comboCheckState.Properties.Items
				If checkEditSample.CheckState.ToString().EndsWith(item) Then
					comboCheckState.Text = item
					Exit For
				End If
			Next item
		End Sub
		'<checkEditAllowMnemonics>
		Private checkEditText As String = "<Color=Blue>{0}Sample<Color=Black> <b>check</b><br>box <image=#info_16x16>"
		Private Sub SetCheckBoxText()
			Dim prefix As String = If(checkEditAllowMnemonics.Checked, "&", String.Empty)
			If ceAllowHTMLString.Checked Then
				checkEditSample.Text = String.Format(checkEditText, prefix)
			Else
				checkEditSample.Text = String.Format(StringPainter.Default.RemoveFormat(checkEditText), prefix)
			End If
		End Sub

		Private Sub checkEditAllowMnemonics_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditAllowMnemonics.CheckedChanged
			SetCheckBoxText()
		End Sub
		'</checkEditAllowMnemonics>
		'<ceAllowHTMLString>
		Private Sub ceAllowHTMLString_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowHTMLString.CheckedChanged
			If updateValues Then
				Return
			End If
			checkEditSample.Properties.AllowHtmlDraw = If(ceAllowHTMLString.Checked, DefaultBoolean.True, DefaultBoolean.False)
			SetCheckBoxText()
		End Sub
		'</ceAllowHTMLString>
		Private Sub UpdateCheckStates()
			comboCheckState.Enabled = checkEditSample.Properties.AllowGrayed
			btnToggleState.Enabled = Not checkEditSample.Properties.AllowGrayed
		End Sub
	End Class
End Namespace

