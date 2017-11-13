Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ASPxTrackBar_Scale
	Inherits Page
	Private Structure TrackBarSettings
		Public MinValue, MaxValue, LargeTickInterval, LargeTickStartValue, LargeTickEndValue, [Step] As Decimal
		Public SmallTickFrequency As Integer
	End Structure

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		UpdateTrackBarSettings()
	End Sub

	Protected Sub OnPredefinedSettingsComboBoxValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim defaultSettingIndex As Integer = (TryCast(sender, ASPxComboBox)).SelectedIndex
		Dim currentDefaultSettings As TrackBarSettings = PredefinedSettings(defaultSettingIndex)
		minValueSpinEdit.Number = currentDefaultSettings.MinValue
		maxValueSpinEdit.Number = currentDefaultSettings.MaxValue
		largeTickIntervalSpinEdit.Number = currentDefaultSettings.LargeTickInterval
		largeTickStartValueSpinEdit.Number = currentDefaultSettings.LargeTickStartValue
		largeTickEndValueSpinEdit.Number = currentDefaultSettings.LargeTickEndValue
		smallTickFrequencySpinEdit.Number = currentDefaultSettings.SmallTickFrequency
		stepSpinEdit.Number = currentDefaultSettings.Step
		UpdateTrackBarSettings()
	End Sub

	Protected Sub UpdateTrackBarSettings()
		trackBar.MinValue = minValueSpinEdit.Number
		trackBar.MaxValue = maxValueSpinEdit.Number
		trackBar.LargeTickInterval = largeTickIntervalSpinEdit.Number
		trackBar.LargeTickStartValue = largeTickStartValueSpinEdit.Number
		trackBar.LargeTickEndValue = largeTickEndValueSpinEdit.Number
		trackBar.SmallTickFrequency = CInt(Fix(smallTickFrequencySpinEdit.Number))
		trackBar.Value = trackBar.MinValue
		trackBar.Step = stepSpinEdit.Number
	End Sub

	Private PredefinedSettings() As TrackBarSettings = { New TrackBarSettings With {.MinValue = 0, .MaxValue = 50, .LargeTickInterval = 10, .LargeTickStartValue = 0, .LargeTickEndValue = 50, .SmallTickFrequency = 5, .Step = 1}, New TrackBarSettings With {.MinValue = 0, .MaxValue = 50, .LargeTickInterval = 10, .LargeTickStartValue = 5, .LargeTickEndValue = 45, .SmallTickFrequency = 5, .Step = 1}, New TrackBarSettings With {.MinValue = 0, .MaxValue = 11, .LargeTickInterval = 2, .LargeTickStartValue = 0.5D, .LargeTickEndValue = 10.5D, .SmallTickFrequency = 1, .Step = 0.5D}, New TrackBarSettings With {.MinValue = -10, .MaxValue = 30, .LargeTickInterval = 10, .LargeTickStartValue = 0, .LargeTickEndValue = 30, .SmallTickFrequency = 8, .Step = 1} }
End Class
