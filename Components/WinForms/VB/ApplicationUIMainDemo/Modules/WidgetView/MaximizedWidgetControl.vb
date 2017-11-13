Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class MaximizedWidgetControl
		Inherits UserControl
		Private updateTimer As Timer = New Timer()
		Private index As Integer = 0
		Private r As Random = New Random()
		Public Sub New()
			InitializeComponent()
			updateTimer.Interval = 1000
			AddHandler updateTimer.Tick, AddressOf OnTimerTick
			updateTimer.Start()
			For i As Integer = 0 To 29
				AddNewSeriesPoint()
			Next i
		End Sub
		Private Const BeginDate As Integer = 40000
		Protected Sub AddNewSeriesPoint()
			Dim data As StockData = StockDataCreator.GetData(index)
			If IsDisposed Then
				updateTimer.Stop()
				Return
			End If
			Dim seriesPoint1 As SeriesPoint = New SeriesPoint(data.Date, New Object() { CObj(data.LowPrice), CObj(data.HighPrice), CObj(data.OpenPrice), CObj(data.ClosePrice) })
			chartControl1.Series(0).Points.Add(seriesPoint1)
			Dim [date] As Integer = BeginDate
			If index > 40 Then
				[date] = BeginDate + index - 30
			End If
			TryCast(chartControl1.Diagram, IXYDiagram2D).AxisX.WholeRange.SetMinMaxValues(DateTime.FromOADate([date]), data.Date)
			TryCast(chartControl2.Diagram, IXYDiagram2D).AxisX.WholeRange.SetMinMaxValues(DateTime.FromOADate([date]), data.Date)
			index += 1
			Dim seriesPoint2 As SeriesPoint = New SeriesPoint(data.Date, data.Volumne)
			chartControl2.Series(0).Points.Add(seriesPoint2)
		End Sub
		Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
			AddNewSeriesPoint()
		End Sub
	End Class
End Namespace
