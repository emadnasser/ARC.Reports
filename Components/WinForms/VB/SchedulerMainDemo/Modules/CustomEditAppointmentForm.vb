Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class CustomEditAppointmentFormModule
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

		Private Sub AddCustomFieldsMapping()
			Dim customNameMapping As New AppointmentCustomFieldMapping("CustomName", "CustomName")
			Dim customStatusMapping As New AppointmentCustomFieldMapping("CustomStatus", "CustomStatus")
			schedulerStorage.Appointments.CustomFieldMappings.Add(customNameMapping)
			schedulerStorage.Appointments.CustomFieldMappings.Add(customStatusMapping)
		End Sub

		Private Sub CustomEditAppointmentFormModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			AddCustomFieldsMapping()
			CarsDataHelper.FillData(schedulerControl, schedulerStorage)
		End Sub
		Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles schedulerControl.EditAppointmentFormShowing
			Dim apt As Appointment = e.Appointment
			Dim openRecurrenceForm As Boolean = apt.IsRecurring AndAlso schedulerStorage.Appointments.IsNewAppointment(apt)

			Dim f As New MyAppointmentEditForm(CType(sender, SchedulerControl), apt, openRecurrenceForm)
			f.SetMenuManager(Me.schedulerControl.MenuManager)
			f.LookAndFeel.ParentLookAndFeel = Me.LookAndFeel.ParentLookAndFeel
			e.DialogResult = f.ShowDialog()
			e.Handled = True

			If apt.Type.Equals(AppointmentType.Pattern) AndAlso schedulerControl.SelectedAppointments.Contains(apt) Then
				schedulerControl.SelectedAppointments.Remove(apt)
			End If

			schedulerControl.Refresh()
		End Sub
	End Class
End Namespace
