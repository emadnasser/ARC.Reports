Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraReports.UserDesigner

Namespace DevExpress.XtraScheduler.Demos.Reporting

	Partial Public Class SingleReportPreviewControl
		Inherits ReportPreviewControlBase
		Private report_Renamed As XtraSchedulerReport
		Public Overridable ReadOnly Property Report() As XtraSchedulerReport
			Get
				Return report_Renamed
			End Get
		End Property

		Protected Overridable Function CreateReportInstance() As XtraSchedulerReport
			Return Nothing
		End Function
		Protected Overrides Sub CreateReports()
			System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = True
			If Me.report_Renamed IsNot Nothing Then
				Me.report_Renamed.Dispose()
			End If
			Me.report_Renamed = CreateReportInstance()
		End Sub
		Protected Overrides Function GetActiveReport() As XtraSchedulerReport
			Return Report
		End Function

	End Class

End Namespace

