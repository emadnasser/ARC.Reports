Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Public Class TimelineStyleReport
	Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
	#Region "Fields"
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private timelineScaleHeaders1 As DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders
	Private timelineCells1 As DevExpress.XtraScheduler.Reporting.TimelineCells
	Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
	Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo
	Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
	Private reportTimelineView1 As DevExpress.XtraScheduler.Reporting.ReportTimelineView

	Private firstTimeScale As String
	Private secondTimeScale As String
	#End Region
	#Region "Properties"
	Public Property TimeIntervalCount() As Integer
		Get
			Return reportTimelineView1.VisibleIntervalCount
		End Get
		Set(ByVal value As Integer)
			Me.reportTimelineView1.VisibleIntervalCount = value
		End Set
	End Property
	Public Property ResourceCount() As Integer
		Get
			Return reportTimelineView1.VisibleResourceCount
		End Get
		Set(ByVal value As Integer)
			Me.reportTimelineView1.VisibleResourceCount = value
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

	#End Region
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
		Me.timelineCells1 = New DevExpress.XtraScheduler.Reporting.TimelineCells()
		Me.timelineScaleHeaders1 = New DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders()
		Me.reportTimelineView1 = New DevExpress.XtraScheduler.Reporting.ReportTimelineView()
		Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
		Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo()
		CType(Me.reportTimelineView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.verticalResourceHeaders1, Me.timelineCells1, Me.calendarControl1, Me.timeIntervalInfo1, Me.timelineScaleHeaders1})
		Me.Detail.Height = 846
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' verticalResourceHeaders1
		' 
		Me.verticalResourceHeaders1.Corners.Top = 42
		Me.verticalResourceHeaders1.Location = New System.Drawing.Point(2, 157)
		Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
		Me.verticalResourceHeaders1.Size = New System.Drawing.Size(25, 675)
		Me.verticalResourceHeaders1.TimeCells = Me.timelineCells1
		Me.verticalResourceHeaders1.View = Me.reportTimelineView1
		' 
		' timelineCells1
		' 
		Me.timelineCells1.HorizontalHeaders = Me.timelineScaleHeaders1
		Me.timelineCells1.Location = New System.Drawing.Point(27, 199)
		Me.timelineCells1.Name = "timelineCells1"
		Me.timelineCells1.Size = New System.Drawing.Size(620, 633)
		Me.timelineCells1.View = Me.reportTimelineView1
		' 
		' timelineScaleHeaders1
		' 
		Me.timelineScaleHeaders1.Location = New System.Drawing.Point(27, 157)
		Me.timelineScaleHeaders1.Name = "timelineScaleHeaders1"
		Me.timelineScaleHeaders1.Size = New System.Drawing.Size(620, 42)
		Me.timelineScaleHeaders1.View = Me.reportTimelineView1
		' 
		' reportTimelineView1
		' 
		Me.reportTimelineView1.VisibleIntervalCount = 5
		Me.reportTimelineView1.VisibleResourceCount = 2
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
		' TimelineStyleReport
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
		Me.Version = "9.2"
		Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportTimelineView1})
		CType(Me.reportTimelineView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub


	#End Region

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
