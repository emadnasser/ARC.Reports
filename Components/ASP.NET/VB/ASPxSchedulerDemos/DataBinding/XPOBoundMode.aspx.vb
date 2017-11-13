Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.Demos
Imports DevExpress.Xpo

Partial Public Class DataBinding_XPOBoundMode
	Inherits System.Web.UI.Page
	Private xpoSession As Session
	Private lastInsertedId As Object

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		InitDataSources()
		SetupMappings()
	End Sub

	Private Sub InitDataSources()
		Me.xpoSession = XpoHelper.GetNewSession()
		appointmentDataSource.Session = Me.xpoSession
		resourceDataSource.Session = Me.xpoSession
		AddHandler appointmentDataSource.Inserted, AddressOf appointmentDataSource_OnInserted
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		AttachDataSources()
		If IsStorageEmpty() Then
			PopulateDataSources()
		End If
		AddHandler xpoSession.BeforeCommitTransaction, AddressOf xpoSession_BeforeCommitTransaction
		ASPxScheduler1.OptionsBehavior.ShowDetailedErrorInfo = False
	End Sub
	Private Sub xpoSession_BeforeCommitTransaction(ByVal sender As Object, ByVal e As SessionManipulationEventArgs)
		Utils.AssertNotReadOnlyText()
	End Sub
	Protected Overrides Sub OnUnload(ByVal e As EventArgs)
		MyBase.OnUnload(e)
		If Me.xpoSession IsNot Nothing Then
			Me.xpoSession.Dispose()
		End If
	End Sub

	Private Sub AttachDataSources()
		ASPxScheduler1.AppointmentDataSource = appointmentDataSource
		ASPxScheduler1.ResourceDataSource = resourceDataSource
		ASPxScheduler1.DataBind()
	End Sub
	Private Function IsStorageEmpty() As Boolean
		Return ASPxScheduler1.Storage.Appointments.Count = 0
	End Function

	Private Sub SetupMappings()
		ASPxScheduler1.Storage.BeginUpdate()
		Try
			Dim aptMappings As ASPxAppointmentMappingInfo = ASPxScheduler1.Storage.Appointments.Mappings
			aptMappings.AllDay = "AllDay"
			aptMappings.Description = "Description"
			aptMappings.End = "Finish"
			aptMappings.Label = "Label"
			aptMappings.Location = "Location"
			aptMappings.RecurrenceInfo = "Recurrence"
			aptMappings.ReminderInfo = "Reminder"
			aptMappings.ResourceId = "Employee!Key"
			aptMappings.Start = "Created"
			aptMappings.Status = "Status"
			aptMappings.Subject = "Subject"
			aptMappings.Type = "AppointmentType"
			aptMappings.AppointmentId = "Oid"

			Dim resourceMappings As ASPxResourceMappingInfo = ASPxScheduler1.Storage.Resources.Mappings
			resourceMappings.Caption = "Name"
			resourceMappings.ResourceId = "Oid"
		Finally
			ASPxScheduler1.Storage.EndUpdate()
		End Try
	End Sub
	Private Sub appointmentDataSource_OnInserted(ByVal sender As Object, ByVal e As XpoDataSourceInsertedEventArgs)
		Me.lastInsertedId = (CType(e.Value, XPObject)).Oid
	End Sub
	Protected Sub ASPxScheduler1_AppointmentRowInserted(ByVal sender As Object, ByVal e As ASPxSchedulerDataInsertedEventArgs)
		e.KeyFieldValue = Me.lastInsertedId
	End Sub

	#Region "Populate database with initial data"
	Private Sub PopulateDataSources()
		For i As Integer = 0 To 4
			Dim employee As Employee = AddEmployee(SchedulerDemoUtils.Users(i))
			AddTasks(employee)
		Next i
		ASPxScheduler1.DataBind()
	End Sub
	Private Function AddEmployee(ByVal name As String) As Employee
		Dim employee As New Employee(Me.xpoSession)
		employee.Name = name
		employee.Save()
		Return employee
	End Function
	Private Sub AddTasks(ByVal employee As Employee)
		AddTask(employee, "meeting", 2, 5)
		AddTask(employee, "travel", 3, 6)
		AddTask(employee, "phone call", 0, 10)
	End Sub
	Private Sub AddTask(ByVal employee As Employee, ByVal taskName As String, ByVal status As Integer, ByVal label As Integer)
		Dim task As New Task(Me.xpoSession)
		task.Employee = employee
		task.Subject = employee.Name & "'s " & taskName

		Dim rangeInHours As Integer = 72
		task.Created = SchedulerDemoUtils.BaseDate + TimeSpan.FromHours(SchedulerDemoUtils.RandomInstance.Next(0, rangeInHours))
		task.Finish = task.Created + TimeSpan.FromHours(SchedulerDemoUtils.RandomInstance.Next(0, rangeInHours \ 12))

		task.Status = status
		task.Label = label

		task.Save()
	End Sub
	#End Region
End Class
