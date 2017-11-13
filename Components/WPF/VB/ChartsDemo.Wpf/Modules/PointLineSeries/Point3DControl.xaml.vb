Imports System
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/PointLineSeries/Point3DControl(.SL).xaml"), CodeFile("Modules/PointLineSeries/Point3DControl.xaml.(cs)")>
    Partial Public Class Point3DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub lbModel_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim markerKind As Marker3DKind = TryCast(lbModel.SelectedItem, Marker3DKind)
            If markerKind IsNot Nothing Then
                Marker3DModelKindHelper.SetModel(chart, DirectCast(Activator.CreateInstance(markerKind.Type), Marker3DModel))
            End If
        End Sub
        Private Sub lbPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                For Each series As MarkerSeries3D In chart.Diagram.Series
                    MarkerSeries3D.SetLabelPosition(series.Label, CType(lbPosition.SelectedItem, Marker3DLabelPosition))
                Next series
            End If
        End Sub
        Private Sub chart_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            lbPosition.SelectedIndex = CInt((MarkerSeries3D.GetLabelPosition(chart.Diagram.Series(0).Label)))
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            lbModel.SelectedItem = Marker3DModelKindHelper.FindActualMarker3DModelKind(CType(chart.Diagram.Series(0), PointSeries3D).ActualModel)
        End Sub
    End Class
End Namespace
