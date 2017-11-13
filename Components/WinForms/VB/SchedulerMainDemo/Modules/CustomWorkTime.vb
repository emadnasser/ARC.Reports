Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class CustomWorkTimeModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub CustomWorkTimeModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DemoUtils.FillResources(schedulerStorage, 5)
			InitAppointments()
			schedulerControl.Start = DateTime.Now
		End Sub
		Private Sub InitAppointments()
			Me.schedulerStorage.Appointments.Mappings.Start = "StartTime"
			Me.schedulerStorage.Appointments.Mappings.End = "EndTime"
			Me.schedulerStorage.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerStorage.Appointments.Mappings.Description = "Description"
			Me.schedulerStorage.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
			Me.schedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo"
			Me.schedulerStorage.Appointments.Mappings.ResourceId = "OwnerId"
			Me.schedulerStorage.Appointments.Mappings.Status = "Status"
			Me.schedulerStorage.Appointments.Mappings.Type = "EventType"

			Dim eventList As New CustomEventList()
			GenerateEvents(eventList)
			Me.schedulerStorage.Appointments.DataSource = eventList

		End Sub
		Private Sub GenerateEvents(ByVal eventList As CustomEventList)
			Dim count As Integer = schedulerStorage.Resources.Count
			For i As Integer = 0 To count - 1
				Dim resource As Resource = schedulerStorage.Resources(i)
				Dim subjPrefix As String = resource.Caption & "'s "
				eventList.Add(CreateEvent(eventList, subjPrefix & "meeting", resource.Id, 2, 5))
				eventList.Add(CreateEvent(eventList, subjPrefix & "travel", resource.Id, 3, 6))
				eventList.Add(CreateEvent(eventList, subjPrefix & "phone call", resource.Id, 0, 10))
			Next i
		End Sub
		Private Function CreateEvent(ByVal eventList As CustomEventList, ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer) As CustomEvent
			Dim apt As New CustomEvent(eventList)
			apt.Subject = subject
			apt.OwnerId = resourceId
			Dim rnd As Random = DemoUtils.RandomInstance
			Dim rangeInMinutes As Integer = 60 * 24
			apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
			apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4))
			apt.Status = status
			apt.Label = label
			Return apt
		End Function
		Private workTimes() As TimeOfDayInterval = { New TimeOfDayInterval(TimeSpan.FromHours(0), TimeSpan.FromHours(16)), New TimeOfDayInterval(TimeSpan.FromHours(10), TimeSpan.FromHours(20)), Nothing, New TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(15)), New TimeOfDayInterval(TimeSpan.FromHours(16), TimeSpan.FromHours(24)) }

		Private Sub schedulerControl_QueryWorkTime(ByVal sender As Object, ByVal e As QueryWorkTimeEventArgs) Handles schedulerControl.QueryWorkTime
			If (Not chkCustomWorkTime.Checked) Then
				Return
			End If

			If schedulerStorage.Resources Is Nothing Then
				Return
			End If

			Dim resourceIndex As Integer = schedulerStorage.Resources.Items.IndexOf(e.Resource)
			If resourceIndex >= 0 Then
				If resourceIndex = 0 Then
					If (e.Interval.Start.Day Mod 2) = 0 Then
						e.WorkTime = workTimes(resourceIndex Mod workTimes.Length)
					Else
						e.WorkTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(13)))
						e.WorkTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(14), TimeSpan.FromHours(18)))
					End If
				Else
					If schedulerControl.WorkDays.IsWorkDay(e.Interval.Start.Date) Then
						e.WorkTime = workTimes(resourceIndex Mod workTimes.Length)
					End If
				End If
			End If
		End Sub

		Private Sub chkCustomWorkTime_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCustomWorkTime.CheckedChanged
			schedulerControl.ActiveView.LayoutChanged()
		End Sub
	End Class
End Namespace
