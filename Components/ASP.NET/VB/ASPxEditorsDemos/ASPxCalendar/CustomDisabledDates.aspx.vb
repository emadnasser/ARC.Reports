Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ASPxCalendar_CustomDisabledDates
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxCalendar2.DisabledDates.AddRange(GetDisabledDates())
	End Sub

	Public Function GetDisabledDates() As IEnumerable(Of DateTime)
		Dim disabledDates As New List(Of DateTime)()

		disabledDates.Add(New DateTime(DateTime.Today.Year, DateTime.Today.Month, 7))
		disabledDates.Add(New DateTime(DateTime.Today.Year, DateTime.Today.Month, 11))
		disabledDates.Add(New DateTime(DateTime.Today.Year, DateTime.Today.Month, 13))
		disabledDates.Add(New DateTime(DateTime.Today.Year, DateTime.Today.Month, 17))
		disabledDates.Add(New DateTime(DateTime.Today.Year, DateTime.Today.Month, 19))

		Return disabledDates
	End Function
	Protected Sub ASPxCalendar1_CustomDisabledDate(ByVal sender As Object, ByVal e As CalendarCustomDisabledDateEventArgs)
		If e.Date.DayOfWeek = DayOfWeek.Wednesday Then
			e.IsDisabled = True
		End If
	End Sub
End Class
