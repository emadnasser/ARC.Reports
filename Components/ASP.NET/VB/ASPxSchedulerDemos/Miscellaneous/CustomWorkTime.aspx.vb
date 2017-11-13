Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler

Partial Public Class Miscellaneous_CustomWorkTime
	Inherits System.Web.UI.Page
	Private ReadOnly Property Storage() As ASPxSchedulerStorage
		Get
			Return ASPxScheduler1.Storage
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)

		If ASPxScheduler1.ActiveViewType.Equals(SchedulerViewType.Timeline) AndAlso (Not IsCallback) Then
			ASPxScheduler1.Start = ASPxScheduler1.Start.AddHours(5)
		End If

		ASPxScheduler1.DataBind()
		If chkCustomWorkTime.Checked Then
			ASPxScheduler1.JSProperties("cp_workTimes") = workTimes
		Else
			ASPxScheduler1.JSProperties("cp_workTimes") = defaultWorkTime
		End If
	End Sub

	Private workTimes() As TimeOfDayInterval = { New TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(16)), New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(19)), New TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(18)), New TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(19)), New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(20)), New TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(19)), New TimeOfDayInterval(TimeSpan.FromHours(6), TimeSpan.FromHours(17)) }


	Private defaultWorkTime() As TimeOfDayInterval = { New TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18)) }

	Protected Sub ASPxScheduler1_QueryWorkTime(ByVal sender As Object, ByVal e As QueryWorkTimeEventArgs)
		If (Not chkCustomWorkTime.Checked) OrElse ASPxScheduler1.Storage.Resources Is Nothing Then
			Return
		End If

		Dim resourceIndex As Integer
		Int32.TryParse(e.Resource.Id.ToString(), resourceIndex)
		If resourceIndex >= 0 Then
			e.WorkTime = workTimes(resourceIndex)
		End If
	End Sub
End Class
