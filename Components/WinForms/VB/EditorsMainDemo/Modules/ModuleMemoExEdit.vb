Imports System.Collections
Imports System.ComponentModel
' <icbScrollBars>
Imports DevExpress.XtraEditors.Controls
' </icbScrollBars>
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMemoExEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleMemoExEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "memoeditex.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleMemoExEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(memoExEditSample)
			memoExEditSample.Text = "This control allows end users to edit memo data within the dropdown window. This control is the best choice when you need to save form space or when you want to provide convenient memo editing in container controls like the XtraGrid. The MemoExEdit control combines the features found in the MemoEdit control and the BLOBEditor."
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
			icbScrollBars.EditValue = memoExEditSample.Properties.ScrollBars
			ceIcon.Checked = memoExEditSample.Properties.ShowIcon
			cePopupSizeable.Checked = memoExEditSample.Properties.PopupSizeable
			ceWordWrap.Checked = memoExEditSample.Properties.WordWrap
			ceCustomIcons.Enabled = memoExEditSample.Properties.ShowIcon
			updateValues = False
		End Sub

		' <icbScrollBars>
		Private Sub icbScrollBars_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbScrollBars.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoExEditSample.Properties.ScrollBars = CType(icbScrollBars.EditValue, ScrollBars)
		End Sub
		' </icbScrollBars>

		' <ceIcon>
		Private Sub ceIcon_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceIcon.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoExEditSample.Properties.ShowIcon = ceIcon.Checked
			' <ceCustomIcons>
			ceCustomIcons.Enabled = memoExEditSample.Properties.ShowIcon
			' </ceCustomIcons>
		End Sub
		' </ceIcon>

		' <cePopupSizeable>
		Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cePopupSizeable.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoExEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
		End Sub
		' </cePopupSizeable>

		' <ceWordWrap>
		Private Sub ceWordWrap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceWordWrap.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			memoExEditSample.Properties.WordWrap = ceWordWrap.Checked
		End Sub
		' </ceWordWrap>

		' <ceCustomIcons>
		Private Sub ceCustomIcons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCustomIcons.CheckedChanged
			memoExEditSample.Properties.Images = If(ceCustomIcons.Checked, imageList1, Nothing)
		End Sub
		' </ceCustomIcons>
	End Class
End Namespace

