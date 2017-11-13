Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxScheduler
Imports System.Web.UI.WebControls
Imports System.Data.OleDb
Imports DevExpress.XtraScheduler
Imports System.Collections.Generic

Partial Public Class Overview
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupLabels(ASPxScheduler1)
		DataHelper.SetupStatuses(ASPxScheduler1)
		PrepareViews(ASPxScheduler1)
	End Sub
	Private Sub PrepareViews(ByVal scheduler As ASPxScheduler)
		PrepareResourceImageStyle(scheduler.Views.DayView.DayViewStyles.HorizontalResourceHeader)
		PrepareResourceImageStyle(scheduler.Views.WorkWeekView.WorkWeekViewStyles.HorizontalResourceHeader)
		PrepareResourceImageStyle(scheduler.Views.WeekView.WeekViewStyles.HorizontalResourceHeader)
		PrepareResourceImageStyle(scheduler.Views.TimelineView.TimelineViewStyles.VerticalResourceHeader)
	End Sub
	Private Sub PrepareResourceImageStyle(ByVal style As ResourceHeaderStyle)
		style.ResourceImageStyle.Width = Unit.Pixel(120)
	End Sub
End Class
