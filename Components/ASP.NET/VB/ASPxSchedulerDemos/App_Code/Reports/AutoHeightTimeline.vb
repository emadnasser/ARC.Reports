Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Public Class AutoHeightTimeline
	Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
	Implements IAutoHeightReport
	#Region "Fields"
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private timelineScaleHeaders1 As DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders
	Private timelineCells As DevExpress.XtraScheduler.Reporting.TimelineCells
	Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
	Private reportTimelineView1 As DevExpress.XtraScheduler.Reporting.ReportTimelineView
	#End Region
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.Container = Nothing

	Public Sub New()
		InitializeComponent()
	End Sub
	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Component Designer generated code"
	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim timeScaleYear1 As New DevExpress.XtraScheduler.TimeScaleYear()
		Dim timeScaleQuarter1 As New DevExpress.XtraScheduler.TimeScaleQuarter()
		Dim timeScaleMonth1 As New DevExpress.XtraScheduler.TimeScaleMonth()
		Dim timeScaleWeek1 As New DevExpress.XtraScheduler.TimeScaleWeek()
		Dim timeScaleDay1 As New DevExpress.XtraScheduler.TimeScaleDay()
		Dim timeScaleHour1 As New DevExpress.XtraScheduler.TimeScaleHour()
		Dim timeScaleFixedInterval1 As New DevExpress.XtraScheduler.TimeScaleFixedInterval()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
		Me.timelineCells = New DevExpress.XtraScheduler.Reporting.TimelineCells()
		Me.timelineScaleHeaders1 = New DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders()
		Me.reportTimelineView1 = New DevExpress.XtraScheduler.Reporting.ReportTimelineView()
		CType(Me.reportTimelineView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.verticalResourceHeaders1, Me.timelineCells, Me.timelineScaleHeaders1})
		Me.Detail.HeightF = 141F
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' verticalResourceHeaders1
		' 
		Me.verticalResourceHeaders1.Corners.Top = 25
		Me.verticalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(5.000051F, 0F)
		Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
		Me.verticalResourceHeaders1.SizeF = New System.Drawing.SizeF(25F, 137.4166F)
		Me.verticalResourceHeaders1.TimeCells = Me.timelineCells
		Me.verticalResourceHeaders1.View = Me.reportTimelineView1
		' 
		' timelineCells
		' 
		Me.timelineCells.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
		Me.timelineCells.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
		Me.timelineCells.HorizontalHeaders = Me.timelineScaleHeaders1
		Me.timelineCells.LocationFloat = New DevExpress.Utils.PointFloat(29.99999F, 25F)
		Me.timelineCells.Name = "timelineCells"
		Me.timelineCells.SizeF = New System.Drawing.SizeF(620F, 110F)
		Me.timelineCells.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
		Me.timelineCells.View = Me.reportTimelineView1
		' 
		' timelineScaleHeaders1
		' 
		Me.timelineScaleHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(29.99999F, 0)
		Me.timelineScaleHeaders1.Name = "timelineScaleHeaders1"
		Me.timelineScaleHeaders1.SizeF = New System.Drawing.SizeF(620F, 25)
		Me.timelineScaleHeaders1.View = Me.reportTimelineView1
		' 
		' reportTimelineView1
		' 
		timeScaleYear1.Enabled = False
		timeScaleQuarter1.Enabled = False
		timeScaleMonth1.Enabled = False
		timeScaleWeek1.DisplayFormat = "MM/dd/yyyy"
		timeScaleWeek1.Enabled = False
		timeScaleDay1.DisplayFormat = "MMMM dd"
		timeScaleHour1.Enabled = False
		timeScaleFixedInterval1.Enabled = False
		Me.reportTimelineView1.Scales.Add(timeScaleYear1)
		Me.reportTimelineView1.Scales.Add(timeScaleQuarter1)
		Me.reportTimelineView1.Scales.Add(timeScaleMonth1)
		Me.reportTimelineView1.Scales.Add(timeScaleWeek1)
		Me.reportTimelineView1.Scales.Add(timeScaleDay1)
		Me.reportTimelineView1.Scales.Add(timeScaleHour1)
		Me.reportTimelineView1.Scales.Add(timeScaleFixedInterval1)
		Me.reportTimelineView1.VisibleIntervalCount = 7
		Me.reportTimelineView1.VisibleResourceCount = 0
		' 
		' AutoHeightTimeline
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
		Me.Version = "10.1"
		Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportTimelineView1})
		CType(Me.reportTimelineView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	#End Region

	#Region "IAutoHeightReport Members"
	Public Property CellsCanShrink() As Boolean Implements IAutoHeightReport.CellsCanShrink
		Get
			Return timelineCells.CanShrink
		End Get
		Set(ByVal value As Boolean)
			timelineCells.CanShrink = value
		End Set
	End Property
	Public Property CellsCanGrow() As Boolean Implements IAutoHeightReport.CellsCanGrow
		Get
			Return timelineCells.CanGrow
		End Get
		Set(ByVal value As Boolean)
			timelineCells.CanGrow = value
		End Set
	End Property
	Public Property CellsHeight() As Single Implements IAutoHeightReport.CellsHeight
		Get
			Return timelineCells.HeightF
		End Get
		Set(ByVal value As Single)
			timelineCells.HeightF = value
		End Set
	End Property
	#End Region
End Class

