Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Partial Public Class Reporting_WeeklyStyle
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
		Dim report As New WeeklyStyleReport()
		report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter

		ReportViewer.Report = report
		InitializeControlValues()
		ApplyOptions(report)
	End Sub
	Private Sub InitializeControlValues()
		If (Not IsPostBack) Then
			Me.edtStart.Value = SchedulerDemoUtils.BaseDate
			Me.edtEnd.Value = SchedulerDemoUtils.BaseDate.AddDays(14)
		End If
	End Sub
	Private Sub ApplyOptions(ByVal report As WeeklyStyleReport)
		report.SchedulerAdapter.TimeInterval = New TimeInterval(Start, [End])
		report.ResourceCount = CInt(Fix(cbResourceCount.Value))
		report.ColumnCount = CInt(Fix(cbLayout.Value))
	End Sub
End Class
