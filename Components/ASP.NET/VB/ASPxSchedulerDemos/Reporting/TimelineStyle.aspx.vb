Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Partial Public Class Reporting_TimelineStyle
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
		Dim report As New TimelineStyleReport()
		report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter
		ReportViewer.Report = report

		InitializeControlValues(report)
		ApplyOptions(report)
	End Sub
	Private Sub InitializeControlValues(ByVal report As TimelineStyleReport)
		InitializeTimeIntervalControls()
	End Sub
	Private Sub InitializeTimeIntervalControls()
		If (Not IsPostBack) Then
			Me.edtStart.Value = SchedulerDemoUtils.BaseDate
			Me.edtEnd.Value = SchedulerDemoUtils.BaseDate.AddMonths(1)
		End If
	End Sub
	Private Sub ApplyOptions(ByVal report As TimelineStyleReport)
		report.SchedulerAdapter.TimeInterval = New TimeInterval(Start, [End])
		report.TimeIntervalCount = CInt(Fix(cbIntervalCount.Value))
		report.ResourceCount = CInt(Fix(cbResourceCount.Value))

		Select Case CInt(Fix(cbTimeScale.Value))
			Case 0
					report.FirstLevelTimeScale = "Year"
					report.SecondLevelTimeScale = "Month"
					Exit Select
			Case 1
					report.FirstLevelTimeScale = "Month"
					report.SecondLevelTimeScale = "Week"
					Exit Select
			Case 2
					report.FirstLevelTimeScale = "Week"
					report.SecondLevelTimeScale = "Day"
					Exit Select
		End Select
	End Sub
End Class
