Imports System.Windows
Imports System.Collections.Generic
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports System.Windows.Media

Namespace ChartsDemo
    <CodeFile("Modules/DataAnalysis/ErrorBarsControl(.SL).xaml"), CodeFile("Modules/DataAnalysis/ErrorBarsControl.xaml.(cs)")>
    Partial Public Class ErrorBarsControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Private series As XYSeries2D = Nothing
        Private indicator As ErrorBars = Nothing

        Public Sub New()
            InitializeComponent()
            UpdateSeries()
        End Sub

        Private Function GetListBoxEditItemTag(Of T)(ByVal obj As Object) As T
            Return CType(DirectCast(obj, ListBoxEditItem).Tag, T)
        End Function
        Private Sub lbeIndicator_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateIndicator()
        End Sub
        Private Sub lbeSeries_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateSeries()
        End Sub
        Private Sub lbeDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateDirection()
        End Sub
        Private Sub lbeEndStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateEndStyle()
        End Sub
        Private Sub UpdateEndStyle()
            If indicator IsNot Nothing Then
                indicator.EndStyle = GetListBoxEditItemTag(Of ErrorBarEndStyle)(lbeEndStyle.SelectedItem)
            End If
        End Sub
        Private Sub UpdateDirection()
            If indicator IsNot Nothing Then
                indicator.Direction = GetListBoxEditItemTag(Of ErrorBarDirection)(lbeDirection.SelectedItem)
            End If
        End Sub
        Private Sub UpdateIndicator()
            If series IsNot Nothing Then
                series.Indicators.Clear()
                Select Case CStr(lbeIndicator.SelectedItem)
                    Case "Fixed Values"
                        indicator = New FixedValueErrorBars() With {.NegativeError = 1, .PositiveError = 3}
                    Case "Percentage"
                        indicator = New PercentageErrorBars() With {.Percent = 10}
                    Case "Standard Deviation(s)"
                        indicator = New StandardDeviationErrorBars() With {.Multiplier = 1}
                    Case "Standard Error"
                        indicator = New StandardErrorBars()
                    Case "Data Source"
                        indicator = New DataSourceBasedErrorBars() With {.NegativeErrorDataMember = "Negative", .PositiveErrorDataMember = "Positive"}
                End Select
                If indicator IsNot Nothing Then
                    indicator.Brush = New SolidColorBrush(Colors.Black)
                    series.Indicators.Add(indicator)
                End If
                UpdateDirection()
                UpdateEndStyle()
            End If
        End Sub
        Private Sub UpdateSeries()
            diagram.Series.Clear()
            Select Case CStr(lbeSeries.SelectedItem)
                Case "Bar"
                    series = New BarSideBySideSeries2D()
                Case "Point"
                    series = New PointSeries2D()
            End Select
            If series IsNot Nothing Then
                series.ArgumentDataMember = "Argument"
                series.ValueDataMember = "Value"
                series.DataSource = GetData()
                diagram.Series.Add(series)
            End If
            UpdateIndicator()
        End Sub
        Private Function GetData() As List(Of DataItem)
            Return New List(Of DataItem)() From {
                New DataItem("A", 20, 5, 8),
                New DataItem("B", 50, 3, 5),
                New DataItem("C", 40, 20, 10),
                New DataItem("D", 22, 15, 5),
                New DataItem("E", 30, 5, 8),
                New DataItem("F", 45, 5, 4),
                New DataItem("G", 35, 5, 3),
                New DataItem("H", 28, 4, 2),
                New DataItem("I", 46, 6, 4),
                New DataItem("J", 27, 8, 20),
                New DataItem("K", 20, 5, 8),
                New DataItem("L", 50, 3, 5),
                New DataItem("M", 40, 20, 10),
                New DataItem("N", 22, 15, 5),
                New DataItem("O", 30, 5, 8),
                New DataItem("P", 45, 5, 2),
                New DataItem("Q", 35, 5, 5),
                New DataItem("R", 28, 4, 4),
                New DataItem("S", 46, 6, 5),
                New DataItem("T", 27, 8, 8)
            }
        End Function
    End Class

    Public Class DataItem
        Private privateArgument As String
        Public Property Argument() As String
            Get
                Return privateArgument
            End Get
            Private Set(ByVal value As String)
                privateArgument = value
            End Set
        End Property
        Private privateValue As Integer
        Public Property Value() As Integer
            Get
                Return privateValue
            End Get
            Private Set(ByVal value As Integer)
                privateValue = value
            End Set
        End Property
        Private privateNegative As Integer
        Public Property Negative() As Integer
            Get
                Return privateNegative
            End Get
            Private Set(ByVal value As Integer)
                privateNegative = value
            End Set
        End Property
        Private privatePositive As Integer
        Public Property Positive() As Integer
            Get
                Return privatePositive
            End Get
            Private Set(ByVal value As Integer)
                privatePositive = value
            End Set
        End Property

        Public Sub New(ByVal argument As String, ByVal value As Integer, ByVal negative As Integer, ByVal positive As Integer)
            Me.Argument = argument
            Me.Value = value
            Me.Negative = negative
            Me.Positive = positive
        End Sub
    End Class
End Namespace
