Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleMarqueeProgressBar
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged
			UpdateSkinInfo()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleMarqueeProgressBar.vb"
			TutorialInfo.WhatsThisXMLFile = "marqueeProgressBar.xml"
		End Sub

		Private Sub UpdateSkinInfo()
			icbProgressViewStyle.Enabled = UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.Skin
		End Sub

		Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateSkinInfo()
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleMarqueeProgressBar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			SetDefaultProgressBarPosition()
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub SetDefaultProgressBarPosition()
			UpdateProgressBarBounds(marqueeProgressBarControl1)
		End Sub

		Private Sub UpdateProgressBarBounds(ByVal progressBar As MarqueeProgressBarControl)
			If progressBar.Properties.ProgressKind = ProgressKind.Horizontal Then
				progressBar.Height = 20
				ControlUtils.HorzAlignControlInParent(progressBar, 16)
			Else
				progressBar.Width = 20
				ControlUtils.VertAlignControlInParent(progressBar, 32)
			End If
			ControlUtils.CenterControlInParent(progressBar)
		End Sub

		Private Sub InitComboBoxes()
			icbProgressViewStyle.Properties.Items.AddEnum(GetType(ProgressViewStyle))
		End Sub

		Private Sub InitValues()
			updateValues = True
			icbProgressViewStyle.EditValue = marqueeProgressBarControl1.Properties.ProgressViewStyle
			spinEditAnimationSpeed.EditValue = marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed
			checkEditVertical.Checked = marqueeProgressBarControl1.Properties.ProgressKind = ProgressKind.Vertical
			checkEditShowTitle.Checked = marqueeProgressBarControl1.Properties.ShowTitle
			checkEditPause.Checked = marqueeProgressBarControl1.Properties.Paused
			teTitle.Text = marqueeProgressBarControl1.Text
			teTitle.Enabled = checkEditShowTitle.Checked
			updateValues = False
		End Sub

		'<checkEditVertical>
		Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditVertical.CheckedChanged
			If updateValues Then
				Return
			End If
			marqueeProgressBarControl1.Properties.ProgressKind = If(checkEditVertical.Checked, ProgressKind.Vertical, ProgressKind.Horizontal)
			UpdateProgressBarBounds(marqueeProgressBarControl1)
		End Sub
		'</checkEditVertical>

		'<checkEditShowTitle>
		Private Sub checkEditShowTitle_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditShowTitle.CheckedChanged
			If updateValues Then
				Return
			End If
			marqueeProgressBarControl1.Properties.ShowTitle = checkEditShowTitle.Checked
			teTitle.Enabled = checkEditShowTitle.Checked
		End Sub
		'</checkEditShowTitle>

		'<checkEditPause>
		Private Sub checkEditPause_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditPause.CheckedChanged
			If updateValues Then
				Return
			End If
			marqueeProgressBarControl1.Properties.Paused = checkEditPause.Checked
		End Sub
		'</checkEditPause>

		'<spinEditAnimationSpeed>
		Private Sub spinEditAnimationSpeed_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEditAnimationSpeed.EditValueChanged
			If updateValues Then
				Return
			End If
			marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed = CInt(Fix(spinEditAnimationSpeed.Value))
		End Sub
		'</spinEditAnimationSpeed>

		'<icbProgressViewStyle>
		Private Sub icbProgressViewStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbProgressViewStyle.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			marqueeProgressBarControl1.Properties.ProgressViewStyle = CType(icbProgressViewStyle.EditValue, ProgressViewStyle)
		End Sub
		'</icbProgressViewStyle>

		'<teTitle>
		Private Sub teTitle_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teTitle.EditValueChanged
			If updateValues Then
				Return
			End If
			marqueeProgressBarControl1.Text = teTitle.Text
		End Sub
		'</teTitle>
	End Class
End Namespace
