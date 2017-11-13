Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Reporting

Partial Public Class Reporting_AutoHeight
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		InitializeControlValues()

		Dim report As XtraSchedulerReport = CreateReport()
		report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter
		report.SchedulerAdapter.TimeInterval = New TimeInterval(New DateTime(2016, 10, 10), TimeSpan.FromDays(14))
		ReportViewer.Report = report
		ApplyOptions(report)

	End Sub
	Private Sub InitializeControlValues()
		If (Not IsPostBack) Then
			Me.rbView.Value = 0
		End If
	End Sub
	Private Function CreateReport() As XtraSchedulerReport
		If CInt(Fix(rbView.Value)) = 0 Then
			Return New AutoHeightMonth()
		Else
			Return New AutoHeightTimeline()
		End If
	End Function
	Private Sub ApplyOptions(ByVal report As XtraSchedulerReport)
		Dim autoHeightReport As IAutoHeightReport = CType(report, IAutoHeightReport)
		autoHeightReport.CellsCanGrow = chkCanGrow.Checked
		autoHeightReport.CellsCanShrink = chkCanShrink.Checked
		autoHeightReport.CellsHeight = CSng(spinHeight.Number)
	End Sub
End Class
