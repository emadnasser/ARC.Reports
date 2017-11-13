Imports System
Imports System.Windows
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports System.Data

Namespace ChartsDemo
    <CodeFile("Modules/PointLineSeries/Bubble3DControl(.SL).xaml"), CodeFile("Modules/PointLineSeries/Bubble3DControl.xaml.(cs)")>
    Partial Public Class Bubble3DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub lbPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing AndAlso lbPosition.SelectedItem IsNot Nothing Then
                For Each series As MarkerSeries3D In chart.Diagram.Series
                    MarkerSeries3D.SetLabelPosition(series.Label, CType(lbPosition.SelectedItem, Marker3DLabelPosition))
                Next series
            End If
        End Sub
        Private Sub lbModel_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim markerKind As Marker3DKind = TryCast(lbModel.SelectedItem, Marker3DKind)
            If markerKind IsNot Nothing Then
                Marker3DModelKindHelper.SetModel(chart, DirectCast(Activator.CreateInstance(markerKind.Type), Marker3DModel))
            End If
        End Sub
        Private Sub Bubble3DDemo_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            lbModel.SelectedItem = Marker3DModelKindHelper.FindActualMarker3DModelKind(CType(chart.Diagram.Series(0), BubbleSeries3D).ActualModel)
            Dim sizeAnimation As Storyboard = TryCast(Series.TryFindResource("SizeAnimationStoryboard"), Storyboard)
            If sizeAnimation IsNot Nothing Then
                sizeAnimation.Begin(Series)
            End If
        End Sub
        Private Sub slMaxSize_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            CType(chart.Diagram.Series(0), BubbleSeries3D).MaxSize = CDbl(e.NewValue)
        End Sub
        Private Sub slMinSize_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            CType(chart.Diagram.Series(0), BubbleSeries3D).MinSize = CDbl(e.NewValue)
        End Sub
        Private Sub Storyboard_Completed(ByVal sender As Object, ByVal e As EventArgs)
            CType(chart.Diagram.Series(0), BubbleSeries3D).MaxSize = slMaxSize.Value
            CType(chart.Diagram.Series(0), BubbleSeries3D).MinSize = slMinSize.Value
        End Sub
        Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            e.LegendText = (DirectCast(CType(e.SeriesPoint.Tag, DataRowView).Row("Title"), String)).Replace(ControlChars.Lf, " ")
        End Sub
    End Class
End Namespace
