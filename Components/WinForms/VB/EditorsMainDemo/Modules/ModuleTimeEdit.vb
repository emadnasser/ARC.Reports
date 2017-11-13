Imports System.Collections
Imports System.ComponentModel
' <radioGroupHourFormat>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Tutorials
' </radioGroupHourFormat>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTimeEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleTimeEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "timeedit.xml"
		End Sub

		Private Sub ModuleTimeEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(timeEditSample)
			timeEditSample.Time = New Date(2005, 01, 07, 22, 54, 32)
			SetTimeFormat()
		End Sub

		' <comboBoxTimeFormat>
		' <radioGroupHourFormat> <teMask>
		Private Sub SetTimeFormat()
			Dim timeFormats() As String = { "hh:mm:ss tt", "hh:mm tt", "hh tt", "HH:mm:ss", "HH:mm", "HH"}
			Dim index As Integer = comboBoxTimeFormat.SelectedIndex + radioGroupHourFormat.SelectedIndex * 3
			timeEditSample.Properties.Mask.EditMask = timeFormats(index)
			teMask.Text = timeEditSample.Properties.Mask.EditMask
		End Sub
		' </comboBoxTimeFormat> </teMask>
		Private Sub radioGroupHourFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroupHourFormat.SelectedIndexChanged
			SetTimeFormat()
		End Sub
		' </radioGroupHourFormat>

		' <comboBoxTimeFormat>
		Private Sub comboBoxTimeFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxTimeFormat.SelectedIndexChanged
			SetTimeFormat()
		End Sub
		' </comboBoxTimeFormat>
		' <comboBoxTimeEditStyle>
		Private Sub comboBoxTimeEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxTimeEditStyle.SelectedIndexChanged
			If comboBoxTimeEditStyle.SelectedIndex = 0 Then
				timeEditSample.Properties.TimeEditStyle = TimeEditStyle.SpinButtons
			Else
				timeEditSample.Properties.TimeEditStyle = TimeEditStyle.TouchUI
			End If
		End Sub
		' </comboBoxTimeEditStyle>
	End Class
End Namespace
