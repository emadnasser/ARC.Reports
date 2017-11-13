Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class RemindersModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub RemindersModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			cbView.EditValue = schedulerControl.ActiveViewType
		End Sub

		Private Sub RemindersModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
			schedulerStorage.Appointments.Clear()
			schedulerControl.DataStorage.EnableReminders = Me.Visible
			'schedulerControl.OptionsBehavior.ShowRemindersForm = this.Visible;
			schedulerControl.Start = DateTime.Today
		End Sub
		Private Sub btnCreateAppointmentWithReminder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateAppointmentWithReminder.Click
			Dim now As DateTime = DateTime.Now + TimeSpan.FromMinutes(5)
			Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
			apt.Start = now
			apt.Duration = TimeSpan.FromHours(1)
			apt.Subject = "Appointment with Reminder"

			apt.HasReminder = True
			schedulerStorage.Appointments.Add(apt)
			schedulerControl.ActiveView.GotoTimeInterval(New TimeInterval(apt.Start, apt.Duration))
		End Sub

		Private Sub btnGotoToday_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGotoToday.Click
			schedulerControl.GoToToday()
		End Sub
		Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbView.SelectedIndexChanged
			schedulerControl.ActiveViewType = CType(cbView.EditValue, SchedulerViewType)
		End Sub
		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			cbView.EditValue = schedulerControl.ActiveViewType
		End Sub
	End Class
End Namespace
