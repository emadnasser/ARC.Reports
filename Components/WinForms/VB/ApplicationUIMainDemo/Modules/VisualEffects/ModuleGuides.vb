﻿Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.VisualEffects
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos.VisualEffects
	Partial Public Class ModuleGuides
		Inherits TutorialControl
		Private panel As GuideFlyoutPanel
		Private saveBackColor, saveForeColor As Color
		Private saveFontSizeDelta As Integer
		Private saveText As String
		Private countLessons As Integer
		Public Sub New()
			InitializeComponent()
			countLessons = 6
			panel = New GuideFlyoutPanel(Me, countLessons)
			AddHandler adornerUIManager.QueryGuideFlyoutControl, AddressOf OnQueryGuideFlyoutControl
            guide1.TargetElement = sample
		End Sub
		Private Sub OnQueryGuideFlyoutControl(ByVal sender As Object, ByVal e As DevExpress.Utils.VisualEffects.QueryGuideFlyoutControlEventArgs)
			e.Control = panel
		End Sub
		Public Sub StartTutorial()
			adornerUIManager.ShowGuides = Utils.DefaultBoolean.True
			saveFontSizeDelta = CInt(Fix(seFontSizeDelta.Value))
			saveText = teText.Text
			saveBackColor = cbBackColor.Color
			saveForeColor = cbForeColor.Color
			SetLesson(panel.CurrentLessonIndex)
			badge1.Visible = False
		End Sub
		Public Sub SetLesson(ByVal index As Integer)
			If index < 0 OrElse index > countLessons - 1 Then
				Return
			End If
			Select Case index
				Case 0
					FirstLesson()
				Case 1
					SecondLesson()
				Case 2
					ThirdLesson()
				Case 3
					FourthLesson()
				Case 4
					FifthLesson()
				Case 5
					SixthLesson()
			End Select
		End Sub
		Private Sub ActivateTextPage()
			textItem.Expanded = True
			appearanceItem.Expanded = False
			tabNavigation.SelectedPage = settingsNavigationPage
		End Sub
		Private Sub ActivateAppearancePage()
			textItem.Expanded = False
			appearanceItem.Expanded = True
			tabNavigation.SelectedPage = styleNavigationPage
		End Sub
		Private Sub FirstLesson()
			ResetSettings()
			panel.LabelText = "You are about to start a tutorial on customizing LabelControl."
			guide1.TargetElement = sample
		End Sub
		Private Sub SecondLesson()
			ResetSettings()
			panel.LabelText = "You can change LabelControl's properties using the Settings panel."
			guide1.TargetElement = tabNavigation
			textItem.Expanded = True
		End Sub
		Private Sub ThirdLesson()
			ActivateTextPage()
            SetSettings("New text label", saveFontSizeDelta, saveBackColor, saveForeColor)
			panel.LabelText = "Use the Text property to change the LabelControl's caption."
			guide1.TargetElement = teText
		End Sub
		Private Sub FourthLesson()
			ActivateTextPage()
            SetSettings("New text label", 3, saveBackColor, saveForeColor)
			panel.LabelText = "You can adjust the font size with the FontSizeDelta setting."
			guide1.TargetElement = seFontSizeDelta
		End Sub
		Private Sub FifthLesson()
			ActivateAppearancePage()
            SetSettings("New text label", 3, Color.Red, saveForeColor)
			panel.LabelText = "The Style tab provides the BackColor setting to change the LabelControl's background."
			guide1.TargetElement = cbBackColor
		End Sub
		Private Sub SixthLesson()
			ActivateAppearancePage()
            SetSettings("New text label", 3, Color.Red, Color.White)
			panel.LabelText = "Use this property to customize the LabelControl's foreground color."
			guide1.TargetElement = cbForeColor
		End Sub
		Private Sub SetSettings(ByVal text As String, ByVal fontSizeDelta As Integer, ByVal backColor As Color, ByVal foreColor As Color)
			teText.Text = text
			cbBackColor.Color = backColor
			cbForeColor.Color = foreColor
			seFontSizeDelta.Value = fontSizeDelta
		End Sub
		Private Sub ResetSettings()
			SetSettings(saveText, saveFontSizeDelta, saveBackColor, saveForeColor)
			textItem.Expanded = False
			appearanceItem.Expanded = False
			tabNavigation.SelectedPage = settingsNavigationPage
		End Sub
		Public Sub EndTutorial()
			adornerUIManager.ShowGuides = Utils.DefaultBoolean.Default
			badge1.Visible = True
			ResetSettings()
		End Sub
        Private Sub _OnBackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBackColor.ColorChanged
            label.Appearance.BackColor = cbBackColor.Color
        End Sub
        Private Sub _OnForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbForeColor.ColorChanged
            label.Appearance.ForeColor = cbForeColor.Color
        End Sub
        Private Sub _OnTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teText.EditValueChanged
            label.Text = teText.Text
        End Sub
        Private Sub OnFontSizeDeltaChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seFontSizeDelta.ValueChanged
            label.Appearance.FontSizeDelta = CInt(Fix(seFontSizeDelta.Value))
        End Sub
		Private Sub OnBadgeClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles badge1.Click
			StartTutorial()
		End Sub
	End Class
End Namespace
