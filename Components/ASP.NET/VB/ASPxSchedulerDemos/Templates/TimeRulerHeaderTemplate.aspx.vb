Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.Demos.ASPxScheduler
Imports DevExpress.XtraScheduler

Partial Public Class Templates_TimeRulerHeaderTemplate
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
		SetTimeRulersProperties()
		ASPxScheduler1.DataBind()
	End Sub
	Private Sub SetTimeRulersProperties()
		For Each ruler As TimeRuler In ASPxScheduler1.DayView.TimeRulers
			ruler.ShowMinutes = True
		Next ruler
	End Sub
	Protected Sub ASPxScheduler1_BeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As SchedulerCallbackCommandEventArgs)
		If e.CommandId = ChangeTimeZoneCallbackCommand.CommandId Then
			e.Command = New ChangeTimeZoneCallbackCommand(CType(sender, ASPxScheduler))
		End If
	End Sub
End Class
