Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports System.Windows

Namespace ChartsDemo
    <CodeFile("Modules/RadarPolarSeries/RadarRangeAreaSeriesControl(.SL).xaml"), CodeFile("Modules/RadarPolarSeries/RadarRangeAreaSeriesControl.xaml.(cs)")>
    Partial Public Class RadarRangeAreaSeriesControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            RangeArea2DHelper.PrepareComboBox(cbeLabelKind, 0)
        End Sub

        Private Sub cbeLabelKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim labelKind As RangeAreaLabelKind = RangeArea2DHelper.GetMode(TryCast(sender, ComboBoxEdit))
            CircularRangeAreaSeries2D.SetLabelKind(series.Label, labelKind)
        End Sub
    End Class
End Namespace
