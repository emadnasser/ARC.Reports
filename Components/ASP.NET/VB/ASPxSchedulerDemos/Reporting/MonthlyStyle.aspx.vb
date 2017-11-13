Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Partial Public Class Reporting_MonthlyStyle
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As New MonthlyStyleReport()
		report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter
		report.SchedulerAdapter.TimeInterval = New TimeInterval(SchedulerDemoUtils.BaseDate, SchedulerDemoUtils.BaseDate.AddMonths(1))

		ReportViewer.Report = report
		ApplyOptions(report)
	End Sub

	Private Sub ApplyOptions(ByVal report As MonthlyStyleReport)
		report.CompressWeekEnd = chkCompressWeekend.Checked
		report.DontPrintWeekends = chkDontPrintWeekends.Checked
		report.PrintExactlyOneMonth = chkExactlyOneMonth.Checked
		report.ResourceCount = CInt(Fix(cbResourceCount.Value))
		report.ColumnCount = CInt(Fix(cbLayout.Value))

	End Sub
End Class
