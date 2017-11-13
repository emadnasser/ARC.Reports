Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.DailyStyle
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Partial Public Class Report
		Inherits XtraSchedulerReport

		Public Sub New()

			InitializeComponent()
		End Sub
		Public Property GroupType() As SchedulerGroupType
			Get
				Return Me.reportDayView1.GroupType
			End Get
			Set(ByVal value As SchedulerGroupType)
				Me.reportDayView1.GroupType = value
			End Set
		End Property
		Public Property VisibleResourceCount() As Integer
			Get
				Return Me.reportDayView1.VisibleResourceCount
			End Get
			Set(ByVal value As Integer)
				Me.reportDayView1.VisibleResourceCount = value
			End Set
		End Property
		Public Property TimeScale() As TimeSpan
			Get
				Return Me.dayViewTimeCells1.TimeScale
			End Get
			Set(ByVal value As TimeSpan)
				Me.dayViewTimeCells1.TimeScale = value
			End Set
		End Property
		Public Property VisibleTime() As TimeOfDayInterval
			Get
				Return Me.dayViewTimeCells1.VisibleTime
			End Get
			Set(ByVal value As TimeOfDayInterval)
				Me.dayViewTimeCells1.VisibleTime = value
			End Set
		End Property
		Public Property PrintAllAppointments() As Boolean
			Get
				Return dayViewTimeCells1.ExtraCells.Visible
			End Get
			Set(ByVal value As Boolean)
				dayViewTimeCells1.ExtraCells.Visible = value
			End Set
		End Property
		Public Property VisibleDayCount() As Integer
			Get
				Return Me.reportDayView1.VisibleDayCount
			End Get
			Set(ByVal value As Integer)
				Me.reportDayView1.VisibleDayCount = value
			End Set
		End Property
	End Class
End Namespace
