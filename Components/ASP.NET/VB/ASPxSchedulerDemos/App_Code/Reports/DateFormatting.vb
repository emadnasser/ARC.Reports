Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler



Public Class DateFormattingReport
	Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
	#Region "Fields"
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders
	Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView
	Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells
	Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler
	Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
	#End Region
	Private formatTimeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo

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
		Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
		Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
		Me.horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
		Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
		Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
		Me.formatTimeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo()
		CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.calendarControl1, Me.horizontalDateHeaders1, Me.dayViewTimeCells1, Me.dayViewTimeRuler1, Me.formatTimeIntervalInfo1})
		Me.Detail.Height = 205
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' calendarControl1
		' 
		Me.calendarControl1.Location = New System.Drawing.Point(292, 0)
		Me.calendarControl1.Name = "calendarControl1"
		Me.calendarControl1.Size = New System.Drawing.Size(350, 142)
		Me.calendarControl1.TimeCells = Me.dayViewTimeCells1
		Me.calendarControl1.View = Me.reportDayView1
		' 
		' dayViewTimeCells1
		' 
		Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalDateHeaders1
		Me.dayViewTimeCells1.Location = New System.Drawing.Point(54, 173)
		Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
		Me.dayViewTimeCells1.Size = New System.Drawing.Size(595, 30)
		Me.dayViewTimeCells1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
		Me.dayViewTimeCells1.View = Me.reportDayView1
		' 
		' horizontalDateHeaders1
		' 
		Me.horizontalDateHeaders1.Location = New System.Drawing.Point(54, 148)
		Me.horizontalDateHeaders1.Name = "horizontalDateHeaders1"
		Me.horizontalDateHeaders1.Size = New System.Drawing.Size(595, 25)
		Me.horizontalDateHeaders1.View = Me.reportDayView1
		' 
		' reportDayView1
		' 
		Me.reportDayView1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None
		Me.reportDayView1.VisibleDayCount = 2
		' 
		' dayViewTimeRuler1
		' 
		Me.dayViewTimeRuler1.Corners.Top = 25
		Me.dayViewTimeRuler1.Location = New System.Drawing.Point(4, 148)
		Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
		Me.dayViewTimeRuler1.Size = New System.Drawing.Size(50, 55)
		Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
		Me.dayViewTimeRuler1.View = Me.reportDayView1
		' 
		' formatTimeIntervalInfo1
		' 
		Me.formatTimeIntervalInfo1.Location = New System.Drawing.Point(0, 8)
		Me.formatTimeIntervalInfo1.Name = "formatTimeIntervalInfo1"
		Me.formatTimeIntervalInfo1.Size = New System.Drawing.Size(300, 125)
		Me.formatTimeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
		' 
		' DateFormattingReport
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
		Me.Version = "9.2"
		Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportDayView1})
		CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	#End Region

End Class
