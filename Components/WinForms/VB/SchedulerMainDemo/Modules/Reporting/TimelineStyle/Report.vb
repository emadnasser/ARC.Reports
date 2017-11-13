Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Partial Public Class Report
		Inherits XtraSchedulerReport
		Private firstTimeScale As String ="Year"
		Private secondTimeScale As String = "Month"

		Public Sub New()

			InitializeComponent()
		End Sub
		Public Property VisibleIntervalCount() As Integer
			Get
				Return reportTimelineView1.VisibleIntervalCount
			End Get
			Set(ByVal value As Integer)
				reportTimelineView1.VisibleIntervalCount = value
			End Set
		End Property
		Public Property VisibleResourceCount() As Integer
			Get
				Return reportTimelineView1.VisibleResourceCount
			End Get
			Set(ByVal value As Integer)
				reportTimelineView1.VisibleResourceCount = value
			End Set
		End Property
		Public ReadOnly Property Scales() As TimeScaleCollection
			Get
				Return reportTimelineView1.Scales
			End Get
		End Property
		Public Property FirstLevelTimeScale() As String
			Get
				Return firstTimeScale
			End Get
			Set(ByVal value As String)
				If firstTimeScale = value Then
					Return
				End If
				firstTimeScale = value
				UpdateTimeScales()
			End Set
		End Property
		Public Property SecondLevelTimeScale() As String
			Get
				Return secondTimeScale
			End Get
			Set(ByVal value As String)
				If secondTimeScale = value Then
					Return
				End If
				secondTimeScale = value
				UpdateTimeScales()
			End Set
		End Property

		Private Sub UpdateTimeScales()
			Dim scales As TimeScaleCollection = reportTimelineView1.Scales
			scales.BeginUpdate()
			Try
			For Each item As TimeScale In scales
				item.Enabled = (item.DisplayName = firstTimeScale) OrElse (item.DisplayName = secondTimeScale)
			Next item
			Finally
			scales.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
