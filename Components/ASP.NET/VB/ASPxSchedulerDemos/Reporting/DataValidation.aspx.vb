Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Reporting

Partial Public Class Reporting_DataValidation
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim adapter As SchedulerPrintAdapter = ReportsDataSource1.SchedulerStorageAdapter
		AddHandler adapter.ValidateResources, AddressOf SchedulerPrintAdapter_ValidateResources
		AddHandler adapter.ValidateAppointments, AddressOf SchedulerPrintAdapter_ValidateAppointments
		AddHandler adapter.ValidateTimeIntervals, AddressOf SchedulerPrintAdapter_ValidateTimeIntervals

		Dim report As New DataValidationReport()
		report.SchedulerAdapter = adapter
		report.SchedulerAdapter.TimeInterval = New TimeInterval(SchedulerDemoUtils.BaseDate, SchedulerDemoUtils.BaseDate.AddDays(21))

		ReportViewer.Report = report
	End Sub

	Private Sub SchedulerPrintAdapter_ValidateTimeIntervals(ByVal sender As Object, ByVal e As TimeIntervalsValidationEventArgs)
		Dim weekDays As Integer = CInt(Fix(cbDays.Value))
		If weekDays = CInt(Fix(DevExpress.XtraScheduler.WeekDays.EveryDay)) Then
			Return
		End If

		Dim count As Integer = e.Intervals.Count

		Dim result As New DayIntervalCollection()
		For i As Integer = count - 1 To 0 Step -1
			Dim sourceDays As New DayIntervalCollection()
			sourceDays.Add(e.Intervals(i))
			FilterDays(sourceDays, weekDays)
			result.AddRange(sourceDays)
		Next i

		e.Intervals.Clear()
		For i As Integer = 0 To result.Count - 1
			e.Intervals.Add(result(i))
		Next i

	End Sub
	Private Sub FilterDays(ByVal dayIntervals As DayIntervalCollection, ByVal validDaysMask As Integer)
		Dim count As Integer = dayIntervals.Count
		For i As Integer = count - 1 To 0 Step -1
			Dim day As DayOfWeek = dayIntervals(i).Start.DayOfWeek
			Dim weekDay As WeekDays = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(day)

			Dim weekDayMask As Integer = Convert.ToInt32(weekDay)

			If (weekDayMask And validDaysMask) <> weekDayMask Then
				dayIntervals.RemoveAt(i)
			End If
		Next i
	End Sub
	Private Sub SchedulerPrintAdapter_ValidateResources(ByVal sender As Object, ByVal e As ResourcesValidationEventArgs)
		Dim resourceMode As Integer = cbResources.SelectedIndex
		If resourceMode = 1 Then
			Dim count As Integer = e.Resources.Count
			For i As Integer = count - 1 To 3 Step -1
				e.Resources.RemoveAt(i)
			Next i
		End If
		If resourceMode = 2 Then
			e.Resources.Sort(New ResourceCaptionComparer())
		End If
		If resourceMode = 3 Then
			e.Resources.Sort(New ResourceCaptionReverseComparer())
		End If
	End Sub

	Private Sub SchedulerPrintAdapter_ValidateAppointments(ByVal sender As Object, ByVal e As AppointmentsValidationEventArgs)
		Dim aptType As Integer = CInt(Fix(cbAppointments.Value))
		If aptType = CInt(Fix(UsedAppointmentType.All)) Then
			Return
		End If

		Dim count As Integer = e.Appointments.Count
		Dim result As New AppointmentBaseCollection()
		For i As Integer = 0 To count - 1
			Dim apt As Appointment = e.Appointments(i)
			If aptType = CInt(Fix(UsedAppointmentType.Recurring)) AndAlso apt.IsRecurring Then
				result.Add(apt)
			End If
			If aptType = CInt(Fix(UsedAppointmentType.NonRecurring)) AndAlso (Not apt.IsRecurring) Then
				result.Add(apt)
			End If
		Next i
		e.Appointments.Clear()
		e.Appointments.AddRange(result)
	End Sub
	Public Class ResourceCaptionComparer
		Implements IComparer(Of Resource), IComparer

		#Region "IComparer Members"
		Private Function IComparer_Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
			Return CompareCore(x, y)
		End Function
		Public Function Compare(ByVal x As Resource, ByVal y As Resource) As Integer Implements IComparer(Of Resource).Compare
			Return CompareCore(x, y)
		End Function
		#End Region

		Protected Overridable Function CompareCore(ByVal x As Object, ByVal y As Object) As Integer
			Dim xRes As Resource = CType(x, Resource)
			Dim yRes As Resource = CType(y, Resource)
			If xRes Is Nothing OrElse yRes Is Nothing Then
				Return 0
			End If
			If EmptyResourceId.Id.Equals(xRes.Id) OrElse EmptyResourceId.Id.Equals(yRes.Id) Then
				Return 0
			End If
			Return CompareCaptions(xRes, yRes)
		End Function
		Protected Overridable Function CompareCaptions(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
			Return String.Compare(xRes.Caption, yRes.Caption)
		End Function

	End Class
	Public Class ResourceCaptionReverseComparer
		Inherits ResourceCaptionComparer
		Protected Overrides Function CompareCaptions(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
			Return String.Compare(yRes.Caption, xRes.Caption)
		End Function
	End Class

End Class
