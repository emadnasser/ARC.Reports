Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Partial Public Class MonthReport
		Inherits XtraSchedulerReport
		Implements IVisibleWeekDaysReport

		Public Sub New()

			InitializeComponent()
		End Sub
		Public Property VisibleWeekDays() As WeekDays Implements IVisibleWeekDaysReport.VisibleWeekDays
			Get
				Return Me.horizontalWeek1.VisibleWeekDays
			End Get
			Set(ByVal value As WeekDays)
				Me.horizontalWeek1.VisibleWeekDays = value
			End Set
		End Property

	End Class
End Namespace
