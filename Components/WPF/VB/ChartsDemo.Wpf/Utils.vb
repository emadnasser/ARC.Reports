Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Threading
Imports System.Xml.Linq
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo

    Public NotInheritable Class DataLoader

        Private Sub New()
        End Sub

        Public Shared Function LoadXmlFromResources(ByVal fileName As String) As XDocument
            Try
                fileName = "/ChartsDemo;component" & fileName
                Dim uri As New Uri(fileName, UriKind.RelativeOrAbsolute)
                Dim info As StreamResourceInfo = Application.GetResourceStream(uri)
                Return XDocument.Load(info.Stream)
            Catch
                Return Nothing
            End Try
        End Function
    End Class


    Public NotInheritable Class ToolTipControlHelper

        Private Sub New()
        End Sub

        Friend Shared Sub PrepareToolTipPositionComboBox(ByVal comboBox As ComboBoxEdit)
            comboBox.Items.Add("Mouse Pointer")
            comboBox.Items.Add("Relative")
            comboBox.Items.Add("Free")
            comboBox.SelectedIndex = 0
        End Sub
        Friend Shared Sub PrepareToolTipLocationComboBox(ByVal comboBox As ComboBoxEdit)
            comboBox.Items.Add("Top Right")
            comboBox.Items.Add("Top Left")
            comboBox.Items.Add("Bottom Right")
            comboBox.Items.Add("Bottom Left")
            comboBox.SelectedIndex = 0
        End Sub
        Friend Shared Function GetLocationFromComboBox(ByVal selectedIndex As Integer) As ToolTipLocation
            Select Case selectedIndex
                Case 0
                    Return ToolTipLocation.TopRight
                Case 1
                    Return ToolTipLocation.TopLeft
                Case 2
                    Return ToolTipLocation.BottomRight
                Case Else
                    Return ToolTipLocation.BottomLeft
            End Select
        End Function
    End Class


    Public NotInheritable Class ResolveOverlappingModeHelper

        Private Sub New()
        End Sub

        Public Shared Sub PrepareListBox(ByVal listBox As ListBoxEdit, ByVal index As Integer)
            listBox.Items.Add("None")
            listBox.Items.Add("Default")
            listBox.Items.Add("Hide Overlapped")
            listBox.Items.Add("Justify Around Point")
            listBox.Items.Add("Justify All Around Point")
            listBox.SelectedIndex = index
        End Sub
        Public Shared Function GetMode(ByVal listBox As ListBoxEdit) As ResolveOverlappingMode
            Select Case listBox.SelectedIndex
                Case 0
                    Return ResolveOverlappingMode.None
                Case 1
                    Return ResolveOverlappingMode.Default
                Case 2
                    Return ResolveOverlappingMode.HideOverlapped
                Case 3
                    Return ResolveOverlappingMode.JustifyAroundPoint
                Case 4
                    Return ResolveOverlappingMode.JustifyAllAroundPoint
                Case Else
                    Return ResolveOverlappingMode.None
            End Select
        End Function
    End Class


    Public NotInheritable Class RangeArea2DHelper

        Private Sub New()
        End Sub

        Public Shared Sub PrepareComboBox(ByVal comboBox As ComboBoxEdit, ByVal index As Integer)
            comboBox.Items.Add("One Label")
            comboBox.Items.Add("Two Labels")
            comboBox.Items.Add("Min Value Label")
            comboBox.Items.Add("Max Value Label")
            comboBox.Items.Add("Value1 Label")
            comboBox.Items.Add("Value2 Label")
            comboBox.SelectedIndex = index
        End Sub
        Public Shared Function GetMode(ByVal comboBox As ComboBoxEdit) As RangeAreaLabelKind
            Select Case comboBox.SelectedIndex
                Case 0
                    Return RangeAreaLabelKind.OneLabel
                Case 1
                    Return RangeAreaLabelKind.TwoLabels
                Case 2
                    Return RangeAreaLabelKind.MinValueLabel
                Case 3
                    Return RangeAreaLabelKind.MaxValueLabel
                Case 4
                    Return RangeAreaLabelKind.Value1Label
                Case 5
                    Return RangeAreaLabelKind.Value2Label
                Case Else
                    Return RangeAreaLabelKind.TwoLabels
            End Select
        End Function
    End Class


    Public NotInheritable Class Marker2DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Function FindActualMarker2DModelKind(ByVal modelType As Type) As Marker2DKind
            Dim marker2DKinds As IEnumerable(Of Marker2DKind) = Marker2DModel.GetPredefinedKinds()
            For Each marker2DKind As Marker2DKind In marker2DKinds
                If Object.Equals(marker2DKind.Type, modelType) Then
                    Return marker2DKind
                End If
            Next marker2DKind
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class Bar3DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Function FindActualBar3DModelKind(ByVal model As Bar3DModel) As Bar3DKind
            If model Is Nothing Then
                Return Nothing
            End If
            Dim bar3DKinds As IEnumerable(Of Bar3DKind) = Bar3DModel.GetPredefinedKinds()
            For Each bar3DKind As Bar3DKind In bar3DKinds
                If Object.Equals(bar3DKind.Type, model.GetType()) Then
                    Return bar3DKind
                End If
            Next bar3DKind
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class Pie3DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Sub SetModel(ByVal chart As ChartControl, ByVal model As Pie3DModel)
            For Each series As PieSeries3D In chart.Diagram.Series
                series.Model = model
            Next series
        End Sub
        Public Shared Function FindActualPie3DModelKind(ByVal model As Pie3DModel) As Pie3DKind
            If model Is Nothing Then
                Return Nothing
            End If
            Dim pie3DKinds As IEnumerable(Of Pie3DKind) = Pie3DModel.GetPredefinedKinds()
            For Each pie3DKind As Pie3DKind In pie3DKinds
                If Object.Equals(pie3DKind.Type, model.GetType()) Then
                    Return pie3DKind
                End If
            Next pie3DKind
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class Marker3DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Sub SetModel(ByVal chart As ChartControl, ByVal model As Marker3DModel)
            For Each series As MarkerSeries3D In chart.Diagram.Series
                series.Model = model
            Next series
        End Sub
        Public Shared Function FindActualMarker3DModelKind(ByVal model As Marker3DModel) As Marker3DKind
            If model Is Nothing Then
                Return Nothing
            End If
            Dim marker3DKinds As IEnumerable(Of Marker3DKind) = Marker3DModel.GetPredefinedKinds()
            For Each marker3DKind As Marker3DKind In marker3DKinds
                If Object.Equals(marker3DKind.Type, model.GetType()) Then
                    Return marker3DKind
                End If
            Next marker3DKind
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class Pie2DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Function FindActualPie2DModelKind(ByVal modelType As Type) As Pie2DKind
            Dim pie2DKinds As IEnumerable(Of Pie2DKind) = Pie2DModel.GetPredefinedKinds()
            For Each pie2DType As Pie2DKind In pie2DKinds
                If Object.Equals(pie2DType.Type, modelType) Then
                    Return pie2DType
                End If
            Next pie2DType
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class Bar2DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Function FindActualBar2DModelKind(ByVal modelType As Type) As Bar2DKind
            Dim bar2DKinds As IEnumerable(Of Bar2DKind) = Bar2DModel.GetPredefinedKinds()
            For Each bar2DKind As Bar2DKind In bar2DKinds
                If Object.Equals(bar2DKind.Type, modelType) Then
                    Return bar2DKind
                End If
            Next bar2DKind
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class RangeBar2DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Function FindActualRangeBar2DModelKind(ByVal modelType As Type) As RangeBar2DKind
            Dim bar2DKinds As IEnumerable(Of RangeBar2DKind) = RangeBar2DModel.GetPredefinedKinds()
            For Each bar2DKind As RangeBar2DKind In bar2DKinds
                If Object.Equals(bar2DKind.Type, modelType) Then
                    Return bar2DKind
                End If
            Next bar2DKind
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class Stock2DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Function FindActualStock2DModelKind(ByVal modelType As Type) As Stock2DKind
            Dim stock2DKinds As IEnumerable(Of Stock2DKind) = Stock2DModel.GetPredefinedKinds()
            For Each stock2DKind As Stock2DKind In stock2DKinds
                If Object.Equals(stock2DKind.Type, modelType) Then
                    Return stock2DKind
                End If
            Next stock2DKind
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class CandleStick2DModelKindHelper

        Private Sub New()
        End Sub

        Public Shared Function FindActualCandleStick2DModelKind(ByVal modelType As Type) As CandleStick2DKind
            Dim candleStick2DKinds As IEnumerable(Of CandleStick2DKind) = CandleStick2DModel.GetPredefinedKinds()
            For Each candleStick2DKind As CandleStick2DKind In candleStick2DKinds
                If Object.Equals(candleStick2DKind.Type, modelType) Then
                    Return candleStick2DKind
                End If
            Next candleStick2DKind
            Return Nothing
        End Function
    End Class


    Public Class FinancialPoint

        Private argument_Renamed As String

        Private dateTimeArgument_Renamed As Date

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
        Public Property DateTimeArgument() As Date
            Get
                Return dateTimeArgument_Renamed
            End Get
            Set(ByVal value As Date)
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


    Public Class SeriesTypeItem

        Private ReadOnly diagramType_Renamed As Type

        Private ReadOnly seriesType_Renamed As Type
        Private ReadOnly seriesName As String

        Private ReadOnly seriesCount_Renamed As Integer

        Public ReadOnly Property DiagramType() As Type
            Get
                Return diagramType_Renamed
            End Get
        End Property
        Public ReadOnly Property SeriesType() As Type
            Get
                Return seriesType_Renamed
            End Get
        End Property
        Public ReadOnly Property SeriesCount() As Integer
            Get
                Return seriesCount_Renamed
            End Get
        End Property

        Public Sub New(ByVal diagramType As Type, ByVal seriesType As Type, ByVal seriesName As String)
            Me.New(diagramType, seriesType, seriesName, 1)
        End Sub
        Public Sub New(ByVal diagramType As Type, ByVal seriesType As Type, ByVal seriesName As String, ByVal seriesCount As Integer)
            Me.diagramType_Renamed = diagramType
            Me.seriesType_Renamed = seriesType
            Me.seriesName = seriesName
            Me.seriesCount_Renamed = seriesCount
        End Sub
        Public Overrides Function ToString() As String
            Return seriesName
        End Function
    End Class


    Public Class DemoValuesProvider
        Public ReadOnly Property Bubble2DLabelPositions() As IEnumerable(Of Bubble2DLabelPosition)
            Get
                Return DevExpress.Utils.EnumExtensions.GetValues(GetType(Bubble2DLabelPosition)).Cast(Of Bubble2DLabelPosition)()
            End Get
        End Property
        Public ReadOnly Property Bar2DLabelPositions() As IEnumerable(Of Bar2DLabelPosition)
            Get
                Return DevExpress.Utils.EnumExtensions.GetValues(GetType(Bar2DLabelPosition)).Cast(Of Bar2DLabelPosition)()
            End Get
        End Property
        Public ReadOnly Property Funnel2DLabelPositions() As IEnumerable(Of Funnel2DLabelPosition)
            Get
                Return DevExpress.Utils.EnumExtensions.GetValues(GetType(Funnel2DLabelPosition)).Cast(Of Funnel2DLabelPosition)()
            End Get
        End Property
        Public ReadOnly Property RangeAreaLabelKinds() As IEnumerable(Of RangeAreaLabelKind)
            Get
                Return DevExpress.Utils.EnumExtensions.GetValues(GetType(RangeAreaLabelKind)).Cast(Of RangeAreaLabelKind)()
            End Get
        End Property
        Public ReadOnly Property PredefinedBar2DKinds() As IEnumerable(Of Bar2DKind)
            Get
                Return Bar2DModel.GetPredefinedKinds()
            End Get
        End Property
        Public ReadOnly Property PredefinedMarker2DKinds() As IEnumerable(Of Marker2DKind)
            Get
                Return Marker2DModel.GetPredefinedKinds()
            End Get
        End Property
        Public ReadOnly Property PredefinedCandleStick2DKinds() As IEnumerable(Of CandleStick2DKind)
            Get
                Return CandleStick2DModel.GetPredefinedKinds()
            End Get
        End Property
        Public ReadOnly Property PredefinedStock2DKinds() As IEnumerable(Of Stock2DKind)
            Get
                Return Stock2DModel.GetPredefinedKinds()
            End Get
        End Property
        Public ReadOnly Property PredefinedPie2DKinds() As IEnumerable(Of Pie2DKind)
            Get
                Return Pie2DModel.GetPredefinedKinds()
            End Get
        End Property
        Public ReadOnly Property PredefinedRangeBar2DKinds() As IEnumerable(Of RangeBar2DKind)
            Get
                Return RangeBar2DModel.GetPredefinedKinds()
            End Get
        End Property
        Public ReadOnly Property ScrollBarAlignments() As IEnumerable(Of ScrollBarAlignment)
            Get
                Return DevExpress.Utils.EnumExtensions.GetValues(GetType(ScrollBarAlignment)).Cast(Of ScrollBarAlignment)()
            End Get
        End Property
        Public ReadOnly Iterator Property PredefinedBubble3DModels() As IEnumerable(Of Marker3DPointModel)
            Get
                Yield New Marker3DCubePointModel()
                Yield New Marker3DSpherePointModel()
            End Get
        End Property
    End Class


    Public Enum CircularFunction
        TaubinsHeart
        Cardioid
        Lemniskate
    End Enum


    Public Enum ScatterCircularFunction
        ArchimedeanSpiral
        Rose
        Folium
    End Enum


    Public Structure RangeDataPoint

        Private x_Renamed As Double

        Private y1_Renamed As Double

        Private y2_Renamed As Double

        Public ReadOnly Property X() As Double
            Get
                Return x_Renamed
            End Get
        End Property
        Public ReadOnly Property Y1() As Double
            Get
                Return y1_Renamed
            End Get
        End Property
        Public ReadOnly Property Y2() As Double
            Get
                Return y2_Renamed
            End Get
        End Property

        Public Sub New(ByVal x As Double, ByVal y1 As Double, ByVal y2 As Double)
            Me.x_Renamed = x
            Me.y1_Renamed = y1
            Me.y2_Renamed = y2
        End Sub
    End Structure


    Public Class FunctionsPointGenerator
        Public Shared Function GeneratePoints(ByVal f As CircularFunction) As List(Of RangeDataPoint)
            Select Case f
                Case CircularFunction.TaubinsHeart
                    Return GeneratePointsOfTaubinsHeart()
                Case CircularFunction.Cardioid
                    Return GeneratePointsOfCardioid()
                Case CircularFunction.Lemniskate
                    Return GeneratePointsOfLemniskate()
                Case Else
                    Return Nothing
            End Select
        End Function
        Public Shared Function GenerateDegreeScatterPoints(ByVal [function] As ScatterCircularFunction) As List(Of Point)
            Return GenerateScatterPoints([function], New DegreeScatterFunctionCalculator())
        End Function
        Public Shared Function GenerateRadianScatterPoints(ByVal [function] As ScatterCircularFunction) As List(Of Point)
            Return GenerateScatterPoints([function], New RadianScatterFunctionCalculator())
        End Function

        Private Shared Function GenerateScatterPoints(ByVal [function] As ScatterCircularFunction, ByVal calculator As ScatterFunctionCalculatorBase) As List(Of Point)
            Return calculator.GenerateScatterFunctionPoints([function])
        End Function
        Private Shared Function GeneratePointsOfLemniskate() As List(Of RangeDataPoint)
            Dim list As New List(Of RangeDataPoint)()
            For x As Double = 0 To 359 Step 5
                Dim xRadian As Double = DegreeToRadian(x)
                Dim cos As Double = Math.Cos(2 * xRadian)
                Dim y As Double = Math.Pow(Math.Abs(cos), 2)
                list.Add(New RangeDataPoint(x, y, 1))
            Next x
            Return list
        End Function

        Private Shared Function GeneratePointsOfCardioid() As List(Of RangeDataPoint)
            Dim list As New List(Of RangeDataPoint)()
            Const a As Double = 0.5
            For x As Double = 0 To 359 Step 15
                Dim y As Double = 2 * a * Math.Cos(DegreeToRadian(x))
                list.Add(New RangeDataPoint(x, y, 1))
            Next x
            Return list
        End Function

        Private Shared Function GeneratePointsOfTaubinsHeart() As List(Of RangeDataPoint)
            Dim list As New List(Of RangeDataPoint)()
            For x As Double = 0 To 359 Step 15
                Dim xRadian As Double = DegreeToRadian(x)
                Dim y As Double = 2 - 0.5 * Math.Sin(xRadian) + Math.Sin(xRadian) * Math.Sqrt(Math.Abs(Math.Cos(xRadian))) / (Math.Sin(xRadian) + 1.4)
                list.Add(New RangeDataPoint(x, y, 1))
            Next x
            Return list
        End Function

        Private Shared Function DegreeToRadian(ByVal degree As Double) As Double
            Return 2 * Math.PI / 360 * degree
        End Function
    End Class


    Public MustInherit Class ScatterFunctionCalculatorBase
        Private Const spiralIntervalsCount As Integer = 72
        Private Const roseIntervalsCount As Integer = 288
        Private Const foliumSegmentIntervalsCount As Integer = 30

        Private Const roseParameter As Double = 7.0 \ 4.0
        Private Const foliumDistanceLimit As Double = 3.0

        Protected MustOverride Function NormalizeAngle(ByVal angle As Double) As Double
        Protected MustOverride Function ToRadian(ByVal angle As Double) As Double
        Protected MustOverride Function FromDegrees(ByVal angle As Double) As Double

        Private Function FilterPointsByRange(ByVal points As List(Of Point), ByVal min As Double, ByVal max As Double) As List(Of Point)
            Dim resultPoints As New List(Of Point)()
            For Each point As Point In points
                Dim pointValue As Double = point.Y
                If pointValue <= max AndAlso pointValue >= min Then
                    resultPoints.Add(point)
                End If
            Next point
            Return resultPoints
        End Function
        Private Sub CreatePolarFunctionPoints(ByVal minAngleDegree As Double, ByVal maxAngleDegree As Double, ByVal intervalsCount As Integer, ByVal [function] As Func(Of Double, Double), ByVal points As List(Of Point))
            Dim minAngle As Double = FromDegrees(minAngleDegree)
            Dim maxAngle As Double = FromDegrees(maxAngleDegree)
            Dim angleStep As Double = (maxAngle - minAngle) / CDbl(intervalsCount)
            For pointIndex As Integer = 0 To intervalsCount
                Dim angle As Double = minAngle + pointIndex * angleStep
                Dim angleRadians As Double = ToRadian(angle)
                Dim distance As Double = [function](angleRadians)
                Dim normalAngle As Double = NormalizeAngle(angle)
                points.Add(New Point(normalAngle, distance))
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
            Return (3.0 * sin * cos) / (Math.Pow(sin, 3.0) + Math.Pow(cos, 3.0))
        End Function

        Public Function GenerateScatterFunctionPoints(ByVal [function] As ScatterCircularFunction) As List(Of Point)
            Dim points As New List(Of Point)()
            Select Case [function]
                Case ScatterCircularFunction.ArchimedeanSpiral
                    CreatePolarFunctionPoints(0.0, 720.0, spiralIntervalsCount, AddressOf ArchimedeanSpiralFunction, points)
                Case ScatterCircularFunction.Rose
                    CreatePolarFunctionPoints(0.0, 1440.0, roseIntervalsCount, AddressOf PolarRoseFunction, points)
                Case ScatterCircularFunction.Folium
                    CreatePolarFunctionPoints(120.0, 180.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
                    CreatePolarFunctionPoints(0.0, 90.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
                    CreatePolarFunctionPoints(270.0, 330.0, foliumSegmentIntervalsCount, AddressOf PolarFoliumFunction, points)
                    points = FilterPointsByRange(points, 0.0, foliumDistanceLimit)
            End Select
            Return points
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


    Public Class DegreeScatterFunctionCalculator
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


    Public Class Bar2DKindToTickmarksLengthConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim bar2DKind As Bar2DKind = TryCast(value, Bar2DKind)
            If bar2DKind IsNot Nothing Then
                Select Case bar2DKind.Name
                    Case "Glass Cylinder"
                        Return 18
                    Case "Quasi-3D Bar"
                        Return 9
                End Select
            End If
            Return 5
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class Bar2DKindToBar2DModelConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim bar2DKind As Bar2DKind = TryCast(value, Bar2DKind)
            If bar2DKind IsNot Nothing Then
                Return Activator.CreateInstance(bar2DKind.Type)
            End If
            Return value
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class RangeBar2DKindToRangeBar2DModelConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim bar2DKind As RangeBar2DKind = TryCast(value, RangeBar2DKind)
            If bar2DKind IsNot Nothing Then
                Return Activator.CreateInstance(bar2DKind.Type)
            End If
            Return value
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class Marker2DKindToMarker2DModelConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim marker2DKind As Marker2DKind = TryCast(value, Marker2DKind)
            If marker2DKind IsNot Nothing Then
                Return Activator.CreateInstance(marker2DKind.Type)
            End If
            Return value
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class CandleStick2DKindToCandleStick2DModelConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim candleStick2DKind As CandleStick2DKind = TryCast(value, CandleStick2DKind)
            If candleStick2DKind IsNot Nothing Then
                Return Activator.CreateInstance(candleStick2DKind.Type)
            End If
            Return value
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class Stock2DKindToStock2DModelConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim stock2DKind As Stock2DKind = TryCast(value, Stock2DKind)
            If stock2DKind IsNot Nothing Then
                Return Activator.CreateInstance(stock2DKind.Type)
            End If
            Return value
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class Pie2DKindToPie2DModelConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim pie2DKind As Pie2DKind = TryCast(value, Pie2DKind)
            If pie2DKind IsNot Nothing Then
                Return Activator.CreateInstance(pie2DKind.Type)
            End If
            Return value
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class MarkerSizeToLabelIndentConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Return (DirectCast(value, Double)) / 2
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class IsCheckedToVisibilityConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If DirectCast(value, Boolean) Then
                Return Visibility.Visible
            End If
            Return Visibility.Collapsed
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
        #End Region
    End Class


    Public Class BoolToResolveOverlappingModeConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim booleanValue As Boolean = DirectCast(value, Boolean)
            If booleanValue = True Then
                Return ResolveOverlappingMode.Default
            Else
                Return ResolveOverlappingMode.None
            End If
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
    End Class


    Public Class StringToRotationDirectionConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim str As String = TryCast(value, String)
            If str Is Nothing OrElse targetType IsNot GetType(CircularDiagramRotationDirection) Then
                Return Nothing
            End If
            If str = "Clockwise" Then
                Return CircularDiagramRotationDirection.Clockwise
            Else
                Return CircularDiagramRotationDirection.Counterclockwise
            End If
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
    End Class


    Public Class StringToCircularDiagramShapeStyleConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim str As String = TryCast(value, String)
            If str Is Nothing OrElse targetType IsNot GetType(CircularDiagramShapeStyle) Then
                Return Nothing
            End If
            If str = "Circle" Then
                Return CircularDiagramShapeStyle.Circle
            Else
                Return CircularDiagramShapeStyle.Polygon
            End If
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
    End Class


    Public Class StringToCrosshairSnapModeConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim str As String = TryCast(value, String)
            If str Is Nothing OrElse targetType IsNot GetType(CrosshairSnapMode) Then
                Return Nothing
            End If
            If str = "Nearest Argument" Then
                Return CrosshairSnapMode.NearestArgument
            Else
                Return CrosshairSnapMode.NearestValue
            End If
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
    End Class


    Public NotInheritable Class PaletteSelectorHelper

        Private Sub New()
        End Sub

        Private Shared actualPalette_Renamed As Palette = New OfficePalette()

        Public Shared Property ActualPalette() As Palette
            Get
                Return actualPalette_Renamed
            End Get
            Set(ByVal value As Palette)
                actualPalette_Renamed = value
            End Set
        End Property
    End Class


    Public NotInheritable Class CsvReader

        Private Sub New()
        End Sub
        Private Const FileNamePrefix As String = "/ChartsDemo;component/Data/"

        Public Shared Function ReadFinancialData(ByVal fileName As String) As List(Of FinancialPoint)
            Dim longFileName As String = String.Empty
            Dim reader As StreamReader
            Dim dataSource = New List(Of FinancialPoint)()
            Try
                longFileName = FileNamePrefix & fileName
                Dim uri As New Uri(longFileName, UriKind.RelativeOrAbsolute)
                Dim info As StreamResourceInfo = Application.GetResourceStream(uri)
                reader = New StreamReader(info.Stream)
                Do While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values = line.Split(","c)
                    Dim point = New FinancialPoint()
                    point.DateTimeArgument = Date.ParseExact(values(0), "yyyy.MM.dd", CultureInfo.InvariantCulture)
                    point.OpenValue = Double.Parse(values(1), CultureInfo.InvariantCulture)
                    point.HighValue = Double.Parse(values(2), CultureInfo.InvariantCulture)
                    point.LowValue = Double.Parse(values(3), CultureInfo.InvariantCulture)
                    point.CloseValue = Double.Parse(values(4), CultureInfo.InvariantCulture)
                    dataSource.Add(point)
                Loop
            Catch
                Throw New Exception("It's impossible to load " & fileName)
            End Try
            Return dataSource
        End Function
    End Class


    <StructLayout(LayoutKind.Sequential, Pack := 1)>
    Public Structure PixelColor
        Public Blue As Byte
        Public Green As Byte
        Public Red As Byte
        Public Alpha As Byte
        Public ReadOnly Property Gray() As Byte
            Get
                Return CByte((CInt(Blue) + CInt(Green) + CInt(Red)) \ 3)
            End Get
        End Property
    End Structure


    Public Class ImageData
        Private ReadOnly streamResourceInfo As StreamResourceInfo

        Public Sub New(ByVal uri As Uri)
            Me.streamResourceInfo = Application.GetResourceStream(uri)
        End Sub
        Private Function GetPixels(ByVal source As BitmapSource) As PixelColor(,)
            If source.Format <> PixelFormats.Bgra32 Then
                source = New FormatConvertedBitmap(source, PixelFormats.Bgra32, Nothing, 0)
            End If
            Dim result(source.PixelWidth - 1, source.PixelHeight - 1) As PixelColor
            Dim stride As Integer = CInt(source.PixelWidth) * (source.Format.BitsPerPixel \ 8)
            CopyPixels(source, result, stride, 0)
            Return result
        End Function
        Private Sub CopyPixels(ByVal source As BitmapSource, ByVal pixels(,) As PixelColor, ByVal stride As Integer, ByVal offset As Integer)
            Dim height = source.PixelHeight
            Dim width = source.PixelWidth
            Dim pixelBytes = New Byte((height * width * 4) - 1){}
            source.CopyPixels(pixelBytes, stride, 0)
            Dim y0 As Integer = offset \ width
            Dim x0 As Integer = offset - width * y0
            For y As Integer = 0 To height - 1
                For x As Integer = 0 To width - 1
                    pixels(x + x0, y + y0) = New PixelColor With {.Blue = pixelBytes((y * width + x) * 4 + 0), .Green = pixelBytes((y * width + x) * 4 + 1), .Red = pixelBytes((y * width + x) * 4 + 2), .Alpha = pixelBytes((y * width + x) * 4 + 3)}
                Next x
            Next y
        End Sub
        Private Sub DoEvents()
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, New Action(Sub()
            End Sub))
        End Sub
        Public Function GetPixels() As PixelColor(,)
            Dim pixels(-1,-1) As PixelColor
            Try
                Dim source As New BitmapImage()
                source.BeginInit()
                source.StreamSource = Me.streamResourceInfo.Stream
                source.EndInit()
                Do While source.IsDownloading
                    DoEvents()
                Loop
                pixels = GetPixels(source)
            Catch
            End Try
            Return pixels
        End Function
    End Class


End Namespace
