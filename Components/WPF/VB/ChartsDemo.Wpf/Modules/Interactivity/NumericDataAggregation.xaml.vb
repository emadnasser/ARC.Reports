Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Charts

Namespace ChartsDemo
    <CodeFile("Modules/Interactivity/NumericDataAggregation(.SL).xaml"), CodeFile("Modules/Interactivity/NumericDataAggregation.xaml.(cs)")>
    Partial Public Class NumericDataAggregation
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub ChartsDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DataContext = New AggregationDataContext()
        End Sub
    End Class

    Public Class AggregationDataContext
        Private Const pointCount As Integer = 100000

        Private ReadOnly _series As New List(Of NumericPoint)()

        Public ReadOnly Property Series() As List(Of NumericPoint)
            Get
                Return _series
            End Get
        End Property

        Public ReadOnly Property Title() As String
            Get
                Return "Data Aggregation (" & pointCount.ToString() & " points)"
            End Get
        End Property
        Public ReadOnly Property SeriesTitle() As String
            Get
                Return "Random data"
            End Get
        End Property

        Public Sub New()
            FillPoints(_series)
        End Sub

        Private Sub FillPoints(ByVal series As List(Of NumericPoint))
            If series IsNot Nothing Then
                Dim value As Double = 0
                Dim argument As Double = 0
                Dim random As New Random()

                For i As Double = 0 To pointCount - 1
                    series.Add(New NumericPoint(argument, value))
                    value += (random.NextDouble() * 10.0 - 5.0)
                    argument += random.NextDouble()
                Next i
            End If
        End Sub

    End Class

    Public Class NumericPoint
        Private privateArgument As Double
        Public Property Argument() As Double
            Get
                Return privateArgument
            End Get
            Private Set(ByVal value As Double)
                privateArgument = value
            End Set
        End Property
        Private privateValue As Double
        Public Property Value() As Double
            Get
                Return privateValue
            End Get
            Private Set(ByVal value As Double)
                privateValue = value
            End Set
        End Property

        Public Sub New(ByVal argument As Double, ByVal value As Double)
            Me.Argument = argument
            Me.Value = value
        End Sub
    End Class
End Namespace
