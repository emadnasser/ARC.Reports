Imports System.Collections
Imports System.ComponentModel
' <comboBoxProgressStyle> <checkEditVertical>
Imports DevExpress.XtraEditors.Controls
' </comboBoxProgressStyle> </checkEditVertical>
Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.Utils.Drawing
Imports DevExpress.Tutorials
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleProgressBar
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged
			UpdateSkinInfo()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleProgressBar.vb"
			TutorialInfo.WhatsThisXMLFile = "progressBar.xml"
		End Sub

		Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateSkinInfo()
		End Sub

		Private Sub UpdateSkinInfo()
			comboBoxProgressStyle.Enabled = UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.Skin
			gcColors.Visible = UserLookAndFeel.Default.ActiveStyle <> ActiveLookAndFeelStyle.Skin
		End Sub

		Private increment As Boolean = True
		Private updateValues As Boolean = False
		Private incrementInternal As Boolean = True

		' <btnApplyColors>
		Private Sub btnApplyColors_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnApplyColors.Click
			progressBarSample.Properties.StartColor = colorEditStartColor.Color
			progressBarSample.Properties.EndColor = colorEditEndColor.Color
		End Sub
		' </btnApplyColors>

		' <comboBoxProgressStyle>
		Private Sub comboBoxProgressStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxProgressStyle.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim styles() As ProgressViewStyle = { ProgressViewStyle.Solid, ProgressViewStyle.Broken }
			progressBarSample.Properties.ProgressViewStyle = styles(comboBoxProgressStyle.SelectedIndex)
		End Sub
		' </comboBoxProgressStyle>

		' <checkEditVertical>
		Private Sub checkEditVertical_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditVertical.CheckedChanged
			Dim kind As ProgressKind = ProgressKind.Horizontal
			If checkEditVertical.Checked Then
				kind = ProgressKind.Vertical
			End If
			progressBarSample.Properties.ProgressKind = kind
			UpdateProgressBarBounds(progressBarSample)
		End Sub
		' </checkEditVertical>

		' <checkEditVertical>
		Private Sub UpdateProgressBarBounds(ByVal progressBar As ProgressBarControl)
			If progressBar.Properties.ProgressKind = ProgressKind.Horizontal Then
				progressBar.Height = GetProgressBarSize(progressBar)
				ControlUtils.HorzAlignControlInParent(progressBar, 16)
			Else
				progressBar.Width = GetProgressBarSize(progressBar)
				ControlUtils.VertAlignControlInParent(progressBar, 32)
			End If
			ControlUtils.CenterControlInParent(progressBar)
		End Sub
		' </checkEditVertical>
		Private Function GetProgressBarSize(ByVal progressBar As ProgressBarControl) As Integer
			Return If(progressBar.Properties.ProgressKind = ProgressKind.Vertical AndAlso progressBar.Properties.TextOrientation = TextOrientation.Horizontal, 30, 20)
		End Function
		' <checkEditShowText>
		Private Sub checkEditShowText_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditShowText.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			progressBarSample.Properties.ShowTitle = checkEditShowText.Checked
			checkEditShowPercent.Enabled = checkEditShowText.Checked
			lblTextOrientation.Enabled = checkEditShowText.Checked
			comboBoxTextOrientation.Enabled = checkEditShowText.Checked
		End Sub
		' </checkEditShowText>

		' <checkEditShowPercent>
		Private Sub checkEditShowPercent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditShowPercent.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			progressBarSample.Properties.PercentView = checkEditShowPercent.Checked
		End Sub
		' </checkEditShowPercent>

		' <colorEditTextColor>
		Private Sub colorEditTextColor_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorEditTextColor.EditValueChanged
			progressBarSample.Properties.Appearance.ForeColor = colorEditTextColor.Color
		End Sub
		' </colorEditTextColor>

		' <spinEditStep>
		Private Sub spinEditStep_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEditStep.EditValueChanged
			progressBarSample2.Properties.Step = CInt(Fix(spinEditStep.Value))
		End Sub
		' </spinEditStep>

		' <btnSetMinimum>
		Private Sub btnSetMinimum_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			progressBarSample2.Position = progressBarSample2.Properties.Minimum
		End Sub
		' </btnSetMinimum>

		' <btnSetMaximum>
		Private Sub btnSetMaximum_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			progressBarSample2.Position = progressBarSample2.Properties.Maximum
		End Sub
		' </btnSetMaximum>

		' <textEditCurrentValue>
		Private Sub progressBarSample2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles progressBarSample2.EditValueChanged
			textEditCurrentValue.Text = progressBarSample2.Position.ToString()
		End Sub
		' </textEditCurrentValue>

		' <buttonsUpDown>
		Private Sub buttonsUpDown_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonsUpDown.ButtonClick
			checkEditAnimation.Checked = False
			checkEditAnimation.Update()
			If e.Button.Caption = "Up" Then
				RunVariableIncrement()
			End If
			If e.Button.Caption = "Down" Then
				RunVariableDecrement()
			End If
		End Sub
		' </buttonsUpDown>

		' <buttonsUpDown>
		Private Sub RunVariableIncrement()
			progressBarSample2.Position = progressBarSample2.Properties.Minimum
			Dim currentStep As Double = (progressBarSample2.Properties.Maximum - progressBarSample2.Properties.Minimum) / 4
			Do While progressBarSample2.Position + currentStep < progressBarSample2.Properties.Maximum
				progressBarSample2.Increment(CInt(Fix(Math.Ceiling(currentStep))))
				progressBarSample2.Update()
				textEditCurrentValue.Update()
				System.Threading.Thread.Sleep(100)
				currentStep /= 1.5
			Loop
		End Sub
		Private Sub RunVariableDecrement()
			progressBarSample2.Position = progressBarSample2.Properties.Maximum
			Dim currentStep As Double = (progressBarSample2.Properties.Maximum - progressBarSample2.Properties.Minimum) / 4
			Do While progressBarSample2.Position - currentStep > progressBarSample2.Properties.Minimum
				progressBarSample2.Decrement(CInt(Fix(Math.Ceiling(currentStep))))
				progressBarSample2.Update()
				textEditCurrentValue.Update()
				System.Threading.Thread.Sleep(100)
				currentStep /= 1.5
			Loop
		End Sub
		' </buttonsUpDown>

		' <comboBoxMaxMin>
		Private Sub comboBoxMaxMin_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxMaxMin.SelectedIndexChanged
			Dim minValues() As Integer = { 0, 100, -100 }
			Dim maxValues() As Integer = { 100, 200, 100 }
			progressBarSample2.Properties.Minimum = minValues(comboBoxMaxMin.SelectedIndex)
			progressBarSample2.Properties.Maximum = maxValues(comboBoxMaxMin.SelectedIndex)
			progressBarSample2.Position = progressBarSample2.Properties.Minimum
		End Sub
		' </comboBoxMaxMin>

		' <checkEditAnimation>
		Private Sub checkEditAnimation_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditAnimation.CheckedChanged
			timer.Enabled = checkEditAnimation.Checked
		End Sub



		Private Sub timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer.Tick
			progressBarSample2.Position += If(increment, 1, -1)
			If progressBarSample2.Position = progressBarSample2.Properties.Maximum Then
				increment = False
			End If
			If progressBarSample2.Position = progressBarSample2.Properties.Minimum Then
				increment = True
			End If
		End Sub
		' </checkEditAnimation>

		Private Sub TutorialModuleProgressBar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			SetDefaultProgressBarPosition()
			InitValues()
		End Sub
		Private Sub SetDefaultProgressBarPosition()
			UpdateProgressBarBounds(progressBarSample)
			UpdateProgressBarBounds(progressBarSample2)
		End Sub

		Private Sub InitValues()
			updateValues = True
			comboBoxProgressStyle.EditValue = progressBarSample.Properties.ProgressViewStyle.ToString()
			checkEditShowText.Checked = progressBarSample.Properties.ShowTitle
			checkEditShowPercent.Checked = progressBarSample.Properties.PercentView
			updateValues = False
			checkEditShowPercent.Enabled = checkEditShowText.Checked
			lblTextOrientation.Enabled = checkEditShowText.Checked
			comboBoxTextOrientation.Enabled = checkEditShowText.Checked
		End Sub


		Private Sub timerInternal_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerInternal.Tick
			progressBarSample.Position += If(incrementInternal, 1, -1)
			If progressBarSample.Position = progressBarSample.Properties.Maximum Then
				incrementInternal = False
			End If
			If progressBarSample.Position = progressBarSample.Properties.Minimum Then
				incrementInternal = True
			End If
		End Sub

		' <buttonsMaxMin>
		Private Sub buttonsMaxMin_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonsMaxMin.ButtonClick
			If e.Button.Caption = "Max" Then
				progressBarSample2.Position = progressBarSample2.Properties.Maximum
			End If
			If e.Button.Caption = "Min" Then
				progressBarSample2.Position = progressBarSample2.Properties.Minimum
			End If
		End Sub
		' </buttonsMaxMin>

		' <spinEditStep>
		Private Sub spinEditStep_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles spinEditStep.ButtonClick
			progressBarSample2.PerformStep()
		End Sub

		Private Sub comboBoxTextOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxTextOrientation.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim orientations() As TextOrientation = { TextOrientation.Default, TextOrientation.Horizontal, TextOrientation.VerticalUpwards, TextOrientation.VerticalDownwards }
			progressBarSample.Properties.TextOrientation = orientations(comboBoxTextOrientation.SelectedIndex)
		End Sub
		' </spinEditStep>

        Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
            progressBarSample.Properties.FlowAnimationEnabled = CheckEdit1.Checked
            spinDelay.Enabled = CheckEdit1.Checked
            spinSpeed.Enabled = CheckEdit1.Checked
            lbDelay.Enabled = CheckEdit1.Checked
            lbSpeed.Enabled = CheckEdit1.Checked
        End Sub

        Private Sub spinSpeed_EditValueChanged(sender As Object, e As EventArgs) Handles spinSpeed.EditValueChanged
            progressBarSample.Properties.FlowAnimationSpeed = CInt(spinSpeed.Value)
        End Sub

        Private Sub spinDelay_EditValueChanged(sender As Object, e As EventArgs) Handles spinDelay.EditValueChanged
            progressBarSample.Properties.FlowAnimationDelay = CInt(spinDelay.Value)
        End Sub
    End Class
End Namespace

