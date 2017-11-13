Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.XtraScheduler

Partial Public Class Miscellaneous_Reminders
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
'        
'            The following code utilizes the DataHelper class, which is implemented
'            solely for the ASPxScheduler Demo project.
'            It is intended to hide unnecessary details and clarify the main idea.
'            For the recommended data binding techniques, please refer to the
'            Data Binding section modules:
'              ~/DataBinding/BoundMode.aspx for MS Access database
'              ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
'              ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
'        
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		DataHelper.SetupCustomEventsMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, schedulerDataSource.AppointmentDataSource)
		schedulerDataSource.AttachTo(ASPxScheduler1)
	End Sub
	Protected Sub SPxScheduler1_OnBeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As SchedulerCallbackCommandEventArgs)
		If e.CommandId = "CREATAPTWR" Then
			e.Command = New CreateAppointmentWithReminderCallbackCommand(ASPxScheduler1)
		End If
	End Sub
End Class

#Region "CreateAppointmentWithReminderCallbackCommand"
Public Class CreateAppointmentWithReminderCallbackCommand
	Inherits SchedulerCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub

	Public Overrides ReadOnly Property Id() As String
		Get
			Return "CREATAPTWR"
		End Get
	End Property
	Public Overrides ReadOnly Property RequiresControlHierarchy() As Boolean
		Get
			Return True
		End Get
	End Property

	Protected Overrides Sub ParseParameters(ByVal parameters As String)
		' do nothing
	End Sub
	Protected Overrides Sub ExecuteCore()
		Dim nowTime As DateTime = DateTime.Now
		Dim now As New DateTime(nowTime.Year, nowTime.Month, nowTime.Day, nowTime.Hour, nowTime.Minute, nowTime.Second)
		now = now + TimeSpan.FromMinutes(5) + TimeSpan.FromSeconds(5)
		Dim apt As Appointment = Control.Storage.CreateAppointment(AppointmentType.Normal)
		apt.Start = now
		apt.Duration = TimeSpan.FromHours(2)
		apt.Subject = "Appointment with Reminder"
		apt.HasReminder = True
		apt.Reminder.TimeBeforeStart = TimeSpan.FromMinutes(5)
		apt.ResourceId = EmptyResourceId.Id
		apt.StatusKey = CInt(Fix(AppointmentStatusType.Busy))
		apt.LabelKey = 1
		Control.Storage.Appointments.Add(apt)
		Control.Start = DateTime.Today
	End Sub
End Class
#End Region
