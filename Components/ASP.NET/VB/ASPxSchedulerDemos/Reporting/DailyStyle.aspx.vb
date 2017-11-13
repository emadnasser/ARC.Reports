Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Partial Public Class Reporting_DailyStyle
	Inherits System.Web.UI.Page
	Private ReadOnly Property Start() As DateTime
		Get
			Return CDate(edtStart.Value)
		End Get
	End Property
	Private ReadOnly Property [End]() As DateTime
		Get
			Return CDate(edtEnd.Value)
		End Get
	End Property
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As New DailyStyleReport()
		report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter
		ReportViewer.Report = report

		InitializeControlValues()
		ApplyOptions(report)
	End Sub
	Private Sub InitializeControlValues()
		If (Not IsPostBack) Then
			Me.edtStart.Value = SchedulerDemoUtils.BaseDate
			Me.edtEnd.Value = SchedulerDemoUtils.BaseDate.AddDays(10)
		End If
	End Sub
	Private Sub ApplyOptions(ByVal report As DailyStyleReport)
		report.SchedulerAdapter.TimeInterval = New TimeInterval(Start, [End])

		report.DayCount = CInt(Fix(cbDayCount.Value))
		report.ResourceCount = CInt(Fix(cbResourceCount.Value))
		report.TimeScale = TimeSpan.FromMinutes(CInt(Fix(cbTimeScale.Value)))
		report.PrintAllAppointments = chkPrintAllAppointments.Checked
	End Sub
End Class
