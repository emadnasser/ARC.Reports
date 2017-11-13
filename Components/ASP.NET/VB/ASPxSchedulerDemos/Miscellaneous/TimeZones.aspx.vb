Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Native

Partial Public Class Miscellaneous_TimeZones
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
		SchedulerDemoUtils.ApplyWorkTime(Me, ASPxScheduler1)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ASPxScheduler1.DataBind()

		UpdateTimeRulers()
	End Sub
	Protected Sub ASPxScheduler1_AfterExecuteCallbackCommand(ByVal sender As Object, ByVal e As SchedulerCallbackCommandEventArgs)
		If e.CommandId = SchedulerCallbackCommandId.ChangeTimeZone Then
			UpdateTimeRulers()
		End If
	End Sub
	Private Sub UpdateTimeRulers()
		ASPxScheduler1.BeginUpdate()
		Try
			UpdateClientTimeRuler(ASPxScheduler1.DayView)
			UpdateClientTimeRuler(ASPxScheduler1.WorkWeekView)
			UpdateClientTimeRuler(ASPxScheduler1.FullWeekView)
			UpdateServerTimeRuler(ASPxScheduler1.DayView)
			UpdateServerTimeRuler(ASPxScheduler1.WorkWeekView)
			UpdateServerTimeRuler(ASPxScheduler1.FullWeekView)
		Finally
			ASPxScheduler1.EndUpdate()
		End Try
	End Sub
	Private Sub UpdateClientTimeRuler(ByVal view As DevExpress.Web.ASPxScheduler.DayView)
		Dim ruler As TimeRuler = view.TimeRulers(2)
		Dim tzId As String = ASPxScheduler1.OptionsBehavior.ClientTimeZoneId
		Dim tzi As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(tzId)
		ruler.TimeZoneId = tzId
		ruler.Caption = String.Format("Client: {0}", tzi.DisplayName)
	End Sub
	Private Sub UpdateServerTimeRuler(ByVal view As DevExpress.Web.ASPxScheduler.DayView)
		Dim ruler As TimeRuler = view.TimeRulers(1)
		ruler.TimeZoneId = TimeZoneInfo.Local.Id
	End Sub
End Class
