Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports DevExpress.Web
Imports DevExpress.XtraScheduler

Partial Public Class PrintSchedule
	Inherits System.Web.UI.Page
	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.ApplyTheme(Me)
	End Sub

	Protected ReadOnly Property StartDate() As DateTime
		Get
			Dim dateString As String = Nothing
			If Utils.TryGetClientStateValue(Of String)(Me, "StartDate", dateString) Then
				Return DateTime.Parse(dateString, CultureInfo.InvariantCulture)
			End If
			Return DateTime.Now
		End Get
	End Property

	Protected ReadOnly Property EndDate() As DateTime
		Get
			Dim dateString As String = Nothing
			If Utils.TryGetClientStateValue(Of String)(Me, "EndDate", dateString) Then
				Return DateTime.Parse(dateString, CultureInfo.InvariantCulture)
			End If
			Return DateTime.Now.AddMonths(1)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report = New ScheduleReport()
		report.SchedulerAdapter = PrintAdapter.SchedulerAdapter
		report.SchedulerAdapter.TimeInterval = New TimeInterval(StartDate, EndDate)
		ScheduleReportViewer.Report = report
	End Sub

	Protected Sub StartDateEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			CType(sender, ASPxDateEdit).Date = StartDate
		End If
	End Sub

	Protected Sub EndDateEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			CType(sender, ASPxDateEdit).Date = EndDate
		End If
	End Sub
End Class
