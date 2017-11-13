Imports System
Imports System.Windows
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Data
Imports System.Globalization
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase


Namespace ChartsDemo
    <CodeFile("Modules/ChartElements/AnnotationsControl(.SL).xaml"), CodeFile("Modules/ChartElements/AnnotationsControl.xaml.(cs)")>
    Partial Public Class AnnotationsControl
        Inherits ChartsDemoModule

        Private annotationLayoutViewModel As AnnotationsViewModel

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            annotationLayoutViewModel = New AnnotationsViewModel()
            DataContext = annotationLayoutViewModel
        End Sub

        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart.Diagram.Series IsNot Nothing AndAlso chart.Diagram.Series.Count > 0 Then
                Dim minMaxPoints As Tuple(Of SeriesPoint, SeriesPoint) = FindExtremalPoints(chart.Diagram.Series(0))
                annotationLayoutViewModel.AnnotationMinimumSeriesPoint = minMaxPoints.Item1
                annotationLayoutViewModel.AnnotationMaximumSeriesPoint = minMaxPoints.Item2
            End If
        End Sub
        Private Function FindExtremalPoints(ByVal series As Series) As Tuple(Of SeriesPoint, SeriesPoint)
            Dim minimumPoint As SeriesPoint = series.Points(0)
            Dim maximumPoint As SeriesPoint = series.Points(0)
            For Each point As SeriesPoint In series.Points
                If point.Value < minimumPoint.Value Then
                    minimumPoint = point
                End If
                If point.Value > maximumPoint.Value Then
                    maximumPoint = point
                End If
            Next point
            Return New Tuple(Of SeriesPoint, SeriesPoint)(minimumPoint, maximumPoint)
        End Function
    End Class

    Public Class AnnotationsViewModel
        Implements INotifyPropertyChanged


        Private marsTemperatureData_Renamed As List(Of MarsTemperature)

        Private annotationMinimumSeriesPoint_Renamed As SeriesPoint

        Private annotationMaximumSeriesPoint_Renamed As SeriesPoint

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Property MarsTemperatureData() As List(Of MarsTemperature)
            Get
                Return marsTemperatureData_Renamed
            End Get
            Set(ByVal value As List(Of MarsTemperature))
                If marsTemperatureData_Renamed IsNot value Then
                    marsTemperatureData_Renamed = value
                    OnPropertyChanged("MarsTemperatureData")
                End If
            End Set
        End Property
        Public Property AnnotationMinimumSeriesPoint() As SeriesPoint
            Get
                Return annotationMinimumSeriesPoint_Renamed
            End Get
            Set(ByVal value As SeriesPoint)
                If annotationMinimumSeriesPoint_Renamed IsNot value Then
                    annotationMinimumSeriesPoint_Renamed = value
                    OnPropertyChanged("AnnotationMinimumSeriesPoint")
                End If
            End Set
        End Property
        Public Property AnnotationMaximumSeriesPoint() As SeriesPoint
            Get
                Return annotationMaximumSeriesPoint_Renamed
            End Get
            Set(ByVal value As SeriesPoint)
                If annotationMaximumSeriesPoint_Renamed IsNot value Then
                    annotationMaximumSeriesPoint_Renamed = value
                    OnPropertyChanged("AnnotationMaximumSeriesPoint")
                End If
            End Set
        End Property

        Public Sub New()
            MarsTemperatureData = MarsTemperature.GetData()
        End Sub

        Private Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    Public Class MarsTemperature
        Public Shared Function GetData() As List(Of MarsTemperature)
            Return New List(Of MarsTemperature)() From {
                New MarsTemperature() With {.Sol = 2.466424, .Temperature = -28.2},
                New MarsTemperature() With {.Sol = 2.486035, .Temperature = -25.4},
                New MarsTemperature() With {.Sol = 2.505635, .Temperature = -23.4},
                New MarsTemperature() With {.Sol = 2.525235, .Temperature = -22.4},
                New MarsTemperature() With {.Sol = 2.544851, .Temperature = -21},
                New MarsTemperature() With {.Sol = 2.564458, .Temperature = -19.7},
                New MarsTemperature() With {.Sol = 2.584058, .Temperature = -15.9},
                New MarsTemperature() With {.Sol = 2.603669, .Temperature = -15.3},
                New MarsTemperature() With {.Sol = 2.623269, .Temperature = -15.3},
                New MarsTemperature() With {.Sol = 2.64288, .Temperature = -18.9},
                New MarsTemperature() With {.Sol = 2.66249, .Temperature = -21.1},
                New MarsTemperature() With {.Sol = 2.682092, .Temperature = -23.2},
                New MarsTemperature() With {.Sol = 2.701703, .Temperature = -26.9},
                New MarsTemperature() With {.Sol = 2.721314, .Temperature = -30.8},
                New MarsTemperature() With {.Sol = 2.760537, .Temperature = -43.8},
                New MarsTemperature() With {.Sol = 2.780148, .Temperature = -45.7},
                New MarsTemperature() With {.Sol = 2.79976, .Temperature = -49.1},
                New MarsTemperature() With {.Sol = 2.819371, .Temperature = -51.5},
                New MarsTemperature() With {.Sol = 2.838982, .Temperature = -55.5},
                New MarsTemperature() With {.Sol = 2.858594, .Temperature = -57.5},
                New MarsTemperature() With {.Sol = 2.878205, .Temperature = -61},
                New MarsTemperature() With {.Sol = 2.897816, .Temperature = -61.1},
                New MarsTemperature() With {.Sol = 2.917428, .Temperature = -64.5},
                New MarsTemperature() With {.Sol = 2.937039, .Temperature = -64.9},
                New MarsTemperature() With {.Sol = 2.976262, .Temperature = -67.8},
                New MarsTemperature() With {.Sol = 3.035084, .Temperature = -69.3},
                New MarsTemperature() With {.Sol = 3.074307, .Temperature = -70.4},
                New MarsTemperature() With {.Sol = 3.093918, .Temperature = -71.3},
                New MarsTemperature() With {.Sol = 3.11353, .Temperature = -71.9},
                New MarsTemperature() With {.Sol = 3.191964, .Temperature = -75},
                New MarsTemperature() With {.Sol = 3.211575, .Temperature = -76},
                New MarsTemperature() With {.Sol = 3.231186, .Temperature = -74.7},
                New MarsTemperature() With {.Sol = 3.250786, .Temperature = -71.6},
                New MarsTemperature() With {.Sol = 3.270398, .Temperature = -67.2},
                New MarsTemperature() With {.Sol = 3.289998, .Temperature = -63.7},
                New MarsTemperature() With {.Sol = 3.309609, .Temperature = -59.5},
                New MarsTemperature() With {.Sol = 3.329209, .Temperature = -53},
                New MarsTemperature() With {.Sol = 3.34882, .Temperature = -47.7},
                New MarsTemperature() With {.Sol = 3.368421, .Temperature = -44.3},
                New MarsTemperature() With {.Sol = 3.388032, .Temperature = -42},
                New MarsTemperature() With {.Sol = 3.407632, .Temperature = -36},
                New MarsTemperature() With {.Sol = 3.427243, .Temperature = -32.6},
                New MarsTemperature() With {.Sol = 3.446843, .Temperature = -29.8},
                New MarsTemperature() With {.Sol = 3.466274, .Temperature = -27},
                New MarsTemperature() With {.Sol = 3.505486, .Temperature = -22.3},
                New MarsTemperature() With {.Sol = 3.544708, .Temperature = -19.5},
                New MarsTemperature() With {.Sol = 3.56432, .Temperature = -17.1},
                New MarsTemperature() With {.Sol = 3.603531, .Temperature = -15.1},
                New MarsTemperature() With {.Sol = 3.623142, .Temperature = -14.8},
                New MarsTemperature() With {.Sol = 3.642742, .Temperature = -19.2},
                New MarsTemperature() With {.Sol = 3.662343, .Temperature = -19.5},
                New MarsTemperature() With {.Sol = 3.681954, .Temperature = -22.4},
                New MarsTemperature() With {.Sol = 3.701565, .Temperature = -26.1},
                New MarsTemperature() With {.Sol = 3.721177, .Temperature = -32.1},
                New MarsTemperature() With {.Sol = 3.740788, .Temperature = -39.2},
                New MarsTemperature() With {.Sol = 3.760399, .Temperature = -45.2},
                New MarsTemperature() With {.Sol = 3.78001, .Temperature = -46.6},
                New MarsTemperature() With {.Sol = 3.799622, .Temperature = -49.9},
                New MarsTemperature() With {.Sol = 3.819233, .Temperature = -55.2},
                New MarsTemperature() With {.Sol = 3.838844, .Temperature = -58.4},
                New MarsTemperature() With {.Sol = 3.858456, .Temperature = -60.1},
                New MarsTemperature() With {.Sol = 3.878068, .Temperature = -60.2},
                New MarsTemperature() With {.Sol = 3.897678, .Temperature = -60.8},
                New MarsTemperature() With {.Sol = 3.91729, .Temperature = -63.9},
                New MarsTemperature() With {.Sol = 3.936901, .Temperature = -65.1},
                New MarsTemperature() With {.Sol = 3.956512, .Temperature = -66.3},
                New MarsTemperature() With {.Sol = 3.976124, .Temperature = -68.7},
                New MarsTemperature() With {.Sol = 3.995735, .Temperature = -65.5},
                New MarsTemperature() With {.Sol = 4.015346, .Temperature = -66},
                New MarsTemperature() With {.Sol = 4.034958, .Temperature = -67.5},
                New MarsTemperature() With {.Sol = 4.054569, .Temperature = -67.4},
                New MarsTemperature() With {.Sol = 4.07418, .Temperature = -69.1},
                New MarsTemperature() With {.Sol = 4.093792, .Temperature = -71.2},
                New MarsTemperature() With {.Sol = 4.113403, .Temperature = -71.1},
                New MarsTemperature() With {.Sol = 4.133014, .Temperature = -72.6},
                New MarsTemperature() With {.Sol = 4.152626, .Temperature = -72.5},
                New MarsTemperature() With {.Sol = 4.172237, .Temperature = -73.9},
                New MarsTemperature() With {.Sol = 4.21146, .Temperature = -73.5},
                New MarsTemperature() With {.Sol = 4.231071, .Temperature = -74.8},
                New MarsTemperature() With {.Sol = 4.250684, .Temperature = -71.7},
                New MarsTemperature() With {.Sol = 4.270294, .Temperature = -64.6},
                New MarsTemperature() With {.Sol = 4.289895, .Temperature = -61.8},
                New MarsTemperature() With {.Sol = 4.309505, .Temperature = -52.9},
                New MarsTemperature() With {.Sol = 4.370569, .Temperature = -43.7},
                New MarsTemperature() With {.Sol = 4.387928, .Temperature = -39.3},
                New MarsTemperature() With {.Sol = 4.427139, .Temperature = -33.3},
                New MarsTemperature() With {.Sol = 4.446739, .Temperature = -32.6},
                New MarsTemperature() With {.Sol = 4.46617, .Temperature = -30.9},
                New MarsTemperature() With {.Sol = 4.52737, .Temperature = -23.6},
                New MarsTemperature() With {.Sol = 4.544582, .Temperature = -20.3},
                New MarsTemperature() With {.Sol = 4.564193, .Temperature = -16.1},
                New MarsTemperature() With {.Sol = 4.583793, .Temperature = -14.6},
                New MarsTemperature() With {.Sol = 4.603404, .Temperature = -15.7},
                New MarsTemperature() With {.Sol = 4.623004, .Temperature = -15.5},
                New MarsTemperature() With {.Sol = 4.642616, .Temperature = -15.7},
                New MarsTemperature() With {.Sol = 4.662216, .Temperature = -20.6},
                New MarsTemperature() With {.Sol = 4.681816, .Temperature = -21.5},
                New MarsTemperature() With {.Sol = 4.701427, .Temperature = -26.4},
                New MarsTemperature() With {.Sol = 4.721039, .Temperature = -31.7},
                New MarsTemperature() With {.Sol = 4.74065, .Temperature = -39.4},
                New MarsTemperature() With {.Sol = 4.760261, .Temperature = -45.1},
                New MarsTemperature() With {.Sol = 4.782272, .Temperature = -49},
                New MarsTemperature() With {.Sol = 4.799484, .Temperature = -50.2},
                New MarsTemperature() With {.Sol = 4.819095, .Temperature = -54.5},
                New MarsTemperature() With {.Sol = 4.838706, .Temperature = -57.9},
                New MarsTemperature() With {.Sol = 4.858318, .Temperature = -59.2},
                New MarsTemperature() With {.Sol = 4.877929, .Temperature = -63.4},
                New MarsTemperature() With {.Sol = 4.89754, .Temperature = -62.9},
                New MarsTemperature() With {.Sol = 4.917152, .Temperature = -60.9},
                New MarsTemperature() With {.Sol = 4.936763, .Temperature = -63.6},
                New MarsTemperature() With {.Sol = 4.95874, .Temperature = -63.2},
                New MarsTemperature() With {.Sol = 4.975986, .Temperature = -68.8},
                New MarsTemperature() With {.Sol = 4.995586, .Temperature = -67.5}
            }
        End Function

        Public Property Temperature() As Double
        Public Property Sol() As Double
    End Class

    Public Class AnnotationContentConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If value IsNot Nothing AndAlso TypeOf value Is SeriesPoint Then
                Return parameter.ToString() & ": " & DirectCast(value, SeriesPoint).Value.ToString()
            End If
            Return String.Empty
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New System.NotImplementedException()
        End Function
    End Class
End Namespace
