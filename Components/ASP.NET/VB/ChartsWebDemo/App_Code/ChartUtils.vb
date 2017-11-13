Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Data
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports System.IO
Imports System.Web
Imports System.Xml

Public NotInheritable Class XMLUtils
	Private Sub New()
	End Sub
	Public Shared Function LoadDataTableFromXml(ByVal fileName As String, ByVal tableName As String) As DataTable
		Dim xmlDataSet As New DataSet()
		Using xmlStream As Stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/" & fileName))
			xmlDataSet.ReadXml(xmlStream)
			xmlStream.Close()
		End Using
		Return xmlDataSet.Tables(tableName)
	End Function
End Class

Public NotInheritable Class CsvReader
	Private Sub New()
	End Sub
	Public Shared Function ReadFinancialData(ByVal fileName As String) As List(Of FinancialPoint)
		Dim longFileName As String = String.Empty
		Dim reader As StreamReader
		Dim dataSource = New List(Of FinancialPoint)()
		Using stream As Stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/" & fileName))
			Try
				reader = New StreamReader(stream)
				Do While Not reader.EndOfStream
					Dim line As String = reader.ReadLine()
					Dim values = line.Split(","c)
					Dim point = New FinancialPoint()
					point.DateTimeArgument = DateTime.ParseExact(values(0), "yyyy.MM.dd", Nothing)
					point.OpenValue = Double.Parse(values(1), CultureInfo.InvariantCulture)
					point.HighValue = Double.Parse(values(2), CultureInfo.InvariantCulture)
					point.LowValue = Double.Parse(values(3), CultureInfo.InvariantCulture)
					point.CloseValue = Double.Parse(values(4), CultureInfo.InvariantCulture)
					dataSource.Add(point)
				Loop
			Catch
				Throw New Exception("It's impossible to load " & fileName)
			End Try
		End Using
		Return dataSource
	End Function
End Class

Public NotInheritable Class ComboBoxHelper
	Private Const defaultMarker As String = "Default"
	Private Const percentMarker As String = "%"
	Private Const defaultDoughnutHole As Integer = 60
	Private Shared ReadOnly markerKinds As MarkerKindItemCollection = MarkerKindItemCollection.CreateCollection()

	Private Sub New()
	End Sub
	Private Shared Function AppendPercentMarker(ByVal items() As String) As String()
		Return AppendPercentMarker(items, 0)
	End Function
	Private Shared Function AppendPercentMarker(ByVal items() As String, ByVal startIndex As Integer) As String()
		Dim result(items.Length - 1) As String
		For i As Integer = 0 To startIndex - 1
			result(i) = items(i)
		Next i
		For i As Integer = startIndex To items.Length - 1
			result(i) = items(i) & percentMarker
		Next i
		Return result
	End Function
	Private Shared Function DeletePercentMarker(ByVal item As String) As String
		Return item.TrimEnd(New Char() { percentMarker.Chars(0) })
	End Function
	Public Shared Sub PrepareComboBox(ByVal comboBox As ASPxComboBox, ByVal items() As String)
		PrepareComboBox(comboBox, items, Nothing)
	End Sub
	Public Shared Sub PrepareComboBox(ByVal comboBox As ASPxComboBox, ByVal items() As String, ByVal defaultItem As Object)
		comboBox.Items.AddRange(items)
		comboBox.SelectedIndex = If(defaultItem IsNot Nothing, comboBox.Items.IndexOfText(defaultItem.ToString()), 0)
	End Sub
	Public Shared Sub PrepareComboBox(ByVal comboBox As ASPxComboBox, ByVal items() As Double, ByVal defaultItem As Double)
		comboBox.Items.AddRange(items)
		comboBox.SelectedIndex = comboBox.Items.IndexOfText(defaultItem.ToString())
	End Sub
	Public Shared Sub PrepareComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultValue As System.Enum)
		PrepareComboBox(comboBox, System.Enum.GetNames(defaultValue.GetType()), defaultValue)
	End Sub
	Public Shared Sub PrepareComboBox(ByVal comboBox As ASPxComboBox, ByVal dictionary As IDictionary)
		PrepareComboBox(comboBox, dictionary, 0)
	End Sub
	Public Shared Sub PrepareComboBox(ByVal comboBox As ASPxComboBox, ByVal dictionary As IDictionary, ByVal selectedIndex As Integer)
		For Each entry As DictionaryEntry In dictionary
			comboBox.Items.Add(CStr(entry.Key), entry.Value)
		Next entry
		comboBox.SelectedIndex = selectedIndex
	End Sub
	Public Shared Sub PrepareLabelAngleComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultAngle As Integer)
		Dim items() As String = { "0", "45", "90", "135", "180", "225", "270", "315" }
		PrepareComboBox(comboBox, items, defaultAngle)
	End Sub
	Public Shared Sub PrepareTransparencyComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultTransparency As Integer)
		Dim items() As String = { "0", "45", "90", "135", "180", "225", "255" }
		PrepareComboBox(comboBox, items, defaultTransparency)
	End Sub
	Public Shared Sub PrepareZoomPercentComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultZoomPercent As Integer)
		Dim items() As String = { "50", "75", "100", "120", "140", "170", "200", "250", "300" }
		PrepareComboBox(comboBox, items, defaultZoomPercent)
	End Sub
	Public Shared Sub PreparePerspectiveAngleComboBox(ByVal comboBox As ASPxComboBox)
		Dim items() As String = { defaultMarker, "0", "30", "45", "60", "90", "120", "135", "150" }
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PrepareBar3DModelComboBox(ByVal comboBox As ASPxComboBox)
		Dim items() As String = { "Box", "Cylinder", "Cone", "Pyramid" }
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PrepareNestedDoughnutHolePercentComboBox(ByVal comboBox As ASPxComboBox)
		Const minRadius As Integer = 30
		Const [step] As Integer = 5
		Const itemsCount As Integer = 8
		Const defaultHole As Integer = 40
		Dim items As New List(Of Double)()
		For itemIndex As Integer = 0 To itemsCount - 1
			Dim radius As Integer = minRadius + [step] * itemIndex
			items.Add(radius)
		Next itemIndex
		PrepareComboBox(comboBox, items.ToArray(), defaultHole)
	End Sub
	Public Shared Sub PrepareNestedDoughnutSeriesArgumentComboBox(ByVal comboBox As ASPxComboBox)
		Dim items() As String = { "Age", "Gender" }
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PrepareInnerIndentComboBox(ByVal comboBox As ASPxComboBox)
		Const itemsCount As Integer = 11
		Const defaultInnerIndent As Integer = 5
		Dim items As New List(Of Double)()
		For itemIndex As Integer = 0 To itemsCount - 1
			items.Add(itemIndex)
		Next itemIndex
		PrepareComboBox(comboBox, items.ToArray(), defaultInnerIndent)
	End Sub
	Public Shared Sub PrepareRegressionLineColorComboBox(ByVal comboBox As ASPxComboBox)
		comboBox.Items.Add("Default")
		Dim colors() As Color = { Color.Black, Color.Red, Color.Green, Color.Blue, Color.Yellow }
		For Each color As Color In colors
			comboBox.Items.Add(color.Name)
		Next color
		comboBox.SelectedIndex = 0
	End Sub
	Public Shared Sub PrepareDashStyleCombobox(ByVal comboBox As ASPxComboBox, ByVal defaultDashStyle As DashStyle)
		For Each dashStyle As DashStyle In System.Enum.GetValues(defaultDashStyle.GetType())
			If dashStyle <> DashStyle.Empty Then
				comboBox.Items.Add(dashStyle.ToString())
			End If
		Next dashStyle
		comboBox.SelectedIndex = comboBox.Items.IndexOfText(defaultDashStyle.ToString())
	End Sub
	Public Shared Sub PrepareLogarithmicBaseComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultLogarithmicBase As Double)
		Dim items() As String = { "2", "5", "10", "20", "50", "100" }
		PrepareComboBox(comboBox, items, defaultLogarithmicBase)
	End Sub
	Public Shared Sub PrepareFunctionTypeComboBox(ByVal comboBox As ASPxComboBox)
		Const lemniscate As String = "Lemniscate"
		Dim items() As String = { "Circles", "Cardioid", lemniscate }
		PrepareComboBox(comboBox, items, lemniscate)
	End Sub
	Public Shared Sub PrepareFunctionTypeScatterLineComboBox(ByVal comboBox As ASPxComboBox)
		Const archimedeanSpiral As String = "Archimedean Spiral"
		Dim items() As String = { archimedeanSpiral, "Cardioid", "Cartesian Folium" }
		PrepareComboBox(comboBox, items, archimedeanSpiral)
	End Sub
	Public Shared Sub PrepareChartTypeComboBox(ByVal comboBox As ASPxComboBox)
		Const line As String = "Line"
		Dim items() As String = { line, "Bar" }
		PrepareComboBox(comboBox, items, line)
	End Sub
	Public Shared Sub PrepareSeriesAxisXComboBox(ByVal comboBox As ASPxComboBox)
		Const primaryAxis As String = "Primary Axis X"
		Dim items() As String = { primaryAxis, "Secondary Axis X" }
		PrepareComboBox(comboBox, items, primaryAxis)
	End Sub
	Public Shared Sub PrepareSeriesAxisYComboBox(ByVal comboBox As ASPxComboBox)
		Const secondaryAxisY As String = "Secondary Axis Y"
		Dim items() As String = { "Primary Axis Y", secondaryAxisY }
		PrepareComboBox(comboBox, items, secondaryAxisY)
	End Sub
	Public Shared Sub PrepareViewTypeComboBox(ByVal comboBox As ASPxComboBox)
		Dim items() As String = { "Lines", "Stacked Lines", "Full-Stacked Lines", "Step Lines", "Areas", "Step Areas", "Stacked Areas", "Full-Stacked Areas", "3D Lines", "3D Stacked Lines", "3D Full-Stacked Lines", "3D Step Lines", "3D Areas", "3D Stacked Areas", "3D Full-Stacked Areas", "3D Step Areas", "Spline", "Spline Area", "Stacked Spline", "Full-Stacked Spline", "Spline 3D", "Spline Area 3D", "Stacked Spline 3D", "Full-Stacked Spline 3D" }
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PreparePieViewTypeComboBox(ByVal comboBox As ASPxComboBox)
		Dim items() As String = { "Pie", "Pie 3D", "Doughnut", "Doughnut 3D" }
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PrepareMarkerKindComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultKind As MarkerKind, ByVal defaultStarPointCount As Integer)
		PrepareComboBox(comboBox, markerKinds.GetNames(), markerKinds.FindName(defaultKind, defaultStarPointCount))
	End Sub
	Public Shared Sub PrepareMarkerSizeComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultSize As Integer)
		PrepareComboBox(comboBox, MarkerKindItemCollection.GetSizeArray(), defaultSize)
	End Sub
	Public Shared Sub PrepareLegendPercentComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultPercent As Double)
		Dim items() As String = AppendPercentMarker(New String() { "25", "50", "75", "100" })
		PrepareComboBox(comboBox, items, defaultPercent.ToString() & percentMarker)
	End Sub
	Public Shared Sub PrepareLineTensionComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultLineTension As Integer)
		Dim items() As String = AppendPercentMarker(New String() { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" })
		PrepareComboBox(comboBox, items, defaultLineTension.ToString() & percentMarker)
	End Sub
	Public Shared Sub PreparePieLabelsComboBox(ByVal comboBox As ASPxComboBox)
		Dim items() As String = { "Inside", "Outside", "TwoColumns", "Radial" }
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PrepareDoughnutHolePercentComboBox(ByVal comboBox As ASPxComboBox)
		Dim defaultHoleString As String = defaultMarker & " (" & defaultDoughnutHole.ToString() & "%)"
		Dim items() As String = AppendPercentMarker(New String() { defaultHoleString, "0", "15", "30", "50", "75", "90", "100" }, 1)
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PrepareExplodedPointsComboBox(ByVal comboBox As ASPxComboBox, ByVal points As SeriesPointCollection, ByVal supportCustom As Boolean)
		Dim items() As String = PieExplodingHelper.GetNames(points, supportCustom)
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PrepareSummaryFunctionsComboBox(ByVal comboBox As ASPxComboBox)
		Dim items() As String = { "SUM", "MIN", "MAX", "AVERAGE", "COUNT", "STDDEV (Custom)" }
		PrepareComboBox(comboBox, items)
	End Sub
	Public Shared Sub PrepareFunctionTypeScatterRadarLineComboBox(ByVal comboBox As ASPxComboBox)
		Const archimedeanSpiral As String = "Archimedean Spiral"
		Dim items() As String = { archimedeanSpiral, "Polar Rose", "Polar Folium" }
		PrepareComboBox(comboBox, items, archimedeanSpiral)
	End Sub
	Public Shared Sub PrepareResolveOverlappingModeComboBox(ByVal comboBox As ASPxComboBox, ByVal defaultMode As ResolveOverlappingMode)
		PrepareComboBox(comboBox, defaultMode)
	End Sub
	Public Shared Function GetSelectedItem(ByVal comboBox As ASPxComboBox, ByVal enumType As Type) As System.Enum
		If (Not enumType.IsEnum) Then
			Throw New ArgumentException()
		End If
		Try
			Return CType(System.Enum.Parse(enumType, comboBox.SelectedItem.Text), [Enum])
		Catch
		End Try
		Return CType(System.Enum.Parse(enumType, CStr(comboBox.SelectedItem.Value)), [Enum])
	End Function
	Public Shared Function GetSelectedResolveOverlappingMode(ByVal comboBox As ASPxComboBox) As ResolveOverlappingMode
		Return CType(GetSelectedItem(comboBox, GetType(ResolveOverlappingMode)), ResolveOverlappingMode)
	End Function
	Public Shared Function GetSelectedPerspectiveAngle(ByVal comboBox As ASPxComboBox) As Integer
		Return If(comboBox.SelectedItem.Text = defaultMarker, 50, Int32.Parse(comboBox.SelectedItem.Text))
	End Function
	Public Shared Function GetSelectedMarkerKindItem(ByVal comboBox As ASPxComboBox) As MarkerKindItem
		Return markerKinds.Find(comboBox.SelectedItem.Text)
	End Function
	Public Shared Function GetSelectedLegendPercent(ByVal comboBox As ASPxComboBox) As Double
		Return Double.Parse(DeletePercentMarker(comboBox.SelectedItem.Text))
	End Function
	Public Shared Function GetSelectedLineTension(ByVal comboBox As ASPxComboBox) As Integer
		Return Convert.ToInt32(DeletePercentMarker(comboBox.SelectedItem.Text))
	End Function
	Public Shared Function GetSelectedDoughnutHolePercent(ByVal comboBox As ASPxComboBox) As Integer
		Dim selectedText As String = comboBox.SelectedItem.Text
		Return If(selectedText.StartsWith(defaultMarker), defaultDoughnutHole, Convert.ToInt32(DeletePercentMarker(selectedText)))
	End Function
	Public Shared Function GetSelectedNestedDoughnutHolePercent(ByVal comboBox As ASPxComboBox) As Integer
		Return Convert.ToInt32(comboBox.SelectedItem.Text)
	End Function
	Public Shared Function GetSelectedInnerIndent(ByVal comboBox As ASPxComboBox) As Integer
		Return Convert.ToInt32(comboBox.SelectedItem.Text)
	End Function
	Public Shared Sub ApplySelectedExplodingMode(ByVal comboBox As ASPxComboBox, ByVal view As PieSeriesViewBase)
		PieExplodingHelper.ApplyMode(view, comboBox.SelectedItem.Text)
	End Sub
	Public Shared Function GetSelectedRegressionLineColor(ByVal comboBox As ASPxComboBox) As Color
		Return If(comboBox.SelectedItem.Text = "Default", Color.Empty, Color.FromName(comboBox.SelectedItem.Text))
	End Function
End Class

Public NotInheritable Class DataHelper
	Private Sub New()
	End Sub
	Private Shared Function StringToDateTime(ByVal str As String) As DateTime
		Return DateTime.Parse(str, CultureInfo.InvariantCulture)
	End Function
	Public Shared Sub AddPoint(ByVal series As Series, ByVal argument As String, ByVal value As Double)
		Dim argumentDT As DateTime = StringToDateTime(argument)
		series.Points.Add(New SeriesPoint(argumentDT, New Double() { value }))
	End Sub
	Public Shared Sub AddPoint(ByVal series As Series, ByVal argument As String, ByVal value1 As Double, ByVal value2 As Double)
		Dim argumentDT As DateTime = StringToDateTime(argument)
		series.Points.Add(New SeriesPoint(argumentDT, New Double() { value1, value2 }))
	End Sub
End Class

Public NotInheritable Class PieExplodingHelper
	Public Const None As String = "None"
	Public Const All As String = "All"
	Public Const MinValue As String = "Min Value"
	Public Const MaxValue As String = "Max Value"
	Public Const Custom As String = "Custom"
	Private Sub New()
	End Sub
	Public Shared Sub ApplyMode(ByVal view As PieSeriesViewBase, ByVal mode As String)
		Select Case mode
			Case Custom
				view.ExplodeMode = PieExplodeMode.UsePoints
			Case None
				view.ExplodeMode = PieExplodeMode.None
			Case All
				view.ExplodeMode = PieExplodeMode.All
			Case MinValue
				view.ExplodeMode = PieExplodeMode.MinValue
			Case MaxValue
				view.ExplodeMode = PieExplodeMode.MaxValue
			Case Else
				view.ExplodedPointsFilters.Clear()
				view.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.Equal, mode))
				view.ExplodeMode = PieExplodeMode.UseFilters
		End Select
	End Sub
	Public Shared Function GetNames(ByVal points As SeriesPointCollection, ByVal supportCustom As Boolean) As String()
		Dim itemsCount As Integer = points.Count + 4
		If supportCustom Then
			itemsCount += 1
		End If
		Dim items(itemsCount - 1) As String
		items(0) = None
		items(1) = All
		items(2) = MinValue
		items(3) = MaxValue
		For i As Integer = 0 To points.Count - 1
			items(i + 4) = points(i).Argument
		Next i
		If supportCustom Then
			items(points.Count + 4) = Custom
		End If
		Return items
	End Function
End Class

Public NotInheritable Class PolarFunctionCalculator
	Private Sub New()
	End Sub
	Private Shared Function GetLineFactor(ByVal index As Integer) As Double
		Select Case index
			Case 0
				Return 1
			Case 1
				Return 0.5
			Case 2
				Return 2
			Case Else
				Return 2
		End Select
	End Function
	Private Shared Function ToRadian(ByVal angle As Double) As Double
		Return angle * Math.PI / 180.0
	End Function
	Private Shared Function [Function](ByVal m As Double, ByVal angle As Double) As Double
		Dim cos As Double = Math.Cos(m * ToRadian(90.0 + angle))
		Return Math.Pow(Math.Abs(cos), m)
	End Function
	Public Shared Function GenerateFunctionPoints(ByVal index As Integer, ByVal pointCount As Integer, Optional ByVal seriesViewValusCount As Integer = 1) As SeriesPoint()
		Dim m As Double = GetLineFactor(index)
		Dim [step] As Integer = 360 \ pointCount
		Dim points(pointCount - 1) As SeriesPoint
		For i As Integer = 0 To pointCount - 1
			points(i) = GenerateSeriesPoint(m, i * [step], seriesViewValusCount) 'new SeriesPoint(step * i, new double[] { Function(m, step * i) });
		Next i
		Return points
	End Function
	Private Shared Function GenerateSeriesPoint(ByVal m As Double, ByVal value As Double, ByVal seriesViewValusCount As Integer) As SeriesPoint
		Dim values(seriesViewValusCount - 1) As Double
		For i As Integer = 0 To seriesViewValusCount - 1
			Dim factor As Double = If((i = 0), m, 0)
			values(i) = [Function](factor, value)
		Next i
		Return New SeriesPoint(value, values)
	End Function
	Private Shared Function GenerateScatterFunctionPoints(ByVal calculator As ScatterFunctionCalculatorBase, ByVal functionIndex As Integer) As SeriesPoint()
		Return calculator.GenerateScatterFunctionPoints(functionIndex)
	End Function
	Public Shared Function GenerateDegreeScatterFunctionPoints(ByVal functionIndex As Integer) As SeriesPoint()
		Return GenerateScatterFunctionPoints(New DegreesScatterFunctionCalculator(), functionIndex)

	End Function
	Public Shared Function GenerateRadianScatterFunctionPoints(ByVal functionIndex As Integer) As SeriesPoint()
		Return GenerateScatterFunctionPoints(New RadianScatterFunctionCalculator(), functionIndex)
	End Function
End Class

Public MustInherit Class ScatterFunctionCalculatorBase
	Private Const archimedeanSpiralIndex As Integer = 0
	Private Const polarRoseIndex As Integer = 1
	Private Const polarFoliumIndex As Integer = 2
	Private Const spiralIntervalsCount As Integer = 72
	Private Const roseIntervalsCount As Integer = 288
	Private Const foliumSegmentIntervalsCount As Integer = 30

	Private Const roseParameter As Double = 7.0 / 4.0
	Private Const foliumDistanceLimit As Double = 3.0

	Protected MustOverride Function NormalizeAngle(ByVal angle As Double) As Double
	Protected MustOverride Function ToRadian(ByVal angle As Double) As Double
	Protected MustOverride Function FromDegrees(ByVal angle As Double) As Double

	Private Function FilterPointsByRange(ByVal points As List(Of SeriesPoint), ByVal min As Double, ByVal max As Double) As List(Of SeriesPoint)
		Dim resultPoints As New List(Of SeriesPoint)()
		For Each point As SeriesPoint In points
			Dim pointValue As Double = point.Values(0)
			If pointValue <= max AndAlso pointValue >= min Then
				resultPoints.Add(point)
			End If
		Next point
		Return resultPoints
	End Function
	Private Sub CreatePolarFunctionPoints(ByVal minAngleDegree As Double, ByVal maxAngleDegree As Double, ByVal intervalsCount As Integer, ByVal [function] As Func(Of Double, Double), ByVal points As List(Of SeriesPoint))
		Dim minAngle As Double = FromDegrees(minAngleDegree)
		Dim maxAngle As Double = FromDegrees(maxAngleDegree)
		Dim angleStep As Double = (maxAngle - minAngle) / CDbl(intervalsCount)
		For pointIndex As Integer = 0 To intervalsCount
			Dim angle As Double = minAngle + pointIndex * angleStep
			Dim angleRadians As Double = ToRadian(angle)
			Dim distance As Double = [function](angleRadians)
			Dim normalAngle As Double = NormalizeAngle(angle)
			points.Add(New SeriesPoint(normalAngle, distance))
		Next pointIndex
	End Sub
	Private Function ArchimedeanSpiralFunction(ByVal angleRadians As Double) As Double
		Return angleRadians
	End Function
	Private Function PolarRoseFunction(ByVal angleRadians As Double) As Double
		Return Math.Max(0.0, Math.Sin(roseParameter * angleRadians))
	End Function
	Private Function PolarFoliumFunction(ByVal angleRadians As Double) As Double
		Dim sin As Double = Math.Sin(angleRadians)
		Dim cos As Double = Math.Cos(angleRadians)
		Return (3.0 * sin * cos)/ (Math.Pow(sin, 3.0) + Math.Pow(cos, 3.0))
	End Function

	Public Function GenerateScatterFunctionPoints(ByVal index As Integer) As SeriesPoint()
		Dim points As New List(Of SeriesPoint)()
		Select Case index
			Case archimedeanSpiralIndex
				CreatePolarFunctionPoints(0.0, 720.0, spiralIntervalsCount, AddressOf ArchimedeanSpiralFunction, points)
			Case polarRoseIndex
				CreatePolarFunctionPoints(0.0, 1440.0, roseIntervalsCount, AddressOf PolarRoseFunction, points)
			Case polarFoliumIndex
				CreatePolarFunctionPoints(120.0, 180.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
				CreatePolarFunctionPoints(0.0, 90.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
				CreatePolarFunctionPoints(270.0, 330.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
				points = FilterPointsByRange(points, 0.0, foliumDistanceLimit)
		End Select
		Return points.ToArray()
	End Function
End Class

Public Class RadianScatterFunctionCalculator
	Inherits ScatterFunctionCalculatorBase
	Protected Overrides Function NormalizeAngle(ByVal angle As Double) As Double
		Return angle Mod (Math.PI * 2.0)
	End Function
	Protected Overrides Function ToRadian(ByVal angle As Double) As Double
		Return angle
	End Function
	Protected Overrides Function FromDegrees(ByVal angle As Double) As Double
		Return angle * Math.PI / 180.0
	End Function
End Class

Public Class DegreesScatterFunctionCalculator
	Inherits ScatterFunctionCalculatorBase
	Protected Overrides Function NormalizeAngle(ByVal angle As Double) As Double
		Return angle Mod 360
	End Function
	Protected Overrides Function ToRadian(ByVal angle As Double) As Double
		Return angle * Math.PI / 180.0
	End Function
	Protected Overrides Function FromDegrees(ByVal angle As Double) As Double
		Return angle
	End Function
End Class


Public Class BubbleDataItem
	Private year_Renamed As DateTime
	Private budget_Renamed As Double
	Private grosses_Renamed As Double
	Private title_Renamed As String

	Public ReadOnly Property Year() As DateTime
		Get
			Return year_Renamed
		End Get
	End Property
	Public ReadOnly Property Budget() As Double
		Get
			Return budget_Renamed
		End Get
	End Property
	Public ReadOnly Property Grosses() As Double
		Get
			Return grosses_Renamed
		End Get
	End Property
	Public ReadOnly Property Title() As String
		Get
			Return title_Renamed
		End Get
	End Property

	Public Sub New(ByVal year As DateTime, ByVal budget As Double, ByVal grosses As Double, ByVal title As String)
		Me.year_Renamed = year
		Me.budget_Renamed = budget
		Me.grosses_Renamed = grosses
		Me.title_Renamed = title
	End Sub
End Class

Public NotInheritable Class BubbleData
	Private Sub New()
	End Sub
	Public Shared Function GetData() As List(Of BubbleDataItem)
		Return New List(Of BubbleDataItem)() From {New BubbleDataItem(New DateTime(2007, 1, 1), 300, 0.963, "Pirates of the Caribbean: At World's End"), New BubbleDataItem(New DateTime(2008, 1, 1), 185, 1.004, "The Dark Knight"), New BubbleDataItem(New DateTime(2009, 1, 1), 237, 2.788, "Avatar"), New BubbleDataItem(New DateTime(2010, 1, 1), 200, 1.067, "Toy Story 3"), New BubbleDataItem(New DateTime(2011, 1, 1), 250, 1.341, "Harry Potter and the Deathly Hallows Part 2"), New BubbleDataItem(New DateTime(2012, 1, 1), 220, 1.519, "Marvel's The Avengers"), New BubbleDataItem(New DateTime(2013, 1, 1), 150, 1.276, "Frozen"), New BubbleDataItem(New DateTime(2014, 1, 1), 210, 1.104, "Transformers: Age of Extinction"), New BubbleDataItem(New DateTime(2015, 1, 1), 245, 2.068, "Star Wars: The Force Awakens"), New BubbleDataItem(New DateTime(2016, 1, 1), 250, 1.153, "Captain America: Civil War")}
	End Function
End Class

Public Class GDPofG7
	Public Shared Function GetData() As IList
		Dim data As DataTable = XMLUtils.LoadDataTableFromXml("GDPofG7.xml", "GDP")
		Return data.AsEnumerable().Where(Function(row) row.Field(Of Integer)("Year") >= 2010).Select(Function(row) New With {Key .Country = row.Field(Of String)("Country"), Key .Year = row.Field(Of Integer)("Year"), Key .Product = row.Field(Of Double)("Product")}).ToList()
	End Function
End Class

Public Class DevAV
	Public Shared Function GetSales() As DataTable
		Dim prevYear As Integer = DateTime.Now.Year - 1
		Dim table As New DataTable()
		table.Columns.AddRange(New DataColumn() { New DataColumn("Year", GetType(Integer)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal)) })

		table.Rows.Add(prevYear - 2, "Asia", 4.2372R)
		table.Rows.Add(prevYear - 2, "Australia", 1.7871R)
		table.Rows.Add(prevYear - 2, "Europe", 3.0884R)
		table.Rows.Add(prevYear - 2, "North America", 3.4855R)
		table.Rows.Add(prevYear - 2, "South America", 1.6027R)

		table.Rows.Add(prevYear - 1, "Asia", 4.7685R)
		table.Rows.Add(prevYear - 1, "Australia", 1.9576R)
		table.Rows.Add(prevYear - 1, "Europe", 3.3579R)
		table.Rows.Add(prevYear - 1, "North America", 3.7477R)
		table.Rows.Add(prevYear - 1, "South America", 1.8237R)

		table.Rows.Add(prevYear, "Asia", 5.2890R)
		table.Rows.Add(prevYear, "Australia", 2.2727R)
		table.Rows.Add(prevYear, "Europe", 3.7257R)
		table.Rows.Add(prevYear, "North America", 4.1825R)
		table.Rows.Add(prevYear, "South America", 2.1172R)

		Return table
	End Function
	Public Shared Function GetSalesMixByRegion() As DataTable
		Dim table As New DataTable()
		table.Columns.AddRange(New DataColumn() { New DataColumn("ProductCategory", GetType(String)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal)) })

		table.Rows.Add("Video players", "Asia", 853R)
		table.Rows.Add("Video players", "Australia", 321R)
		table.Rows.Add("Video players", "Europe", 655R)
		table.Rows.Add("Video players", "North America", 1325R)
		table.Rows.Add("Video players", "South America", 653R)

		table.Rows.Add("Automation", "Asia", 172R)
		table.Rows.Add("Automation", "Australia", 255R)
		table.Rows.Add("Automation", "Europe", 981R)
		table.Rows.Add("Automation", "North America", 963R)
		table.Rows.Add("Automation", "South America", 123R)

		table.Rows.Add("Monitors", "Asia", 1011R)
		table.Rows.Add("Monitors", "Australia", 359R)
		table.Rows.Add("Monitors", "Europe", 721R)
		table.Rows.Add("Monitors", "North America", 565R)
		table.Rows.Add("Monitors", "South America", 532R)

		table.Rows.Add("Projectors", "Asia", 998R)
		table.Rows.Add("Projectors", "Australia", 222R)
		table.Rows.Add("Projectors", "Europe", 865R)
		table.Rows.Add("Projectors", "North America", 787R)
		table.Rows.Add("Projectors", "South America", 332R)

		table.Rows.Add("Televisions", "Asia", 1356R)
		table.Rows.Add("Televisions", "Australia", 232R)
		table.Rows.Add("Televisions", "Europe", 1323R)
		table.Rows.Add("Televisions", "North America", 1125R)
		table.Rows.Add("Televisions", "South America", 865R)

		Return table
	End Function
	Public Shared Function GetBranchesSales() As DataTable
		Dim lastYear As Integer = DateTime.Now.Year - 1
		Dim table As New DataTable()
		table.Columns.AddRange(New DataColumn() { New DataColumn("Year", GetType(DateTime)), New DataColumn("Company", GetType(String)), New DataColumn("Sales", GetType(Decimal)) })

		table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV North", 1.010)
		table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV Center", 3.032)
		table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "DevAV South", 1.31)

		table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV North", 1.512)
		table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV Center", 3.050)
		table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "DevAV South", 1.34)

		table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV North", 1.723)
		table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV West", 0.005)
		table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV Center", 3.054)
		table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "DevAV South", 1.30)

		table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV West", 0.31)
		table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV North", 2.001)
		table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV Center", 2.975)
		table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "DevAV South", 1.283)

		table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV West", 0.41)
		table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV North", 2.612)
		table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV Center", 2.066)
		table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "DevAV South", 0.88)

		table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV West", 0.95)
		table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV North", 2.666)
		table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV Center", 2.078)
		table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "DevAV South", 1.09)

		table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV West", 1.53)
		table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV North", 3.665)
		table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV Center", 3.888)
		table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "DevAV South", 1.01)

		table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV East", 0.003)
		table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV West", 1.75)
		table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV North", 3.555)
		table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV Center", 3.008)
		table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "DevAV South", 1.11)

		table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV East", 0.32)
		table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV West", 1.31)
		table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV North", 3.485)
		table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV Center", 3.088)
		table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "DevAV South", 1.12)

		table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV East", 0.51)
		table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV West", 1.31)
		table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV North", 3.747)
		table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV Center", 3.357)
		table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "DevAV South", 1.12)

		table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV East", 1.71)
		table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV West", 1.22)
		table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV North", 4.182)
		table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV Center", 3.725)
		table.Rows.Add(New DateTime(lastYear, 12, 31), "DevAV South", 1.111)

		Return table
	End Function
	Public Shared Function GetSalesByLast10Years() As DataTable
		Dim lastYear As Integer = DateTime.Now.Year - 1
		Dim table As New DataTable()
		table.Columns.AddRange(New DataColumn() { New DataColumn("Year", GetType(DateTime)), New DataColumn("Region", GetType(String)), New DataColumn("Sales", GetType(Decimal)) })

		table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "North America", 3.010D)
		table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "Europe", 3.032D)
		table.Rows.Add(New DateTime(lastYear - 10, 12, 31), "Australia", 1.31D)

		table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "North America", 3.212D)
		table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "Europe", 3.050D)
		table.Rows.Add(New DateTime(lastYear - 9, 12, 31), "Australia", 1.64D)

		table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "North America", 3.223D)
		table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "Europe", 3.054D)
		table.Rows.Add(New DateTime(lastYear - 8, 12, 31), "Australia", 1.70D)

		table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "North America", 3.001D)
		table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "Europe", 2.775D)
		table.Rows.Add(New DateTime(lastYear - 7, 12, 31), "Australia", 1.083D)

		table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "North America", 2.612D)
		table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "Europe", 2.066D)
		table.Rows.Add(New DateTime(lastYear - 6, 12, 31), "Australia", 0.88D)

		table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "North America", 2.666D)
		table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "Europe", 2.078D)
		table.Rows.Add(New DateTime(lastYear - 5, 12, 31), "Australia", 1.09D)

		table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "North America", 3.665D)
		table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "Europe", 3.888D)
		table.Rows.Add(New DateTime(lastYear - 4, 12, 31), "Australia", 2.01D)

		table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "North America", 3.555D)
		table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "Europe", 3.008D)
		table.Rows.Add(New DateTime(lastYear - 3, 12, 31), "Australia", 1.85D)

		table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "North America", 3.485D)
		table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "Europe", 3.088D)
		table.Rows.Add(New DateTime(lastYear - 2, 12, 31), "Australia", 1.78D)

		table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "North America", 3.747D)
		table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "Europe", 3.357D)
		table.Rows.Add(New DateTime(lastYear - 1, 12, 31), "Australia", 1.957D)

		table.Rows.Add(New DateTime(lastYear, 12, 31), "North America", 4.182D)
		table.Rows.Add(New DateTime(lastYear, 12, 31), "Europe", 3.725D)
		table.Rows.Add(New DateTime(lastYear, 12, 31), "Australia", 2.272D)

		Return table
	End Function
	Public Shared Function GetOutsideVendorCosts() As DataTable
		Dim lastYear As Integer = DateTime.Now.Year - 1
		Dim table As New DataTable()
		table.Columns.AddRange(New DataColumn() { New DataColumn("Year", GetType(DateTime)), New DataColumn("Company", GetType(String)), New DataColumn("Costs", GetType(Decimal)) })

		table.Rows.Add(New DateTime(lastYear - 6, 1, 1), "DevAV North", 362.5D)
		table.Rows.Add(New DateTime(lastYear - 5, 1, 1), "DevAV North", 348.4D)
		table.Rows.Add(New DateTime(lastYear - 4, 1, 1), "DevAV North", 279.0D)
		table.Rows.Add(New DateTime(lastYear - 3, 1, 1), "DevAV North", 230.9D)
		table.Rows.Add(New DateTime(lastYear - 2, 1, 1), "DevAV North", 203.5D)
		table.Rows.Add(New DateTime(lastYear - 1, 1, 1), "DevAV North", 197.1D)

		table.Rows.Add(New DateTime(lastYear - 6, 1, 1), "DevAV South", 277.0D)
		table.Rows.Add(New DateTime(lastYear - 5, 1, 1), "DevAV South", 328.5D)
		table.Rows.Add(New DateTime(lastYear - 4, 1, 1), "DevAV South", 297.0D)
		table.Rows.Add(New DateTime(lastYear - 3, 1, 1), "DevAV South", 255.3D)
		table.Rows.Add(New DateTime(lastYear - 2, 1, 1), "DevAV South", 173.5D)
		table.Rows.Add(New DateTime(lastYear - 1, 1, 1), "DevAV South", 131.8D)

		Return table
	End Function
End Class

Public Class AgeStructure
	Private Shared ageStructureTable_Renamed As DataTable
	Private Shared ReadOnly Property AgeStructureTable() As DataTable
		Get
			If ageStructureTable_Renamed Is Nothing Then
				ageStructureTable_Renamed = LoadPopulationAgeStructure()
			End If
			Return ageStructureTable_Renamed
		End Get
	End Property

	Private Shared Function LoadPopulationAgeStructure() As DataTable ' data for end of 2016
		Return XMLUtils.LoadDataTableFromXml("Population.xml", "Population")
	End Function
	Public Shared Function GetDataByAgeAndGender() As IList
		Return AgeStructureTable.AsEnumerable().Select(Function(row) New With {Key .GenderAge = New GenderAgeInfo(row.Field(Of String)("Gender"), row.Field(Of String)("Age")), Key .Country = row.Field(Of String)("Country"), Key .Population = row.Field(Of Long)("Population")}).ToList()
	End Function
	Public Shared Function GetDataByMaleAge() As IList
		Return AgeStructureTable.AsEnumerable().Where(Function(row) row.Field(Of String)("Gender") = "Male").Select(Function(row) New With {Key .Age = row.Field(Of String)("Age"), Key .Country = row.Field(Of String)("Country"), Key .Population = row.Field(Of Long)("Population")}).ToList()
	End Function
	Public Shared Function GetDataByFemaleAge() As IList
		Return AgeStructureTable.AsEnumerable().Where(Function(row) row.Field(Of String)("Gender") = "Female").Select(Function(row) New With {Key .Age = row.Field(Of String)("Age"), Key .Country = row.Field(Of String)("Country"), Key .Population = row.Field(Of Long)("Population")}).ToList()
	End Function
	Public Shared Function GetPopulationAgeStructure() As IList
		Return AgeStructureTable.AsEnumerable().Select(Function(row) New AgePopulation(row.Field(Of String)("Country"), row.Field(Of String)("Age"), row.Field(Of String)("Gender"), row.Field(Of Long)("Population"))).ToList()
	End Function
End Class
Public Structure GenderAgeInfo
	Private gender_Renamed As String
	Private age_Renamed As String

	Public ReadOnly Property Gender() As String
		Get
			Return gender_Renamed
		End Get
	End Property
	Public ReadOnly Property Age() As String
		Get
			Return age_Renamed
		End Get
	End Property

	Public Sub New(ByVal gender As String, ByVal age As String)
		Me.gender_Renamed = gender
		Me.age_Renamed = age
	End Sub
	Public Overrides Function ToString() As String
		Return gender_Renamed & ": " & age_Renamed
	End Function
End Structure
Public Class AgePopulation
	Private name_Renamed As String
	Private age_Renamed As String
	Private gender_Renamed As String
	Private population_Renamed As Double

	Public ReadOnly Property Name() As String
		Get
			Return name_Renamed
		End Get
	End Property
	Public ReadOnly Property Age() As String
		Get
			Return age_Renamed
		End Get
	End Property
	Public ReadOnly Property Gender() As String
		Get
			Return gender_Renamed
		End Get
	End Property
	Public ReadOnly Property GenderAgeKey() As String
		Get
			Return gender_Renamed.ToString() & ": " & age_Renamed
		End Get
	End Property
	Public ReadOnly Property CountryAgeKey() As String
		Get
			Return name_Renamed & ": " & age_Renamed
		End Get
	End Property
	Public ReadOnly Property CountryGenderKey() As String
		Get
			Return name_Renamed & ": " & gender_Renamed.ToString()
		End Get
	End Property
	Public ReadOnly Property Population() As Double
		Get
			Return population_Renamed
		End Get
	End Property

	Public Sub New(ByVal name As String, ByVal age As String, ByVal gender As String, ByVal population As Double)
		Me.name_Renamed = name
		Me.age_Renamed = age
		Me.gender_Renamed = gender
		Me.population_Renamed = population
	End Sub
End Class

Public Class MarketPrices
	Public Shared Function GetGoogleStockPrices() As DataTable
		Return XMLUtils.LoadDataTableFromXml("GoogleStock.xml", "StockPrice")
	End Function
	Public Shared Function GetAppleStockPrices() As DataTable
		Return XMLUtils.LoadDataTableFromXml("AppleStock.xml", "StockPrice")
	End Function
	Public Shared Function GetPartialAppleStockPrices() As IList
		Return GetAppleStockPrices().AsEnumerable().Where(Function(row) row.Field(Of DateTime)("Date") >= New DateTime(2016, 09, 1)).Select(Function(row) New With {Key .Date = row.Field(Of DateTime)("Date"), Key .Low = row.Field(Of Double)("Low"), Key .High = row.Field(Of Double)("High"), Key .Open = row.Field(Of Double)("Open"), Key .Close = row.Field(Of Double)("Close")}).ToList()
	End Function
End Class

Public Class SourceOfEnergy
	Public Shared Function GetEuropeBrentPrices() As DataTable
		Dim table As New DataTable("Europe Brent")
		table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("Min", GetType(Single)), New DataColumn("Max", GetType(Single)) })
		table.Rows.Add(New DateTime(2015, 01, 1), 45.13, 55.38)
		table.Rows.Add(New DateTime(2015, 02, 1), 51.74, 61.89)
		table.Rows.Add(New DateTime(2015, 03, 1), 52.00, 61.18)
		table.Rows.Add(New DateTime(2015, 04, 1), 55.73, 63.97)
		table.Rows.Add(New DateTime(2015, 05, 1), 60.12, 66.33)
		table.Rows.Add(New DateTime(2015, 06, 1), 59.03, 64.68)
		table.Rows.Add(New DateTime(2015, 07, 1), 53.29, 61.73)
		table.Rows.Add(New DateTime(2015, 08, 1), 41.59, 49.49)
		table.Rows.Add(New DateTime(2015, 09, 1), 45.87, 50.41)
		table.Rows.Add(New DateTime(2015, 10, 1), 45.54, 52.13)
		table.Rows.Add(New DateTime(2015, 11, 1), 40.28, 48.00)
		table.Rows.Add(New DateTime(2015, 12, 1), 35.26, 42.97)
		Return table
	End Function
	Public Shared Function GetOkWtiPrices() As DataTable
		Dim table As New DataTable("OK WTI")
		table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("Min", GetType(Single)), New DataColumn("Max", GetType(Single)) })
		table.Rows.Add(New DateTime(2015, 01, 1), 44.08, 52.72)
		table.Rows.Add(New DateTime(2015, 02, 1), 47.65, 49.84)
		table.Rows.Add(New DateTime(2015, 03, 1), 43.39, 51.53)
		table.Rows.Add(New DateTime(2015, 04, 1), 49.13, 59.62)
		table.Rows.Add(New DateTime(2015, 05, 1), 57.29, 60.93)
		table.Rows.Add(New DateTime(2015, 06, 1), 58.00, 61.36)
		table.Rows.Add(New DateTime(2015, 07, 1), 47.11, 56.94)
		table.Rows.Add(New DateTime(2015, 08, 1), 38.22, 49.20)
		table.Rows.Add(New DateTime(2015, 09, 1), 44.07, 47.12)
		table.Rows.Add(New DateTime(2015, 10, 1), 43.19, 49.67)
		table.Rows.Add(New DateTime(2015, 11, 1), 39.27, 47.88)
		table.Rows.Add(New DateTime(2015, 12, 1), 34.55, 41.08)
		Return table
	End Function
	Public Shared Function GetGasolinePrices() As DataTable
		Dim table As New DataTable("Gasoline")
		table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("Price", GetType(Single)) })
		table.Rows.Add(New DateTime(2015, 01, 1), 2.208)
		table.Rows.Add(New DateTime(2015, 02, 1), 2.301)
		table.Rows.Add(New DateTime(2015, 03, 1), 2.546)
		table.Rows.Add(New DateTime(2015, 04, 1), 2.555)
		table.Rows.Add(New DateTime(2015, 05, 1), 2.802)
		table.Rows.Add(New DateTime(2015, 06, 1), 2.885)
		table.Rows.Add(New DateTime(2015, 07, 1), 2.880)
		table.Rows.Add(New DateTime(2015, 08, 1), 2.726)
		table.Rows.Add(New DateTime(2015, 09, 1), 2.462)
		table.Rows.Add(New DateTime(2015, 10, 1), 2.387)
		table.Rows.Add(New DateTime(2015, 11, 1), 2.260)
		table.Rows.Add(New DateTime(2015, 12, 1), 2.144)
		Return table
	End Function
	Public Shared Function GetFuelPrices() As DataTable
		Dim table As New DataTable()
		Dim lastYear As Integer = DateTime.Now.Year - 1
		table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("Price", GetType(Decimal)) })
		table.Rows.Add(New DateTime(lastYear, 1, 1, 0, 0, 0), 1.05D)
		table.Rows.Add(New DateTime(lastYear, 3, 3, 0, 0, 0), 1.07D)
		table.Rows.Add(New DateTime(lastYear, 3, 20, 0, 0, 0), 1.12D)
		table.Rows.Add(New DateTime(lastYear, 4, 15, 0, 0, 0), 1.15D)
		table.Rows.Add(New DateTime(lastYear, 5, 12, 0, 0, 0), 1.30D)
		table.Rows.Add(New DateTime(lastYear, 7, 15, 0, 0, 0), 1.25D)
		table.Rows.Add(New DateTime(lastYear, 7, 20, 0, 0, 0), 1.21D)
		table.Rows.Add(New DateTime(lastYear, 9, 15, 0, 0, 0), 1.20D)
		table.Rows.Add(New DateTime(lastYear, 10, 10, 0, 0, 0), 1.18D)
		table.Rows.Add(New DateTime(lastYear, 12, 30, 0, 0, 0), 1.12D)
		Return table
	End Function
	Public Shared Function GetCoalProduction() As DataTable
		Dim table As New DataTable()
		table.Columns.AddRange(New DataColumn() { New DataColumn("Date", GetType(DateTime)), New DataColumn("South Africa", GetType(Decimal)), New DataColumn("Poland", GetType(Decimal)), New DataColumn("Russia", GetType(Decimal)) })
		table.Rows.Add(New DateTime(2015, 12, 31, 0, 0, 0), 252.099, 135.523, 373.300)
		table.Rows.Add(New DateTime(2014, 12, 31, 0, 0, 0), 261.523, 137.148, 357.396)
		table.Rows.Add(New DateTime(2013, 12, 31, 0, 0, 0), 256.562, 142.906, 355.231)
		table.Rows.Add(New DateTime(2012, 12, 31, 0, 0, 0), 258.575, 144.093, 358.300)
		table.Rows.Add(New DateTime(2011, 12, 31, 0, 0, 0), 252.756, 139.289, 337.400)
		table.Rows.Add(New DateTime(2010, 12, 31, 0, 0, 0), 254.521, 133.238, 322.920)
		table.Rows.Add(New DateTime(2009, 12, 31, 0, 0, 0), 247.820, 135.172, 302.382)
		table.Rows.Add(New DateTime(2008, 12, 31, 0, 0, 0), 252.213, 144.013, 330.182)
		table.Rows.Add(New DateTime(2007, 12, 31, 0, 0, 0), 247.666, 145.850, 315.570)
		table.Rows.Add(New DateTime(2006, 12, 31, 0, 0, 0), 244.774, 156.065, 311.370)
		table.Rows.Add(New DateTime(2005, 12, 31, 0, 0, 0), 244.985, 159.540, 299.970)
		table.Rows.Add(New DateTime(2004, 12, 31, 0, 0, 0), 242.821, 161.284, 284.398)
		table.Rows.Add(New DateTime(2003, 12, 31, 0, 0, 0), 238.751, 163.790, 278.746)
		table.Rows.Add(New DateTime(2002, 12, 31, 0, 0, 0), 220.212, 161.920, 258.912)
		table.Rows.Add(New DateTime(2001, 12, 31, 0, 0, 0), 223.560, 163.540, 274.001)
		table.Rows.Add(New DateTime(2000, 12, 31, 0, 0, 0), 224.199, 162.820, 262.081)
		table.Rows.Add(New DateTime(1999, 12, 31, 0, 0, 0), 223.514, 172.730, 255.050)
		table.Rows.Add(New DateTime(1998, 12, 31, 0, 0, 0), 222.976, 178.550, 235.383)
		table.Rows.Add(New DateTime(1997, 12, 31, 0, 0, 0), 220.072, 200.930, 250.617)
		table.Rows.Add(New DateTime(1996, 12, 31, 0, 0, 0), 206.362, 201.720, 262.052)
		table.Rows.Add(New DateTime(1995, 12, 31, 0, 0, 0), 206.210, 200.720, 269.574)
		table.Rows.Add(New DateTime(1994, 12, 31, 0, 0, 0), 195.805, 200.700, 278.304)
		table.Rows.Add(New DateTime(1993, 12, 31, 0, 0, 0), 188.214, 198.580, 311.862)
		table.Rows.Add(New DateTime(1992, 12, 31, 0, 0, 0), 184.045, 198.380, 349.004)
		table.Rows.Add(New DateTime(1991, 12, 31, 0, 0, 0), 178.390, 209.790, 362.235)
		table.Rows.Add(New DateTime(1990, 12, 31, 0, 0, 0), 174.780, 215.320, 405.194)
		Return table
	End Function
End Class

Public Class FinancialPoint
		Private argument_Renamed As String
		Private dateTimeArgument_Renamed As DateTime
		Private highValue_Renamed As Double
		Private lowValue_Renamed As Double
		Private openValue_Renamed As Double
		Private closeValue_Renamed As Double

		Public Property Argument() As String
			Get
				Return argument_Renamed
			End Get
			Set(ByVal value As String)
				argument_Renamed = value
			End Set
		End Property
		Public Property DateTimeArgument() As DateTime
			Get
				Return dateTimeArgument_Renamed
			End Get
			Set(ByVal value As DateTime)
				dateTimeArgument_Renamed = value
			End Set
		End Property
		Public Property HighValue() As Double
			Get
				Return highValue_Renamed
			End Get
			Set(ByVal value As Double)
				highValue_Renamed = value
			End Set
		End Property
		Public Property LowValue() As Double
			Get
				Return lowValue_Renamed
			End Get
			Set(ByVal value As Double)
				lowValue_Renamed = value
			End Set
		End Property
		Public Property OpenValue() As Double
			Get
				Return openValue_Renamed
			End Get
			Set(ByVal value As Double)
				openValue_Renamed = value
			End Set
		End Property
		Public Property CloseValue() As Double
			Get
				Return closeValue_Renamed
			End Get
			Set(ByVal value As Double)
				closeValue_Renamed = value
			End Set
		End Property
End Class

Public Class FinancialData
	Public Shared Function GetUSDJPYData() As List(Of FinancialPoint)
		Return CsvReader.ReadFinancialData("USDJPYDaily.csv")
	End Function
	Public Shared Function GetAUDUSDData() As List(Of FinancialPoint)
		Return CsvReader.ReadFinancialData("AUDUSDDaily.csv")
	End Function
End Class

Public Class PowerConsumption
	Public Shared Function GetData() As DataTable
		Dim table As New DataTable()
		table.Columns.AddRange(New DataColumn() { New DataColumn("Branch", GetType(String)), New DataColumn("Time", GetType(DateTime)), New DataColumn("Power", GetType(Double)) })

		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 7, 0, 0), 429)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 8, 0, 0), 432)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 9, 0, 0), 301)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 10, 0, 0), 307)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 11, 0, 0), 310)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 12, 0, 0), 380)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 13, 0, 0), 384)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 14, 0, 0), 398)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 15, 0, 0), 379)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 16, 0, 0), 220)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 17, 0, 0), 321)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 18, 0, 0), 341)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 19, 0, 0), 368)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 20, 0, 0), 557)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 21, 0, 0), 523)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 22, 0, 0), 501)
		table.Rows.Add("Branch ""Center""", New DateTime(1, 1, 1, 23, 0, 0), 443)

		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 7, 0, 0), 260)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 8, 0, 0), 287)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 9, 0, 0), 285)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 10, 0, 0), 281)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 11, 0, 0), 294)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 12, 0, 0), 303)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 13, 0, 0), 325)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 14, 0, 0), 336)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 15, 0, 0), 325)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 16, 0, 0), 186)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 17, 0, 0), 420)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 18, 0, 0), 455)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 19, 0, 0), 481)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 20, 0, 0), 487)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 21, 0, 0), 490)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 22, 0, 0), 467)
		table.Rows.Add("Branch ""East""", New DateTime(1, 1, 1, 23, 0, 0), 409)

		Return table
	End Function
End Class