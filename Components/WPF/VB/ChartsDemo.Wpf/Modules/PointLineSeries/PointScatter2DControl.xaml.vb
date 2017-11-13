﻿Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports System.Windows

Namespace ChartsDemo
    <CodeFile("Modules/PointLineSeries/PointScatter2DControl(.SL).xaml"), CodeFile("Modules/PointLineSeries/PointScatter2DControl.xaml.(cs)")>
    Partial Public Class PointScatter2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(GetType(RingMarker2DModel))
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class
End Namespace