Imports DevExpress.Xpf.Charts
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/Interactivity/ScrollingZoomingControl(.SL).xaml"), CodeFile("Modules/Interactivity/ScrollingZoomingControl.xaml.(cs)")>
    Partial Public Class ScrollingZoomingControl
        Inherits ChartsDemoModule

        Private Const initialZoomFactor As Double = 0.1
        Private Const pointCount As Integer = 1500

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ChartsDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DataContext = New PricesModel(pointCount)
            AxisX.ActualVisualRange.MinValue = Date.Now.Subtract(New TimeSpan(CInt((pointCount * initialZoomFactor)), 0, 0, 0))
        End Sub
        Private Sub UpdateAxisXScrollBarPositionEnabled(ByVal sender As Object, ByVal e As RoutedEventArgs)
            cbeAxisXScrollBarPosition.IsEnabled = chbAxisXScrollBarVisible.IsChecked.Value AndAlso chbAxisXNavigation.IsChecked.Value
            If Not chbAxisXNavigation.IsChecked.Value Then
                CType(chart.Diagram, XYDiagram2D).ActualAxisX.ActualVisualRange.SetAuto()
            End If
        End Sub
        Private Sub UpdateAxisYScrollBarPositionEnabled(ByVal sender As Object, ByVal e As RoutedEventArgs)
            cbeAxisYScrollBarPosition.IsEnabled = chbAxisYScrollBarVisible.IsChecked.Value AndAlso chbAxisYNavigation.IsChecked.Value
            If Not chbAxisYNavigation.IsChecked.Value Then
                CType(chart.Diagram, XYDiagram2D).ActualAxisY.ActualVisualRange.SetAuto()
            End If
        End Sub
    End Class

    Public Class PriceByDate

        Private price_Renamed As Double

        Private tradeDate_Renamed As Date

        Public ReadOnly Property Price() As Double
            Get
                Return price_Renamed
            End Get
        End Property
        Public ReadOnly Property TradeDate() As Date
            Get
                Return tradeDate_Renamed
            End Get
        End Property

        Public Sub New(ByVal [date] As Date, ByVal price As Double)
            Me.tradeDate_Renamed = [date]
            Me.price_Renamed = price
        End Sub
    End Class

    Public Class PricesModel

        Private ReadOnly product1_Renamed As New List(Of PriceByDate)()

        Private ReadOnly product2_Renamed As New List(Of PriceByDate)()

        Private ReadOnly product3_Renamed As New List(Of PriceByDate)()

        Public ReadOnly Property Product1() As List(Of PriceByDate)
            Get
                Return product1_Renamed
            End Get
        End Property
        Public ReadOnly Property Product1Title() As String
            Get
                Return "Product 1"
            End Get
        End Property
        Public ReadOnly Property Product2() As List(Of PriceByDate)
            Get
                Return product2_Renamed
            End Get
        End Property
        Public ReadOnly Property Product2Title() As String
            Get
                Return "Product 2"
            End Get
        End Property
        Public ReadOnly Property Product3() As List(Of PriceByDate)
            Get
                Return product3_Renamed
            End Get
        End Property
        Public ReadOnly Property Product3Title() As String
            Get
                Return "Product 3"
            End Get
        End Property
        Public ReadOnly Property Title() As String
            Get
                Return "Sales History"
            End Get
        End Property

        Public Sub New(ByVal pointsCount As Integer)
            Dim random As New Random()
            Dim [date] As Date = Date.Now.Subtract(New TimeSpan(pointsCount, 0, 0, 0))
            Dim price1 As Double = GenerateStartValue(random)
            Dim price2 As Double = GenerateStartValue(random)
            Dim price3 As Double = GenerateStartValue(random)
            For i As Integer = 0 To pointsCount - 1
                product1_Renamed.Add(New PriceByDate([date], price1))
                product2_Renamed.Add(New PriceByDate([date], price2))
                product3_Renamed.Add(New PriceByDate([date], price3))
                price1 += GenerateAddition(random)
                price2 += GenerateAddition(random)
                price3 += GenerateAddition(random)
                [date] = [date].AddDays(1)
            Next i
        End Sub

        Private Function GenerateAddition(ByVal random As Random) As Double
            Dim factor As Double = random.NextDouble()
            If factor = 1 Then
                factor = 5
            ElseIf factor = 0 Then
                factor = -5
            End If
            Return (factor - 0.475) * 10
        End Function
        Private Function GenerateStartValue(ByVal random As Random) As Double
            Return random.NextDouble() * 100
        End Function
    End Class
End Namespace
