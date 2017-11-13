Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Schedule
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Native

Partial Public Class Miscellaneous_Holidays
	Inherits System.Web.UI.Page
	Protected ReadOnly Property IsLocationSelected() As Boolean
		Get
			Return cbLocation.SelectedIndex > 0
		End Get
	End Property
	Protected ReadOnly Property SelectedLocation() As String
		Get
			Return cbLocation.Text
		End Get
	End Property

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
		DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource)
		DataSource1.AttachTo(ASPxScheduler1)

		If IsLocationSelected Then
			Dim holidays As HolidayBaseCollection = SchedulerDemoUtils.LoadHolidaysFromXml(Page.MapPath("~/App_Data/holidays.xml"), SelectedLocation)
			AddHolidaysToScheduler(holidays)
			btnGenerate.ClientEnabled = True
			btnClear.ClientEnabled = True
		End If
		If (Not IsPostBack) Then
			Clear()
			GenerateDefaultAppointmentsHolidays()
			Dim appointments As AppointmentBaseCollection = ASPxScheduler1.Storage.GetAppointments(DateTime.Now, DateTime.Now.AddMonths(6))
			appointments.Sort(New AppointmentStartDateComparer())
			If appointments.Count > 0 Then
				ASPxScheduler1.Start = appointments(0).Start
			End If
		End If

		ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.RenderAppointments Or ASPxSchedulerChangeAction.NotifyVisibleIntervalsChanged)
	End Sub

	Private Sub Clear()
		Dim command As New HolidaysClearCallbackCommand(ASPxScheduler1)
		command.Execute(String.Empty)
	End Sub
	Private Sub GenerateDefaultAppointmentsHolidays()
		Dim command As New HolidaysGenerateCallbackCommand(ASPxScheduler1)
		command.Execute(String.Empty)
	End Sub
	Private Sub AddHolidaysToScheduler(ByVal holidays As HolidayBaseCollection)
		ASPxScheduler1.BeginUpdate()
		Try
			ASPxScheduler1.WorkDays.Clear()
			ASPxScheduler1.WorkDays.Add(WeekDays.WorkDays)
			ASPxScheduler1.WorkDays.AddRange(holidays)
		Finally
			ASPxScheduler1.EndUpdate()
		End Try
	End Sub
	Protected Sub ASPxScheduler1_BeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As SchedulerCallbackCommandEventArgs)
		If e.CommandId = "HOLGNR" Then
			e.Command = New HolidaysGenerateCallbackCommand(ASPxScheduler1)
		End If
		If e.CommandId = "HOLCLEAR" Then
			e.Command = New HolidaysClearCallbackCommand(ASPxScheduler1)
		End If
	End Sub
End Class
#Region "HolidaysGenerateCallbackCommand"
Public Class HolidaysGenerateCallbackCommand
	Inherits SchedulerCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub
	Public Overrides ReadOnly Property Id() As String
		Get
			Return "HOLGNR"
		End Get
	End Property

	Protected Overrides Sub ParseParameters(ByVal parameters As String)
		'do nothing
	End Sub
	Protected Overrides Sub ExecuteCore()
		Dim storage As ASPxSchedulerStorage = Control.Storage
		Dim apts As AppointmentBaseCollection = HolidaysHelper.GenerateHolidayAppointments(storage, Control.WorkDays)
		storage.BeginUpdate()
		Try
			storage.Appointments.Items.AddRange(apts)
		Finally
			storage.EndUpdate()
		End Try
	End Sub
End Class
#End Region

#Region "HolidaysClearCallbackCommand"
Public Class HolidaysClearCallbackCommand
	Inherits SchedulerCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub
	Public Overrides ReadOnly Property Id() As String
		Get
			Return "HOLCLEAR"
		End Get
	End Property

	Protected Overrides Sub ParseParameters(ByVal parameters As String)
		'do nothing
	End Sub
	Protected Overrides Sub ExecuteCore()
		Control.Storage.Appointments.Items.Clear()
	End Sub
End Class
#End Region
