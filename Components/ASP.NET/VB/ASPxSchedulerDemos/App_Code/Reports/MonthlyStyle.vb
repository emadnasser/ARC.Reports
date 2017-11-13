Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler

Public Class MonthlyStyleReport
	Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
	#Region "Fields"
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private reportMonthView1 As DevExpress.XtraScheduler.Reporting.ReportMonthView
	Private horizontalWeek1 As DevExpress.XtraScheduler.Reporting.HorizontalWeek
	Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
	Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
	Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
	Private dayOfWeekHeaders1 As DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders
	#End Region

	#Region "Properties"
	Public Property CompressWeekEnd() As Boolean
		Get
			Return horizontalWeek1.CompressWeekend
		End Get
		Set(ByVal value As Boolean)
			horizontalWeek1.CompressWeekend = value
		End Set
	End Property
	Public Property DontPrintWeekends() As Boolean
		Get
			Return horizontalWeek1.VisibleWeekDays = WeekDays.WorkDays
		End Get
		Set(ByVal value As Boolean)
			If value Then
				horizontalWeek1.VisibleWeekDays = WeekDays.WorkDays
			Else
				horizontalWeek1.VisibleWeekDays = WeekDays.EveryDay
			End If
		End Set
	End Property
	Public Property PrintExactlyOneMonth() As Boolean
		Get
			Return reportMonthView1.ExactlyOneMonth
		End Get
		Set(ByVal value As Boolean)
			reportMonthView1.ExactlyOneMonth = value
		End Set
	End Property
	Public Property ResourceCount() As Integer
		Get
			Return reportMonthView1.VisibleResourceCount
		End Get
		Set(ByVal value As Integer)
			reportMonthView1.VisibleResourceCount = value
		End Set
	End Property
	Public Property ColumnCount() As Integer
		Get
			Return reportMonthView1.VisibleWeekDayColumnCount
		End Get
		Set(ByVal value As Integer)
			If reportMonthView1.VisibleWeekDayColumnCount = value Then
				Return
			End If

			reportMonthView1.VisibleWeekDayColumnCount = value
			OnColumnCountChanged()
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
		Me.dayOfWeekHeaders1 = New DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders()
		Me.horizontalWeek1 = New DevExpress.XtraScheduler.Reporting.HorizontalWeek()
		Me.reportMonthView1 = New DevExpress.XtraScheduler.Reporting.ReportMonthView()
		Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
		Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
		Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
		CType(Me.reportMonthView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.dayOfWeekHeaders1, Me.verticalResourceHeaders1, Me.calendarControl1, Me.timeIntervalInfo1, Me.horizontalWeek1})
		Me.Detail.Height = 901
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' dayOfWeekHeaders1
		' 
		Me.dayOfWeekHeaders1.Location = New System.Drawing.Point(27, 148)
		Me.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1"
		Me.dayOfWeekHeaders1.Size = New System.Drawing.Size(620, 25)
		Me.dayOfWeekHeaders1.TimeCells = Me.horizontalWeek1
		Me.dayOfWeekHeaders1.View = Me.reportMonthView1
		' 
		' horizontalWeek1
		'            
		Me.horizontalWeek1.Location = New System.Drawing.Point(27, 173)
		Me.horizontalWeek1.Name = "horizontalWeek1"
		Me.horizontalWeek1.Size = New System.Drawing.Size(620, 720)
		Me.horizontalWeek1.View = Me.reportMonthView1
		' 
		' reportMonthView1
		' 
		Me.reportMonthView1.VisibleWeekCount = 2
		' 
		' verticalResourceHeaders1
		'             
		Me.verticalResourceHeaders1.Corners.Top = 25
		Me.verticalResourceHeaders1.Location = New System.Drawing.Point(2, 148)
		Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
		Me.verticalResourceHeaders1.Size = New System.Drawing.Size(25, 745)
		Me.verticalResourceHeaders1.TimeCells = Me.horizontalWeek1
		Me.verticalResourceHeaders1.View = Me.reportMonthView1
		' 
		' calendarControl1
		' 
		Me.calendarControl1.Location = New System.Drawing.Point(292, 0)
		Me.calendarControl1.Name = "calendarControl1"
		Me.calendarControl1.Size = New System.Drawing.Size(350, 142)
		Me.calendarControl1.TimeCells = Me.horizontalWeek1
		Me.calendarControl1.View = Me.reportMonthView1
		' 
		' timeIntervalInfo1
		' 
		Me.timeIntervalInfo1.FormatType = DevExpress.XtraScheduler.Reporting.TimeIntervalFormatType.Monthly
		Me.timeIntervalInfo1.Location = New System.Drawing.Point(0, 0)
		Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
		Me.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns
		Me.timeIntervalInfo1.Size = New System.Drawing.Size(283, 117)
		Me.timeIntervalInfo1.TimeCells = Me.horizontalWeek1
		' 
		' Report
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
		Me.Version = "9.2"
		Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportMonthView1})
		CType(Me.reportMonthView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	#End Region

	Private Sub OnColumnCountChanged()
		If ColumnCount = 2 Then
			Me.timeIntervalInfo1.PrintInColumn = PrintInColumnMode.Odd
			Me.calendarControl1.PrintInColumn = PrintInColumnMode.Even
			Me.timeIntervalInfo1.PrintContentMode = PrintContentMode.AllColumns
		Else
			Me.timeIntervalInfo1.PrintInColumn = PrintInColumnMode.All
			Me.calendarControl1.PrintInColumn = PrintInColumnMode.All
			Me.timeIntervalInfo1.PrintContentMode = PrintContentMode.CurrentColumn
		End If
	End Sub
End Class
