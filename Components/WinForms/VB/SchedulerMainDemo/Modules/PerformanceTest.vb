Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class PerformanceTestModule
		Inherits TutorialControl
		Private Const DAY_COUNT As Integer = 100
		Private Const MAX_APPOINTMENTS_PER_DAY As Integer = 1000
		Private data50 As BindingList(Of Record) = Nothing
		Private data100 As BindingList(Of Record) = Nothing
		Private data500 As BindingList(Of Record) = Nothing
		Private data1000 As BindingList(Of Record) = Nothing

		Private subjects() As String = { "Peter Dolan's meeting", "Peter Dolan's phone call", "Peter Dolan's travel", "Ryan Fischer's meeting", "Ryan Fischer's phone call", "Ryan Fischer's travel" }

		Public Sub New()
			InitializeComponent()
			PrepareViews()
			DemoUtils.FillResources(schedulerStorage, 2)
		End Sub

		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Function GetRandomDouble(ByVal rnd As Random, ByVal min As Double, ByVal max As Double) As Double
			Return min + (max - min) * rnd.NextDouble()
		End Function

		Private Sub PrepareViews()
			Me.schedulerControl.MonthView.Enabled = True
			Me.schedulerControl.TimelineView.Enabled = True
			Me.schedulerControl.GanttView.Enabled = False
			Me.schedulerControl.DayView.Enabled = True
			Me.schedulerControl.WorkWeekView.Enabled = True
			Me.schedulerControl.FullWeekView.Enabled = True
			Me.schedulerControl.AgendaView.Enabled = False
		End Sub

		Private Sub PerformanceTestModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			grSwitch.SelectedIndex = 0
		End Sub

		Private Sub UpdateAppointmentStorage()
			Dim aptsPerDay As Integer = Convert.ToInt32(grSwitch.EditValue)
			Select Case aptsPerDay
				Case 50
					If Me.data50 Is Nothing Then
						GenerateAppointments(aptsPerDay, Me.data50)
					End If
					schedulerStorage.Appointments.DataSource = Me.data50
				Case 100
					If Me.data100 Is Nothing Then
						GenerateAppointments(aptsPerDay, Me.data100)
					End If
					schedulerStorage.Appointments.DataSource = Me.data100
				Case 500
					If Me.data500 Is Nothing Then
						GenerateAppointments(aptsPerDay, Me.data500)
					End If
					schedulerStorage.Appointments.DataSource = Me.data500
				Case 1000
					If Me.data1000 Is Nothing Then
						GenerateAppointments(aptsPerDay, Me.data1000)
					End If
					schedulerStorage.Appointments.DataSource = Me.data1000
			End Select
		End Sub

		Private Sub GenerateAppointments(ByVal aptsPerDay As Integer, <System.Runtime.InteropServices.Out()> ByRef list As BindingList(Of Record))
			Dim rnd As New Random()
			Dim start As DateTime = DateTime.Today.AddDays(-DAY_COUNT \ 2)

			Dim appointments As List(Of Record) = Enumerable.Range(0, DAY_COUNT * aptsPerDay).Select(Function(i) CreateNewRecord(i, aptsPerDay, rnd, start)).ToList()
			list = New BindingList(Of Record)(appointments)
		End Sub

		Private Function CreateNewRecord(ByVal index As Integer, ByVal aptsPerDay As Integer, ByVal rnd As Random, ByVal start As DateTime) As Record
			Dim day As Integer = index \ aptsPerDay

			Dim rec As New Record()
			rec.Id = index + 1
			rec.StartTime = start.AddDays(day).AddHours(Me.GetRandomDouble(rnd, 0, 18))
			rec.EndTime = rec.StartTime.AddHours(Me.GetRandomDouble(rnd, 0.5, 6.0))
			Dim subjectIndex As Integer = rnd.Next(0, subjects.Length)
			rec.Subject = Me.subjects(subjectIndex)
			rec.Label = rnd.Next(1, 12)
			rec.ResourceId = If(subjectIndex < 3, 1, 2)
			Return rec
		End Function

		Private Sub PerformanceTestModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.VisibleChanged
			schedulerControl.ActiveViewType = SchedulerViewType.Day
			schedulerControl.DayView.DayCount = 1
			schedulerControl.GroupType = SchedulerGroupType.Resource
			Me.schedulerControl.Start = DateTime.Today
		End Sub

		Private Sub grSwitch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles grSwitch.SelectedIndexChanged
			BeginInvoke(New Action(Function() AnonymousMethod1()))
		End Sub
		
		Private Function AnonymousMethod1() As Boolean
			SplashScreenManager.ShowDefaultWaitForm()
			UpdateAppointmentStorage()
			SplashScreenManager.CloseDefaultWaitForm()
			Return True
		End Function
	End Class

	Public Class Record
		Public Property Id() As Integer
		Public Property Subject() As String
		Public Property StartTime() As DateTime
		Public Property EndTime() As DateTime
		Public Property Label() As Integer
		Public Property ResourceId() As Integer
	End Class
End Namespace

