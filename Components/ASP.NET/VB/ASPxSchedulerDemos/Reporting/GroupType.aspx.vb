Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Partial Public Class Reporting_GroupType
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		Dim report As New GroupTypeReport()
		report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter
		report.SchedulerAdapter.TimeInterval = New TimeInterval(SchedulerDemoUtils.BaseDate, SchedulerDemoUtils.BaseDate.AddMonths(2))

		ReportViewer.Report = report
		ApplyOptions(report)

	End Sub

	Private Sub ApplyOptions(ByVal report As GroupTypeReport)
		report.GroupType = CType(rbGroupType.Value, SchedulerGroupType)
	End Sub
End Class
