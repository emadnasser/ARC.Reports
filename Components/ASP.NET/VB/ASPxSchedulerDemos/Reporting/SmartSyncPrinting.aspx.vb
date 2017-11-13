Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Reporting

Partial Public Class Reporting_SmartSyncPrinting
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim adapter As SchedulerPrintAdapter = ReportsDataSource1.SchedulerStorageAdapter
		adapter.TimeInterval = New TimeInterval(SchedulerDemoUtils.BaseDate.AddDays(17), TimeSpan.FromDays(4))
		adapter.EnableSmartSync = True
		AddHandler adapter.ValidateResources, AddressOf SchedulerPrintAdapter_ValidateResources

		Dim report As New SmartSyncPrintingReport()
		report.SchedulerAdapter = adapter
		ReportViewer.Report = report

		InitializeControlValues(adapter)

		ApplyOptions(adapter)

	End Sub
	Private Sub InitializeControlValues(ByVal adapter As SchedulerPrintAdapter)
		If (Not IsPostBack) Then
			Me.rbGroupType.Value = Convert.ToInt32(adapter.SmartSyncOptions.GroupType)
		End If
	End Sub
	Private Sub ApplyOptions(ByVal adapter As SchedulerPrintAdapter)
		adapter.SmartSyncOptions.GroupType = CType(rbGroupType.Value, SchedulerGroupType)
	End Sub
	Private Sub SchedulerPrintAdapter_ValidateResources(ByVal sender As Object, ByVal e As ResourcesValidationEventArgs)
		If e.Resources.Count = 0 Then
			Return
		End If

		Dim r1 As Resource = e.Resources(0)
		Dim r2 As Resource = e.Resources(2)
		e.Resources.BeginUpdate()
		Try
			e.Resources.Clear()
			e.Resources.Add(r1)
			e.Resources.Add(r2)
		Finally
			e.Resources.EndUpdate()

		End Try

	End Sub

End Class
