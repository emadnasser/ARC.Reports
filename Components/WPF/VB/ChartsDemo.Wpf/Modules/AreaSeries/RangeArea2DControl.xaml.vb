Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo
    <CodeFile("Modules/AreaSeries/RangeArea2DControl(.SL).xaml"), CodeFile("Modules/AreaSeries/RangeArea2DControl.xaml.(cs)")>
    Partial Public Class RangeArea2DControl
        Inherits ChartsDemoModule

        Private Shared predefinedSizes() As String = { "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30"}

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitializeMarkersSizeComboBox()
            RangeArea2DHelper.PrepareComboBox(cbeLabelKind, 1)
        End Sub
        Private Sub InitializeMarkersSizeComboBox()
            cbeMarker1Size.Items.AddRange(predefinedSizes)
            cbeMarker2Size.Items.AddRange(predefinedSizes)
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub cbeLabelKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim labelKind As RangeAreaLabelKind = RangeArea2DHelper.GetMode(TryCast(sender, ComboBoxEdit))
            RangeAreaSeries2D.SetLabelKind(rangeArea.Label, labelKind)
        End Sub
    End Class
End Namespace
