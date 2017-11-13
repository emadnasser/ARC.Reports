Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace DevExpress.XtraScheduler.Demos
	' XP object
	Public Class OlAppointment
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Start As DateTime ' Appointment.Start
		Public [End] As DateTime ' Appointment.End

		Public Subject As String ' Appointment.Subject

		<Size(SizeAttribute.Unlimited)> _
		Public Body As String ' Appointment.Description

		Public AllDayEvent As Boolean ' Appointment.AllDay
		Public BusyStatus As Integer ' Appointment.Status
		Public Location As String ' Appointment.Location

		<Size(SizeAttribute.Unlimited)> _
		Public RecurrencePattern As String ' Appointment.RecurrenceInfo

		<Size(SizeAttribute.Unlimited)> _
		Public ReminderSet As String ' Appointment.ReminderInfo

		Public AppointmentType As Integer ' Appointment.Type
		Public Label As Integer ' Appointment.Label

		<Size(SizeAttribute.Unlimited)> _
		Public EntryID As String ' ForeignIdFieldName
	End Class
End Namespace
