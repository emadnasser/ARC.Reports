Imports Microsoft.VisualBasic
Imports System


Public Class DataValidationReport
	Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private timelineScaleHeaders1 As DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders
	Private timelineCells1 As DevExpress.XtraScheduler.Reporting.TimelineCells
	Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
	Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo
	Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
	Private reportTimelineView1 As DevExpress.XtraScheduler.Reporting.ReportTimelineView
	Private resourceInfo1 As DevExpress.XtraScheduler.Reporting.ResourceInfo
	Private xrShape1 As DevExpress.XtraReports.UI.XRShape


	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()

	End Sub
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

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
		Dim shapeStar1 As New DevExpress.XtraPrinting.Shape.ShapeStar()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
		Me.timelineCells1 = New DevExpress.XtraScheduler.Reporting.TimelineCells()
		Me.timelineScaleHeaders1 = New DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders()
		Me.reportTimelineView1 = New DevExpress.XtraScheduler.Reporting.ReportTimelineView()
		Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
		Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo()
		Me.resourceInfo1 = New DevExpress.XtraScheduler.Reporting.ResourceInfo()
		Me.xrShape1 = New DevExpress.XtraReports.UI.XRShape()
		CType(Me.reportTimelineView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.verticalResourceHeaders1, Me.timelineCells1, Me.calendarControl1, Me.timeIntervalInfo1, Me.timelineScaleHeaders1, Me.resourceInfo1, Me.xrShape1})
		Me.Detail.Height = 860
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' verticalResourceHeaders1
		' 
		Me.verticalResourceHeaders1.Corners.Top = 75
		Me.verticalResourceHeaders1.Location = New System.Drawing.Point(0, 142)
		Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
		Me.verticalResourceHeaders1.Size = New System.Drawing.Size(25, 675)
		Me.verticalResourceHeaders1.TimeCells = Me.timelineCells1
		Me.verticalResourceHeaders1.View = Me.reportTimelineView1
		' 
		' timelineCells1
		' 
		Me.timelineCells1.HorizontalHeaders = Me.timelineScaleHeaders1
		Me.timelineCells1.Location = New System.Drawing.Point(25, 217)
		Me.timelineCells1.Name = "timelineCells1"
		Me.timelineCells1.Size = New System.Drawing.Size(620, 600)
		Me.timelineCells1.View = Me.reportTimelineView1
		' 
		' timelineScaleHeaders1
		' 
		Me.timelineScaleHeaders1.Location = New System.Drawing.Point(25, 142)
		Me.timelineScaleHeaders1.Name = "timelineScaleHeaders1"
		Me.timelineScaleHeaders1.Size = New System.Drawing.Size(620, 75)
		Me.timelineScaleHeaders1.View = Me.reportTimelineView1
		' 
		' reportTimelineView1
		' 
		timeScaleYear1.Enabled = False
		timeScaleQuarter1.Enabled = False
		timeScaleHour1.Enabled = False
		timeScaleFixedInterval1.Enabled = False
		Me.reportTimelineView1.Scales.Add(timeScaleYear1)
		Me.reportTimelineView1.Scales.Add(timeScaleQuarter1)
		Me.reportTimelineView1.Scales.Add(timeScaleMonth1)
		Me.reportTimelineView1.Scales.Add(timeScaleWeek1)
		Me.reportTimelineView1.Scales.Add(timeScaleDay1)
		Me.reportTimelineView1.Scales.Add(timeScaleHour1)
		Me.reportTimelineView1.Scales.Add(timeScaleFixedInterval1)
		Me.reportTimelineView1.VisibleIntervalCount = 5
		Me.reportTimelineView1.VisibleResourceCount = 0
		' 
		' calendarControl1
		' 
		Me.calendarControl1.Location = New System.Drawing.Point(292, 0)
		Me.calendarControl1.Name = "calendarControl1"
		Me.calendarControl1.Size = New System.Drawing.Size(350, 142)
		Me.calendarControl1.TimeCells = Me.timelineCells1
		Me.calendarControl1.View = Me.reportTimelineView1
		' 
		' timeIntervalInfo1
		' 
		Me.timeIntervalInfo1.Location = New System.Drawing.Point(0, 0)
		Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
		Me.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns
		Me.timeIntervalInfo1.Size = New System.Drawing.Size(283, 142)
		Me.timeIntervalInfo1.TimeCells = Me.timelineCells1
		' 
		' resourceInfo1
		' 
		Me.resourceInfo1.Location = New System.Drawing.Point(33, 825)
		Me.resourceInfo1.Name = "resourceInfo1"
		Me.resourceInfo1.Size = New System.Drawing.Size(608, 25)
		Me.resourceInfo1.TimeCells = Me.timelineCells1
		' 
		' xrShape1
		' 
		Me.xrShape1.Location = New System.Drawing.Point(8, 830)
		Me.xrShape1.Name = "xrShape1"
		shapeStar1.StarPointCount = 5
		Me.xrShape1.Shape = shapeStar1
		Me.xrShape1.Size = New System.Drawing.Size(15, 15)
		' 
		' DataValidationReport
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
		Me.Version = "9.2"
		Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportTimelineView1})
		CType(Me.reportTimelineView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub


	#End Region

End Class
