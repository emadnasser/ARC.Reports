Imports System.Collections
Imports System.ComponentModel
' <icbScrollBars>
Imports DevExpress.XtraEditors.Controls
' </icbScrollBars>
Imports DevExpress.Tutorials


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMemoEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleMemoEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "memoedit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleMemoEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(memoEditSample)
			memoEditSample.Text = "MemoEdit is a multi-line text editor. In addition to the advanced text input features derived from the TextEdit control, it offers numerous options for multi-line text management." & ControlChars.CrLf & ControlChars.CrLf & "- Optional ENTER and TAB key processing." & ControlChars.CrLf & "- Customizable visibility for vertical and horizontal scrollbars." & ControlChars.CrLf & "- Optional text word-wrapping." & ControlChars.CrLf & "- Specifying height in text lines (if used within a container control such as the XtraGrid, XtraTreeList, and XtraVerticalGrid)."
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub InitComboBoxes()
			' <icbScrollBars>
			icbScrollBars.Properties.Items.AddEnum(GetType(ScrollBars))
			' </icbScrollBars>
		End Sub

		Private Sub InitValues()
			updateValues = True
			icbScrollBars.EditValue = memoEditSample.Properties.ScrollBars
			ceWordWrap.Checked = memoEditSample.Properties.WordWrap
			ceReturn.Checked = memoEditSample.Properties.AcceptsReturn
			ceTab.Checked = memoEditSample.Properties.AcceptsTab
			seMaxLength.Value = memoEditSample.Properties.MaxLength
			updateValues = False
		End Sub

		' <icbScrollBars>
		Private Sub icbScrollBars_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbScrollBars.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoEditSample.Properties.ScrollBars = CType(icbScrollBars.EditValue, ScrollBars)
		End Sub
		' </icbScrollBars>

		' <ceWordWrap>
		Private Sub ceWordWrap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceWordWrap.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoEditSample.Properties.WordWrap = ceWordWrap.Checked
		End Sub
		' </ceWordWrap>

		' <ceReturn>
		Private Sub ceReturn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceReturn.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoEditSample.Properties.AcceptsReturn = ceReturn.Checked
		End Sub
		' </ceReturn>

		' <ceTab>
		Private Sub ceTab_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceTab.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoEditSample.Properties.AcceptsTab = ceTab.Checked
		End Sub
		' </ceTab>

		' <seMaxLength>
		Private Sub seMaxLength_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMaxLength.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoEditSample.Properties.MaxLength = Convert.ToInt32(seMaxLength.Value)
		End Sub
		' </seMaxLength>
	End Class
End Namespace

