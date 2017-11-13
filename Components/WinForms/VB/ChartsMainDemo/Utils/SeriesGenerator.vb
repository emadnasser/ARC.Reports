Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace DevExpress.XtraCharts.Demos
	Friend NotInheritable Class SeriesGenerator
		Private Sub New()
		End Sub
		Private Shared Function GenerateSeries(ByVal count As Integer, ByVal viewType As ViewType) As List(Of Series)
			Dim seriesList = New List(Of Series)()
			For i As Integer = 0 To count - 1
				Dim series = New Series(String.Format("Series {0}", i + 1), viewType)
				seriesList.Add(series)
			Next i
			Return seriesList
		End Function
		Private Shared Sub SetUpXySeriesData(ByVal result As List(Of Series), ByVal pointsCount As Integer)
			For i As Integer = 0 To result.Count - 1
				Dim generator = New DataGenerator(i, 5 + 3 * i)
				result(i).DataSource = generator.GenerateData(SeriesDataType.ArgumentValue, pointsCount)
				result(i).ArgumentDataMember = "Argument"
				result(i).ValueDataMembers.AddRange("Value")
			Next i
		End Sub
		Private Shared Sub SetUpXyScatterSeriesData(ByVal result As List(Of Series))
			For i As Integer = 0 To result.Count - 1
				Dim generator = New DataGenerator()
				result(i).DataSource = generator.GenerateXyScatterData()
				result(i).ArgumentDataMember = "Argument"
				result(i).ValueDataMembers.AddRange("Value")
			Next i
		End Sub
		Private Shared Sub SetUpPolarScatterSeriesData(ByVal result As List(Of Series))
			For i As Integer = 0 To result.Count - 1
				Dim functionCalculator As New DegreeScatterFunctionCalculator()
				Dim points() As SeriesPoint = functionCalculator.GenerateScatterFunctionPoints(1)
				result(i).Points.AddRange(points)
			Next i
		End Sub
		Private Shared Sub SetUpRadarScatterSeriesData(ByVal result As List(Of Series))
			For i As Integer = 0 To result.Count - 1
				Dim functionCalculator As New DegreeScatterFunctionCalculator()
				Dim points() As SeriesPoint = functionCalculator.GenerateScatterFunctionPoints(0)
				result(i).Points.AddRange(points)
			Next i
		End Sub
		Private Shared Sub SetUpRangeSeriesData(ByVal result As List(Of Series), ByVal pointsCount As Integer)
			For i As Integer = 0 To result.Count - 1
				Dim generator = New DataGenerator(i, 25)
				result(i).DataSource = generator.GenerateData(SeriesDataType.Range, pointsCount)
				result(i).ArgumentDataMember = "Argument"
				result(i).ValueDataMembers.AddRange("Value", "Value2")
			Next i
		End Sub
		Private Shared Sub SetUpPolarSeriesData(ByVal result As List(Of Series), ByVal pointsCount As Integer)
			For i As Integer = 0 To result.Count - 1
				Dim generator = New DataGenerator(i)
				result(i).DataSource = generator.GeneratePolarData(SeriesDataType.ArgumentValue, pointsCount)
				result(i).ArgumentDataMember = "Argument"
				result(i).ValueDataMembers.AddRange("Value")
			Next i
		End Sub
		Private Shared Sub SetUpPolarRangeSeriesData(ByVal result As List(Of Series), ByVal pointsCount As Integer)
			For i As Integer = 0 To result.Count - 1
				Dim generator = New DataGenerator(i)
				result(i).DataSource = generator.GeneratePolarData(SeriesDataType.Range, pointsCount)
				result(i).ArgumentDataMember = "Argument"
				result(i).ValueDataMembers.AddRange("Value", "Value2")
			Next i
		End Sub
		Private Shared Sub SetUpFunnelSeriesData(ByVal result As List(Of Series), ByVal pointsCount As Integer)
			For i As Integer = 0 To result.Count - 1
				Dim generator = New DataGenerator(i, 35)
				result(i).DataSource = generator.GenerateData(SeriesDataType.Funnel, pointsCount)
				result(i).ArgumentDataMember = "Argument"
				result(i).ValueDataMembers.AddRange("Value")
			Next i
		End Sub
		Private Shared Sub SetUpBubbleSeriesData(ByVal result As List(Of Series), ByVal pointsCount As Integer)
			For i As Integer = 0 To result.Count - 1
				Dim generator = New DataGenerator(i, 5 + 3 * i)
				result(i).DataSource = generator.GenerateData(SeriesDataType.Bubble, pointsCount)
				result(i).ArgumentDataMember = "Argument"
				result(i).ValueDataMembers.AddRange("Value", "Weight")
			Next i
		End Sub
		Private Shared Sub SetUpFinancialSeriesData(ByVal result As List(Of Series), ByVal pointsCount As Integer)
			For i As Integer = 0 To result.Count - 1
				Dim generator = New DataGenerator(i, 60)
				result(i).DataSource = generator.GenerateData(SeriesDataType.Financial, pointsCount)
				result(i).ArgumentDataMember = "Argument"
				result(i).ValueDataMembers.AddRange("Low", "High", "Open", "Close")
			Next i
		End Sub
		Private Shared Function CreateOverlappedGanttSeries(ByVal overlappedOrSbSGantt As ViewType) As List(Of Series)
			Dim series1 As New Series("Planned", overlappedOrSbSGantt)
			Dim series2 As New Series("Completed", overlappedOrSbSGantt)
			series1.ValueScaleType = ScaleType.DateTime
			series2.ValueScaleType = ScaleType.DateTime
			series1.Points.Add(New SeriesPoint("Market analysis", New DateTime() { New DateTime(2006, 8, 16), New DateTime(2006, 8, 23) }))
			series1.Points.Add(New SeriesPoint("Feature planning", New DateTime() {New DateTime(2006, 8, 23), New DateTime(2006, 8, 26) }))
			series1.Points.Add(New SeriesPoint("Implementation", New DateTime() {New DateTime(2006, 8, 26), New DateTime(2006, 9, 26) }))
			series1.Points.Add(New SeriesPoint("Testing & bug fixing", New DateTime() {New DateTime(2006, 9, 26), New DateTime(2006, 10, 10) }))
			series2.Points.Add(New SeriesPoint("Market analysis", New DateTime() {New DateTime(2006, 8, 16), New DateTime(2006, 8, 23) }))
			series2.Points.Add(New SeriesPoint("Feature planning", New DateTime() {New DateTime(2006, 8, 23), New DateTime(2006, 8, 26) }))
			series2.Points.Add(New SeriesPoint("Implementation", New DateTime() {New DateTime(2006, 8, 26), New DateTime(2006, 9, 10) }))
			Dim result = New List(Of Series)()
			result.Add(series1)
			result.Add(series2)
			CType(series1.View, GanttSeriesView).BarWidth = 0.6
			CType(series2.View, GanttSeriesView).BarWidth = 0.3
			CType(series1.View, GanttSeriesView).LinkOptions.ArrowHeight = 7
			CType(series1.View, GanttSeriesView).LinkOptions.ArrowWidth = 11
			For i As Integer = 1 To series1.Points.Count - 1
				series1.Points(i).Relations.Add(series1.Points(i - 1))
			Next i
			Return result
		End Function

		Public Shared Function GenerateSeries(ByVal viewType As ViewType) As Series()
			Dim result As List(Of Series) = Nothing
			Select Case viewType
				Case ViewType.Area
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.Bar
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 7)
				Case ViewType.Bubble
					result = GenerateSeries(1, viewType)
					SetUpBubbleSeriesData(result, 10)
				Case ViewType.CandleStick
					result = GenerateSeries(1, viewType)
					SetUpFinancialSeriesData(result, 80)
				Case ViewType.Doughnut
					result = GenerateSeries(1, viewType)
					SetUpXySeriesData(result, 7)
				Case ViewType.FullStackedArea
					result = GenerateSeries(3, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.FullStackedStepArea
					result = GenerateSeries(3, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.FullStackedBar
					result = GenerateSeries(3, viewType)
					SetUpXySeriesData(result, 7)
				Case ViewType.FullStackedLine
					result = GenerateSeries(3, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.FullStackedSplineArea
					result = GenerateSeries(3, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.Funnel
					result = GenerateSeries(1, viewType)
					SetUpFunnelSeriesData(result, 7)
				Case ViewType.Gantt
					result = CreateOverlappedGanttSeries(ViewType.Gantt)
				Case ViewType.Line
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.NestedDoughnut
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 7)
				Case ViewType.Pie
					result = GenerateSeries(1, viewType)
					SetUpXySeriesData(result, 7)
				Case ViewType.Point
					result = GenerateSeries(1, viewType)
					SetUpXySeriesData(result, 30)
				Case ViewType.PolarArea
					result = GenerateSeries(2, viewType)
					SetUpPolarSeriesData(result, 7)
				Case ViewType.PolarLine
					result = GenerateSeries(2, viewType)
					SetUpPolarSeriesData(result, 7)
				Case ViewType.PolarPoint
					result = GenerateSeries(1, viewType)
					SetUpPolarSeriesData(result, 20)
				Case ViewType.PolarRangeArea
					result = GenerateSeries(1, viewType)
					SetUpPolarRangeSeriesData(result, 20)
				Case ViewType.RadarArea
					result = GenerateSeries(2, viewType)
					SetUpPolarSeriesData(result, 7)
				Case ViewType.RadarLine
					result = GenerateSeries(2, viewType)
					SetUpPolarSeriesData(result, 7)
				Case ViewType.RadarPoint
					result = GenerateSeries(1, viewType)
					SetUpPolarSeriesData(result, 20)
				Case ViewType.RadarRangeArea
					result = GenerateSeries(1, viewType)
					SetUpPolarRangeSeriesData(result, 20)
				Case ViewType.RangeArea
					result = GenerateSeries(1, viewType)
					SetUpRangeSeriesData(result, 20)
				Case ViewType.RangeBar
					result = GenerateSeries(1, viewType)
					SetUpRangeSeriesData(result, 15)
				Case ViewType.ScatterLine
					result = GenerateSeries(1, viewType)
					SetUpXyScatterSeriesData(result)
				Case ViewType.ScatterPolarLine
					result = GenerateSeries(1, viewType)
					SetUpPolarScatterSeriesData(result)
				Case ViewType.ScatterRadarLine
					result = GenerateSeries(1, viewType)
					SetUpRadarScatterSeriesData(result)
				Case ViewType.SideBySideFullStackedBar
					result = GenerateSeries(6, viewType)
					SetUpXySeriesData(result, 7)
					For i As Integer = 0 To 2
						CType(result(i).View, SideBySideFullStackedBarSeriesView).StackedGroup = "Group 1"
					Next i
					For i As Integer = 2 To 5
						CType(result(i).View, SideBySideFullStackedBarSeriesView).StackedGroup = "Group 2"
					Next i
				Case ViewType.SideBySideGantt
					result = CreateOverlappedGanttSeries(ViewType.SideBySideGantt)
				Case ViewType.SideBySideRangeBar
					result = GenerateSeries(2, viewType)
					SetUpRangeSeriesData(result, 15)
				Case ViewType.SideBySideStackedBar
					result = GenerateSeries(5, viewType)
					SetUpRangeSeriesData(result, 15)
					For i As Integer = 0 To 2
						CType(result(i).View, SideBySideStackedBarSeriesView).StackedGroup = "Group 1"
					Next i
					For i As Integer = 2 To 4
						CType(result(i).View, SideBySideStackedBarSeriesView).StackedGroup = "Group 2"
					Next i
				Case ViewType.Spline
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.SplineArea
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.StackedArea
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.StackedStepArea
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.StackedBar
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.StackedLine
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.StackedSplineArea
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.StepArea
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.StepLine
					result = GenerateSeries(2, viewType)
					SetUpXySeriesData(result, 15)
				Case ViewType.Stock
					result = GenerateSeries(1, viewType)
					SetUpFinancialSeriesData(result, 80)
				Case ViewType.SwiftPlot

			End Select
			Return If(result Is Nothing, Nothing, result.ToArray())
		End Function
	End Class

	Public Class ComboBoxSeriesViewItem
		Private ReadOnly viewType_Renamed As ViewType
		Private ReadOnly viewName As String

		Public ReadOnly Property ViewType() As ViewType
			Get
				Return viewType_Renamed
			End Get
		End Property

		Public Sub New(ByVal viewType As ViewType)
			Me.New(viewType, String.Empty)
		End Sub
		Public Sub New(ByVal viewType As ViewType, ByVal viewName As String)
			Me.viewType_Renamed = viewType
			Me.viewName = viewName
		End Sub
		Public Overrides Function ToString() As String
			Return viewName
		End Function
		Public Overrides Overloads Function Equals(ByVal obj As Object) As Boolean
			Dim item As ComboBoxSeriesViewItem = TryCast(obj, ComboBoxSeriesViewItem)
			Return item IsNot Nothing AndAlso item.viewType.Equals(viewType_Renamed)
		End Function
		Public Overrides Function GetHashCode() As Integer
			Return MyBase.GetHashCode()
		End Function
	End Class

	Public NotInheritable Class AnimationViewTypesItemsGenerator
		Private Sub New()
		End Sub
		Public Shared Function CreateItems() As List(Of ComboBoxSeriesViewItem)
			Dim viewTypes As New List(Of ViewType) (New ViewType() {ViewType.Bar, ViewType.StackedBar, ViewType.FullStackedBar, ViewType.SideBySideStackedBar, ViewType.SideBySideFullStackedBar, ViewType.Point, ViewType.Bubble, ViewType.Line, ViewType.StackedLine, ViewType.FullStackedLine, ViewType.StepLine, ViewType.Spline, ViewType.ScatterLine, ViewType.Area, ViewType.StackedArea, ViewType.FullStackedArea, ViewType.StackedStepArea, ViewType.FullStackedStepArea, ViewType.StepArea, ViewType.SplineArea, ViewType.StackedSplineArea, ViewType.FullStackedSplineArea, ViewType.RangeBar, ViewType.SideBySideRangeBar, ViewType.RangeArea, ViewType.Pie, ViewType.Doughnut, ViewType.NestedDoughnut, ViewType.Funnel, ViewType.RadarPoint, ViewType.RadarLine, ViewType.ScatterRadarLine, ViewType.RadarArea, ViewType.RadarRangeArea, ViewType.PolarPoint, ViewType.PolarLine, ViewType.ScatterPolarLine, ViewType.PolarArea, ViewType.PolarRangeArea, ViewType.Stock, ViewType.CandleStick, ViewType.Gantt, ViewType.SideBySideGantt})
			Dim viewItems As New List(Of ComboBoxSeriesViewItem)()
			For Each viewType As ViewType In viewTypes
				viewItems.Add(New ComboBoxSeriesViewItem(viewType, DevExpress.XtraCharts.Native.SeriesViewFactory.GetStringID(viewType)))
			Next viewType
			Return viewItems
		End Function
	End Class
End Namespace
