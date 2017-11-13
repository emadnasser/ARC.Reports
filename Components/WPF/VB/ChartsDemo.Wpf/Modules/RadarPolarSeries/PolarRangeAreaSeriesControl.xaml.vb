Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports System.Collections.Generic
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo
    <CodeFile("Modules/RadarPolarSeries/PolarRangeAreaSeriesControl(.SL).xaml"), CodeFile("Modules/RadarPolarSeries/PolarRangeAreaSeriesControl.xaml.(cs)")>
    Partial Public Class PolarRangeAreaSeriesControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            RangeArea2DHelper.PrepareComboBox(cbeLabelKind, 4)
            chart.DataSource = FunctionsPointGenerator.GeneratePoints(CircularFunction.Lemniskate)
        End Sub

        Private Sub lbFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim f As CircularFunction
            If CStr(lbFunction.SelectedItem) = "Taubin's Heart" Then
                f = CircularFunction.TaubinsHeart
            ElseIf CStr(lbFunction.SelectedItem) = "Cardioid" Then
                f = CircularFunction.Cardioid
            Else
                f = CircularFunction.Lemniskate
            End If
            chart.DataSource = FunctionsPointGenerator.GeneratePoints(f)
            chart.Animate()
        End Sub
        Private Sub cbeLabelKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim labelKind As RangeAreaLabelKind = RangeArea2DHelper.GetMode(TryCast(sender, ComboBoxEdit))
            CircularRangeAreaSeries2D.SetLabelKind(series.Label, labelKind)
        End Sub
    End Class
End Namespace
