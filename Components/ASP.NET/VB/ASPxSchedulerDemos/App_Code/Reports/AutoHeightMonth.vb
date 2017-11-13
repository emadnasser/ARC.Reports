Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraScheduler.Reporting

Public Class AutoHeightMonth
	Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
	Implements IAutoHeightReport
	#Region "Fields"
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private reportMonthView1 As DevExpress.XtraScheduler.Reporting.ReportMonthView
	Private horizontalWeek As DevExpress.XtraScheduler.Reporting.HorizontalWeek
	Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.Container = Nothing
	#End Region

	Public Sub New()
		InitializeComponent()
	End Sub

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' 
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
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
		Me.reportMonthView1 = New DevExpress.XtraScheduler.Reporting.ReportMonthView()
		Me.horizontalWeek = New DevExpress.XtraScheduler.Reporting.HorizontalWeek()
		CType(Me.reportMonthView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.horizontalResourceHeaders1, Me.horizontalWeek})
		Me.Detail.HeightF = 142F
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' horizontalResourceHeaders1
		' 
		Me.horizontalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(1.999982F, 0F)
		Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
		Me.horizontalResourceHeaders1.SizeF = New System.Drawing.SizeF(648F, 26F)
		Me.horizontalResourceHeaders1.View = Me.reportMonthView1
		' 
		' reportMonthView1
		' 
		Me.reportMonthView1.VisibleWeekCount = 2
		' 
		' horizontalWeek
		' 
		Me.horizontalWeek.HorizontalHeaders = Me.horizontalResourceHeaders1
		Me.horizontalWeek.LocationFloat = New DevExpress.Utils.PointFloat(1.999982F, 26.00002F)
		Me.horizontalWeek.Name = "horizontalWeek"
		Me.horizontalWeek.SizeF = New System.Drawing.SizeF(648F, 110F)
		Me.horizontalWeek.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
		Me.horizontalWeek.View = Me.reportMonthView1
		' 
		' AutoHeightMonth
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
		Me.Version = "10.1"
		Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportMonthView1})
		CType(Me.reportMonthView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
	#End Region

	#Region "IAutoHeightReport Members"
	Public Property CellsCanShrink() As Boolean Implements IAutoHeightReport.CellsCanShrink
		Get
			Return horizontalWeek.CanShrink
		End Get
		Set(ByVal value As Boolean)
			horizontalWeek.CanShrink = value
		End Set
	End Property
	Public Property CellsCanGrow() As Boolean Implements IAutoHeightReport.CellsCanGrow
		Get
			Return horizontalWeek.CanGrow
		End Get
		Set(ByVal value As Boolean)
			horizontalWeek.CanGrow = value
		End Set
	End Property
	Public Property CellsHeight() As Single Implements IAutoHeightReport.CellsHeight
		Get
			Return horizontalWeek.HeightF
		End Get
		Set(ByVal value As Single)
			horizontalWeek.HeightF = value
		End Set
	End Property
	#End Region
End Class

Public Interface IAutoHeightReport
	Property CellsCanShrink() As Boolean
	Property CellsCanGrow() As Boolean
	Property CellsHeight() As Single
End Interface

