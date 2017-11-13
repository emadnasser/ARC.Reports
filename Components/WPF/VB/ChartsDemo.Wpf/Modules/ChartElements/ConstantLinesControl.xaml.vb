Imports DevExpress.Xpf.Charts
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Media
Imports System.Xml.Linq
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/ChartElements/ConstantLinesControl(.SL).xaml"), CodeFile("Modules/ChartElements/ConstantLinesControl.xaml.(cs)")>
    Partial Public Class ConstantLinesControl
        Inherits ChartsDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Private ReadOnly Property ConstantLines() As ConstantLineCollection
            Get
                Return CType(chart.Diagram, XYDiagram2D).AxisY.ConstantLinesBehind
            End Get
        End Property
        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property
        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim diagram As XYDiagram2D = CType(chart.Diagram, XYDiagram2D)
            If diagram.Series(0).Points.Count = 0 Then
                Return
            End If
            Dim minPrice As Double = Double.MaxValue
            Dim maxPrice As Double = 0
            Dim averagePrice As Double = 0
            For Each point As SeriesPoint In diagram.Series(0).Points
                Dim price As Double = point.Value
                If price < minPrice Then
                    minPrice = price
                End If
                If price > maxPrice Then
                    maxPrice = price
                End If
                averagePrice += price
            Next point
            averagePrice /= diagram.Series(0).Points.Count
            Dim minConstantLine As New ConstantLine(minPrice, "Min")
            minConstantLine.Brush = New SolidColorBrush(Colors.Green)
            minConstantLine.Title.Foreground = New SolidColorBrush(Colors.Green)
            Dim maxConstantLine As New ConstantLine(maxPrice, "Max")
            maxConstantLine.Brush = New SolidColorBrush(Colors.Red)
            maxConstantLine.Title.Foreground = New SolidColorBrush(Colors.Red)
            Dim averageConstantLine As New ConstantLine(averagePrice, "Average")
            averageConstantLine.Brush = New SolidColorBrush(Color.FromArgb(&HFF, &H9A, &HCD, &H32))
            averageConstantLine.Title.Foreground = New SolidColorBrush(Color.FromArgb(&HFF, &H9A, &HCD, &H32))
            ConstantLines.AddRange(New ConstantLine() { minConstantLine, maxConstantLine, averageConstantLine })
            For Each constantLine As ConstantLine In ConstantLines
                constantLine.Title.Alignment = ConstantLineTitleAlignment.Far
            Next constantLine
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub chbVisible_CheckedUnchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                Dim isVisible As Boolean = chbVisible.IsChecked.HasValue AndAlso chbVisible.IsChecked.Value
                For Each constantLine As ConstantLine In ConstantLines
                    constantLine.Visible = isVisible
                Next constantLine
                lbTitleAlignment.IsEnabled = isVisible
                lbTitlePosition.IsEnabled = isVisible
            End If
        End Sub
        Private Sub lbTitleAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                Dim titleAlignment As ConstantLineTitleAlignment
                If lbTitleAlignment.SelectedIndex = 1 Then
                    titleAlignment = ConstantLineTitleAlignment.Far
                Else
                    titleAlignment = ConstantLineTitleAlignment.Near
                End If
                For Each constantLine As ConstantLine In ConstantLines
                    constantLine.Title.Alignment = titleAlignment
                Next constantLine
            End If
        End Sub
        Private Sub lbTitlePosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                Dim showBelowLine As Boolean = lbTitlePosition.SelectedIndex = 1
                For Each constantLine As ConstantLine In ConstantLines
                    constantLine.Title.ShowBelowLine = showBelowLine
                Next constantLine
            End If
        End Sub
    End Class

    Public Class OilPrice

        Private price_Renamed As Double

        Private year_Renamed As Double
        Public Sub New(ByVal year As Double, ByVal price As Double)
            Me.year_Renamed = year
            Me.price_Renamed = price
        End Sub
        Public ReadOnly Property Price() As Double
            Get
                Return price_Renamed
            End Get
        End Property
        Public ReadOnly Property Year() As Double
            Get
                Return year_Renamed
            End Get
        End Property
    End Class
End Namespace
