Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.Demos
Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Microsoft.AspNet.EntityDataSource
Imports System.Drawing

Public NotInheritable Class DataHelper
	Private Sub New()
	End Sub
	Public Shared Sub SetupDefaultMappings(ByVal control As ASPxScheduler)
		SetupDefaultMappings(control, False)
	End Sub
	Public Shared Sub SetupDefaultMappings(ByVal control As ASPxScheduler, ByVal useImageResourceMapping As Boolean)
		Dim storage As ASPxSchedulerStorage = control.Storage
		storage.BeginUpdate()
		Try
			Dim resourceMappings As ASPxResourceMappingInfo = storage.Resources.Mappings
			resourceMappings.ResourceId = "ID"
			resourceMappings.Caption = "DisplayName"
			If useImageResourceMapping Then
				resourceMappings.Image = "PhotoBytes"
			End If

			Dim appointmentMappings As ASPxAppointmentMappingInfo = storage.Appointments.Mappings
			appointmentMappings.AppointmentId = "ID"
			appointmentMappings.Start = "StartTime"
			appointmentMappings.End = "EndTime"
			appointmentMappings.Subject = "Subject"
			appointmentMappings.Description = "Description"
			appointmentMappings.Location = "Location"
			appointmentMappings.AllDay = "AllDay"
			appointmentMappings.Type = "EventType"
			appointmentMappings.RecurrenceInfo = "RecurrenceInfo"
			appointmentMappings.ReminderInfo = "ReminderInfo"
			appointmentMappings.Label = "Label"
			appointmentMappings.Status = "Status"
			appointmentMappings.ResourceId = "MedicId"
		Finally
			storage.EndUpdate()
		End Try
	End Sub
	Public Shared Sub SetupCustomEventsMappings(ByVal control As ASPxScheduler)
		Dim storage As ASPxSchedulerStorage = control.Storage
		storage.BeginUpdate()
		Try
			Dim resourceMappings As ASPxResourceMappingInfo = storage.Resources.Mappings
			resourceMappings.ResourceId = "ID"
			resourceMappings.Caption = "Caption"

			Dim appointmentMappings As ASPxAppointmentMappingInfo = storage.Appointments.Mappings
			appointmentMappings.AppointmentId = "ID"
			appointmentMappings.Start = "StartTime"
			appointmentMappings.End = "EndTime"
			appointmentMappings.Subject = "Subject"
			appointmentMappings.AllDay = "AllDay"
			appointmentMappings.Description = "Description"
			appointmentMappings.Label = "Label"
			appointmentMappings.Location = "Location"
			appointmentMappings.RecurrenceInfo = "RecurrenceInfo"
			appointmentMappings.ReminderInfo = "ReminderInfo"
			appointmentMappings.ResourceId = "OwnerId"
			appointmentMappings.Status = "Status"
			appointmentMappings.Type = "EventType"
		Finally
			storage.EndUpdate()
		End Try
	End Sub
	Public Shared Sub SetupLabels(ByVal control As ASPxScheduler)
		Dim labels As DevExpress.Web.ASPxScheduler.AppointmentLabelCollection = control.Storage.Appointments.Labels
		labels.Clear()
		labels.Add(1, "Routine", "Routine", Color.FromArgb(255, 75, 194, 80))
		labels.Add(2, "Follow-Up", "Follow-Up", Color.FromArgb(255, 58, 159, 254))
		labels.Add(3, "Urgent", "Urgent", Color.FromArgb(255, 255, 89, 50))
		labels.Add(4, "Lab Testing", "Lab Testing", Color.FromArgb(255, 92, 107, 192))
		labels.Add(5, "Service", "Service", Color.FromArgb(255, 159, 159, 159))
	End Sub
	Public Shared Sub SetupStatuses(ByVal control As ASPxScheduler)
		Dim statuses As DevExpress.Web.ASPxScheduler.AppointmentStatusCollection = control.Storage.Appointments.Statuses
		statuses.Clear()
		statuses.Add(1, AppointmentStatusType.Custom, "Confirmed", "Confirmed", Color.FromArgb(255, 0, 171, 71))
		statuses.Add(2, AppointmentStatusType.Custom, "Awaiting Confirmation", "Awaiting Confirmation", Color.FromArgb(255, 94, 53, 177))
		statuses.Add(3, AppointmentStatusType.Custom, "Cancelled", "Cancelled", Color.FromArgb(255, 255, 255, 255))
	End Sub
	Public Shared Sub ProvideRowInsertion(ByVal control As ASPxScheduler, ByVal dataSource As DataSourceControl)

		Dim isDbDataSource As Boolean = TypeOf dataSource Is EntityDataSource OrElse TypeOf dataSource Is AccessDataSource
		If isDbDataSource Then
			Dim provider As New DbRowInsertionProvider()
			provider.ProvideRowInsertion(control, dataSource)
			Return
		End If

		Dim objectDataSource As ObjectDataSource = TryCast(dataSource, ObjectDataSource)
		If objectDataSource IsNot Nothing Then
			Dim provider As New ObjectDataSourceRowInsertionProvider()
			provider.ProvideRowInsertion(control, objectDataSource)
		End If
	End Sub
	Public Shared Sub ProvideRowInsertion(ByVal control As ASPxScheduler, ByVal dataSource As DevExpress.Web.DemoUtils.SchedulerDemoDataSource)
		If dataSource.IsSiteMode.Equals(DevExpress.Utils.DefaultBoolean.True) Then
			Dim provider As New DataSourceControlRowInsertionProvider()
			provider.ProvideRowInsertion(control, dataSource)
		Else
			control.Storage.Appointments.AutoRetrieveId = True
		End If
	End Sub
	Public Shared Sub EnsureOnlineVersionModificationLock(ByVal control As ASPxScheduler)
		If Utils.IsSiteMode Then
			Dim provider As New DemoOnlineRowModificationProvider()
			provider.ProvideModification(control)
		End If
	End Sub
	Public Shared Sub EnsureOnlineVersionModificationLock(ByVal control As ASPxScheduler, ByVal dataSource As SqlDataSource)
		If Utils.IsSiteMode Then
			Dim provider As New DemoOnlineRowModificationProvider()
			provider.ProvideModification(control, dataSource)
		End If
	End Sub
	Public Shared Function GenerateCustomEventList(ByVal Storage As ASPxSchedulerStorage) As CustomEventList
		Dim eventList As New CustomEventList()
		Dim count As Integer = Storage.Resources.Count
		For i As Integer = 0 To count - 1
			Dim resource As Resource = Storage.Resources(i)
			Dim subjPrefix As String = resource.Caption & "'s "

			eventList.Add(CreateEvent(resource.Id, subjPrefix & "meeting", 2, 5))
			eventList.Add(CreateEvent(resource.Id, subjPrefix & "travel", 3, 6))
			eventList.Add(CreateEvent(resource.Id, subjPrefix & "phone call", 0, 10))
		Next i
		Return eventList
	End Function
	Public Shared Function GenerateCustomEventListByInterval(ByVal Storage As ASPxSchedulerStorage, ByVal workTimes() As TimeOfDayInterval) As CustomEventList
		Dim eventList As CustomEventList = GenerateCustomEventList(Storage)
		For Each evt As CustomEvent In eventList
			Dim workTime As TimeOfDayInterval = workTimes(Int32.Parse(evt.OwnerId.ToString()) Mod workTimes.Length)
			Dim StartHour As Integer = If(workTime IsNot Nothing, workTime.Start.Hours, 0)
			Dim EndHour As Integer = If(workTime IsNot Nothing, workTime.End.Hours, 24)
			Dim rnd As Random = SchedulerDemoUtils.RandomInstance
			evt.StartTime = SchedulerDemoUtils.BaseDate + TimeSpan.FromHours(rnd.Next(StartHour, EndHour - 2))
			evt.EndTime = evt.StartTime + TimeSpan.FromHours(rnd.Next(1, EndHour - evt.StartTime.Hour))
		Next evt
		Return eventList
	End Function
	Public Shared Function CreateEvent(ByVal resourceId As Object, ByVal subject As String, ByVal status As Integer, ByVal label As Integer) As CustomEvent
		Dim customEvent As New CustomEvent()
		customEvent.Subject = subject
		customEvent.OwnerId = resourceId
		Dim rnd As Random = SchedulerDemoUtils.RandomInstance
		Dim rangeInHours As Integer = 48
		customEvent.StartTime = SchedulerDemoUtils.BaseDate + TimeSpan.FromHours(rnd.Next(0, rangeInHours))
		customEvent.EndTime = customEvent.StartTime + TimeSpan.FromHours(rnd.Next(0, rangeInHours \ 8))
		customEvent.Status = status
		customEvent.Label = label
		customEvent.ID = "ev" & customEvent.GetHashCode()
		Return customEvent
	End Function
End Class
Public Class DemoOnlineRowModificationProvider
	Public Sub ProvideModification(ByVal control As ASPxScheduler, ByVal dataSource As SqlDataSource)
		AddHandler dataSource.Updating, AddressOf OnSqlDataSourceModifying
		AddHandler dataSource.Inserting, AddressOf OnSqlDataSourceModifying
		AddHandler dataSource.Deleting, AddressOf OnSqlDataSourceModifying
	End Sub
	Private Sub OnSqlDataSourceModifying(ByVal sender As Object, ByVal e As SqlDataSourceCommandEventArgs)
		Utils.AssertNotReadOnlyText()
	End Sub
	Public Sub ProvideModification(ByVal control As ASPxScheduler)
		AddHandler control.AppointmentRowInserting, AddressOf AppointmentRowChanging
		AddHandler control.AppointmentRowUpdating, AddressOf AppointmentRowChanging
		AddHandler control.AppointmentRowDeleting, AddressOf AppointmentRowChanging
	End Sub
	Private Sub AppointmentRowChanging(ByVal sender As Object, ByVal e As CancelEventArgs)
		Utils.AssertNotReadOnlyText()
	End Sub
End Class

Public Class DbRowInsertionProvider
	Private lastInsertedIdList As New List(Of Integer)()

	Private Sub ProvideRowInsertionCore(ByVal control As ASPxScheduler)
		AddHandler control.AppointmentRowInserting, AddressOf ControlOnAppointmentRowInserting
		AddHandler control.AppointmentRowInserted, AddressOf ControlOnAppointmentRowInserted
		AddHandler control.AppointmentsInserted, AddressOf ControlOnAppointmentsInserted
		AddHandler control.AppointmentCollectionCleared, AddressOf OnControlAppointmentCollectionCleared
	End Sub

	Public Sub ProvideRowInsertion(ByVal control As ASPxScheduler, ByVal dataSource As DataSourceControl)
		If TypeOf dataSource Is AccessDataSource Then
			AddHandler TryCast(dataSource, AccessDataSource).Inserted, AddressOf AppointmentsAccessDataSource_Inserted
		End If
		If TypeOf dataSource Is EntityDataSource Then
			AddHandler TryCast(dataSource, EntityDataSource).Inserted, AddressOf AppointmentsEntityDataSource_Inserted
		End If
		ProvideRowInsertionCore(control)
	End Sub
	Public Sub ProvideRowInsertion(ByVal control As ASPxScheduler, ByVal dataSource As DevExpress.Web.DemoUtils.DemoDataSource)
		AddHandler dataSource.Inserted, AddressOf AppointmentsAccessDataSource_Inserted
		ProvideRowInsertionCore(control)
	End Sub

	Private Sub OnControlAppointmentCollectionCleared(ByVal sender As Object, ByVal e As EventArgs)
		Me.lastInsertedIdList.Clear()
	End Sub

	Private Sub ControlOnAppointmentRowInserting(ByVal sender As Object, ByVal e As ASPxSchedulerDataInsertingEventArgs)
		' Autoincremented primary key case
		e.NewValues.Remove("ID")
	End Sub
	Private Sub ControlOnAppointmentRowInserted(ByVal sender As Object, ByVal e As ASPxSchedulerDataInsertedEventArgs)
		' Autoincremented primary key case
		Dim count As Integer = Me.lastInsertedIdList.Count
		System.Diagnostics.Debug.Assert(count > 0)
		e.KeyFieldValue = Me.lastInsertedIdList(count - 1)
	End Sub
	Private Sub AppointmentsAccessDataSource_Inserted(ByVal sender As Object, ByVal e As SqlDataSourceStatusEventArgs)
		' Autoincremented primary key case
		Dim connection As OleDbConnection = CType(e.Command.Connection, OleDbConnection)
		Using cmd As New OleDbCommand("SELECT @@IDENTITY", connection)
			Me.lastInsertedIdList.Add(CInt(Fix(cmd.ExecuteScalar())))
		End Using
	End Sub
	Private Sub AppointmentsEntityDataSource_Inserted(ByVal sender As Object, ByVal e As EntityDataSourceChangedEventArgs)
		Me.lastInsertedIdList.Add((TryCast(e.Entity, MedicsSchedulingDb_MedicalAppointments)).ID)
	End Sub
	Private Sub ControlOnAppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
		' Autoincremented primary key case
		Dim count As Integer = e.Objects.Count
		System.Diagnostics.Debug.Assert(count = Me.lastInsertedIdList.Count)
		Dim storage As ASPxSchedulerStorage = CType(sender, ASPxSchedulerStorage)
		For i As Integer = 0 To count - 1
			Dim apt As Appointment = CType(e.Objects(i), Appointment)
			Dim appointmentId As Integer = Me.lastInsertedIdList(i)
			storage.SetAppointmentId(apt, appointmentId)
		Next i

		Me.lastInsertedIdList.Clear()
	End Sub
End Class
Public Class ObjectDataSourceRowInsertionProvider
	Private lastInsertedIdList As New List(Of Object)()

	Public Sub ProvideRowInsertion(ByVal control As ASPxScheduler, ByVal dataSource As ObjectDataSource)
		AddHandler control.AppointmentsInserted, AddressOf control_AppointmentsInserted
		AddHandler control.AppointmentCollectionCleared, AddressOf control_AppointmentCollectionCleared
		AddHandler dataSource.Inserted, AddressOf dataSource_Inserted
	End Sub

	Private Sub control_AppointmentCollectionCleared(ByVal sender As Object, ByVal e As EventArgs)
		Me.lastInsertedIdList.Clear()
	End Sub
	Private Sub dataSource_Inserted(ByVal sender As Object, ByVal e As ObjectDataSourceStatusEventArgs)
		Me.lastInsertedIdList.Add(e.ReturnValue)
	End Sub
	Private Sub control_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
		Dim storage As ASPxSchedulerStorage = CType(sender, ASPxSchedulerStorage)
		Dim count As Integer = e.Objects.Count
		System.Diagnostics.Debug.Assert(count = Me.lastInsertedIdList.Count)
		For i As Integer = 0 To count - 1 'B184873
			Dim apt As Appointment = CType(e.Objects(i), Appointment)
			storage.SetAppointmentId(apt, Me.lastInsertedIdList(i))
		Next i
		Me.lastInsertedIdList.Clear()
	End Sub
End Class
Public Class DataSourceControlRowInsertionProvider
	Private lastInsertedIdList As New List(Of Object)()

	Public Sub ProvideRowInsertion(ByVal control As ASPxScheduler, ByVal dataSource As DevExpress.Web.DemoUtils.SchedulerDemoDataSource)
		AddHandler control.AppointmentRowInserting, AddressOf ControlOnAppointmentRowInserting
		AddHandler control.AppointmentRowInserted, AddressOf ControlOnAppointmentRowInserted
		AddHandler control.AppointmentsInserted, AddressOf control_AppointmentsInserted
		AddHandler control.AppointmentCollectionCleared, AddressOf control_AppointmentCollectionCleared
	End Sub

	Private Sub control_AppointmentCollectionCleared(ByVal sender As Object, ByVal e As EventArgs)
		Me.lastInsertedIdList.Clear()
	End Sub
	Private Sub ControlOnAppointmentRowInserting(ByVal sender As Object, ByVal e As ASPxSchedulerDataInsertingEventArgs)
		Me.lastInsertedIdList.Add(e.GetHashCode())
	End Sub
	Private Sub ControlOnAppointmentRowInserted(ByVal sender As Object, ByVal e As ASPxSchedulerDataInsertedEventArgs)
		e.KeyFieldValue = Me.lastInsertedIdList(Me.lastInsertedIdList.Count - 1)
	End Sub
	Private Sub control_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
		Dim storage As ASPxSchedulerStorage = CType(sender, ASPxSchedulerStorage)
		Dim count As Integer = e.Objects.Count
		System.Diagnostics.Debug.Assert(count = Me.lastInsertedIdList.Count)
		For i As Integer = 0 To count - 1
			Dim apt As Appointment = CType(e.Objects(i), Appointment)
			storage.SetAppointmentId(apt, Me.lastInsertedIdList(i))
		Next i
		Me.lastInsertedIdList.Clear()
	End Sub
End Class
