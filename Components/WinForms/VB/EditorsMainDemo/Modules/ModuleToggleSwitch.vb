Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleToggleSwitch
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleToggleSwitch.vb"
			TutorialInfo.WhatsThisXMLFile = "toggleSwitch.xml"
		End Sub
		'<tsTextOn>
		Private Sub OnTextChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles tsTextOn.EditValueChanging
			toggleSwitch.Properties.OnText = e.NewValue.ToString()
		End Sub
		'</tsTextOn>
		'<tsTextOff>
		Private Sub OffTextChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles tsTextOff.EditValueChanging
			toggleSwitch.Properties.OffText = e.NewValue.ToString()
		End Sub
		'</tsTextOff>
		'<btnToggleState>
		Private Sub btnToggleState_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnToggleState.Click
			toggleSwitch.IsOn = Not toggleSwitch.IsOn
		End Sub
		'</btnToggleState>
		'<tsAllowHTMLString>
		Private Sub tsAllowHTMLString_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAllowHTMLString.CheckedChanged
			toggleSwitch.Properties.AllowHtmlDraw = If(tsAllowHTMLString.Checked, DefaultBoolean.True, DefaultBoolean.False)
			SetToggleSwitchText()
		End Sub
		'</tsAllowHTMLString>
		'<tsAllowMnemonics>
		Private toggleSwitchOnText As String = "<Color=Blue><b>{0}{1}</b>"
		Private toggleSwitchOffText As String = "<Color=Red><b>{0}{1}</b>"
		Private Sub SetToggleSwitchText()
			Dim prefix As String = If(tsAllowMnemonics.Checked, "&", String.Empty)
			If tsAllowHTMLString.Checked Then
				toggleSwitch.Properties.OnText = String.Format(toggleSwitchOnText, New Object() { prefix, tsTextOn.Text })
				toggleSwitch.Properties.OffText = String.Format(toggleSwitchOffText, New Object() { prefix, tsTextOff.Text })
			Else
				toggleSwitch.Properties.OnText = String.Format(DevExpress.Utils.Text.StringPainter.Default.RemoveFormat(toggleSwitchOnText), New Object() { prefix, tsTextOn.Text })
				toggleSwitch.Properties.OffText = String.Format(DevExpress.Utils.Text.StringPainter.Default.RemoveFormat(toggleSwitchOffText), New Object() { prefix, tsTextOff.Text })
			End If
		End Sub
		Private Sub tsAllowMnemonics_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAllowMnemonics.CheckedChanged
			SetToggleSwitchText()
		End Sub
		'</tsAllowMnemonics>
		Private Sub tsResize(ByVal sender As Object, ByVal e As System.EventArgs) Handles toggleSwitch.Resize
			SetToggleSwitchText()
		End Sub
		'<comboAlign>
		Private Sub comboAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboAlign.SelectedIndexChanged
			Dim alignments() As HorzAlignment = { HorzAlignment.Near, HorzAlignment.Center, HorzAlignment.Far }
			Dim selectedIndex As Integer = comboAlign.SelectedIndex
			toggleSwitch.Properties.GlyphAlignment = alignments(selectedIndex)
			toggleSwitch.Properties.Appearance.TextOptions.HAlignment = alignments(selectedIndex)
		End Sub
		'</comboAlign>
		'<tsAllowThumbAnimation>
		Private Sub tsAllowThumbAnimation_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsAllowThumbAnimation.CheckedChanged
			toggleSwitch.Properties.AllowThumbAnimation = tsAllowThumbAnimation.Checked
		End Sub
		'</tsAllowThumbAnimation>
	End Class
End Namespace
