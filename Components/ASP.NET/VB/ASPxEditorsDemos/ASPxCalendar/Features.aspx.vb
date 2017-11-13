Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports System

Partial Public Class ASPxCalendar_Features
	Inherits Page
	Private Const AutoSelectedDatesCount As Integer = 5

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		calendar.HighlightToday = cbHighlightToday.Checked
		calendar.HighlightWeekends = cbHighlightWeekends.Checked
		calendar.ShowClearButton = cbShowClearButton.Checked
		calendar.ShowTodayButton = cbShowTodayButton.Checked
		calendar.ShowDayHeaders = cbShowDayHeaders.Checked
		calendar.ShowHeader = cbShowHeader.Checked
		calendar.ShowWeekNumbers = cbShowWeekNumber.Checked
		ToggleMultiSelect()
	End Sub

	Protected Sub ToggleMultiSelect()
		calendar.EnableMultiSelect = cbEnableMultiSelect.Checked
		If calendar.EnableMultiSelect Then
			Dim visibleDaysCount As Integer = (calendar.GetLastVisibleDate() - calendar.GetFirstVisibleDate()).Days
			Dim rnd As New Random()
			For i As Integer = 0 To AutoSelectedDatesCount - 1
				Dim selectedDate As DateTime = calendar.GetFirstVisibleDate().AddDays(rnd.Next(visibleDaysCount))
				calendar.SelectedDates.Add(selectedDate)
			Next i
		Else
			calendar.SelectedDates.Clear()
		End If
	End Sub
End Class
